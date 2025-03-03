using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class InventoryCategory
    {
        public int InventoryCategoryID { get; set; }
        public required string CategoryName { get; set; }
        public required string Description { get; set; }
        public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
    }
}
