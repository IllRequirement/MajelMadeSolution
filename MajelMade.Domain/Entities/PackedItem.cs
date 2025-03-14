namespace MajelMade.Domain.Entities
{
    public class PackedItem(int packedItemID, int packingID, int orderItemID, int quantityPacked, string notes)
    {
        public int PackedItemID { get; set; } = packedItemID;
        public int PackingID { get; set; } = packingID;
        public int OrderItemID { get; set; } = orderItemID;
        public int QuantityPacked { get; set; } = quantityPacked;
        public string Notes { get; set; } = notes;

        public required PackingDetails PackingDetails { get; set; }
        public required OrderItem OrderItem { get; set; }
    }
}
