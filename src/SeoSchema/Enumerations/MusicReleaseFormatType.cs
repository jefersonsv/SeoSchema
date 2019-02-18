using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    /// <see cref="https://schema.org/MusicReleaseFormatType"/>
    /// </summary>
    public enum MusicReleaseFormatType
    {
        [ItemType("https://schema.org/CDFormat")]
        CDFormat,

        [ItemType("https://schema.org/CassetteFormat")]
        CassetteFormat,

        [ItemType("https://schema.org/DVDFormat")]
        DVDFormat,

        [ItemType("https://schema.org/DigitalAudioTapeFormat")]
        DigitalAudioTapeFormat,

        [ItemType("https://schema.org/DigitalFormat")]
        DigitalFormat,

        [ItemType("https://schema.org/LaserDiscFormat")]
        LaserDiscFormat,

        [ItemType("https://schema.org/VinylFormat")]
        VinylFormat
    }
}
