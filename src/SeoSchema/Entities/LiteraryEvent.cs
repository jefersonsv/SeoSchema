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
    /// Event type: Literary event.
    /// <see cref="https://schema.org/LiteraryEvent"/>
    /// </summary>
    public class LiteraryEvent : IEntity
    {
        /// The subject matter of the content. Inverse property: subjectOf.
        public Or<Thing>? About { get; set; }

        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip. Supersedes actors.
        public Or<Person>? Actor { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// A person or organization attending the event. Supersedes attendees.
        public Or<Organization, Person>? Attendee { get; set; }

        /// An intended audience, i.e. a group for whom something was created. Supersedes serviceAudience.
        public Or<Audience>? Audience { get; set; }

        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        public Or<Organization, Person>? Composer { get; set; }

        /// A secondary contributor to the CreativeWork or Event.
        public Or<Organization, Person>? Contributor { get; set; }

        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip. Supersedes directors.
        public Or<Person>? Director { get; set; }

        /// The time admission will commence.
        public Or<DateTime>? DoorTime { get; set; }

        /// The duration of the item (movie, audio recording, event, etc.) in ISO 8601 date format.
        public Or<Duration>? Duration { get; set; }

        /// The end date and time of the item (in ISO 8601 date format).
        public Or<SuperStructs.Date, DateTime>? EndDate { get; set; }

        /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
        public Or<EventStatusType>? EventStatus { get; set; }

        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        public Or<Organization, Person>? Funder { get; set; }

        /// The language of the content or performance or used in an action. Please use one of the language codes from the IETF BCP 47 standard. See also availableLanguage. Supersedes language.
        public Or<Language, string>? InLanguage { get; set; }

        /// A flag to signal that the item, event, or place is accessible for free. Supersedes free.
        public Or<bool>? IsAccessibleForFree { get; set; }

        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        public Or<Place, PostalAddress, string>? Location { get; set; }

        /// The total number of individuals that may attend an event or venue.
        public Or<int>? MaximumAttendeeCapacity { get; set; }

        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        public Or<Offer>? Offers { get; set; }

        /// An organizer of an Event.
        public Or<Organization, Person>? Organizer { get; set; }

        /// A performer at the event—for example, a presenter, musician, musical group or actor. Supersedes performers.
        public Or<Organization, Person>? Performer { get; set; }

        /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
        public Or<SuperStructs.Date>? PreviousStartDate { get; set; }

        /// The CreativeWork that captured all or part of this Event. Inverse property: recordedAt.
        public Or<CreativeWork>? RecordedIn { get; set; }

        /// The number of attendee places for an event that remain unallocated.
        public Or<int>? RemainingAttendeeCapacity { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        public Or<Organization, Person>? Sponsor { get; set; }

        /// The start date and time of the item (in ISO 8601 date format).
        public Or<SuperStructs.Date, DateTime>? StartDate { get; set; }

        /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference. Supersedes subEvents. Inverse property: superEvent.
        public Or<Event>? SubEvent { get; set; }

        /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent. Inverse property: subEvent.
        public Or<Event>? SuperEvent { get; set; }

        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        public Or<Organization, Person>? Translator { get; set; }

        /// The typical expected age range, e.g. '7-9', '11-'.
        public Or<string>? TypicalAgeRange { get; set; }

        /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
        ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
        public Or<CreativeWork>? WorkFeatured { get; set; }

        /// A work performed in some event, for example a play performed in a TheaterEvent.
        public Or<CreativeWork>? WorkPerformed { get; set; }

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
