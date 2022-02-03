using Microsoft.Extensions.Hosting;
using System.Reflection;
using HomeAssistantGenerated.Logging;
using Microsoft.Extensions.DependencyInjection;
using MqttHandler;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.Extensions.Tts;
using NetDaemon.Runtime;

#pragma warning disable CA1812

try
{
    Environment.CurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;

    await Host.CreateDefaultBuilder(args)
        .UseNetDaemonAppSettings()
        .UseCustomLogging()
        .UseNetDaemonRuntime()
        .UseNetDaemonTextToSpeech()
        .ConfigureServices((_, services) =>
            services
                .AddAppsFromAssembly(Assembly.GetExecutingAssembly())
                .AddNetDaemonStateManager()
                .AddNetDaemonScheduler()
                .AddMqttExtensions()
        )
        .Build()
        .RunAsync()
        .ConfigureAwait(false);
}
catch (Exception e)
{
    Console.WriteLine($"Failed to start host... {e}");
    throw;
}