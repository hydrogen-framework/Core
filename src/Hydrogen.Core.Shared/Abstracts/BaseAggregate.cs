using Hydrogen.Core.Shared.Interfaces;
using System.Collections.Immutable;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseAggregate<TAggregate> : BaseEntity, IAggregate
{
    public Guid Key { get; }

    protected bool ValidateKey(Guid key)
        => Key == key;

    protected BaseAggregate() : base()
        => Key = Guid.NewGuid();

    protected BaseAggregate(long id, Guid key) : base(id)
        => Key = key;
}

public abstract class BaseAggregateWithEventsSupport<TAggregate> : BaseAggregate<TAggregate>, IEventBasedAggregate<TAggregate>
    where TAggregate : IAggregate
{
    public int Version { get; protected set; }
    public DateTime Timestamp { get; protected set; }
    public ImmutableArray<IDomainEvent> Events { get; protected set; }

    protected abstract TAggregate DispatchEvent(IDomainEvent e);

    public TAggregate ApplyEvent(IDomainEvent e)
    {
        Version++;

        if (e.IsNew)
        {
            Timestamp = DateTime.UtcNow;
            Events = Events.Add(e);
        }
        else
            Timestamp = e.Timestamp;

        return DispatchEvent(e);
    }

    protected BaseAggregateWithEventsSupport() : base()
    {
        Version = 0;
        Timestamp = DateTime.UtcNow;
        Events = [];
    }

    protected BaseAggregateWithEventsSupport(long id, Guid key, int version, DateTime timestamp) : base(id, key)
    {
        Version = version;
        Timestamp = timestamp;
    }
}

public abstract class BaseAggregateWithEventSourcing<TAggregate> : BaseAggregateWithEventsSupport<TAggregate>, IEventSourceAggregate<TAggregate>
    where TAggregate : IAggregate
{
    private string rollbackSnapshot = string.Empty;

    public void Commit()
        => Events = [];

    //TODO: This method has not implemented yet.
    public void Rollback() => throw new NotImplementedException();

    //TODO: This method has not implemented yet.
    public string GenerateSnapshot() => throw new NotImplementedException();

    //TODO: This method has not implemented yet.
    public void LoadSnapshot(string snapshot) => throw new NotImplementedException();

    //TODO: This method has not implemented yet.
    public void LoadEvents(IEnumerable<IDomainEvent> events) => throw new NotImplementedException();
}