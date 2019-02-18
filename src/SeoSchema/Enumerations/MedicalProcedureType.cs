using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// An enumeration that describes different types of medical procedures.
    /// <see cref="https://schema.org/MedicalProcedureType"/>
    /// </summary>
    public enum MedicalProcedureType
    {
        [ItemType("https://schema.org/NoninvasiveProcedure")]
        NoninvasiveProcedure,

        [ItemType("https://schema.org/PercutaneousProcedure")]
        PercutaneousProcedure,

        [ItemType("https://schema.org/SurgicalProcedure")]
        SurgicalProcedure
    }
}
