namespace MajelMade.Domain.Entities
{
    public class OrderType(int orderTypeID, string typeName)
    {
        public int OrderTypeID { get; set; } = orderTypeID;
        public string TypeName { get; set; } = typeName;
    }
}
