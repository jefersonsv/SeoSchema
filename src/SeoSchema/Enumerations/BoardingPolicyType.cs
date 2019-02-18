using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A type of boarding policy used by an airline.
    /// <see cref="https://schema.org/BoardingPolicyType"/>
    /// </summary>
    public enum BoardingPolicyType
    {
        [ItemType("https://schema.org/GroupBoardingPolicy")]
        GroupBoardingPolicy,

        [ItemType("https://schema.org/ZoneBoardingPolicy")]
        ZoneBoardingPolicy
    }
}
