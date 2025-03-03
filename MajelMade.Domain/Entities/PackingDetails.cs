using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class PackingDetails
    {
        public int PackingID { get; set; }
        public int OrderID { get; set; }
        public int PackedByUserID { get; set; }
        public DateTime? StartPackingTime { get; set; }
        public DateTime? EndPackingTime { get; set; }
        public int TotalPackedItems { get; set; }

        public ICollection<PackedItem> PackedItems { get; set; } = new List<PackedItem>();
        public required Order Order { get; set; }
        public required User PackedByUser { get; set; }
    }
}
