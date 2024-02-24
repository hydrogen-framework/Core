namespace Hydrogen.Core.Shared.Interfaces;

public interface IQueryValidator<TQuery> : IRequestValidator<TQuery> 
    where TQuery : IQueryBase;
