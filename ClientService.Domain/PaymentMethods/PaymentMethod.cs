using ClientService.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.PaymentMethods
{
    public sealed class PaymentMethod : Entity
    {
        private PaymentMethod()
        {

        }
        private PaymentMethod(
            Guid id,
            TypePaymentMethod typePaymentMethod

            ) : base(id)
        {
            TypePaymentMethod = typePaymentMethod;
        }
        public TypePaymentMethod? TypePaymentMethod { get; private set; }
    }

}
