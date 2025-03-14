namespace MajelMade.Domain.Entities;

public class RecipeEquipment(int recipeId, int equipmentId, Recipe recipe, Equipment equipment)
{
    public int RecipeEquipmentID { get; set; }
    public int RecipeID { get; set; } = recipeId;
    public int EquipmentID { get; set; } = equipmentId;
    public string? Notes { get; set; }
    public Recipe Recipe { get; set; } = recipe;
    public Equipment Equipment { get; set; } = equipment;
}
