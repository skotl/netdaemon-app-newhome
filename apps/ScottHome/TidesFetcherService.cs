using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using daemonapp.apps.ScottHome.Helpers;
using daemonapp.apps.ScottHome.UkhoTidalApi;
using daemonapp.apps.ScottHome.UkhoTidalApi.Model;
using HomeAssistantGenerated;
using Microsoft.Extensions.Configuration;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome;

/// <summary>
/// Register a tidal events service that can be called by a HASS automation
/// </summary>
[NetDaemonApp]
public class TidesFetcherService
{
    private class ServiceData
    {
    };
    
    private readonly IHaContext _ha;
    private readonly ILogger<TidesFetcherService> _logger;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly TideConfiguration _tidalConfig;

    public TidesFetcherService(IHaContext ha,
        ILogger<TidesFetcherService> logger,
        IConfiguration configuration,
        IHttpClientFactory httpClientFactory, INetDaemonScheduler scheduler)
    {
        _ha = ha;
        _logger = logger;
        _httpClientFactory = httpClientFactory;
        
        _logger.LogInformation($"{nameof(TidesFetcherService)} starting");

        _tidalConfig = configuration.GetSection("Tides")
            .Get<TideConfiguration>();

        // For debugging, execute the data fetch (almost) immediately
        if (EnvironmentHelper.IsDevelopment)
        {
            _logger.LogDebug("Development mode");
            scheduler.RunIn(TimeSpan.FromSeconds(1), GetTides);
        }

        ha.RegisterServiceCallBack<ServiceData>("get_tidal_events",
            e => SafeMethodExecuteWithLogging.Execute(GetTides, _logger));
    }

    private void GetTides()
    {
        var httpClient = _httpClientFactory.CreateClient();
        var tidalApi = new TidalApi(_tidalConfig?.ApiKey, httpClient);
        
        var stationId = GetStationId(tidalApi);
        _logger.LogDebug($"Station ID={stationId} for {_tidalConfig?.StationName}");
        
        var events = GetTidalEvents(tidalApi, stationId);
        _logger.LogDebug($"Retrieved {events.Count} tidal events");

        
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
}