namespace MajelMade.Domain.Entities;

public class Room(int roomID, string roomName, int scannableLabelID, ScannableLabel scannableLabel)
{
    public int RoomID { get; init; } = roomID;
    public string RoomName { get; init; } = roomName;
    public int ScannableLabelID { get; init; } = scannableLabelID;
    public ScannableLabel ScannableLabel { get; init; } = scannableLabel;

    public ICollection<StorageLocation> StorageLocations { get; init; } = new List<StorageLocation>();
}
