namespace MajelMade.Domain.Entities;

public class PhoneType(int phoneTypeID, string typeName)
{
    public int PhoneTypeID { get; set; } = phoneTypeID;
    public string TypeName { get; set; } = typeName;

    public ICollection<CustomerPhone> CustomerPhones { get; set; } = new List<CustomerPhone>();
}
