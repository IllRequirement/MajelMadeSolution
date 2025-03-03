using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class StorageLocation
    {
        public int StorageLocationID { get; set; }
        public int RoomID { get; set; }
        public int LocationID { get; set; }

        public required Room Room { get; set; }
        public required Location Location { get; set; }
        public ICollection<InventoryBatch> InventoryBatches { get; set; } = new List<InventoryBatch>();
    }
}
