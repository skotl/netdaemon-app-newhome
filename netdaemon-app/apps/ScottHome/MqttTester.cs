using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
public class MqttTester
{
    private readonly IHaContext _ha;
    private readonly ILogger<MqttTester> _logger;
    private readonly INetDaemonScheduler _scheduler;
    private readonly IMqttEntityManager _mqttEntityManager;

    public MqttTester(IHaContext ha, ILogger<MqttTester> logger, INetDaemonScheduler scheduler,
        IMqttEntityManager mqttEntityManager)
    {
        _ha = ha;
        _logger = logger;
        _scheduler = scheduler;
        _mqttEntityManager = mqttEntityManager;

        scheduler.RunIn(TimeSpan.FromSeconds(2), RegisterEntities);
        scheduler.RunIn(TimeSpan.FromSeconds(1), Exercise);
    }

    private void RegisterEntities()
    {

    }

    private void Exercise()
    {

    }
}