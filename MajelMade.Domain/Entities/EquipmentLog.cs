using System;

namespace MajelMade.Domain.Entities
{
    public class EquipmentLog(int logID, int equipmentID, int equipmentLogTypeID, decimal duration, decimal cost, string notes)
    {
        public int LogID { get; set; } = logID;
        public int EquipmentID { get; set; } = equipmentID;
        public int EquipmentLogTypeID { get; set; } = equipmentLogTypeID;
        public decimal Duration { get; set; } = duration;
        public decimal Cost { get; set; } = cost;
        public string Notes { get; set; } = notes;

        public required Equipment Equipment { get; set; }
        public required EquipmentLogType EquipmentLogType { get; set; }
    }
}
