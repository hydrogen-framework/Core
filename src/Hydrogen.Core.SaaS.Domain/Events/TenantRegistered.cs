using Hydrogen.Core.SaaS.Domain.Enums;
using Hydrogen.Core.Shared.Abstracts;

namespace Hydrogen.Core.SaaS.Domain.Events;

public class TenantRegistered : BaseDomainEvent<TenantRegistered>
{
    public Guid Key { get; init; } = Guid.Empty;
    public string Name { get; init; } = string.Empty;
    public TenantTypes Type { get; init; } = TenantTypes.None;
}
