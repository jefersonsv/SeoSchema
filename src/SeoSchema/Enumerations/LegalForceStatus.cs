using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A list of possible statuses for the legal force of a legislation.
    /// <see cref="https://schema.org/LegalForceStatus"/>
    /// </summary>
    public enum LegalForceStatus
    {
        [ItemType("https://schema.org/InForce")]
        InForce,

        [ItemType("https://schema.org/NotInForce")]
        NotInForce,

        [ItemType("https://schema.org/PartiallyInForce")]
        PartiallyInForce
    }
}
