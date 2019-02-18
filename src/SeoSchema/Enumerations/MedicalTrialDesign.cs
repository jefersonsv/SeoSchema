using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Design models for medical trials. Enumerated type.
    /// <see cref="https://schema.org/MedicalTrialDesign"/>
    /// </summary>
    public enum MedicalTrialDesign
    {
        [ItemType("https://schema.org/DoubleBlindedTrial")]
        DoubleBlindedTrial,

        [ItemType("https://schema.org/InternationalTrial")]
        InternationalTrial,

        [ItemType("https://schema.org/MultiCenterTrial")]
        MultiCenterTrial,

        [ItemType("https://schema.org/OpenTrial")]
        OpenTrial,

        [ItemType("https://schema.org/PlaceboControlledTrial")]
        PlaceboControlledTrial,

        [ItemType("https://schema.org/RandomizedTrial")]
        RandomizedTrial,

        [ItemType("https://schema.org/SingleBlindedTrial")]
        SingleBlindedTrial,

        [ItemType("https://schema.org/SingleCenterTrial")]
        SingleCenterTrial,

        [ItemType("https://schema.org/TripleBlindedTrial")]
        TripleBlindedTrial
    }
}
