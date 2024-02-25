namespace Hydrogen.Core.Shared.Interfaces;

public interface IAggregateCommandsRepository<TAggregate>
{
    ITenantContext TenantContext { get; }

    Task<TAggregate> CreateAsync(TAggregate obj, CancellationToken cancellationToken);
    Task<TAggregate> UpdateAsync(TAggregate obj, CancellationToken cancellationToken);
    Task<TAggregate> DeleteAsync(TAggregate obj, CancellationToken cancellationToken);
    Task<int> SaveAsync(CancellationToken cancellationToken);   
}
