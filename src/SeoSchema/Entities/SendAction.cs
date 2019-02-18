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
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:
    /// 
    /// 
    /// ReceiveAction: The reciprocal of SendAction.
    /// GiveAction: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).
    /// <see cref="https://schema.org/SendAction"/>
    /// </summary>
    public class SendAction : IEntity
    {
        /// A sub property of instrument. The method of delivery.
        public Or<DeliveryMethod>? DeliveryMethod { get; set; }

        /// A sub property of participant. The participant who is at the receiving end of the action.
        public Or<Audience, ContactPoint, Organization, Person>? Recipient { get; set; }

        /// A sub property of location. The original location of the object or the agent before the action.
        public Or<Place>? FromLocation { get; set; }

        /// A sub property of location. The final location of the object or the agent after the action.
        public Or<Place>? ToLocation { get; set; }

        /// Indicates the current disposition of the Action.
        public Or<ActionStatusType>? ActionStatus { get; set; }

        /// The direct performer or driver of the action (animate or inanimate). e.g. John wrote a book.
        public Or<Organization, Person>? Agent { get; set; }

        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to December.
        /// 
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        public Or<DateTime>? EndTime { get; set; }

        /// For failed actions, more information on the cause of the failure.
        public Or<Thing>? Error { get; set; }

        /// The object that helped the agent perform the action. e.g. John wrote a book with a pen.
        public Or<Thing>? Instrument { get; set; }

        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        public Or<Place, PostalAddress, string>? Location { get; set; }

        /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read a book.
        public Or<Thing>? Object { get; set; }

        /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with Steve.
        public Or<Organization, Person>? Participant { get; set; }

        /// The result produced in the action. e.g. John wrote a book.
        public Or<Thing>? Result { get; set; }

        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to December.
        /// 
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        public Or<DateTime>? StartTime { get; set; }

        /// Indicates a target EntryPoint for an Action.
        public Or<EntryPoint>? Target { get; set; }

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
