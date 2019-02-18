using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A type of physical examination of a patient performed by a physician.
    /// <see cref="https://schema.org/PhysicalExam"/>
    /// </summary>
    public enum PhysicalExam
    {
        [ItemType("https://schema.org/Abdomen")]
        Abdomen,

        [ItemType("https://schema.org/Appearance")]
        Appearance,

        [ItemType("https://schema.org/CardiovascularExam")]
        CardiovascularExam,

        [ItemType("https://schema.org/Ear")]
        Ear,

        [ItemType("https://schema.org/Eye")]
        Eye,

        [ItemType("https://schema.org/Genitourinary")]
        Genitourinary,

        [ItemType("https://schema.org/Head")]
        Head,

        [ItemType("https://schema.org/Lung")]
        Lung,

        [ItemType("https://schema.org/MusculoskeletalExam")]
        MusculoskeletalExam,

        [ItemType("https://schema.org/Neck")]
        Neck,

        [ItemType("https://schema.org/Neuro")]
        Neuro,

        [ItemType("https://schema.org/Nose")]
        Nose,

        [ItemType("https://schema.org/Skin")]
        Skin,

        [ItemType("https://schema.org/Throat")]
        Throat
    }
}
