

using ClientService.Domain.Abstractions;


public sealed record PaymentCreatedDomainEvent(Guid PersonId) : IDomainEvent;