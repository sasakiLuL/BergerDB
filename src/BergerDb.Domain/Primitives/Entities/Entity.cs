using BergerDb.Domain.Primitives.Events;

namespace BergerDb.Domain.Primitives.Entities;

public abstract class Entity(EntityId id)
{
    protected readonly List<IDomainEvent> _domainEvents = [];

    public EntityId Id { get; init; } = id;

    public void RaiseDomainEvent(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);

    public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
}
