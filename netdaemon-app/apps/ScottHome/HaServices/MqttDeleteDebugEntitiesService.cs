using daemonapp.apps.ScottHome.Helpers;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome.HaServices;

/// <summary>
/// This service deletes test / debug entities that I create through the NetDaemon core project
/// </summary>
[NetDaemonApp]
public class MqttDeleteDebugEntitiesService
{
    private readonly ILogger<MqttDeleteDebugEntitiesService> _logger;
    private readonly IHaContext _ha;
    private readonly INetDaemonScheduler _scheduler;
    private readonly IMqttEntityManager _mqttEntityManager;

    private static readonly string[] DebugEntityIds = new string[]
    {
        "binary_sensor.manager_test",
        "binary_sensor.s2",
        "input_boolean.frostysense",
        "sensor.basic_sensor",
        "sensor.my_id",
        "sensor.rain_nexthour4",
        "switch.helto_switch",
        "switch.switch_one",
        "switch.switch_two"
    };

    public MqttDeleteDebugEntitiesService(ILogger<MqttDeleteDebugEntitiesService> logger, IHaContext ha,
        INetDaemonScheduler scheduler, IMqttEntityManager mqttEntityManager)
    {
        _logger = logger;
        _ha = ha;
        _scheduler = scheduler;
        _mqttEntityManager = mqttEntityManager;

        _logger.LogInformation("{App} started", nameof(MqttDeleteDebugEntitiesService));

        scheduler.RunIn(TimeSpan.FromSeconds(1), DeleteEntities);

        ha.RegisterServiceCallBack<HaServiceData>("delete_debug_entities",
            e => SafeMethodExecuteWithLogging.Execute(DeleteEntities, _logger));
    }

    private void DeleteEntities()
    {
        _logger.LogInformation("Deleting debug entities");

        foreach (var entityId in DebugEntityIds)
        {
            _logger.LogDebug("Deleting {EntityId}", entityId);

            try
            {
                _mqttEntityManager.RemoveAsync(entityId).GetAwaiter();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error when trying to delete #{EntityId} with error {Message}", entityId,
                    ex.Message);
            }
        }
    }
}