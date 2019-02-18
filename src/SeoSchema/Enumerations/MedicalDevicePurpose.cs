using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Categories of medical devices, organized by the purpose or intended use of the device.
    /// <see cref="https://schema.org/MedicalDevicePurpose"/>
    /// </summary>
    public enum MedicalDevicePurpose
    {
        [ItemType("https://schema.org/Diagnostic")]
        Diagnostic,

        [ItemType("https://schema.org/Therapeutic")]
        Therapeutic
    }
}
