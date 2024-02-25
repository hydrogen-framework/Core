using Hydrogen.Core.Shared.Abstracts;

namespace Hydrogen.Core.SaaS.Domain.Events;

public class TenantRenamed : BaseDomainEvent<TenantRenamed>
{
    public Guid Key { get; init; } = Guid.Empty;
    public string Name { get; init; } = string.Empty;
}
