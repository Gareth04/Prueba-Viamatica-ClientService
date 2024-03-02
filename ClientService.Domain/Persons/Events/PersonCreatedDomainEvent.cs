

using ClientService.Domain.Abstractions;


public sealed record PersonCreatedDomainEvent(Guid Id) : IDomainEvent;