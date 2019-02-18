using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Classes of agents or pathogens that transmit infectious diseases. Enumerated type.
    /// <see cref="https://schema.org/InfectiousAgentClass"/>
    /// </summary>
    public enum InfectiousAgentClass
    {
        [ItemType("https://schema.org/Bacteria")]
        Bacteria,

        [ItemType("https://schema.org/Fungus")]
        Fungus,

        [ItemType("https://schema.org/MulticellularParasite")]
        MulticellularParasite,

        [ItemType("https://schema.org/Prion")]
        Prion,

        [ItemType("https://schema.org/Protozoa")]
        Protozoa,

        [ItemType("https://schema.org/Virus")]
        Virus
    }
}
