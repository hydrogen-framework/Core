using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseDomainEvent<TDomainEvent> : BaseTrigger, IDomainEvent;
