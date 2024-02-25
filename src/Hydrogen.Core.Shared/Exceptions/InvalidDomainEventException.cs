using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Exceptions;

public class InvalidDomainEventException : BaseException
{
    public IDomainEvent Event { get; }

    public InvalidDomainEventException(IDomainEvent e) 
    {
        Event = e;
    }
}
