namespace MajelMade.Domain.Entities
{
    public class Inventory(int inventoryID, string itemName, int inventoryCategoryID, decimal costPerUnit, int measurementUnitID, DateTime lastUpdated, int userID, string codeID, int? scannableLabelID = null)
    {
        public int InventoryID { get; set; } = inventoryID;
        public string ItemName { get; set; } = itemName;
        public int InventoryCategoryID { get; set; } = inventoryCategoryID;
        public decimal CostPerUnit { get; set; } = costPerUnit;
        public int MeasurementUnitID { get; set; } = measurementUnitID;
        public DateTime LastUpdated { get; set; } = lastUpdated;
        public int UserID { get; set; } = userID;
        public string CodeID { get; set; } = codeID;
        public int? ScannableLabelID { get; set; } = scannableLabelID;

        public InventoryCategory InventoryCategory { get; set; }
        public ScannableLabel? ScannableLabel { get; set; }
        public ICollection<InventoryBatch> InventoryBatches { get; set; } = new List<InventoryBatch>();
    }
}
