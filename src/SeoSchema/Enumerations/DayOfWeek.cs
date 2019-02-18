using System;
using System.Collections.Generic;
using System.Text;

namespace SeoSchema.Enumerations
{
	/// <summary>
	///     /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.
    /// 
    /// Originally, URLs from GoodRelations were used (for Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday plus a special entry for PublicHolidays); these have now been integrated directly into schema.org.
    /// <see cref="https://schema.org/DayOfWeek_"/>
    /// </summary>
    public enum DayOfWeek
    {
        [ItemType("https://schema.org/Friday")]
        Friday,

        [ItemType("https://schema.org/Monday")]
        Monday,

        [ItemType("https://schema.org/PublicHolidays")]
        PublicHolidays,

        [ItemType("https://schema.org/Saturday")]
        Saturday,

        [ItemType("https://schema.org/Sunday")]
        Sunday,

        [ItemType("https://schema.org/Thursday")]
        Thursday,

        [ItemType("https://schema.org/Tuesday")]
        Tuesday,

        [ItemType("https://schema.org/Wednesday")]
        Wednesday
    }
}
