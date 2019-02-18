using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// <see cref="https://schema.org/ItemListOrderType"/>
    /// </summary>
    public enum ItemListOrderType
    {
        [ItemType("https://schema.org/ItemListOrderAscending")]
        ItemListOrderAscending,

        [ItemType("https://schema.org/ItemListOrderDescending")]
        ItemListOrderDescending,

        [ItemType("https://schema.org/ItemListUnordered")]
        ItemListUnordered
    }
}
