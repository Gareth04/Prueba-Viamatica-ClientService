
using ClientService.Domain.Abstractions;

public sealed record CashCreatedDomainEvent(Guid CashId) : IDomainEvent;