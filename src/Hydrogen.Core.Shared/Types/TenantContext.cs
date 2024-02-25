using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Types;

public class TenantContext : ITenantContext
{
    public Guid TenantKey { get; }

    public TenantContext(Guid tenantKey)
    {
        TenantKey = tenantKey;
    }
}
