namespace MajelMade.Domain.Entities
{
    public class TableCombination
    {
        public int TableComboID { get; set; }
        public int TableID { get; set; }
        public int CombinedWithTableID { get; set; }

        public required Table Table { get; set; }
        public required Table CombinedWithTable { get; set; }
    }
}
