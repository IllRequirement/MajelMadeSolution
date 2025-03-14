namespace MajelMade.Domain.Entities
{
    public class EquipmentStatus(int equipmentStatusID, string statusName)
    {
        public int EquipmentStatusID { get; set; } = equipmentStatusID;
        public string StatusName { get; set; } = statusName;

        public ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
    }
}
