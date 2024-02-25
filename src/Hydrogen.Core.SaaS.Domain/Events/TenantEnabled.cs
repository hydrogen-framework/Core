using Hydrogen.Core.Shared.Abstracts;

namespace Hydrogen.Core.SaaS.Domain.Events;

public class TenantEnabled : BaseDomainEvent<TenantEnabled>
{
    public Guid Key { get; init; } = Guid.Empty;
}
