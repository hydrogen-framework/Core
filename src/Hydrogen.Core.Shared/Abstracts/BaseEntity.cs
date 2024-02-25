using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseEntity : IEntity
{
    public long Id { get; }

    public BaseEntity() 
    {
        Id = default;
    }

    public BaseEntity(long id)
    {
        Id = id;
    }
}
