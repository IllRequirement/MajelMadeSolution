namespace MajelMade.Domain.Entities;

public class StorageLocation(int storageLocationID, int roomID, int locationID, Room room, Location location)
{
    public int StorageLocationID { get; init; } = storageLocationID;
    public int RoomID { get; init; } = roomID;
    public int LocationID { get; init; } = locationID;

    public Room Room { get; init; } = room;
    public Location Location { get; init; } = location;
    public ICollection<InventoryBatch> InventoryBatches { get; set; } = new List<InventoryBatch>();
}
