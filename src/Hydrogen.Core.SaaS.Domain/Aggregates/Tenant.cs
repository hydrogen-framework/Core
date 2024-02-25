using Hydrogen.Core.SaaS.Domain.Enums;
using Hydrogen.Core.SaaS.Domain.Events;
using Hydrogen.Core.SaaS.Domain.Exceptions;
using Hydrogen.Core.Shared.Abstracts;
using Hydrogen.Core.Shared.Exceptions;
using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.SaaS.Domain.Aggregates;

public class Tenant : BaseAggregateWithEventsSupport<Tenant>
{
    public string Name { get; private set; } = string.Empty;
    public TenantTypes Type { get; } = TenantTypes.None;
    public TenantStates State { get; private set; } = TenantStates.None;

    private void ValidateStateTransition(TenantStates newState)
    {
        var validationResult = (State, newState) switch
        {
            (TenantStates.None, TenantStates.Pending) => true,
            (TenantStates.Pending, TenantStates.Enabled) => true,
            (TenantStates.Pending, TenantStates.Disabled) => true,
            (TenantStates.Pending, TenantStates.Archived) => true,
            (TenantStates.Enabled, TenantStates.Disabled) => true,
            (TenantStates.Enabled, TenantStates.Archived) => true,
            (TenantStates.Disabled, TenantStates.Enabled) => true,
            (TenantStates.Disabled, TenantStates.Archived) => true,
            (_, _) => false
        };

        if (validationResult == false)
            throw new InvalidTenantStateTransitionException(State, newState);
    }

    private void ValidateChangeRequests(IDomainEvent e)
    {
        bool isConsistent = State == TenantStates.Archived;

        if (isConsistent)
        {
            if (Type == TenantTypes.Default || Type == TenantTypes.Primary)
            {

                isConsistent = e switch
                {
                    TenantEnabled p => true,
                    TenantRenamed p => false,
                    TenantDisabled p => false,
                    TenantArchived p => false,
                    TenantRegistered p => true,

                    _ => true
                };
            }
        }

        if (isConsistent == false)
            throw new InvalidTenantChangeException();
    }

    private void ValidateEventTarget(IDomainEvent e, Guid targetKey)
    {
        if (Key == targetKey)
            return;

        throw new InvalidDomainEventTargetException(Key, targetKey, e);
    }

    private Tenant Apply(TenantEnabled e)
    {
        ValidateChangeRequests(e);
        ValidateEventTarget(e, e.Key);
        ValidateStateTransition(TenantStates.Enabled);

        State = TenantStates.Enabled;

        return this;
    }

    private Tenant Apply(TenantDisabled e)
    {
        ValidateChangeRequests(e);
        ValidateEventTarget(e, e.Key);
        ValidateStateTransition(TenantStates.Disabled);

        State = TenantStates.Disabled;

        return this;
    }

    private Tenant Apply(TenantArchived e)
    {
        ValidateChangeRequests(e);
        ValidateEventTarget(e, e.Key);
        ValidateStateTransition(TenantStates.Archived);

        State = TenantStates.Archived;

        return this;
    }

    private Tenant Apply(TenantRegistered e)
    {
        return this;
    }

    private Tenant Apply(TenantRenamed e)
    {
        ValidateChangeRequests(e);
        ValidateEventTarget(e, e.Key);

        Name = e.Name;

        return this;
    }

    protected override Tenant DispatchEvent(IDomainEvent e)
    {
        return e switch
        {
            TenantEnabled p => Apply(p),
            TenantRenamed p => Apply(p),
            TenantDisabled p => Apply(p),
            TenantArchived p => Apply(p),
            TenantRegistered p => Apply(p),

            _ => throw new InvalidDomainEventException(e)
        };
    }

    public Tenant Enable(Guid key)
        => ApplyEvent(new TenantEnabled()
        {
            Key = key,
        });

    public Tenant Disable(Guid key)
        => ApplyEvent(new TenantDisabled()
        {
            Key = key,
        });
  
    public Tenant Archive(Guid key)
        => ApplyEvent(new TenantArchived()
        {
            Key = key,
        });

    public Tenant Rename(Guid key, string name)
        => ApplyEvent(new TenantRenamed()
        {
            Key = key,
            Name = name
        });

    public static Tenant Create(Guid key, string name, TenantTypes type)
    {
        return new Tenant(key, name, type);
    }

    private Tenant(Guid key, string name, TenantTypes type)
    {
        ApplyEvent(new TenantRegistered()
        {
            Key = key,
            Name = name,
            Type = type
        });
    }

    protected Tenant(long id, Guid key, int version, DateTime timestamp, string name, TenantTypes type, TenantStates state) :
        base(id, key, version, timestamp)
    {
        Name = name;
        Type = type;
        State = state;
    }
}
