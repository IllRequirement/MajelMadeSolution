namespace MajelMade.Domain.Entities
{
    public class OrderStatusHistory(int orderStatusHistoryID, int orderID, int statusTypeID, DateTime updatedDateTime,string notes)
    {
        public int OrderStatusHistoryID { get; set; } = orderStatusHistoryID;
        public int OrderID { get; set; } = orderID;
        public int StatusTypeID { get; set; } = statusTypeID;
        public DateTime UpdatedDateTime { get; set; } = updatedDateTime;
        public string Notes { get; set; } = notes;

        public required Order Order { get; set; }
        public required StatusType StatusType { get; set; }
    }
}
