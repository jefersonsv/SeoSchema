using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A list of possible product availability options.
    /// <see cref="https://schema.org/ItemAvailability"/>
    /// </summary>
    public enum ItemAvailability
    {
        [ItemType("https://schema.org/Discontinued")]
        Discontinued,

        [ItemType("https://schema.org/InStock")]
        InStock,

        [ItemType("https://schema.org/InStoreOnly")]
        InStoreOnly,

        [ItemType("https://schema.org/LimitedAvailability")]
        LimitedAvailability,

        [ItemType("https://schema.org/OnlineOnly")]
        OnlineOnly,

        [ItemType("https://schema.org/OutOfStock")]
        OutOfStock,

        [ItemType("https://schema.org/PreOrder")]
        PreOrder,

        [ItemType("https://schema.org/PreSale")]
        PreSale,

        [ItemType("https://schema.org/SoldOut")]
        SoldOut
    }
}
