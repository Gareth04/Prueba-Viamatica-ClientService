using ClientService.Domain.Abstractions;
using ClientService.Domain.Cashs;
using ClientService.Domain.Clients;
using ClientService.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.OperationTypes
{
    public sealed class OperationType : Entity
    {
        private OperationType()
        {

        }

        private OperationType(
            Guid id,
            Type type

            ) : base(id)
        {
            Type = type;
        }
        public Type? Type { get; private set; }

    }
}
