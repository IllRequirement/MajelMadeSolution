using System;

namespace MajelMade.Domain.Entities
{
    public class InventoryTransaction
    {
        public int TransactionID { get; set; }
        public int InventoryBatchID { get; set; }
        public int InventoryTransactionTypeID { get; set; }
        public decimal QuantityChange { get; set; }
        public DateTime TransactionDate { get; set; }
        public required string Notes { get; set; }

        public required InventoryBatch InventoryBatch { get; set; }
    }
}
