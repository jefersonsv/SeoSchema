using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Enumerated options related to a ContactPoint.
    /// <see cref="https://schema.org/ContactPointOption"/>
    /// </summary>
    public enum ContactPointOption
    {
        [ItemType("https://schema.org/HearingImpairedSupported")]
        HearingImpairedSupported,

        [ItemType("https://schema.org/TollFree")]
        TollFree
    }
}
