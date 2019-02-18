using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// <see cref="https://schema.org/RsvpResponseType"/>
    /// </summary>
    public enum RsvpResponseType
    {
        [ItemType("https://schema.org/RsvpResponseMaybe")]
        RsvpResponseMaybe,

        [ItemType("https://schema.org/RsvpResponseNo")]
        RsvpResponseNo,

        [ItemType("https://schema.org/RsvpResponseYes")]
        RsvpResponseYes
    }
}
