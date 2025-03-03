using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<CustomerPhone> CustomerPhones { get; set; } = new List<CustomerPhone>();
        public ICollection<CustomerEmail> CustomerEmails { get; set; } = new List<CustomerEmail>();
        public ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
    }
}
