using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseCommand : BaseRequest, ICommand;
public abstract class BaseCommand<TResponse> : BaseRequest<TResponse>, ICommand<TResponse>
    where TResponse : IResponse;
