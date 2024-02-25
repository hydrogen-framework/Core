namespace Hydrogen.Core.Shared.Interfaces;

public interface ITrigger : ITrackable
{
    bool IsNew { get; }
}
