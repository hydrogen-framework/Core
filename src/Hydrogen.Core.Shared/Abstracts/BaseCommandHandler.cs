using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseCommandHandler<TCommand> : BaseRequestHandler<TCommand>
    where TCommand : ICommand;

public abstract class BaseCommandHandler<TCommand, TResponse> : BaseRequestHandler<TCommand>
    where TCommand : ICommand;
