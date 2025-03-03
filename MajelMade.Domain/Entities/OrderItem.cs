namespace MajelMade.Domain.Entities
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int RecipeID { get; set; }
        public int Quantity { get; set; }
        public required string CodeID { get; set; }

        public required Order Order { get; set; }
        public required Recipe Recipe { get; set; }
    }
}
