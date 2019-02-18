using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// No comment
    /// <see cref="https://schema.org/MusicAlbumProductionType"/>
    /// </summary>
    public enum MusicAlbumProductionType
    {
        [ItemType("https://schema.org/CompilationAlbum")]
        CompilationAlbum,

        [ItemType("https://schema.org/DJMixAlbum")]
        DJMixAlbum,

        [ItemType("https://schema.org/DemoAlbum")]
        DemoAlbum,

        [ItemType("https://schema.org/LiveAlbum")]
        LiveAlbum,

        [ItemType("https://schema.org/MixtapeAlbum")]
        MixtapeAlbum,

        [ItemType("https://schema.org/RemixAlbum")]
        RemixAlbum,

        [ItemType("https://schema.org/SoundtrackAlbum")]
        SoundtrackAlbum,

        [ItemType("https://schema.org/SpokenWordAlbum")]
        SpokenWordAlbum,

        [ItemType("https://schema.org/StudioAlbum")]
        StudioAlbum
    }
}
