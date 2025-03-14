namespace MajelMade.Domain.Entities;

public class ShippingMethodType(int shippingMethodTypeID, string methodName)
{
    public int ShippingMethodTypeID { get; init; } = shippingMethodTypeID;
    public string MethodName { get; init; } = methodName;
}
