namespace MajelMade.Domain.Entities
{
    public class CustomerAddress
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        public required string Address { get; set; }
        public int AddressTypeID { get; set; }
        public bool IsActive { get; set; } = true;

        public required Customer Customer { get; set; }
        public required AddressType AddressType { get; set; }
    }
}
