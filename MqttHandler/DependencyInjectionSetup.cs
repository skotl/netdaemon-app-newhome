using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MQTTnet;

namespace MqttHandler;

public static class DependencyInjectionSetup
{
    /// <summary>
    ///     Adds scheduling capabilities through dependency injection
    /// </summary>
    /// <param name="services">Provided service collection</param>
    public static IServiceCollection AddMqttExtensions(
        this IServiceCollection services)
    {
        services.AddSingleton<IMqttFactory, MqttFactory>();
        services.AddScoped<IEntityUpdater, EntityUpdater>();
        services.AddScoped<IMessageSender, MessageSender>();
        
        return services;
    }
}