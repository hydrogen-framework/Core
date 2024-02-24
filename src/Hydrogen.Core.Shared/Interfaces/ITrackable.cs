namespace Hydrogen.Core.Shared.Interfaces;

public interface ITrackable
{
    Guid ReferenceKey { get; }
    DateTime Timestamp { get; }
}
