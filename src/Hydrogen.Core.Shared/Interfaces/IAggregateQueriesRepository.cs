namespace Hydrogen.Core.Shared.Interfaces;

public interface IAggregateQueriesRepository<TAggregate>
{
    ITenantContext TenantContext { get; }

    Task<TAggregate?> InvokeAsync(long id, CancellationToken cancellationToken);
    Task<TAggregate?> InvokeAsync(Guid key, CancellationToken cancellationToken);
    Task<TAggregate[]> InvokeAllAsync(CancellationToken cancellationToken);
}
