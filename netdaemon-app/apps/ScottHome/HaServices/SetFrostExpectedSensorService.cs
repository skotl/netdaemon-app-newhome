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

namespace daemonapp.apps.ScottHome.HaServices;

[NetDaemonApp]
public class SetFrostExpectedSensorService
{
    private const string EntityId = "binary_sensor.frost_forecast";
    private const string EntityName = "Frost forecast";
    private const double FrostWarningThreshold = 5.0;
    private const string WarningSetTrue = "ON";
    private const string WarningSetFalse = "OFF";
    private const string WarningSetUnknown = "unknown";
    private const string Available = "online";
    private const string Unavailable = "offline";
    private readonly IHaContext _ha;
    private readonly ILogger<SetFrostExpectedSensorService> _logger;
    private readonly IMqttEntityManager _mqttEntityManager;
    private readonly IWeatherHelper _weatherHelper;

    public SetFrostExpectedSensorService(IHaContext ha, ILogger<SetFrostExpectedSensorService> logger,
        INetDaemonScheduler scheduler, IMqttEntityManager mqttEntityManager, IWeatherHelper weatherHelper)
    {
        _ha = ha;
        _logger = logger;
        _mqttEntityManager = mqttEntityManager;
        _weatherHelper = weatherHelper;

        _logger.LogInformation("{App} started", nameof(SetFrostExpectedSensorService));

        scheduler.RunIn(TimeSpan.FromSeconds(1), RegisterEntities);

        ha.RegisterServiceCallBack<HaServiceData>("check_for_frost",
            e => SafeMethodExecuteWithLogging.Execute(SetFrostExpected, _logger));
    }

    private void RegisterEntities()
    {
        try
        {
            _logger.LogDebug("Creating entity {EntityId}", EntityId);
            _mqttEntityManager.CreateAsync(EntityId, new EntityCreationOptions(
                    Name: EntityName, DeviceClass:"cold",
                    PayloadAvailable: Available, PayloadNotAvailable: Unavailable))
                .GetAwaiter();
            ClearFrostWarning();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{Message}", ex.Message);
        }
    }

    private void SetFrostExpected()
    {
        var entities = new Entities(_ha);
        var currentFrostExpected = TranslateState(_ha.Entity(EntityId).State);
        var forecasts = _weatherHelper.GetWeatherForecast(entities.Weather.MetOfficeQueensferryEdinburghDaily).ToList();

        if (!forecasts.Any())
        {
            _logger.LogWarning("Failed to fetch weather forecast data");
            SetUnavailable();
            return;
        }

        var willBeFrosty = forecasts.Any(f => f.TempLow <= FrostWarningThreshold);
        var lowestForecast = forecasts.OrderBy(f => f.TempLow).First();
        var clearedForecast = FindClearedForecast(forecasts);

        _logger.LogInformation("Will be frost={WillBe}, Lowest={Lowest}", willBeFrosty, lowestForecast);

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

    private string TranslateState(string? state)
    {
        switch (state?.ToLower())
        {
            case "false":
                case "off":
                return WarningSetFalse;
            case "true":
                case "on":
                return WarningSetTrue;
            default:
                return WarningSetUnknown;
        }
    }

    private static WeatherForecast? FindClearedForecast(List<WeatherForecast> forecasts)
    {
        var inFrost = false;
        foreach (var f in forecasts)
        {
            switch (f.TempLow)
            {
                case <= FrostWarningThreshold when !inFrost:
                    inFrost = true;
                    break;
                case > FrostWarningThreshold when inFrost:
                    return f;
            }
        }

        return null;
    }


    private void SetFrostWarning(WeatherForecast coldest, WeatherForecast? clearingBy)
    {
        SetAvailable();
        _mqttEntityManager.SetStateAsync(EntityId, WarningSetTrue).GetAwaiter();
        
        _mqttEntityManager.SetAttributesAsync(EntityId, new
        {
            friendly_name = EntityName, icon = "mdi:snowflake-alert", coldTemp = coldest.TempLow,
            coldDate = coldest.DateTime, clearTemp = clearingBy?.TempLow, clearDate = clearingBy?.DateTime,
            updated = DateTime.UtcNow
        }).GetAwaiter();
    }

    private void ClearFrostWarning()
    {
        SetAvailable();
        _mqttEntityManager.SetStateAsync(EntityId, WarningSetFalse).GetAwaiter();
        
        _mqttEntityManager.SetAttributesAsync(EntityId, new
        {
            friendly_name = EntityName, icon = "mdi:sun-thermometer-outline",
            updated = DateTime.UtcNow
        }).GetAwaiter();
    }

    private void SetAvailable()
    {
        _mqttEntityManager.SetAvailabilityAsync(EntityId, Available).GetAwaiter();
    }

    private void SetUnavailable()
    {
        _mqttEntityManager.SetAvailabilityAsync(EntityId, Unavailable).GetAwaiter();
    }
}