using System.Linq;
using daemonapp.apps.ScottHome.Helpers;
using HomeAssistantGenerated;
using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.Scheduler;
using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome;

/// <summary>
/// When a person's state changes, update the "home_occupancy" sensor to show whether home is occupied or not
/// </summary>
[NetDaemonApp]
public class PersonHomeUpdater
{
    private const string EntityId = "sensor.home_occupancy";
    private const string EntityName = "Home occupancy";
    private const string OccupiedIcon = "mdi:home-circle";
    private const string NotOccupiedIcon = "mdi:home-circle-outline";
    private readonly IHaContext _ha;
    private readonly ILogger<PersonHomeUpdater> _logger;
    private readonly IMqttEntityManager _mqttEntityManager;

    public PersonHomeUpdater(IHaContext ha, ILogger<PersonHomeUpdater> logger, INetDaemonScheduler scheduler,
        IMqttEntityManager mqttEntityManager)
    {
        _ha = ha;
        _logger = logger;
        _mqttEntityManager = mqttEntityManager;

        scheduler.RunIn(TimeSpan.FromSeconds(1), RegisterEntities);

        var entities = new Entities(ha);

        entities.Person.Scott.StateChanges()
            .Subscribe(e => PersonChangedState(e.Entity.EntityId, e.New?.State));
        entities.Person.Jo.StateChanges()
            .Subscribe(e => PersonChangedState(e.Entity.EntityId, e.New?.State));
        entities.Person.Theo.StateChanges()
            .Subscribe(e => PersonChangedState(e.Entity.EntityId, e.New?.State));

        _logger.LogInformation("{App} started", nameof(PersonHomeUpdater));
    }

    private void RegisterEntities()
    {
        try
        {
            _logger.LogDebug("Creating entity {EntityId}", EntityId);
            _mqttEntityManager.CreateAsync(EntityId, new EntityCreationOptions(Name: EntityName),
                    new { icon = NotOccupiedIcon })
                .GetAwaiter();

            PersonChangedState("initialising", "unknown");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "{Message}", ex.Message);
        }
    }

    private void PersonChangedState(string entityId, string? newState)
    {
        _logger.LogDebug("{EntityId} changed state to {NewState}", entityId, newState);

        var peopleStates = _ha.GetAllEntities()
            .Where(e => e.EntityId != entityId && MyHomeEntityList.GetFamily.Contains(e.EntityId))
            .Select(e => e.State)
            .ToList();

        peopleStates.Add(newState);

        VerifyHomeStateAs(peopleStates.Contains(StateEnums.PersonPresence.home.ToString())
            ? StateEnums.HomePresence.occupied
            : StateEnums.HomePresence.not_occupied);
    }

    private void VerifyHomeStateAs(StateEnums.HomePresence verifiedState)
    {
        var verifiedStateValue = verifiedState.ToString();
        var homeOccupancy = _ha.Entity(EntityId);
        var currentState = homeOccupancy.State;

        _logger.LogDebug("Home presence currently {CurrentState}, should be {VerifiedState}", currentState,
            verifiedState);

        if (currentState == null || currentState != verifiedStateValue)
        {
            _mqttEntityManager.SetStateAsync(EntityId, verifiedStateValue).GetAwaiter();
            _mqttEntityManager.SetAttributesAsync(EntityId, new
            {
                icon = verifiedState == StateEnums.HomePresence.not_occupied ? NotOccupiedIcon : OccupiedIcon
            });
            _ha.WriteLogbook(EntityId, $"Home is now {verifiedState}");
        }
    }
}