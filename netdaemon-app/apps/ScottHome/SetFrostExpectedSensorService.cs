using System.Collections.Generic;
using System.IO;
using System.Linq;
using daemonapp.apps.ScottHome.Helpers;
using daemonapp.apps.ScottHome.Weather;
using daemonapp.apps.ScottHome.Weather.Model;
using HomeAssistantGenerated;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
public class SetFrostExpectedSensorService
{
    private class ServiceData
    {
    };

    private const string EntityId = "binary_sensor.frost_forecast";
    private const string EntityName = "Frost forecast";
    private const double FrostWarningThreshold = 5.0;
    private const string WarningSetTrue = "ON";
    private const string WarningSetFalse = "OFF";
    private const string WarningSetUnknown = "unknown";
    private readonly IHaContext _ha;
    private readonly ILogger<SetFrostExpectedSensorService> _logger;
    private readonly IMqttEntityManager _mqttEntityManager;

    public SetFrostExpectedSensorService(IHaContext ha, ILogger<SetFrostExpectedSensorService> logger,
        INetDaemonScheduler scheduler, IMqttEntityManager mqttEntityManager)
    {
        _ha = ha;
        _logger = logger;
        _mqttEntityManager = mqttEntityManager;

        _logger.LogInformation($"{nameof(SetFrostExpectedSensorService)} started");

        scheduler.RunIn(TimeSpan.FromSeconds(1), RegisterEntities);

        return;
        ha.RegisterServiceCallBack<ServiceData>("check_for_frost",
            e => SafeMethodExecuteWithLogging.Execute(SetFrostExpected, _logger));
    }

    private void RegisterEntities()
    {
        try
        {
            _logger.LogDebug($"Creating entity {EntityId}");
            _mqttEntityManager.CreateAsync(EntityId, new EntityCreationOptions(Name: EntityName, DeviceClass:"cold"))
                .GetAwaiter();
            
            
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
        }
    }

    private void SetFrostExpected()
    {
        var entities = new Entities(_ha);
        var currentFrostExpected = _ha.Entity(EntityId).State;
        var forecasts = WeatherHelper.GetWeatherForecast(entities.Weather.Home).ToList();

        if (!forecasts.Any())
        {
            _logger.LogWarning("Failed to fetch weather forecast data");
            return;
        }

        var willBeFrosty = forecasts.Any(f => f.TempLow <= FrostWarningThreshold);
        var lowestForecast = forecasts.OrderBy(f => f.TempLow).First();
        var clearedForecast = FindClearedForecast(forecasts);

        switch (willBeFrosty)
        {
            case true when currentFrostExpected is WarningSetFalse or WarningSetUnknown:
                _logger.LogDebug("Going to be frosty, state change - set warning");
                SetFrostWarning(lowestForecast, clearedForecast);
                break;
            case true when currentFrostExpected == WarningSetTrue:
                _logger.LogDebug("Going to be frosty, warning is already set");
                break;
            case false when currentFrostExpected is WarningSetFalse or WarningSetUnknown:
                _logger.LogDebug("Not going to be frosty, warning is not set");
                break;
            case false when currentFrostExpected == WarningSetTrue:
                _logger.LogDebug("Not going to be frosty, state change - clear warning");
                ClearFrostWarning();
                break;
            default:
                throw new InvalidDataException(
                    $"Unhandled state for {nameof(currentFrostExpected)} == {currentFrostExpected}, {nameof(willBeFrosty)} == {willBeFrosty}");
        }
    }

    private WeatherForecast? FindClearedForecast(List<WeatherForecast> forecasts)
    {
        var inFrost = false;
        foreach (var f in forecasts)
        {
            if (f.TempLow <= FrostWarningThreshold && !inFrost)
                inFrost = true;
            else if (f.TempLow > FrostWarningThreshold && inFrost)
                return f;
        }

        return null;
    }


    private void SetFrostWarning(WeatherForecast coldest, WeatherForecast? clearingBy)
    {
        _mqttEntityManager.SetStateAsync(EntityId, WarningSetTrue).GetAwaiter();
        
        _mqttEntityManager.SetAttributesAsync(EntityId, new
        {
            friendly_name = "Frost forecast", icon = "mdi:snowflake-alert", coldTemp = coldest.TempLow,
            coldDate = coldest.DateTime, clearTemp = clearingBy?.TempLow, clearDate = clearingBy?.DateTime,
            updated = DateTime.UtcNow
        }).GetAwaiter();
    }

    private void ClearFrostWarning()
    {
        _mqttEntityManager.SetStateAsync(EntityId, WarningSetFalse).GetAwaiter();
        
        _mqttEntityManager.SetAttributesAsync(EntityId, new
        {
            friendly_name = "Frost forecast", icon = "mdi:sun-thermometer-outline",
            updated = DateTime.UtcNow
        }).GetAwaiter();
    }
}