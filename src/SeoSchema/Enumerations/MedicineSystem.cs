using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Systems of medical practice.
    /// <see cref="https://schema.org/MedicineSystem"/>
    /// </summary>
    public enum MedicineSystem
    {
        [ItemType("https://schema.org/Ayurvedic")]
        Ayurvedic,

        [ItemType("https://schema.org/Chiropractic")]
        Chiropractic,

        [ItemType("https://schema.org/Homeopathic")]
        Homeopathic,

        [ItemType("https://schema.org/Osteopathic")]
        Osteopathic,

        [ItemType("https://schema.org/TraditionalChinese")]
        TraditionalChinese,

        [ItemType("https://schema.org/WesternConventional")]
        WesternConventional
    }
}
