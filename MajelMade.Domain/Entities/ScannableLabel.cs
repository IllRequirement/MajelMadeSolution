namespace MajelMade.Domain.Entities
{
    public class ScannableLabel
    {
        public int LabelID { get; set; }
        public required string BarcodeValue { get; set; }
        public required string LabelType { get; set; }
    }
}
