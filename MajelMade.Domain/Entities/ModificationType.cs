namespace MajelMade.Domain.Entities
{
    public class ModificationType(int modificationTypeID, string modificationName)
    {
        public int ModificationTypeID { get; set; } = modificationTypeID;
        public string ModificationName { get; set; } = modificationName;
    }
}
