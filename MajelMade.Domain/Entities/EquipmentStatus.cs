using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class EquipmentStatus
    {
        public int EquipmentStatusID { get; set; }
        public required string StatusName { get; set; }
        public ICollection<Equipment> Equipment { get; set; } = new List<Equipment>();
    }
}
