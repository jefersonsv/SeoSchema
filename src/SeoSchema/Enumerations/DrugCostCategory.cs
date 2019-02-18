using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Enumerated categories of medical drug costs.
    /// <see cref="https://schema.org/DrugCostCategory"/>
    /// </summary>
    public enum DrugCostCategory
    {
        [ItemType("https://schema.org/ReimbursementCap")]
        ReimbursementCap,

        [ItemType("https://schema.org/Retail")]
        Retail,

        [ItemType("https://schema.org/Wholesale")]
        Wholesale
    }
}
