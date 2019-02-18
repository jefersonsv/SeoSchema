using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// The publication format of the book.
    /// <see cref="https://schema.org/BookFormatType"/>
    /// </summary>
    public enum BookFormatType
    {
        [ItemType("https://schema.org/AudiobookFormat")]
        AudiobookFormat,

        [ItemType("https://schema.org/EBook")]
        EBook,

        [ItemType("https://schema.org/Hardcover")]
        Hardcover,

        [ItemType("https://schema.org/Paperback")]
        Paperback
    }
}
