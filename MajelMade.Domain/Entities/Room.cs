namespace MajelMade.Domain.Entities
{
    public class Room
    {
        public int RoomID { get; set; }
        public required string RoomName { get; set; }
        public ICollection<StorageLocation> StorageLocations { get; set; } = new List<StorageLocation>();

        public int ScannableLabelID { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
