namespace Hydrogen.Core.Shared.Interfaces;

public interface IRequestBase;
public interface IRequest : IRequestBase, ITrigger, MediatR.IRequest;
public interface IRequest<TResponse> : IRequestBase, ITrigger, MediatR.IRequest<TResponse>;
