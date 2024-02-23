using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseRequestValidator<TRequest> : BaseValidator<TRequest>, IRequestValidator<TRequest>
    where TRequest : IRequestBase;
