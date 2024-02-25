using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Extensions;

public static class SnapshotExtension
{
    public static TSnapshotModel Import<TSnapshotModel>(this TSnapshotModel instance, string json) 
        where TSnapshotModel : IAggregate
    {
        throw new NotImplementedException();
    }

    public static string Export<TSnapshotModel>(this TSnapshotModel instance)
    {
        throw new NotImplementedException();
    }
}
