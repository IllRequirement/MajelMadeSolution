namespace MajelMade.Domain.Entities;

public class Shipping(int shippingID, int orderID, int shippingMethodTypeID, string trackingNumber, DateTime? shippingDate, DateTime? expectedDeliveryDate, decimal shippingCost, int statusTypeID, Order order, ShippingMethodType shippingMethodType, StatusType statusType)
{
    public int ShippingID { get; init; } = shippingID;
    public int OrderID { get; init; } = orderID;
    public int ShippingMethodTypeID { get; init; } = shippingMethodTypeID;
    public string TrackingNumber { get; init; } = trackingNumber;
    public DateTime? ShippingDate { get; set; } = shippingDate;
    public DateTime? ExpectedDeliveryDate { get; set; } = expectedDeliveryDate;
    public decimal ShippingCost { get; set; } = shippingCost;
    public int StatusTypeID { get; init; } = statusTypeID;

    public Order Order { get; init; } = order;
    public ShippingMethodType ShippingMethodType { get; init; } = shippingMethodType;
    public StatusType StatusType { get; init; } = statusType;
}
