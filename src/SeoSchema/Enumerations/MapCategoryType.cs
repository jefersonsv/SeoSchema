using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// An enumeration of several kinds of Map.
    /// <see cref="https://schema.org/MapCategoryType"/>
    /// </summary>
    public enum MapCategoryType
    {
        [ItemType("https://schema.org/ParkingMap")]
        ParkingMap,

        [ItemType("https://schema.org/SeatingMap")]
        SeatingMap,

        [ItemType("https://schema.org/TransitMap")]
        TransitMap,

        [ItemType("https://schema.org/VenueMap")]
        VenueMap
    }
}
