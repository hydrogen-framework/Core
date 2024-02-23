namespace Hydrogen.Core.Shared.Interfaces;

public interface ICommandBase : IRequestBase;
public interface ICommand : ICommandBase, IRequest, MediatR.IRequest;
public interface ICommand<TResponse> : ICommandBase, IRequest<TResponse>, MediatR.IRequest
    where TResponse : IResponse;
