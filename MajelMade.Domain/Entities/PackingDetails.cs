namespace MajelMade.Domain.Entities
{
    public class PackingDetails(int packingID, int orderID, int packedByUserID, DateTime? startPackingTime = null, DateTime? endPackingTime = null)
    {
        public int PackingID { get; set; } = packingID;
        public int OrderID { get; set; } = orderID;
        public int PackedByUserID { get; set; } = packedByUserID;
        public DateTime? StartPackingTime { get; set; } = startPackingTime;
        public DateTime? EndPackingTime { get; set; }

        public required Order Order { get; set; }
        public required User PackedByUser { get; set; }

        public ICollection<PackedItem> PackedItems { get; set; } = new List<PackedItem>();
    }
}