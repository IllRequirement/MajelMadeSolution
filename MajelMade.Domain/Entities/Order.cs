namespace MajelMade.Domain.Entities
{
    public class Order(int orderId, int customerID, int userID, DateTime orderDate, decimal totalCost, bool requiresShipping, int orderTypeID, string customerComments, string deliveryInstructions, string codeID, int scannableLabelID)
    {
        public int OrderID { get; } = orderId;
        public int CustomerID { get; set; } = customerID;
        public int UserID { get; set; } = userID;
        public DateTime OrderDate { get; } = orderDate;
        public decimal TotalCost { get; set; } = totalCost;
        public bool RequiresShipping { get; set; } = requiresShipping;
        public int OrderTypeID { get; set; } = orderTypeID;
        public string CustomerComments { get; set; } = customerComments;
        public string DeliveryInstructions { get; set; } = deliveryInstructions;
        public string CodeID { get; set; } = codeID;
        public int ScannableLabelID { get; set; } = scannableLabelID;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<OrderStatusHistory> OrderStatusHistories { get; set; } = new List<OrderStatusHistory>();

        public required Customer Customer { get; set; }
        public required User User { get; set; }
        public required OrderType OrderType { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
        public Order() : this(0, 0, 0, DateTime.UtcNow, 0, false, 0, "", "", "", 0) { }
    }
}
