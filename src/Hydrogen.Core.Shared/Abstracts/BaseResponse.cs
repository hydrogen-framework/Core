using Hydrogen.Core.Shared.Enums;
using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseResponse : IResponse
{
    public Guid ReferenceKey { get; init; }
    public DateTime Timestamp { get; init; }
    public ResponseStates State { get; init; }
    public string[] Details { get; init; } = [];
}
