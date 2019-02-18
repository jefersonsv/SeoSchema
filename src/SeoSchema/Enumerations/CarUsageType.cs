using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A value indicating a special usage of a car, e.g. commercial rental, driving school, or as a taxi.
    /// <see cref="https://schema.org/CarUsageType"/>
    /// </summary>
    public enum CarUsageType
    {
        [ItemType("https://schema.org/DrivingSchoolVehicleUsage")]
        DrivingSchoolVehicleUsage,

        [ItemType("https://schema.org/RentalVehicleUsage")]
        RentalVehicleUsage,

        [ItemType("https://schema.org/TaxiVehicleUsage")]
        TaxiVehicleUsage
    }
}
