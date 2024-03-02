
using ClientService.Domain.Abstractions;

public sealed record ClientCreatedDomainEvent(Guid ClientId) : IDomainEvent;