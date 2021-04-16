using RAEFC.Domain.Core.Models;
using System;

namespace RAEFC.Domain.Models
{
    public class Customer : Entity, IAggregateRoot
    {
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}