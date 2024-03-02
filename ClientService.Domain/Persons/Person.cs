using CleanArchitecture.Domain.Users.Events;
using ClientService.Domain.Abstractions;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClientService.Domain.Users
{
    public sealed class Person : Entity
    {
        private Person()
        {
        }

        private Person(
        Guid id,
        FirstName firstName,
        LastName lastName,
        Address address,
        DateRange birthdate
        ) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Birthdate = birthdate;
        }

        public FirstName? FirstName { get; private set; }
        public LastName? LastName { get; private set; }
        public Address? Address { get; private set; }
        public DateRange? Birthdate { get; internal set; }

        public static Person Create(
            Guid userId,
            FirstName firstName,
            LastName lastName,
            Address address,
            DateRange birthdate
        )
        {
            var person = new Person(Guid.NewGuid(), firstName, lastName, address, birthdate);
            person.RaiseDomainEvent(new PersonCreatedDomainEvent(person.Id));
            return person;
        }

    }
}
