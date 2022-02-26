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

        _logger.LogInformation("{EntityId} changed state to {NewState}", sensorArg.Entity.EntityId, sensorArg?.New?.State);
        var frostSensor = new Entities(_ha).BinarySensor.FrostForecast;
        
        var state = StateEnums.ConvertToBinaryState(sensorArg?.New?.State);

        if (state)
            NotifyFrostWarning(frostSensor?.Attributes);
        else
            NotifyFrostCleared(frostSensor?.Attributes);
    }

    private void NotifyFrostWarning(BinarySensorAttributes? attributes)
    {
        if (attributes == null)
            throw new ArgumentNullException(nameof(attributes));
        
        var coldDate = attributes.ColdDate.ToDateTime();
        var clearDate = attributes.ClearDate.ToDateTime();
        
        var msg = $"Frost warning for {ToShortDate(coldDate)}, temp below {attributes.ColdTemp}C";
        if (clearDate.HasValue)
            msg += $", clearing by {ToShortDate(clearDate)} with temp of {attributes.ClearTemp}C";
        
        _logger.LogInformation("{Message}", msg);

        var svc = new NotifyServices(_ha);
        svc.MobileAppScottSXr(msg, "title");
    }

    private void NotifyFrostCleared(BinarySensorAttributes? attributes)
    {
        if (attributes == null)
            throw new ArgumentNullException(nameof(attributes));
        
        var clearDate = attributes.ClearDate.ToDateTime();
        var msg = $"Frost will clear by {ToShortDate(clearDate)}, with a temp of {attributes.ClearTemp}C";
        
        _logger.LogInformation("{Message}", msg);
        
        var svc = new NotifyServices(_ha);
        svc.MobileAppScottSXr(msg, "title");
    }

    private string ToShortDate(DateTime? date)
    {
        return date == null ? "??" : date.Value.ToShortDateString();
    }
}