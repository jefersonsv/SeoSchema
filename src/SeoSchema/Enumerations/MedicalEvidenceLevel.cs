using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Level of evidence for a medical guideline. Enumerated type.
    /// <see cref="https://schema.org/MedicalEvidenceLevel"/>
    /// </summary>
    public enum MedicalEvidenceLevel
    {
        [ItemType("https://schema.org/EvidenceLevelA")]
        EvidenceLevelA,

        [ItemType("https://schema.org/EvidenceLevelB")]
        EvidenceLevelB,

        [ItemType("https://schema.org/EvidenceLevelC")]
        EvidenceLevelC
    }
}
