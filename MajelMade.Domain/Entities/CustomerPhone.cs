namespace MajelMade.Domain.Entities
{
    public class CustomerPhone(int phoneID, int customerID, string phoneNumber, int phoneTypeID, bool isActive = true)
    {
        public int PhoneID { get; set; } = phoneID;
        public int CustomerID { get; set; } = customerID;
        public string PhoneNumber { get; set; } = phoneNumber;
        public int PhoneTypeID { get; set; } = phoneTypeID;
        public bool IsActive { get; set; } = isActive;

        public required Customer Customer { get; set; }
        public required PhoneType PhoneType { get; set; }
    }
}
