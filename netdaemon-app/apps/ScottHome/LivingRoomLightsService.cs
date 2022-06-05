using System.Collections.Generic;
using daemonapp.apps.ScottHome.Helpers;
using HomeAssistantGenerated;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Integration;

namespace daemonapp.apps.ScottHome;

/// <summary>
/// Presents living room light controls as services as HA is way better at detecting sunset than we are, over here
/// </summary>
[NetDaemonApp]
public class LivingRoomLightsService
{
    private class ServiceData
    {
    };

    private static readonly long DefaultBrightness = 70;
    private readonly IHaContext _ha;
    private readonly ILogger<LivingRoomLightsService> _logger;

    public LivingRoomLightsService(IHaContext ha, ILogger<LivingRoomLightsService> logger,
        INetDaemonScheduler scheduler)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation($"{nameof(LivingRoomLightsService)} started");

        ha.RegisterServiceCallBack<ServiceData>("livingroom_lights_on",
            e => SafeMethodExecuteWithLogging.Execute(TurnOnLivingRoom, _logger));
        ha.RegisterServiceCallBack<ServiceData>("livingroom_lights_off",
            e => SafeMethodExecuteWithLogging.Execute(TurnOffLivingRoom, _logger));
    }

    /// <summary>
    /// Turn off living room lamps if nobody is home, otherwise leave them on
    /// </summary>
    private void TurnOffLivingRoom()
    {
        var homeOccupancy = StateEnums.ConvertToHomePresence(new Entities(_ha).Sensor.HomeOccupancy.State);

        if (homeOccupancy == StateEnums.HomePresence.occupied)
            _logger.LogDebug("Signalled to turn off lights but the house is occupied, so aborting");
        else
        {
            _logger.LogDebug("House is unoccupied so turning off the lights");

            foreach (var light in GetLivingRoomLights())
                light.TurnOff();
        }
    }

    //Turn on living room lights and reset their brightness levels
    private void TurnOnLivingRoom()
    {
        _logger.LogDebug("Turning on living room lights");

        foreach (var light in GetLivingRoomLights())
        {
            light.TurnOn(brightnessPct: DefaultBrightness);
        }
    }

    private List<LightEntity> GetLivingRoomLights()
    {
        var entities = new Entities(_ha);
        return new List<LightEntity>
        {
            entities.Light.JoSLamp,
            entities.Light.ScottSLamp,
            //entities.Light.LrWallBack,
            //entities.Light.LrWallFront,
            //entities.Light.LrWindowBack,
            //entities.Light.LrWindowFront
        };
    }
}