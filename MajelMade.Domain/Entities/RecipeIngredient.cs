namespace MajelMade.Domain.Entities
{
    public class RecipeIngredient
    {
        public int RecipeIngredientID { get; set; }
        public int RecipeID { get; set; }
        public int InventoryID { get; set; }
        public decimal QuantityRequired { get; set; }
        public int MeasurementUnitID { get; set; }
        public required string CodeID { get; set; }
        public bool NeedsReorder { get; set; } = false;

        public required Recipe Recipe { get; set; }
    }
}
