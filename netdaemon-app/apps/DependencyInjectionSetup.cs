using daemonapp.apps.Maserati;
using daemonapp.apps.ScottHome.Weather;
using Kwolo.MaseratiConnect;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace daemonapp.apps;

public static class DependencyInjectionSetup
{
    public static IHostBuilder UseScottServices(
        this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureServices((Action<HostBuilderContext, IServiceCollection>) ((context, services) =>
        {
            services.UseMaseratiConnect();
            services.AddSingleton<IWeatherHelper, WeatherHelper>();
            services.AddSingleton<IMaseratiConnect, MaseratiConnect>();
        }));
    }
}