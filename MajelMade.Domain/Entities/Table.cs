using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Table
    {
        public int TableID { get; set; }
        public required string TableName { get; set; }
        public int SeatCapacity { get; set; }
        public bool IsCombinable { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<TableCombination> PrimaryTableCombinations { get; set; } = new List<TableCombination>();
        public ICollection<TableCombination> CombinedWithTableCombinations { get; set; } = new List<TableCombination>();
    }
}
