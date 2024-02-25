namespace Hydrogen.Core.Shared.Interfaces;

public interface ICommandsDataContext
{
    Task<TEntity> CreateAsync<TEntity>(TEntity instance, CancellationToken cancellationToken)
        where TEntity : class;

    Task<TEntity> UpdateAsync<TEntity>(TEntity instance, CancellationToken cancellationToken)
        where TEntity : class;

    Task<TEntity> DeleteAsync<TEntity>(TEntity instance, CancellationToken cancellationToken)
        where TEntity : class;

    Task<int> SaveAsync(CancellationToken cancellationToken);
}
