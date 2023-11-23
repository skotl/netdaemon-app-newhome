using daemonapp.apps.ScottHome.Configuration;
using Kwolo.MaseratiConnect;
using Kwolo.MaseratiConnect.Model;
using Microsoft.Extensions.Configuration;

namespace daemonapp.apps.Maserati;

public class MaseratiConnect : IMaseratiConnect
{
    private readonly ILogger<MaseratiConnect> _logger;
    private readonly IMaseratiConnector _maseratiConnector;
    private readonly MaseratiConnectConfiguration _maseratiConfig;

    public MaseratiConnect(
        ILogger<MaseratiConnect> logger,
        IMaseratiConnector maseratiConnector,
        IConfiguration configuration)
    {
        _logger = logger;
        _maseratiConnector = maseratiConnector;
        _maseratiConfig = configuration.GetSection("MaseratiConnect").Get<MaseratiConnectConfiguration>()
                          ?? throw new InvalidOperationException();
    }

    public void GetVehicleDetails()
    {
        var car = _maseratiConnector.FetchData(new ConnectionDetails
        {
            LoginUrl = _maseratiConfig.LoginUrl,
            DashboardUrl = _maseratiConfig.DashboardUrl,
            UserLogin = _maseratiConfig.UserLogin,
            UserPassword = _maseratiConfig.UserPassword,
            ShowChromiumWindow = false
        });
    }
}