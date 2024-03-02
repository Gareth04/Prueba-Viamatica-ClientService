using ClientService.Domain.Abstractions;
using ClientService.Domain.Clients;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.Payments
{
    public sealed class Payment : Entity

    {
        private Payment()
        {

        }

        private Payment(
            Guid id,
            Guid clientId,
            DateRange maxPaymentDate

            ) : base(id)
        {
            ClientId = clientId;
            MaxPaymentDate = maxPaymentDate;
        }

        public DateRange? MaxPaymentDate { get; private set; }
        public Guid ClientId { get; private set; }


        public static Payment Create(
            Guid clientId,
            DateRange maxPaymentDate
        )
        {
            var payment = new Payment(Guid.NewGuid(), clientId, maxPaymentDate);
            payment.RaiseDomainEvent(new PaymentCreatedDomainEvent(payment.Id));
            return payment;
        }
    }
}
