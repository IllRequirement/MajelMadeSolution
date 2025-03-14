using System;
using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Equipment(int equipmentID, string equipmentName, string modelNumber, string serialNumber, int equipmentStatusID, DateTime? lastMaintenanceDate, DateTime? nextMaintenanceDue, string codeID, int scannableLabelID)
    {
        public int EquipmentID { get; set; } = equipmentID;
        public string EquipmentName { get; set; } = equipmentName;
        public string ModelNumber { get; set; } = modelNumber;
        public string SerialNumber { get; set; } = serialNumber;
        public int EquipmentStatusID { get; set; } = equipmentStatusID;
        public DateTime? LastMaintenanceDate { get; set; } = lastMaintenanceDate;
        public DateTime? NextMaintenanceDue { get; set; } = nextMaintenanceDue;
        public string CodeID { get; set; } = codeID;
        public int ScannableLabelID { get; set; } = scannableLabelID;

        public ICollection<RecipeEquipment> RecipeEquipment { get; set; } = new List<RecipeEquipment>();
        public ICollection<EquipmentLog> EquipmentLogs { get; set; } = new List<EquipmentLog>();

        public required ScannableLabel ScannableLabel { get; set; }
    }
}
