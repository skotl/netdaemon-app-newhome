using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetDaemon.Extensions.MqttEntityManager;

namespace daemonapp.apps.ScottHome.EntityRegistrationHelpers;

internal class EntityRegistration : IEntityRegistration
{
    private readonly ILogger<EntityRegistration> _logger;
    private readonly IMqttEntityManager _entityManager;
    private readonly IHaContext _haContext;
    private Dictionary<string, EntityRegistrationTask?> registeredEntities = new();

    private Task[] AllRegistrationTasks => registeredEntities.Values.
        Select(e => e.Task)
        .Distinct()
        .ToArray();
    
    public EntityRegistration(ILogger<EntityRegistration> logger, IMqttEntityManager entityManager, IHaContext haContext)
    {
        _logger = logger;
        _entityManager = entityManager;
        _haContext = haContext;
    }
    
    public void AddEntityForRegistration(string entityId, EntityCreationOptions? creationOptions)
    {
        _logger.LogDebug("Adding {entityId} to registration list", entityId);
        registeredEntities.Add(entityId, new EntityRegistrationTask(entityId, creationOptions));
    }

    public async Task RegisterEntitiesAsync()
    {
        foreach (var entity in registeredEntities.Values)
        {
            _logger.LogDebug("Triggering create message for {entityId}", entity.EntityId);
            entity.Task = _entityManager.CreateAsync(entity.EntityId, entity.CreationOptions);
        }

        await VerifyEntitiesCreatedAsync();
    }

    public async Task VerifyEntitiesCreatedAsync()
    {
        _logger.LogDebug("Verify all entity creation requests have completed");
        
        Task.WaitAll(AllRegistrationTasks);
        
        _logger.LogDebug("Verified that all entity creation requests have completed");
    }
}