using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A value indicating which roadwheels will receive torque.
    /// <see cref="https://schema.org/DriveWheelConfigurationValue"/>
    /// </summary>
    public enum DriveWheelConfigurationValue
    {
        [ItemType("https://schema.org/AllWheelDriveConfiguration")]
        AllWheelDriveConfiguration,

        [ItemType("https://schema.org/FourWheelDriveConfiguration")]
        FourWheelDriveConfiguration,

        [ItemType("https://schema.org/FrontWheelDriveConfiguration")]
        FrontWheelDriveConfiguration,

        [ItemType("https://schema.org/RearWheelDriveConfiguration")]
        RearWheelDriveConfiguration
    }
}
