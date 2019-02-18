using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// <see cref="https://schema.org/EventStatusType"/>
    /// </summary>
    public enum EventStatusType
    {
        [ItemType("https://schema.org/EventCancelled")]
        EventCancelled,

        [ItemType("https://schema.org/EventPostponed")]
        EventPostponed,

        [ItemType("https://schema.org/EventRescheduled")]
        EventRescheduled,

        [ItemType("https://schema.org/EventScheduled")]
        EventScheduled
    }
}
