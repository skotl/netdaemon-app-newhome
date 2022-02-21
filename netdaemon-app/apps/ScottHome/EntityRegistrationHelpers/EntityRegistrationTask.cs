using System.Threading.Tasks;
using NetDaemon.Extensions.MqttEntityManager;

namespace daemonapp.apps.ScottHome.EntityRegistrationHelpers;

internal class EntityRegistrationTask
{
    public string? EntityId { get; set; }
    public EntityCreationOptions? CreationOptions { get; }
    public Task? Task { get; set; }

    public EntityRegistrationTask(string entityId, EntityCreationOptions? creationOptions)
    {
        EntityId = entityId;
        CreationOptions = creationOptions;
    }
}