using System.Threading.Tasks;
using NetDaemon.Extensions.MqttEntityManager;

namespace daemonapp.apps.ScottHome.EntityRegistrationHelpers;

public interface IEntityRegistration
{
    void AddEntityForRegistration(string entityId, EntityCreationOptions? creationOptions);
    Task RegisterEntitiesAsync();
    Task VerifyEntitiesCreatedAsync();
}