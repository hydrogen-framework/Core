using Hydrogen.Core.SaaS.Domain.Aggregates;
using Hydrogen.Core.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hydrogen.Core.SaaS.Infrastructures.Persistence.SqlServer.DataContexts;

public class SaaSCommandsDataContext : DbContext, ICommandsDataContext
{
    public DbSet<Tenant> Tenants { get; set; }

    public IQueryable<TEntity> GetContext<TEntity>()
        where TEntity : class
    {
        return Set<TEntity>();
    }

    public Task<long> CountAsync<TEntity>(IQueryable<TEntity> query, CancellationToken cancellationToken)
        where TEntity : class
        => query.LongCountAsync<TEntity>(cancellationToken);

    public Task<List<TEntity>> QueryAsync<TEntity>(IQueryable<TEntity> query, CancellationToken cancellationToken)
        where TEntity : class
        => query.ToListAsync<TEntity>(cancellationToken);

    public Task<TEntity> CreateAsync<TEntity>(TEntity instance, CancellationToken cancellationToken)
        where TEntity : class
        => Task.Run(() => { return Add<TEntity>(instance).Entity; });

    public Task<TEntity> DeleteAsync<TEntity>(TEntity instance, CancellationToken cancellationToken)
        where TEntity : class
        => Task.Run(() => { return Remove<TEntity>(instance).Entity; });

    public Task<TEntity> UpdateAsync<TEntity>(TEntity instance, CancellationToken cancellationToken)
        where TEntity : class
        => Task.Run(() => { return Update<TEntity>(instance).Entity; });

    public Task<int> SaveAsync(CancellationToken cancellationToken)
        => SaveChangesAsync(cancellationToken);
}
