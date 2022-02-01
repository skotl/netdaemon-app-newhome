using daemonapp.apps.ScottHome.Helpers;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
public class FrostSensorNotifications
{
    private readonly IHaContext _ha;
    private readonly ILogger<FrostSensorNotifications> _logger;

    public FrostSensorNotifications(IHaContext ha, ILogger<FrostSensorNotifications> logger)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation($"{nameof(FrostSensorNotifications)} started");
        new Entities(_ha).BinarySensor.FrostForecast.StateChanges()
            .Subscribe(e => SafeMethodExecuteWithLogging.Execute(FrostSensorChangedState, _logger, e));
    }

    private void FrostSensorChangedState(StateChange arg)
    {
        var sensorArg = (StateChange<BinarySensorEntity, EntityState<BinarySensorAttributes>>)arg;

        _logger.LogInformation($"{sensorArg.Entity.EntityId} changed state to {sensorArg.New.State}");
        var frostSensor = new Entities(_ha).BinarySensor.FrostForecast;
        var state = StateEnums.ConvertToBinaryState(sensorArg.New.State);

        if (state)
            NotifyFrostWarning(frostSensor.Attributes);
        else
            NotifyFrostCleared(frostSensor.Attributes);
    }

    private void NotifyFrostWarning(BinarySensorAttributes attributes)
    {
        var msg = $"Frost warning for {ToShortDate(attributes.ColdDate)}, temp below {attributes.ColdTemp}C";
        if (!string.IsNullOrWhiteSpace(attributes?.ClearDate))
            msg += $", clearing by {ToShortDate(attributes.ClearDate)} with temp of {attributes.ClearTemp}C";
        
        _logger.LogInformation(msg);

        var svc = new NotifyServices(_ha);
        svc.MobileAppScottSXr(msg, "title");
        
    }

    private void NotifyFrostCleared(BinarySensorAttributes attributes)
    {
        var msg = $"Frost will clear by {ToShortDate(attributes.ClearDate)}, with a temp of {attributes.ClearTemp}C";
        
        _logger.LogInformation(msg);
        
        var svc = new NotifyServices(_ha);
        svc.MobileAppScottSXr(msg, "title");
    }

    private string ToShortDate(string dateString)
    {
        if (DateTime.TryParse(dateString, out var date))
            return date.ToShortDateString();

        return "??";
    }
}