using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome;

/// <summary>
/// When the home status changes, check whether the front door needs to be locked or unlocked and do so if needed
/// </summary>
[NetDaemonApp]
public class FrontDoorLocker
{
    private readonly IHaContext _ha;
    private readonly ILogger<FrontDoorLocker> _logger;

    public FrontDoorLocker(IHaContext ha, ILogger<FrontDoorLocker> logger)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation($"{nameof(FrontDoorLocker)} started");

        // TODO: When the debugger starts, this kicks in and unlocks the door. Should we do more checking of the old state?
        var entities = new Entities(ha);
        entities.Sensor.HomeOccupancy.StateChanges()
            .Where(e => !string.IsNullOrWhiteSpace(e.New?.State))
            .Subscribe(e => VerifyLockState(e.New?.State));
    }

    private void VerifyLockState(string? homeStatus)
    {
        var currentHomeStatus = StateEnums.ConvertToHomePresence(homeStatus);
        var frontDoorLock = new Entities(_ha).Lock.FrontDoorLock;
        var currentLockStatus = StateEnums.ConvertToLockState(frontDoorLock.State);

        _logger.LogDebug($"Home state changed to {homeStatus}, door lock is {currentLockStatus}");
        
        switch (currentHomeStatus)
        {
            case StateEnums.HomePresence.not_occupied when currentLockStatus == StateEnums.LockState.unlocked:
                _logger.LogInformation("House status changed to not occupied, door is unlocked: locking");
                frontDoorLock.Lock();
                break;
            case StateEnums.HomePresence.occupied when currentLockStatus == StateEnums.LockState.locked:
                _logger.LogInformation("House status changed to occupied, door is locked: unlocking");
                frontDoorLock.Unlock();
                break;
        }
    }
}