namespace Hydrogen.Core.Shared.Interfaces;

public interface IAggregate : IEntity
{
    Guid Key { get; }
}
