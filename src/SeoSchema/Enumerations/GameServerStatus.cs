using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Status of a game server.
    /// <see cref="https://schema.org/GameServerStatus"/>
    /// </summary>
    public enum GameServerStatus
    {
        [ItemType("https://schema.org/OfflinePermanently")]
        OfflinePermanently,

        [ItemType("https://schema.org/OfflineTemporarily")]
        OfflineTemporarily,

        [ItemType("https://schema.org/Online")]
        Online,

        [ItemType("https://schema.org/OnlineFull")]
        OnlineFull
    }
}
