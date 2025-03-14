namespace MajelMade.Domain.Entities
{
    public class CustomerEmail(int emailID, int customerID, string email, int emailTypeID, bool isActive = true)
    {
        public int EmailID { get; set; } = emailID;
        public int CustomerID { get; set; } = customerID;
        public string Email { get; set; } = email;
        public int EmailTypeID { get; set; } = emailTypeID;
        public bool IsActive { get; set; } = isActive;

        public required Customer Customer { get; set; }
        public required EmailType EmailType { get; set; }
    }
}
