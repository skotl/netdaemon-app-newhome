using System.Linq;
using daemonapp.apps.ScottHome.Weather;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
public class SetFrostExpectedSensor
{
    private const double _frostWarningThreshold = 5.0;
    private const double _comparitorThreshold = 0.01;
    private readonly IHaContext _ha;
    private readonly ILogger<SetFrostExpectedSensor> _logger;
    private readonly INetDaemon _netDaemon;

    public SetFrostExpectedSensor(IHaContext ha, ILogger<SetFrostExpectedSensor> logger, INetDaemon netDaemon)
    {
        _ha = ha;
        _logger = logger;
        _netDaemon = netDaemon;

        _logger.LogInformation($"{nameof(SetFrostExpectedSensor)} started");
        
            _netDaemon.SetState("binary_sensor.frost_forecast", "on");


    }
}