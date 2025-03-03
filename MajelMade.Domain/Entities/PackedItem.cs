namespace MajelMade.Domain.Entities
{
    public class PackedItem
    {
        public int PackedItemID { get; set; }
        public int PackingID { get; set; }
        public int OrderItemID { get; set; }
        public int QuantityPacked { get; set; }
        public required string Notes { get; set; }

        public required PackingDetails PackingDetails { get; set; }
        public required OrderItem OrderItem { get; set; }
    }
}
