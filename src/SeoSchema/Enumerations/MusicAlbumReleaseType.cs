using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// The kind of release which this album is: single, EP or album.
    /// <see cref="https://schema.org/MusicAlbumReleaseType"/>
    /// </summary>
    public enum MusicAlbumReleaseType
    {
        [ItemType("https://schema.org/AlbumRelease")]
        AlbumRelease,

        [ItemType("https://schema.org/BroadcastRelease")]
        BroadcastRelease,

        [ItemType("https://schema.org/EPRelease")]
        EPRelease,

        [ItemType("https://schema.org/SingleRelease")]
        SingleRelease
    }
}
