using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using daemonapp.apps.ScottHome.Helpers;
using daemonapp.apps.ScottHome.UkhoTidalApi;
using daemonapp.apps.ScottHome.UkhoTidalApi.Model;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.MqttEntityManager.Models;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome;

/// <summary>
/// Register a tidal events service that can be called by a HASS automation
/// </summary>
[NetDaemonApp]
[Focus]
public class TidesFetcherService
{
    private class ServiceData
    {
    };

    private const string EntityId = "sensor.leith_tides";
    private const string EntityName = "Leith Tides";
    
    private readonly IHaContext _ha;
    private readonly ILogger<TidesFetcherService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IMqttEntityManager _mqttEntityManager;
    private readonly TideConfiguration _tidalConfig;

    public TidesFetcherService(IHaContext ha,
        ILogger<TidesFetcherService> logger,
        IConfiguration configuration,
        IHttpClientFactory httpClientFactory, 
        INetDaemonScheduler scheduler,
        IMqttEntityManager mqttEntityManager)
    {
        _ha = ha;
        _logger = logger;
        _httpClientFactory = httpClientFactory;
        _mqttEntityManager = mqttEntityManager;

        _logger.LogInformation($"{nameof(TidesFetcherService)} starting");

        _tidalConfig = configuration.GetSection("Tides")
            .Get<TideConfiguration>();

        // For debugging, execute the data fetch (almost) immediately
        if (EnvironmentHelper.IsDevelopment)
        {
            _logger.LogDebug("Development mode");
            scheduler.RunIn(TimeSpan.FromSeconds(5), GetTides);
        }

        scheduler.RunIn(TimeSpan.FromSeconds(1), RegisterEntities);
        
        ha.RegisterServiceCallBack<ServiceData>("get_tidal_events",
            e => SafeMethodExecuteWithLogging.Execute(GetTides, _logger));
    }

    private void RegisterEntities()
    {
        try
        {
            _logger.LogDebug($"Creating entity {EntityId}");
            _mqttEntityManager.CreateAsync(EntityId, new EntityCreationOptions(Name: EntityName), new
                {
                    icon = "mdi:waves"
                })
                .GetAwaiter();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

    private void GetTides()
    {
        var httpClient = _httpClientFactory.CreateClient();
        var tidalApi = new TidalApi(_tidalConfig?.ApiKey, httpClient);
        
        var stationId = GetStationId(tidalApi);
        _logger.LogDebug($"Station ID={stationId} for {_tidalConfig?.StationName}");
        
        var events = GetTidalEvents(tidalApi, stationId);
        _logger.LogDebug($"Retrieved {events.Count} tidal events");

        if (events.Any())
            UpdateTidesSensor(events);
    }

    private string? GetStationId(TidalApi tidalApi)
    {
        var stationIdGetter = tidalApi.GetStationIdAsync(_tidalConfig.StationName);
        stationIdGetter.Wait();

        if (stationIdGetter.IsFaulted)
            throw new Exception("Request to get tidal station ID failed", stationIdGetter.Exception);

        return stationIdGetter.Result;
    }

    private List<TidalEvent> GetTidalEvents(TidalApi tidalApi, string? stationId)
    {
        var tidalEventsGetter = tidalApi.GetTidalEvents(stationId);
        tidalEventsGetter.Wait();

        if (tidalEventsGetter.IsFaulted)
            throw new Exception("Request to get tidal events data failed", tidalEventsGetter.Exception);

        return tidalEventsGetter.Result;
    }
    
    private void UpdateTidesSensor(List<TidalEvent> events)
    {
        if (events.Count < 4)
            throw new InvalidDataException($"Expected at least four events, but got {events.Count}");
    
        var data = new
        {
            Summary1 = events[0].ToString(),
            Summary2 = events[1].ToString(),
            Summary3 = events[2].ToString(),
            Summary4 = events[3].ToString(),
            EventType1 = events[0].EventType.ToString(),
            EventType2 = events[1].EventType.ToString(),
            EventType3 = events[2].EventType.ToString(),
            EventType4 = events[3].EventType.ToString(),
            Date1 = events[0].DateTime.ToLocalTime(),
            Date2 = events[1].DateTime.ToLocalTime(),
            Date3 = events[2].DateTime.ToLocalTime(),
            Date4 = events[3].DateTime.ToLocalTime(),
            Height1 = events[0].Height,
            Height2 = events[1].Height,
            Height3 = events[2].Height,
            Height4 = events[3].Height,
            Updated = DateTime.UtcNow
        };

        _mqttEntityManager.SetStateAsync(EntityId, DateTime.UtcNow.ToLocalTime().ToShortDateString()).GetAwaiter();
        _mqttEntityManager.SetAttributesAsync(EntityId, data).GetAwaiter();
    }

}