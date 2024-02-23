using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseResponseValidator<TResponse> : BaseValidator<TResponse>
    where TResponse : IResponse;