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
            
        }));
    }
}