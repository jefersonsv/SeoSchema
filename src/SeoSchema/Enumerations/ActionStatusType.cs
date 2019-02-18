using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	/// The status of an Action.
    /// <see cref="https://schema.org/ActionStatusType"/>
    /// </summary>
    public enum ActionStatusType
    {
        [ItemType("https://schema.org/ActiveActionStatus")]
        ActiveActionStatus,

        [ItemType("https://schema.org/CompletedActionStatus")]
        CompletedActionStatus,

        [ItemType("https://schema.org/FailedActionStatus")]
        FailedActionStatus,

        [ItemType("https://schema.org/PotentialActionStatus")]
        PotentialActionStatus
    }
}
