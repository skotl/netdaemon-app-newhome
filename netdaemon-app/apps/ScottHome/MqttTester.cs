using System.Threading.Tasks;
using MqttHandler;

namespace daemonapp.apps.ScottHome;

[Focus]
[NetDaemonApp]
public class MqttTester
{
    private readonly ILogger<MqttTester> _logger;
    private readonly IEntityUpdater _entityUpdater;

    public MqttTester(ILogger<MqttTester> logger, IEntityUpdater entityUpdater)
    {
        _logger = logger;
        _entityUpdater = entityUpdater;

        var t = _entityUpdater.CreateAsync("binary_sensor", "motion", "motion_test_1", "mqtt test");
        Task.WaitAll(t);
        
    }
    
}