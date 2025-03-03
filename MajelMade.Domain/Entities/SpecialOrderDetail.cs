namespace MajelMade.Domain.Entities
{
    public class SpecialOrderDetail
    {
        public int SpecialOrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int InventoryID { get; set; }
        public int ModificationTypeID { get; set; }
        public decimal Quantity { get; set; }
        public int MeasurementUnitID { get; set; }
        public decimal ModificationCost { get; set; }
        public required string Notes { get; set; }

        public required Order Order { get; set; }
        public required Inventory Inventory { get; set; }
        public required ModificationType ModificationType { get; set; }
    }
}
