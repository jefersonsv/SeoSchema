using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Categories of physical activity, organized by physiologic classification.
    /// <see cref="https://schema.org/PhysicalActivityCategory"/>
    /// </summary>
    public enum PhysicalActivityCategory
    {
        [ItemType("https://schema.org/AerobicActivity")]
        AerobicActivity,

        [ItemType("https://schema.org/AnaerobicActivity")]
        AnaerobicActivity,

        [ItemType("https://schema.org/Balance")]
        Balance,

        [ItemType("https://schema.org/Flexibility")]
        Flexibility,

        [ItemType("https://schema.org/LeisureTimeActivity")]
        LeisureTimeActivity,

        [ItemType("https://schema.org/OccupationalActivity")]
        OccupationalActivity,

        [ItemType("https://schema.org/StrengthTraining")]
        StrengthTraining
    }
}
