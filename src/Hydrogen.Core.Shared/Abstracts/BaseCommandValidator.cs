using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseCommandValidator<TCommand> : BaseValidator<TCommand>, ICommandValidator<TCommand>
    where TCommand : ICommandBase;
