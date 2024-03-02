using CleanArchitecture.Domain.Users.Events;
using ClientService.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.Clients
{
    public sealed class Client : Entity
    {
        private Client()
        {

        }

        private Client(
            Guid id,
            Guid userId,
            Identification identification

            ) : base(id)
        {
            UserId = userId;
            Identification = identification;
        }

        public Identification? Identification { get; private set; }
        public Guid UserId { get; private set; }


        public static Client Create(
            Guid userId,
            Identification identification
        )
        {
            var client = new Client(Guid.NewGuid(), userId, identification);
            client.RaiseDomainEvent(new ClientCreatedDomainEvent(client.Id));
            return client;
        }

    }
}
