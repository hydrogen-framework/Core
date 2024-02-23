using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseQueryHandler<TQuery, TResponse> : BaseRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : IResponse;