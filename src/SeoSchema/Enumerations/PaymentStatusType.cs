using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// <see cref="https://schema.org/PaymentStatusType"/>
    /// </summary>
    public enum PaymentStatusType
    {
        [ItemType("https://schema.org/PaymentAutomaticallyApplied")]
        PaymentAutomaticallyApplied,

        [ItemType("https://schema.org/PaymentComplete")]
        PaymentComplete,

        [ItemType("https://schema.org/PaymentDeclined")]
        PaymentDeclined,

        [ItemType("https://schema.org/PaymentDue")]
        PaymentDue,

        [ItemType("https://schema.org/PaymentPastDue")]
        PaymentPastDue
    }
}
