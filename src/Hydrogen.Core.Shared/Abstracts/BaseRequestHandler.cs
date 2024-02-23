using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseRequestHandler<TRequest> : IRequestHandler<TRequest>
    where TRequest : IRequest
{
    public abstract Task Handle(TRequest request, CancellationToken cancellationToken);
}

public abstract class BaseRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
