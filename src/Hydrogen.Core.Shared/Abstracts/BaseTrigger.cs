using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseTrigger : ITrigger
{
    public Guid ReferenceKey { get; init; }
    public DateTime Timestamp { get; init; }
}
