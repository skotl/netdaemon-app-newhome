using System.Collections.Generic;
using System.IO;
using System.Linq;
using daemonapp.apps.ScottHome.Geolocation;
using daemonapp.apps.ScottHome.Geolocation.Model;
using HomeAssistantGenerated;
using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome;

[Focus]
[NetDaemonApp]
public class HeatingBasedOnPresence
{
    private readonly Coordinates _homeLocation = new Coordinates(55.9861704, -3.3804923);
    private readonly double _turnDownExitDistance = 4000; // Distance in metres, where we should turn down heating
    private readonly double _turnUpReturnDistance = 3000; // Distance in metres, where we should turn up heating
    private readonly double _noChangeTolerance = 100; // Tolerance distance indicating no change
    private readonly double _targetTempExit = 16; // Target temp when everyone is far away
    private readonly double _targetTempReturn = 22; // Target temp when someone is returning

    private readonly IHaContext _ha;
    private readonly ILogger<HeatingBasedOnPresence> _logger;

    public HeatingBasedOnPresence(IHaContext ha, ILogger<HeatingBasedOnPresence> logger)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation($"{nameof(HeatingBasedOnPresence)} started");
        var entities = new Entities(ha);
        var homeOccupancy = entities.Sensor.HomeOccupancy;
        var thermostat = entities.Climate.Thermostat1;

        // When people have moved far from the house
        entities.DeviceTracker.ScottSXr.StateAllChanges()
            .Where(e => HasMovedOutsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedFarAway(e, entities));
        entities.DeviceTracker.JoSIphone.StateAllChanges()
            .Where(e => HasMovedOutsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedFarAway(e, entities));
        entities.DeviceTracker.TheosIphone6s.StateAllChanges()
            .Where(e => HasMovedOutsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedFarAway(e, entities));

        // When people are moving closer to the house
        entities.DeviceTracker.ScottSXr.StateAllChanges()
            .Where(e => HasMovedInsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedCloser(e, entities));
        entities.DeviceTracker.JoSIphone.StateAllChanges()
            .Where(e => HasMovedInsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedCloser(e, entities));
        entities.DeviceTracker.TheosIphone6s.StateAllChanges()
            .Where(e => HasMovedInsideHeatZone(homeOccupancy, thermostat, e))
            .Subscribe(e => PersonHasMovedCloser(e, entities));
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
               && thermostat?.Attributes?.Temperature > _targetTempExit
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, stateChange?.Old?.Attributes?.Latitude,
                   stateChange?.Old?.Attributes?.Longitude) > _noChangeTolerance
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, _homeLocation) > _turnDownExitDistance;
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
               && thermostat?.Attributes?.Temperature < _targetTempReturn
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, stateChange?.Old?.Attributes?.Latitude,
                   stateChange?.Old?.Attributes?.Longitude) > _noChangeTolerance
               && LocationHelper.CalculateDistance(stateChange?.New?.Attributes?.Latitude,
                   stateChange?.New?.Attributes?.Longitude, _homeLocation) < _turnUpReturnDistance;
    }

    private void PersonHasMovedFarAway(StateChange<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>> changes,
        Entities entities)
    {
        var distance = LocationHelper.CalculateDistance(changes?.New?.Attributes?.Latitude,
            changes?.New?.Attributes?.Longitude, _homeLocation);

        _logger.LogDebug($"Tracker {changes?.Entity?.EntityId} is outside heat zone, checking everyone");
        bool allPeopleAreFarAway = true;
        foreach (var trackerId in MyHomeEntityList.GetFamilyTrackers)
        {
            var tracker = _ha.Entity(trackerId);

            if (LocationHelper.CalculateDistance(ExtractCoordindatesFromEntity(tracker), _homeLocation)
                < _turnUpReturnDistance)
            {
                _logger.LogDebug($"Tracker {trackerId} is inside the heat zone, aborting check");
                allPeopleAreFarAway = false;
                break;
            }
        }

        if (allPeopleAreFarAway)
        {
            _logger.LogDebug($"Everyone is far away so set heat to {_targetTempExit}");
            entities.Climate.Thermostat1.SetTemperature(_targetTempExit);
        }
    }

    private Coordinates ExtractCoordindatesFromEntity(Entity tracker)
    {
        var attributes = tracker.Attributes as IDictionary<string, object>;
        if (!attributes.ContainsKey("latitude") || !attributes.ContainsKey("longitude"))
            throw new InvalidDataException(
                $"Entity with id = {tracker.EntityId} does not contain lat or long attributes");

        return new Coordinates(
            double.Parse(attributes["latitude"].ToString()),
            double.Parse(attributes["longitude"].ToString()));
    }

    private void PersonHasMovedCloser(StateChange<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>> changes,
        Entities entities)
    {
        var distance = LocationHelper.CalculateDistance(changes?.New?.Attributes?.Latitude,
            changes?.New?.Attributes?.Longitude, _homeLocation);

        _logger.LogDebug(
            $"Person {changes?.Entity?.EntityId} is inside heat zone, {(int)distance}m away, setting heat to {_targetTempReturn}");
        entities.Climate.Thermostat1.SetTemperature(_targetTempReturn);
    }
}