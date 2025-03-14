namespace MajelMade.Domain.Entities;

public class ScannableLabel(int labelID, string barcodeValue, string labelType)
{
    public int LabelID { get; init; } = labelID;
    public string BarcodeValue { get; init; } = barcodeValue;
    public string LabelType { get; init; } = labelType;
}
