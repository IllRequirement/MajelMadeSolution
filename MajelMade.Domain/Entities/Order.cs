using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalCost { get; set; }
        public bool RequiresShipping { get; set; }
        public int OrderTypeID { get; set; }
        public required string CustomerComments { get; set; }
        public required string DeliveryInstructions { get; set; }
        public required string CodeID { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public ICollection<OrderStatusHistory> OrderStatusHistories { get; set; } = new List<OrderStatusHistory>();

        public required Customer Customer { get; set; }
        public required User User { get; set; }
        public required OrderType OrderType { get; set; }

        public int ScannableLabelID { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
