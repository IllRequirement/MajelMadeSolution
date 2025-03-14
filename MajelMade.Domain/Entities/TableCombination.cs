namespace MajelMade.Domain.Entities;

public class TableCombination(int tableComboID, int tableID, int combinedWithTableID, Table table, Table combinedWithTable)
{
    public int TableComboID { get; init; } = tableComboID;
    public int TableID { get; init; } = tableID;
    public int CombinedWithTableID { get; init; } = combinedWithTableID;

    public Table Table { get; init; } = table;
    public Table CombinedWithTable { get; init; } = combinedWithTable;
}
