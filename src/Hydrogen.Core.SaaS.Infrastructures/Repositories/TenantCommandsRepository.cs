using Hydrogen.Core.SaaS.Domain.Aggregates;
using Hydrogen.Core.SaaS.Domain.Repositories;
using Hydrogen.Core.Shared.Interfaces;

namespace Hydrogen.Core.SaaS.Infrastructures.Repositories;

public class TenantCommandsRepository : ITenantCommandsRepository
{
    public ITenantContext TenantContext { get; }
    private ICommandsDataContext dataContext { get; }

    public Task<Tenant> CreateAsync(Tenant obj, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant> UpdateAsync(Tenant obj, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Tenant> DeleteAsync(Tenant obj, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public TenantCommandsRepository(ITenantContext tenantContext, ICommandsDataContext dataContext)
    {
        TenantContext = tenantContext;
        this.dataContext = dataContext;
    }

}
