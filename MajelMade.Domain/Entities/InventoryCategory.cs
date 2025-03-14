namespace MajelMade.Domain.Entities
{
    public class InventoryCategory(int inventoryCategoryID, string categoryName, string description)
    {
        public int InventoryCategoryID { get; set; } = inventoryCategoryID;
        public string CategoryName { get; set; } = categoryName;
        public string Description { get; set; } = description;

        public ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
    }
}
