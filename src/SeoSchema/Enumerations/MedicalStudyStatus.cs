using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// The status of a medical study. Enumerated type.
    /// <see cref="https://schema.org/MedicalStudyStatus"/>
    /// </summary>
    public enum MedicalStudyStatus
    {
        [ItemType("https://schema.org/ActiveNotRecruiting")]
        ActiveNotRecruiting,

        [ItemType("https://schema.org/Completed")]
        Completed,

        [ItemType("https://schema.org/EnrollingByInvitation")]
        EnrollingByInvitation,

        [ItemType("https://schema.org/NotYetRecruiting")]
        NotYetRecruiting,

        [ItemType("https://schema.org/Recruiting")]
        Recruiting,

        [ItemType("https://schema.org/ResultsAvailable")]
        ResultsAvailable,

        [ItemType("https://schema.org/ResultsNotAvailable")]
        ResultsNotAvailable,

        [ItemType("https://schema.org/Suspended")]
        Suspended,

        [ItemType("https://schema.org/Terminated")]
        Terminated,

        [ItemType("https://schema.org/Withdrawn")]
        Withdrawn
    }
}
