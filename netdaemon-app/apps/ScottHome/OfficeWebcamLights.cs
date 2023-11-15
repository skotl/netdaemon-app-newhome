using System.Threading.Tasks;
using HomeAssistantGenerated;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome;

/// <summary>
/// Control office and on-air lamps when the office webcam changes state
/// </summary>
[NetDaemonApp]
public class OfficeWebcamLights
{
    private readonly ILogger<OfficeWebcamLights> _logger;
    private readonly IHaContext _ha;
    private readonly IMqttEntityManager _mqtt;

    private const string WebcamDomain = "switch";
    private const string WebcamIdentifier = "scott_office_webcam";

    private string WebcamEntityId { get; } = WebcamDomain + "." + WebcamIdentifier;

    private static readonly string[] AffectedLights = new string[]
    {
        "light.on_air_lamp", "switch.studio_light_socket_1"
    };

    public OfficeWebcamLights(ILogger<OfficeWebcamLights> logger, IHaContext ha, IMqttEntityManager mqtt,
        INetDaemonScheduler scheduler)
    {
        _logger = logger;
        _ha = ha;
        _mqtt = mqtt;

        _logger.LogInformation("{App} started", nameof(OfficeWebcamLights));

        Task.Run(SetupAsync);
    }

    private async Task SetupAsync()
    {
        _logger.LogDebug("Executing startup for {App}", nameof(OfficeWebcamLights));

        try
        {
            await _mqtt.CreateAsync(WebcamEntityId, new EntityCreationOptions(DeviceClass: "switch"),
                new { icon = "mdi:webcam" });
            (await _mqtt.PrepareCommandSubscriptionAsync(WebcamEntityId).ConfigureAwait(false))
                .Subscribe(new Action<string>(async state => { await ReceivedNotification(state); }));

            _ha.Entity(WebcamEntityId).StateAllChanges()
                .SubscribeAsync(WebcamStateChanged, ExceptionReceived);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            throw;
        }
    }

    private void ExceptionReceived(Exception exception)
    {
        _logger.LogError(exception, exception?.Message);
    }

    /// <summary>
    /// We received a notification that the webcam has turned on or off
    /// So send a state change message to the switch and tell it to assume this state
    /// </summary>
    /// <param name="state"></param>
    private async Task ReceivedNotification(string state)
    {
        _logger.LogInformation("Webcam changed state to {State}", state);

        await _mqtt.SetStateAsync(WebcamEntityId, state).ConfigureAwait(false);
    }

    /// <summary>
    /// The webcam state has changed so update the lights
    /// </summary>
    /// <param name="change"></param>
    private async Task WebcamStateChanged(StateChange change)
    {
        _logger.LogInformation("Confirmed webcam state change to {state}", change.New?.State);

        var onOff = LightState(change);

        foreach (var light in AffectedLights)
        {
            var lightEntity = new LightEntity(_ha, light);
            
            _logger.LogDebug("{lamp} going to {state}", light, onOff);
            if (onOff)
                lightEntity.TurnOn();
            else
                lightEntity.TurnOff();
        }
    }

    private static bool LightState(StateChange change)
    {
        return change?.New?.State?.ToString().ToLower() switch
        {
            "on" => true,
            "off" => false,
            _ => throw new ArgumentException(change?.ToString())
        };
    }
}