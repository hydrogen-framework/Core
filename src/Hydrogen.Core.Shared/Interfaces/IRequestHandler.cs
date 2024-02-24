namespace Hydrogen.Core.Shared.Interfaces;

public interface IRequestHandler<TRequest> : IHandler<TRequest>, MediatR.IRequestHandler<TRequest>
    where TRequest : IRequest;

public interface IRequestHandler<TRequest, TResponse> : IHandler<TRequest>, MediatR.IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>;