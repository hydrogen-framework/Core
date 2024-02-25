using Hydrogen.Core.SaaS.Domain.Aggregates;
using Hydrogen.Core.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hydrogen.Core.SaaS.Infrastructures.Persistence.SqlServer.DataContexts;

public class SaaSQueriesDataContext : DbContext, IQueriesDataContext
{
    public DbSet<Tenant> Tenants { get; set; }

    public Task<long> CountAsync<TEntity>(IQueryable<TEntity> query, CancellationToken cancellationToken) where TEntity : class
    {
        throw new NotImplementedException();
    }

    public IQueryable<TEntity> GetContext<TEntity>() where TEntity : class
    {
        throw new NotImplementedException();
    }

    public Task<List<TEntity>> QueryAsync<TEntity>(IQueryable<TEntity> query, CancellationToken cancellationToken) where TEntity : class
    {
        throw new NotImplementedException();
    }
}
