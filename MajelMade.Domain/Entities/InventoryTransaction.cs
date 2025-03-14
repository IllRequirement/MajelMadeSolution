namespace MajelMade.Domain.Entities
{
    public class InventoryTransaction(int transactionID, int inventoryBatchID, int inventoryTransactionTypeID, decimal quantityChange, DateTime transactionDate, string notes)
    {
        public int TransactionID { get; set; } = transactionID;
        public int InventoryBatchID { get; set; } = inventoryBatchID;
        public int InventoryTransactionTypeID { get; set; } = inventoryTransactionTypeID;
        public decimal QuantityChange { get; set; } = quantityChange;
        public DateTime TransactionDate { get; set; } = transactionDate;
        public string Notes { get; set; } = notes;

        public required InventoryBatch InventoryBatch { get; set; }
    }
}
