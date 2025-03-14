namespace MajelMade.Domain.Entities
{
    public class AddressType(int addressTypeID, string typeName)
    {
        public int AddressTypeID { get; set; } = addressTypeID;
        public string TypeName { get; set; } = typeName;
        private AddressType() : this(0, string.Empty) { }
    }
}
