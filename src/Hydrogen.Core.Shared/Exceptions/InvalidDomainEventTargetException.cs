using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Exceptions;

public class InvalidDomainEventTargetException : BaseException
{
    public Guid AggregateKey { get; }
    public Guid TargetKey { get; }
    public IDomainEvent Event { get; }

    public InvalidDomainEventTargetException(Guid aggregateKey, Guid targetKey, IDomainEvent e)
    {
        AggregateKey = aggregateKey;
        TargetKey = targetKey;
        Event = e;
    }
}
