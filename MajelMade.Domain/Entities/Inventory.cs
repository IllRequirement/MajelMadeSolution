using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public required string ItemName { get; set; }
        public int InventoryCategoryID { get; set; }
        public decimal CostPerUnit { get; set; }
        public int MeasurementUnitID { get; set; }
        public DateTime LastUpdated { get; set; }
        public int UserID { get; set; }
        public required string CodeID { get; set; }
        public int? ScannableLabelID { get; set; }

        public required InventoryCategory InventoryCategory { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
        public ICollection<InventoryBatch> InventoryBatches { get; set; } = new List<InventoryBatch>();
    }
}
