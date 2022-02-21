using daemonapp.apps.ScottHome.EntityRegistrationHelpers;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.MqttEntityManager.Models;
using NetDaemon.Extensions.Scheduler;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
[Focus]
public class MqttTester
{
    private readonly IHaContext _ha;
    private readonly ILogger<MqttTester> _logger;
    private readonly INetDaemonScheduler _scheduler;
    private readonly IMqttEntityManager _mqttEntityManager;
    private readonly IEntityRegistration _entityRegistration;

    public MqttTester(IHaContext ha, ILogger<MqttTester> logger, INetDaemonScheduler scheduler,
        IMqttEntityManager mqttEntityManager, IEntityRegistration entityRegistration)
    {
        _ha = ha;
        _logger = logger;
        _scheduler = scheduler;
        _mqttEntityManager = mqttEntityManager;
        _entityRegistration = entityRegistration;

        scheduler.RunIn(TimeSpan.FromSeconds(2), RegisterEntities);
        scheduler.RunIn(TimeSpan.FromSeconds(1), Exercise);
    }

    private void RegisterEntities()
    {
        _logger.LogTrace("Registering entities");
        _entityRegistration.AddEntityForRegistration("sensor.test", new EntityCreationOptions(Name: "Testing"));

        _entityRegistration.RegisterEntitiesAsync().GetAwaiter();
        
        _logger.LogTrace("Entities registered");
    }

    private void Exercise()
    {
        _entityRegistration.VerifyEntitiesCreatedAsync().GetAwaiter();

        _logger.LogTrace("Verified entities are ready");
    }
}