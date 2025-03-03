namespace MajelMade.Domain.Entities
{
    public class EquipmentLogType
    {
        public int EquipmentLogTypeID { get; set; }
        public required string LogTypeName { get; set; }
        public ICollection<EquipmentLog> EquipmentLogs { get; set; } = new List<EquipmentLog>();
    }
}
