using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A list of possible levels for the legal validity of a legislation.
    /// <see cref="https://schema.org/LegalValueLevel"/>
    /// </summary>
    public enum LegalValueLevel
    {
        [ItemType("https://schema.org/AuthoritativeLegalValue")]
        AuthoritativeLegalValue,

        [ItemType("https://schema.org/DefinitiveLegalValue")]
        DefinitiveLegalValue,

        [ItemType("https://schema.org/OfficialLegalValue")]
        OfficialLegalValue,

        [ItemType("https://schema.org/UnofficialLegalValue")]
        UnofficialLegalValue
    }
}
