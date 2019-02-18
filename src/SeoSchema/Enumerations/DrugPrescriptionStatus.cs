using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Indicates whether this drug is available by prescription or over-the-counter.
    /// <see cref="https://schema.org/DrugPrescriptionStatus"/>
    /// </summary>
    public enum DrugPrescriptionStatus
    {
        [ItemType("https://schema.org/OTC")]
        OTC,

        [ItemType("https://schema.org/PrescriptionOnly")]
        PrescriptionOnly
    }
}
