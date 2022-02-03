namespace MqttHandler;

public interface IMessageSender
{
    Task SendMessageAsync(string topic, string payload);
}