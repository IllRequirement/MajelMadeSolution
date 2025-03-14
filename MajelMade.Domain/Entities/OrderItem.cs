namespace MajelMade.Domain.Entities
{
    public class OrderItem(int orderItemID, int orderID, int recipeID, int quantity, string codeID)
    {
        public int OrderItemID { get; set; } = orderItemID;
        public int OrderID { get; set; } = orderID;
        public int RecipeID { get; set; } = recipeID;
        public int Quantity { get; set; } = quantity;
        public string CodeID { get; set; } = codeID;

        public required Order Order { get; set; }
        public required Recipe Recipe { get; set; }
    }
}
