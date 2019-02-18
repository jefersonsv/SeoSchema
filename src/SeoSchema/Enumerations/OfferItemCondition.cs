using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A list of possible conditions for the item.
    /// <see cref="https://schema.org/OfferItemCondition"/>
    /// </summary>
    public enum OfferItemCondition
    {
        [ItemType("https://schema.org/DamagedCondition")]
        DamagedCondition,

        [ItemType("https://schema.org/NewCondition")]
        NewCondition,

        [ItemType("https://schema.org/RefurbishedCondition")]
        RefurbishedCondition,

        [ItemType("https://schema.org/UsedCondition")]
        UsedCondition
    }
}
