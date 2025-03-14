using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Customer(int customerID, string firstName, string lastName, DateTime dateCreated)
    {
        public int CustomerID { get; set; } = customerID;
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
        public DateTime DateCreated { get; set; } = dateCreated;

        private readonly List<CustomerPhone> _customerPhones = new();
        private readonly List<CustomerEmail> _customerEmails = new();
        private readonly List<CustomerAddress> _customerAddresses = new();

        public IReadOnlyCollection<CustomerPhone> CustomerPhones => _customerPhones.AsReadOnly();
        public IReadOnlyCollection<CustomerEmail> CustomerEmails => _customerEmails.AsReadOnly();
        public IReadOnlyCollection<CustomerAddress> CustomerAddresses => _customerAddresses.AsReadOnly();

        // ✅ EF Core requires a parameterless constructor
        private Customer() : this(0, string.Empty, string.Empty, DateTime.UtcNow) { }

        public void AddPhone(CustomerPhone phone)
        {
            if (phone == null) throw new ArgumentNullException(nameof(phone));
            _customerPhones.Add(phone);
        }

        public void AddEmail(CustomerEmail email)
        {
            if (email == null) throw new ArgumentNullException(nameof(email));
            _customerEmails.Add(email);
        }

        public void AddAddress(CustomerAddress address)
        {
            if (address == null) throw new ArgumentNullException(nameof(address));
            _customerAddresses.Add(address);
        }
    }
}
