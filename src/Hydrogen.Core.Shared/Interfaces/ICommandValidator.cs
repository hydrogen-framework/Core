namespace Hydrogen.Core.Shared.Interfaces;

public interface ICommandValidator<TCommand> : IRequestValidator<TCommand>
    where TCommand : ICommandBase;

