using Hydrogen.Core.SaaS.Domain.Aggregates;
using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.SaaS.Domain.Repositories;

public interface ITenantCommandsRepository : IAggregateCommandsRepository<Tenant>
{

}
