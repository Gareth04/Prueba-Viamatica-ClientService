using ClientService.Domain.Abstractions;
using ClientService.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.Cashs
{
    public sealed class Cash : Entity
    {
        private Cash()
        {

        }

        private Cash(
            Guid id,
            Guid userId,
            CashDescription cashDescription

            ) : base(id)
        {
            UserId = userId;
            CashDescription = cashDescription;
        }

        public CashDescription? CashDescription { get; private set; }
        public Guid UserId { get; private set; }


        public static Cash Create(
            Guid userId,
            CashDescription cashDescription
        )
        {
            var cash = new Cash(Guid.NewGuid(), userId, cashDescription);
            cash.RaiseDomainEvent(new ClientCreatedDomainEvent(cash.Id));
            return cash;
        }

    }
}
