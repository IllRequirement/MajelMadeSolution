namespace MajelMade.Domain.Entities
{
    public class Location(int locationID, string locationName, int scannableLabelID)
    {
        public int LocationID { get; set; } = locationID;
        public string LocationName { get; set; } = locationName;
        public int ScannableLabelID { get; set; } = scannableLabelID;

        public ICollection<StorageLocation> StorageLocations { get; set; } = new List<StorageLocation>();
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
