using System;

namespace MajelMade.Domain.Entities
{
    public class OrderStatusHistory
    {
        public int OrderStatusHistoryID { get; set; }
        public int OrderID { get; set; }
        public int StatusTypeID { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public required string Notes { get; set; }

        public required Order Order { get; set; }
        public required StatusType StatusType { get; set; }
    }
}
