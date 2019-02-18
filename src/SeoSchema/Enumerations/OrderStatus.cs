using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Enumerated status values for Order.
    /// <see cref="https://schema.org/OrderStatus"/>
    /// </summary>
    public enum OrderStatus
    {
        [ItemType("https://schema.org/OrderCancelled")]
        OrderCancelled,

        [ItemType("https://schema.org/OrderDelivered")]
        OrderDelivered,

        [ItemType("https://schema.org/OrderInTransit")]
        OrderInTransit,

        [ItemType("https://schema.org/OrderPaymentDue")]
        OrderPaymentDue,

        [ItemType("https://schema.org/OrderPickupAvailable")]
        OrderPickupAvailable,

        [ItemType("https://schema.org/OrderProblem")]
        OrderProblem,

        [ItemType("https://schema.org/OrderProcessing")]
        OrderProcessing,

        [ItemType("https://schema.org/OrderReturned")]
        OrderReturned
    }
}
