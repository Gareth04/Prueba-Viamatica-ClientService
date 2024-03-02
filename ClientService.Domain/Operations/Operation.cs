using ClientService.Domain.Abstractions;
using ClientService.Domain.Clients;
using ClientService.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.Operations
{
    public sealed class Operation : Entity
    {
        public Operation() { }
        private Operation(
            Guid id,
            DateTime operationDate,
            Guid operationTypeId,
            Guid cashId,
            Guid clientId

            ) : base(id)
        {
            OperationDate = operationDate;
            OperationTypeId = operationTypeId;
            CashId = cashId;
            ClientId = clientId;
        }
        public Guid OperationTypeId { get; private set; }
        public Guid CashId { get; private set; }
        public Guid ClientId { get; private set; }
        public DateTime OperationDate { get; private set;}

    }
}
