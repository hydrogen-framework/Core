using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.Shared.Abstracts;

public abstract class BaseQueryValidator<TQuery> : BaseValidator<TQuery>, IQueryValidator<TQuery>
    where TQuery : IQueryBase;
