namespace MajelMade.Domain.Entities
{
    public class EquipmentLogType(int equipmentLogTypeID, string logTypeName)
    {
        public int EquipmentLogTypeID { get; set; } = equipmentLogTypeID;
        public string LogTypeName { get; set; } = logTypeName;

        public ICollection<EquipmentLog> EquipmentLogs { get; set; } = new List<EquipmentLog>();
    }
}
