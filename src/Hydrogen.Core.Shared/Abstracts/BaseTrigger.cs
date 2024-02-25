using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseTrigger : ITrigger
{
    public Guid ReferenceKey { get; }
    public DateTime Timestamp { get; }
    public bool IsNew { get; }

    public BaseTrigger()
    {
        ReferenceKey = Guid.NewGuid();
        Timestamp = DateTime.UtcNow;
        IsNew = true;
    }

    public BaseTrigger(Guid referenceKey, DateTime timestamp)
    {
        ReferenceKey = referenceKey;
        Timestamp = timestamp;
        IsNew = false;
    }
}
