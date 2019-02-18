using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SeoSchema;
using SeoSchema.Enumerations;
using SuperStructs;

namespace SeoSchema.Entities
{
    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring Event. At a minimum a schedule will specify repeatFrequency which describes the interval between occurences of the event. Additional information can be provided to specify the schedule more precisely. 
    ///       This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    ///       have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// <see cref="https://schema.org/Schedule"/>
    /// </summary>
    public class Schedule : IEntity
    {
        /// Defines the day(s) of the week on which a recurring Event takes place
        public Or<Enumerations.DayOfWeek>? ByDay { get; set; }

        /// Defines the month(s) of the year on which a recurring Event takes place. Specified as an Integer between 1-12. January is 1.
        public Or<int>? ByMonth { get; set; }

        /// Defines the day(s) of the month on which a recurring Event takes place. Specified as an Integer between 1-31.
        public Or<int>? ByMonthDay { get; set; }

        /// Associates an Event with a Schedule. There are circumstances where it is preferable to share a schedule for a series of
        ///       repeating events rather than data on the individual events themselves. For example, a website or application might prefer to publish a schedule for a weekly
        ///       gym class rather than provide data on every event. A schedule could be processed by applications to add forthcoming events to a calendar. An Event that
        ///       is associated with a Schedule using this property should not have startDate or endDate properties. These are instead defined within the associated
        ///       Schedule, this avoids any ambiguity for clients using the data. The propery might have repeated values to specify different schedules, e.g. for different months
        ///       or seasons.
        public Or<Duration>? EventSchedule { get; set; }

        /// Defines a Date or DateTime during which a scheduled Event will not take place. The property allows exceptions to
        ///       a Schedule to be specified. If an exception is specified as a DateTime then only the event that would have started at that specific date and time
        ///       should be excluded from the schedule. If an exception is specified as a Date then any event that is scheduled for that 24 hour period should be
        ///       excluded from the schedule. This allows a whole day to be excluded from the schedule without having to itemise every scheduled event.
        public Or<SuperStructs.Date, DateTime>? ExceptDate { get; set; }

        /// Defines the number of times a recurring Event will take place
        public Or<int>? RepeatCount { get; set; }

        /// Defines the frequency at which Events will occur according to a schedule Schedule. The intervals between
        ///       events should be defined as a Duration of time.
        public Or<Duration, string>? RepeatFrequency { get; set; }

        /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
        public Or<Uri>? AdditionalType { get; set; }

        /// An alias for the item.
        public Or<string>? AlternateName { get; set; }

        /// A description of the item.
        public Or<string>? Description { get; set; }

        /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
        public Or<string>? DisambiguatingDescription { get; set; }

        /// The identifier property represents any kind of identifier for any kind of Thing, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See background notes for more details.
        public Or<PropertyValue, string, Uri>? Identifier { get; set; }

        /// An image of the item. This can be a URL or a fully described ImageObject.
        public Or<ImageObject, Uri>? Image { get; set; }

        /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See background notes for details. Inverse property: mainEntity.
        public Or<CreativeWork, Uri>? MainEntityOfPage { get; set; }

        /// The name of the item.
        public Or<string>? Name { get; set; }

        /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
        public Or<Action>? PotentialAction { get; set; }

        /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
        public Or<Uri>? SameAs { get; set; }

        /// A CreativeWork or Event about this Thing.. Inverse property: about.
        public Or<CreativeWork, Event>? SubjectOf { get; set; }

        /// URL of the item.
        public Or<Uri>? Url { get; set; }
    }
}
