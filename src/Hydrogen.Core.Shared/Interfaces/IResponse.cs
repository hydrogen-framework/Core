using Hydrogen.Core.Shared.Enums;

namespace Hydrogen.Core.Shared.Interfaces;

public interface IResponse : ITrackable
{
    string[] Details { get; }
    ResponseStates State { get; }
}