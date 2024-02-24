namespace Hydrogen.Core.Shared.Interfaces;

public interface IRequestValidator<TRequest> : IValidator<TRequest> where TRequest : IRequestBase;
