using Hydrogen.Core.Shared.Abstracts;

namespace Hydrogen.Core.SaaS.Domain.Events;

public class TenantDisabled : BaseDomainEvent<TenantDisabled>
{
    public Guid Key { get; init; } = Guid.Empty;
}
