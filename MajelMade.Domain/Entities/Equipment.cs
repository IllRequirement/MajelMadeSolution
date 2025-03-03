using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Equipment
    {
        public int EquipmentID { get; set; }
        public required string EquipmentName { get; set; }
        public required string ModelNumber { get; set; }
        public required string SerialNumber { get; set; }
        public int EquipmentStatusID { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDue { get; set; }
        public required string CodeID { get; set; }

        public ICollection<RecipeEquipment> RecipeEquipment { get; set; } = new List<RecipeEquipment>();
        public ICollection<EquipmentLog> EquipmentLogs { get; set; } = new List<EquipmentLog>();

        // Assuming every Equipment must have a label:
        public int ScannableLabelID { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
