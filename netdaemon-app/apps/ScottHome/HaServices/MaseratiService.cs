using daemonapp.apps.Maserati;
using daemonapp.apps.ScottHome.Helpers;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome.HaServices;

[NetDaemonApp]
public class MaseratiService
{
    private readonly IHaContext _ha;
    private readonly ILogger<MaseratiService> _logger;
    private readonly IMaseratiConnect _maseratiConnect;

    public MaseratiService(
        IHaContext ha,
        ILogger<MaseratiService> logger,
        IMaseratiConnect maseratiConnect,
        INetDaemonScheduler scheduler)
    {
        _ha = ha;
        _logger = logger;
        _maseratiConnect = maseratiConnect;

        _logger.LogInformation("{App} started", nameof(MaseratiService));

        ha.RegisterServiceCallBack<HaServiceData>("Maserati_fetch_details",
            e => SafeMethodExecuteWithLogging.Execute(FetchMaseratiDetails, _logger));
    }

    private void FetchMaseratiDetails()
    {
        _maseratiConnect.GetVehicleDetails();
    }
}