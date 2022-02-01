using System.Collections.Generic;
using System.IO;
using System.Linq;
using daemonapp.apps.ScottHome.Weather;
using daemonapp.apps.ScottHome.Weather.Model;
using HomeAssistantGenerated;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
public class SetFrostExpectedSensorService
{
    private class ServiceData
    {
    };

    private const double FrostWarningThreshold = 5.0;
    private const string WarningSetTrue = "on";
    private const string WarningSetFalse = "off";
    private readonly IHaContext _ha;
    private readonly ILogger<SetFrostExpectedSensorService> _logger;

    public SetFrostExpectedSensorService(IHaContext ha, ILogger<SetFrostExpectedSensorService> logger,
        INetDaemonScheduler scheduler)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation($"{nameof(SetFrostExpectedSensorService)} started");

        ha.RegisterServiceCallBack<ServiceData>("check_for_frost", e =>
            {
                try
                {
                    SetFrostExpected();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                }
            }
        );
    }

    private void SetFrostExpected()
    {
        var entities = new Entities(_ha);
        var currentFrostExpected = entities.BinarySensor.FrostForecast.State;

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
            case true when currentFrostExpected == WarningSetFalse:
                _logger.LogDebug("Going to be frosty, state change - set warning");
                SetFrostWarning(lowestForecast, clearedForecast);
                break;
            case true when currentFrostExpected == WarningSetTrue:
                _logger.LogDebug("Going to be frosty, warning is already set");
                break;
            case false when currentFrostExpected == WarningSetFalse:
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
        new Services(_ha).Netdaemon.EntityUpdate("binary_sensor.frost_forecast",
            WarningSetTrue,
            attributes: new
            {
                friendly_name = "Frost forecast", icon = "mdi:snowflake-alert", coldTemp = coldest.TempLow,
                coldDate = coldest.DateTime, clearTemp = clearingBy?.TempLow, clearDate = clearingBy?.DateTime
            });
    }

    private void ClearFrostWarning()
    {
        new Services(_ha).Netdaemon.EntityUpdate("binary_sensor.frost_forecast",
            WarningSetFalse,
            attributes: new
            {
                friendly_name = "Frost forecast", icon = "mdi:sun-thermometer-outline"
            });
    }
}