namespace MajelMade.Domain.Entities
{
    public class RecipeEquipment
    {
        public int RecipeEquipmentID { get; set; }
        public int RecipeID { get; set; }
        public int EquipmentID { get; set; }
        public string? Notes { get; set; }

        public required Recipe Recipe { get; set; }
        public required Equipment Equipment { get; set; }
    }
}
