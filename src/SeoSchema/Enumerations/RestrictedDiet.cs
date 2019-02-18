using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// <see cref="https://schema.org/RestrictedDiet"/>
    /// </summary>
    public enum RestrictedDiet
    {
        [ItemType("https://schema.org/DiabeticDiet")]
        DiabeticDiet,

        [ItemType("https://schema.org/GlutenFreeDiet")]
        GlutenFreeDiet,

        [ItemType("https://schema.org/HalalDiet")]
        HalalDiet,

        [ItemType("https://schema.org/HinduDiet")]
        HinduDiet,

        [ItemType("https://schema.org/KosherDiet")]
        KosherDiet,

        [ItemType("https://schema.org/LowCalorieDiet")]
        LowCalorieDiet,

        [ItemType("https://schema.org/LowFatDiet")]
        LowFatDiet,

        [ItemType("https://schema.org/LowLactoseDiet")]
        LowLactoseDiet,

        [ItemType("https://schema.org/LowSaltDiet")]
        LowSaltDiet,

        [ItemType("https://schema.org/VeganDiet")]
        VeganDiet,

        [ItemType("https://schema.org/VegetarianDiet")]
        VegetarianDiet
    }
}
