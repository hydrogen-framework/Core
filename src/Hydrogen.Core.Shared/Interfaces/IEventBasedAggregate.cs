using System.Collections.Immutable;

namespace Hydrogen.Core.Shared.Interfaces;

public interface IEventBasedAggregate<TAggregate>
    where TAggregate : IAggregate
{
    int Version { get; }
    DateTime Timestamp { get; }
    ImmutableArray<IDomainEvent> Events { get; }
}
