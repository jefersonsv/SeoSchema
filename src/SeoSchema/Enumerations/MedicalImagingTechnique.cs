using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Any medical imaging modality typically used for diagnostic purposes. Enumerated type.
    /// <see cref="https://schema.org/MedicalImagingTechnique"/>
    /// </summary>
    public enum MedicalImagingTechnique
    {
        [ItemType("https://schema.org/CT")]
        CT,

        [ItemType("https://schema.org/MRI")]
        MRI,

        [ItemType("https://schema.org/PET")]
        PET,

        [ItemType("https://schema.org/Radiography")]
        Radiography,

        [ItemType("https://schema.org/Ultrasound")]
        Ultrasound,

        [ItemType("https://schema.org/XRay")]
        XRay
    }
}
