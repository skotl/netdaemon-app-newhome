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

        _logger.LogInformation("{App} starting", nameof(TidesFetcherService));

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
            _logger.LogDebug("Creating entity {EntityId}", EntityId);
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
        _logger.LogDebug("Station ID={StationId} for {StationName}", stationId, _tidalConfig?.StationName);
        
        var events = GetTidalEvents(tidalApi, stationId);
        _logger.LogDebug("Retrieved {Count} tidal events", events.Count);

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

        var updatedAt = DateTime.UtcNow.ToLocalTime().ToString("dd MMMM");
        
        var data = new
        {
            Updated = updatedAt,
            Dates = events.Select(e => e.DateTime),
            Heights = events.Select(e => e.Height)
        };

        _mqttEntityManager.SetStateAsync(EntityId, updatedAt).GetAwaiter();
        _mqttEntityManager.SetAttributesAsync(EntityId, data).GetAwaiter();
        
        _ha.WriteLogbook(EntityId, "Tide times were updated");
    }

}