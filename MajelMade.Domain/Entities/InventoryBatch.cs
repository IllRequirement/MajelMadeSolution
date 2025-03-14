namespace MajelMade.Domain.Entities
{
    public class InventoryBatch(int inventoryBatchID, int inventoryID, string batchNumber, decimal quantity, int measurementUnitID, DateTime? expirationDate, DateTime receivedDate,int storageLocationID, int scannableLabelID)
    {
        public int InventoryBatchID { get; set; } = inventoryBatchID;
        public int InventoryID { get; set; } = inventoryID;
        public string BatchNumber { get; set; } = batchNumber;
        public decimal Quantity { get; set; } = quantity;
        public int MeasurementUnitID { get; set; } = measurementUnitID;
        public DateTime? ExpirationDate { get; set; } = expirationDate;
        public DateTime ReceivedDate { get; set; } = receivedDate;
        public int StorageLocationID { get; set; } = storageLocationID;
        public int ScannableLabelID { get; set; } = scannableLabelID;

        public required Inventory Inventory { get; set; }
        public required StorageLocation StorageLocation { get; set; }
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
