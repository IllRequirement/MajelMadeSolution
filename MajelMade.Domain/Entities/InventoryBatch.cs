using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class InventoryBatch
    {
        public int InventoryBatchID { get; set; }
        public int InventoryID { get; set; }
        public required string BatchNumber { get; set; }
        public decimal Quantity { get; set; }
        public int MeasurementUnitID { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int StorageLocationID { get; set; }

        public required Inventory Inventory { get; set; }
        public required StorageLocation StorageLocation { get; set; }
        public ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

        public int ScannableLabelID { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
