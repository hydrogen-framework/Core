using Hydrogen.Core.SaaS.Domain.Enums;
using Hydrogen.Core.Shared.Exceptions;

namespace Hydrogen.Core.SaaS.Domain.Exceptions;

public class InvalidTenantStateTransitionException : BaseException
{
    public TenantStates CurrentState { get; }
    public TenantStates NewState { get; }

    public InvalidTenantStateTransitionException(TenantStates currentState, TenantStates newState)
    {
        CurrentState = currentState;
        NewState = newState;
    }
}
