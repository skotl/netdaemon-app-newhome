using System.Collections.Generic;
using System.Linq;
using HomeAssistantGenerated;

namespace daemonapp.apps.ScottHome;


/// <summary>
/// When a person's state changes, update the "home_occupancy" sensor to show whether home is occupied or not
/// </summary>
[NetDaemonApp]
public class PersonHomeUpdater
{
    private readonly IHaContext _ha;
    private readonly ILogger<PersonHomeUpdater> _logger;

    public PersonHomeUpdater(IHaContext ha, ILogger<PersonHomeUpdater> logger)
    {
        _ha = ha;
        _logger = logger;

        _logger.LogInformation($"{nameof(PersonHomeUpdater)} started");

        var entities = new Entities(ha);

        entities.Person.Scott.StateChanges()
            .Subscribe(e => PersonChangedState(e.Entity.EntityId, e.New?.State));
        entities.Person.Jo.StateChanges()
            .Subscribe(e => PersonChangedState(e.Entity.EntityId, e.New?.State));
        entities.Person.Theo.StateChanges()
            .Subscribe(e => PersonChangedState(e.Entity.EntityId, e.New?.State));
    }

    private void PersonChangedState(string entityId, string? newState)
    {
        _logger.LogDebug($"{entityId} changed state to {newState}");
        
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
        var homeOccupancy = _ha.Entity(MyHomeEntityList.GetHomeOccupancy);
        var currentState = homeOccupancy.State;

        _logger.LogDebug($"Home presence currently {currentState}, should be {verifiedState}");

        if (currentState == null || currentState != verifiedStateValue)
        {
            var services = new Services(_ha);
            services.Netdaemon.EntityUpdate(homeOccupancy.EntityId, verifiedStateValue);
        }
    }
}