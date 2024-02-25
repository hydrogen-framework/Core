using Hydrogen.Core.SaaS.Domain.Aggregates;
using Hydrogen.Core.SaaS.Domain.Repositories;
using Hydrogen.Core.SaaS.Infrastructures.Persistence.SqlServer.DataContexts;
using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.SaaS.Infrastructures.Repositories;

public class TenantAggregateRepository : ITenantCommandsRepository
{
    public ITenantContext TenantContext { get; }
    private ICommandsDataContext dataContext { get; }

    public Task<Tenant?> CreateAsync(Tenant obj, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> DeleteAsync(Tenant obj, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant[]> InvokeAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> InvokeAsync(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> InvokeAsync(Guid key, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant?> UpdateAsync(Tenant obj, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }


    public TenantAggregateRepository(ITenantContext tenantContext, ICommandsDataContext dataContext)
    {
        TenantContext = tenantContext;
        this.dataContext = dataContext;
    }
}
