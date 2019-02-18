using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// A type of permission which can be granted for accessing a digital document.
    /// <see cref="https://schema.org/DigitalDocumentPermissionType"/>
    /// </summary>
    public enum DigitalDocumentPermissionType
    {
        [ItemType("https://schema.org/CommentPermission")]
        CommentPermission,

        [ItemType("https://schema.org/ReadPermission")]
        ReadPermission,

        [ItemType("https://schema.org/WritePermission")]
        WritePermission
    }
}
