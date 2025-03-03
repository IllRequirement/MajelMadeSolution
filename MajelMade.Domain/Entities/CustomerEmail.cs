namespace MajelMade.Domain.Entities
{
    public class CustomerEmail
    {
        public int EmailID { get; set; }
        public int CustomerID { get; set; }
        public required string Email { get; set; }
        public int EmailTypeID { get; set; }
        public bool IsActive { get; set; } = true;

        public required Customer Customer { get; set; }
        public required EmailType EmailType { get; set; }
    }
}
