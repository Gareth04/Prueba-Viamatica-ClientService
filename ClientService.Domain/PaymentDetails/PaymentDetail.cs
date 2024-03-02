using ClientService.Domain.Abstractions;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.PaymentDetails
{
    public sealed class PaymentDetail : Entity
    {
        public PaymentDetail() { }
        private PaymentDetail(
            Guid id,
            Guid paymentId,
            Guid paymentMethodId,
            DateRange paymentDate,
            PaymentValue paymentValue

            ) : base(id)
        {
            PaymentId = paymentId;
            PaymentMethodId = paymentMethodId;
            PaymentDate = paymentDate;
            PaymentValue = paymentValue;
        }
        public Guid ClientId { get; private set; }
        public Guid PaymentId { get; private set; }
        public Guid PaymentMethodId { get; private set; }
        public DateRange? PaymentDate { get; private set; }
        public PaymentValue? PaymentValue { get; private set; }

        public static PaymentDetail Create(
            Guid paymentId,
            Guid paymentMethodId,
            DateRange paymentDate,
            PaymentValue paymentValue
        )
        {
            var payment = new PaymentDetail(Guid.NewGuid(), paymentId, paymentMethodId, paymentDate, paymentValue);
            payment.RaiseDomainEvent(new PaymentCreatedDomainEvent(payment.Id));
            return payment;
        }

    }
}
