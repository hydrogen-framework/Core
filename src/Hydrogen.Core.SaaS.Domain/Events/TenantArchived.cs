using Hydrogen.Core.Shared.Abstracts;

namespace Hydrogen.Core.SaaS.Domain.Events;

public class TenantArchived : BaseDomainEvent<TenantArchived>
{
    public Guid Key { get; init; } = Guid.Empty;
}
