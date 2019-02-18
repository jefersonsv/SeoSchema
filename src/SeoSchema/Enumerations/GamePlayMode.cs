using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Indicates whether this game is multi-player, co-op or single-player.
    /// <see cref="https://schema.org/GamePlayMode"/>
    /// </summary>
    public enum GamePlayMode
    {
        [ItemType("https://schema.org/CoOp")]
        CoOp,

        [ItemType("https://schema.org/MultiPlayer")]
        MultiPlayer,

        [ItemType("https://schema.org/SinglePlayer")]
        SinglePlayer
    }
}
