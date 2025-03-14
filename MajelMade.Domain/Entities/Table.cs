namespace MajelMade.Domain.Entities;

public class Table(int tableID, string tableName, int seatCapacity, bool isCombinable, bool isAvailable)
{
    public int TableID { get; init; } = tableID;
    public string TableName { get; init; } = tableName;
    public int SeatCapacity { get; init; } = seatCapacity;
    public bool IsCombinable { get; init; } = isCombinable;
    public bool IsAvailable { get; set; } = isAvailable;

    public ICollection<TableCombination> PrimaryTableCombinations { get; set; } = new List<TableCombination>();
    public ICollection<TableCombination> CombinedWithTableCombinations { get; set; } = new List<TableCombination>();
}
