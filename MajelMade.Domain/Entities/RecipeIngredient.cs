namespace MajelMade.Domain.Entities;

public class RecipeIngredient(int recipeId, int inventoryId, decimal quantityRequired, int measurementUnitId, string codeId, Recipe recipe, Inventory inventory)
{
    public int RecipeIngredientID { get; set; }
    public int RecipeID { get; set; } = recipeId;
    public int InventoryID { get; set; } = inventoryId;
    public decimal QuantityRequired { get; set; } = quantityRequired;
    public int MeasurementUnitID { get; set; }
    public string CodeID { get; set; } = codeId;
    public bool NeedsReorder { get; set; } = false;

    public Recipe Recipe { get; set; } = recipe;
    public Inventory Inventory { get; set; } = inventory;
}
