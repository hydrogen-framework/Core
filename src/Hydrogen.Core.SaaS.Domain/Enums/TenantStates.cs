namespace Hydrogen.Core.SaaS.Domain.Enums;

public enum TenantStates : byte
{
    None = 0,
    Pending = 1,
    Enabled = 2,
    Disabled = 3,
    Archived = 4,
}
