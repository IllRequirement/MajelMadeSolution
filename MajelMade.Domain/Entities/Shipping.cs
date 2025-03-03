using System;

namespace MajelMade.Domain.Entities
{
    public class Shipping
    {
        public int ShippingID { get; set; }
        public int OrderID { get; set; }
        public int ShippingMethodTypeID { get; set; }
        public required string TrackingNumber { get; set; }
        public DateTime? ShippingDate { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public decimal ShippingCost { get; set; }
        public int StatusTypeID { get; set; }

        public required Order Order { get; set; }
        public required ShippingMethodType ShippingMethodType { get; set; }
        public required StatusType StatusType { get; set; }
    }
}
