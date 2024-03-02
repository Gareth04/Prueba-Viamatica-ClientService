using CleanArchitecture.Domain.Users.Events;
using ClientService.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClientService.Domain.Users
{
    public sealed class User : Entity
    {
        private User()
        {

        }

        private User(
            Guid id,
            Guid personId,
            Email email,
            Password password

            ) : base(id)
        {
            Email = email;
            Password = password;
            PersonId = personId;
        }

        public Email? Email { get; private set; }
        public Password? Password { get; private set; }
        public Guid PersonId { get; private set; }

        public static User Create(
            Guid personId,
            Email email,
            Password password
        )
        {
            var user = new User(Guid.NewGuid(), personId, email, password);
            user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));
            return user;
        }

    }
}
