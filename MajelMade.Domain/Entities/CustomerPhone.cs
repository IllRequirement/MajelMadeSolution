namespace MajelMade.Domain.Entities
{
    public class CustomerPhone
    {
        public int PhoneID { get; set; }
        public int CustomerID { get; set; }
        public required string PhoneNumber { get; set; }
        public int PhoneTypeID { get; set; }
        public bool IsActive { get; set; } = true;

        public required Customer Customer { get; set; }
        public required PhoneType PhoneType { get; set; }
    }
}
