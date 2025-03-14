namespace MajelMade.Domain.Entities
{
    public class CustomerAddress(int addressID, int customerID, string address, int addressTypeID, bool isActive = true)
    {
        public int AddressID { get; set; } = addressID;
        public int CustomerID { get; set; } = customerID;
        public string Address { get; set; } = address;
        public int AddressTypeID { get; set; } = addressTypeID;
        public bool IsActive { get; set; } = isActive;

        public required Customer Customer { get; set; }
        public required AddressType AddressType { get; set; }
    }
}
