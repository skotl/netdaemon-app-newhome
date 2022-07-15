using System.Collections.Generic;
using System.IO;
using System.Linq;
using daemonapp.apps.ScottHome.Geolocation;
using daemonapp.apps.ScottHome.Geolocation.Model;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome;

[NetDaemonApp]
public class HeatingBasedOnPresence
{
    private readonly Coordinates _homeLocation = new Coordinates(55.9861704, -3.3804923);
    private const double TurnDownExitDistance = 4000; // Distance in metres, where we should turn down heating
    private const double TurnUpReturnDistance = 3000; // Distance in metres, where we should turn up heating
    private const double NoChangeTolerance = 100; // Tolerance distance indicating no change
    private const double TargetTempExit = 16; // Target temp when everyone is far away
    private const double TargetTempReturn = 21; // Target temp when someone is returning

    private readonly IHaContext _ha;
    private readonly ILogger<HeatingBasedOnPresence> _logger;

    public HeatingBasedOnPresence(IHaContext ha, ILogger<HeatingBasedOnPresence> logger)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation("{App} started", nameof(HeatingBasedOnPresence));
        var entities = new Entities(ha);
        var homeOccupancy = entities.Sensor.HomeOccupancy;
        var thermostat = entities.Climate.Thermostat;

        // When people have moved far from the house
        SubscribeMovedOutsideHeatZone(entities.DeviceTracker.ScottSXr, homeOccupancy, thermostat);
        SubscribeMovedOutsideHeatZone(entities.DeviceTracker.JoSIphone, homeOccupancy, thermostat);
        SubscribeMovedOutsideHeatZone(entities.DeviceTracker.TheosIphone6s, homeOccupancy, thermostat);

        // When people are moving closer to the house
        SubscribeMovedInsideHeatZone(entities.DeviceTracker.ScottSXr, homeOccupancy, thermostat);
        SubscribeMovedInsideHeatZone(entities.DeviceTracker.JoSIphone, homeOccupancy, thermostat);
        SubscribeMovedInsideHeatZone(entities.DeviceTracker.TheosIphone6s, homeOccupancy, thermostat);
    }

    private void SubscribeMovedOutsideHeatZone(DeviceTrackerEntity trackerEntity, SensorEntity homeOccupancy,
        ClimateEntity thermostat)
    {
        trackerEntity.StateAllChanges()
            .Where(e => HasMovedOutsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedFarAway(e, thermostat));
    }

    private void SubscribeMovedInsideHeatZone(DeviceTrackerEntity trackerEntity, SensorEntity homeOccupancy,
        ClimateEntity thermostat)
    {
        trackerEntity.StateAllChanges()
            .Where(e => HasMovedInsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedCloser(e, thermostat));
    }

    /// <summary>
    /// House is not occupied, heating is set high, tracker location has changed appreciably,
    /// and tracker is far enough away from the house to turn the heating down
    /// </summary>
    /// <param name="homeOccupancy"></param>
    /// <param name="thermostat"></param>
    /// <param name="stateChange"></param>
    /// <returns></returns>
    private bool HasMovedOutsideHeatZone(SensorEntity homeOccupancy,
        ClimateEntity thermostat, StateChange<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>> stateChange)
    {
        return StateEnums.ConvertToHomePresence(homeOccupancy.State) == StateEnums.HomePresence.not_occupied
               && thermostat?.Attributes?.Temperature > TargetTempExit
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, stateChange?.Old?.Attributes?.Latitude,
                   stateChange?.Old?.Attributes?.Longitude) > NoChangeTolerance
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, _homeLocation) > TurnDownExitDistance;
    }

    /// <summary>
    /// House is not occupied, heating is set low, tracker location has changed appreciably, and tracker is
    /// close enough to the house to turn the heating up
    /// </summary>
    /// <param name="homeOccupancy"></param>
    /// <param name="thermostat"></param>
    /// <param name="stateChange"></param>
    /// <returns></returns>
    private bool HasMovedInsideHeatZone(SensorEntity homeOccupancy,
        ClimateEntity thermostat, StateChange<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>> stateChange)
    {
        return StateEnums.ConvertToHomePresence(homeOccupancy.State) == StateEnums.HomePresence.not_occupied
               && thermostat?.Attributes?.Temperature < TargetTempReturn
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, stateChange?.Old?.Attributes?.Latitude,
                   stateChange?.Old?.Attributes?.Longitude) > NoChangeTolerance
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, _homeLocation) < TurnUpReturnDistance;
    }

    private void PersonHasMovedFarAway(StateChange<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>> changes,
        ClimateEntity thermostat)
    {
        try
        {
            var distance = LocationHelper.CalculateDistance(changes?.New?.Attributes?.Latitude,
                changes?.New?.Attributes?.Longitude, _homeLocation);

            _logger.LogDebug("Tracker {EntityId} is outside heat zone, checking everyone", changes?.Entity?.EntityId);
            var allPeopleAreFarAway = true;
            foreach (var trackerId in from trackerId in MyHomeEntityList.GetFamilyTrackers
                     let tracker = _ha.Entity(trackerId)
                     where LocationHelper.CalculateDistance(ExtractCoordinatesFromEntity(tracker), _homeLocation)
                           < TurnUpReturnDistance
                     select trackerId)
            {
                _logger.LogDebug("Tracker {TrackerId} is inside the heat zone, aborting check", trackerId);
                allPeopleAreFarAway = false;
                break;
            }

            if (!allPeopleAreFarAway)
                return;

            _logger.LogDebug("Everyone is far away so set heat to {TargetTempExit}", TargetTempExit);
            thermostat.SetTemperature(TargetTempExit);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{Message}", ex.Message);
        }
    }

    private static Coordinates ExtractCoordinatesFromEntity(Entity tracker)
    {
        var attributes = tracker.Attributes as IDictionary<string, object>;
        if (attributes == null || !attributes.ContainsKey("latitude") || !attributes.ContainsKey("longitude"))
            throw new InvalidDataException(
                $"Entity with id = {tracker.EntityId} does not contain lat or long attributes");

        return new Coordinates(
            double.Parse(attributes["latitude"].ToString()!),
            double.Parse(attributes["longitude"].ToString()!));
    }

    private void PersonHasMovedCloser(StateChange<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>> changes,
        ClimateEntity thermostat)
    {
        try
        {
            var distance = LocationHelper.CalculateDistance(changes?.New?.Attributes?.Latitude,
                changes?.New?.Attributes?.Longitude, _homeLocation);

            _logger.LogDebug(
                "Person {EntityId} is inside heat zone, {Distance}m away, setting heat to {TargetTempReturn}",
                changes?.Entity?.EntityId, (int)distance, TargetTempReturn);

            thermostat.SetTemperature(TargetTempReturn);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{Message}", ex.Message);
        }
    }
}