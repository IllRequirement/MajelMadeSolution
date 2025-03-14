namespace MajelMade.Domain.Entities;

public class SpecialOrderDetail(int specialOrderDetailID, int orderID, int inventoryID, int modificationTypeID, decimal quantity, int measurementUnitID, decimal modificationCost, string notes, Order order, Inventory inventory, ModificationType modificationType)
{
    public int SpecialOrderDetailID { get; init; } = specialOrderDetailID;
    public int OrderID { get; init; } = orderID;
    public int InventoryID { get; init; } = inventoryID;
    public int ModificationTypeID { get; init; } = modificationTypeID;
    public decimal Quantity { get; init; } = quantity;
    public int MeasurementUnitID { get; init; } = measurementUnitID;
    public decimal ModificationCost { get; init; } = modificationCost;
    public string Notes { get; init; } = notes;

    public Order Order { get; init; } = order;
    public Inventory Inventory { get; init; } = inventory;
    public ModificationType ModificationType { get; init; } = modificationType;
}
