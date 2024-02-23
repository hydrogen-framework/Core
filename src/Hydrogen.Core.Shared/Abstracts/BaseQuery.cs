using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseQuery<TResponse> : BaseRequest<TResponse>, IQuery<TResponse>
    where TResponse : IResponse;
