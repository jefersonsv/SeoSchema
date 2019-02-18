using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A value indicating a steering position.
    /// <see cref="https://schema.org/SteeringPositionValue"/>
    /// </summary>
    public enum SteeringPositionValue
    {
        [ItemType("https://schema.org/LeftHandDriving")]
        LeftHandDriving,

        [ItemType("https://schema.org/RightHandDriving")]
        RightHandDriving
    }
}
