namespace Hydrogen.Core.Shared.Interfaces;

public interface IResponseValidator<TResponse> : IValidator<TResponse>
    where TResponse : IResponse;
