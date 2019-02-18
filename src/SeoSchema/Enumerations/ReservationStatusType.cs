using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// Enumerated status values for Reservation.
    /// <see cref="https://schema.org/ReservationStatusType"/>
    /// </summary>
    public enum ReservationStatusType
    {
        [ItemType("https://schema.org/ReservationCancelled")]
        ReservationCancelled,

        [ItemType("https://schema.org/ReservationConfirmed")]
        ReservationConfirmed,

        [ItemType("https://schema.org/ReservationHold")]
        ReservationHold,

        [ItemType("https://schema.org/ReservationPending")]
        ReservationPending
    }
}
