namespace Hydrogen.Core.Shared.Interfaces;

public interface IQueriesDataContext
{
    IQueryable<TEntity> GetContext<TEntity>()
        where TEntity : class;

    Task<long> CountAsync<TEntity>(IQueryable<TEntity> query, CancellationToken cancellationToken)
        where TEntity : class;

    Task<List<TEntity>> QueryAsync<TEntity>(IQueryable<TEntity> query, CancellationToken cancellationToken)
        where TEntity : class;
}
