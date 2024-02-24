namespace Hydrogen.Core.Shared.Enums;

public enum ResponseStates : byte
{
    None = 0,
    Completed = 1,
    InvalidRequest = 2,
    InvalidResponse = 3,
    OperationFailed = 4,
}
