using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseRequest : BaseTrigger, IRequest;
public abstract class BaseRequest<TResponse> : BaseTrigger, IRequest<TResponse>
    where TResponse : IResponse;
