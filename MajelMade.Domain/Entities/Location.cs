using System.Collections.Generic;

namespace MajelMade.Domain.Entities
{
    public class Location
    {
        public int LocationID { get; set; }
        public required string LocationName { get; set; }
        public ICollection<StorageLocation> StorageLocations { get; set; } = new List<StorageLocation>();

        public int ScannableLabelID { get; set; }
        public required ScannableLabel ScannableLabel { get; set; }
    }
}
