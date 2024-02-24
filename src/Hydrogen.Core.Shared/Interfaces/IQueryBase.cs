namespace Hydrogen.Core.Shared.Interfaces;

public interface IQueryBase : IRequestBase;
public interface IQuery<TResponse> : IQueryBase, IRequest<TResponse>, MediatR.IRequest
    where TResponse : IResponse;

