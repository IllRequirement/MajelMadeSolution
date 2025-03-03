namespace MajelMade.Domain.Entities
{
    public class EquipmentLog
    {
        public int LogID { get; set; }
        public int EquipmentID { get; set; }
        public int EquipmentLogTypeID { get; set; }
        public decimal Duration { get; set; }
        public decimal Cost { get; set; }
        public required string Notes { get; set; }
        public required Equipment Equipment { get; set; }
        public required EquipmentLogType EquipmentLogType { get; set; }
    }
}
