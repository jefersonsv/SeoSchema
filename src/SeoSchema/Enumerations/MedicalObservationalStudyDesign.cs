using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Design models for observational medical studies. Enumerated type.
    /// <see cref="https://schema.org/MedicalObservationalStudyDesign"/>
    /// </summary>
    public enum MedicalObservationalStudyDesign
    {
        [ItemType("https://schema.org/CaseSeries")]
        CaseSeries,

        [ItemType("https://schema.org/CohortStudy")]
        CohortStudy,

        [ItemType("https://schema.org/CrossSectional")]
        CrossSectional,

        [ItemType("https://schema.org/Longitudinal")]
        Longitudinal,

        [ItemType("https://schema.org/Observational")]
        Observational,

        [ItemType("https://schema.org/Registry")]
        Registry
    }
}
