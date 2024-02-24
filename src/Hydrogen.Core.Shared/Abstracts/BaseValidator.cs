namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseValidator<T> : FluentValidation.AbstractValidator<T>, Interfaces.IValidator<T>;
