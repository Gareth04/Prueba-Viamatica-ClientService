using ClientService.Domain.Abstractions;
using ClientService.Domain.Shared;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientService.Domain.Services
{
    public sealed class Service : Entity
    {
        public Service() { }
        public Service(
            Guid id,
            ServiceName serviceName,
            Moneda price
        ) : base(id) 
        {
            ServiceName = serviceName;
            Price = price;
        }
        public Guid ServiceId { get; private set; }
        public ServiceName? ServiceName { get; private set; }
        public Moneda? Price { get; private set; }
        public Mbps? Mbps { get; private set; }


    }
}
