using Microsoft.Extensions.Hosting;
using NetDaemon;

try
{
    Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    
    await Host.CreateDefaultBuilder(args)
        .UseDefaultNetDaemonLogging()
        .UseNetDaemon()
        .Build()
        .RunAsync();
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
}
finally
{
    NetDaemon.NetDaemonExtensions.CleanupNetDaemon();
}
