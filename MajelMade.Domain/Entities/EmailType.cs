namespace MajelMade.Domain.Entities
{
    public class EmailType(int emailTypeID, string typeName)
    {
        public int EmailTypeID { get; set; } = emailTypeID;
        public string TypeName { get; set; } = typeName;
        private EmailType() : this(0, string.Empty) { }
    }
}