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
    /// A group of multiple reservations with common values for all sub-reservations.
    /// <see cref="https://schema.org/ReservationPackage"/>
    /// </summary>
    public class ReservationPackage : IEntity
    {
        /// The individual reservations included in the package. Typically a repeated property.
        public Or<Reservation>? SubReservation { get; set; }

        /// The date and time the reservation was booked.
        public Or<DateTime>? BookingTime { get; set; }

        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. Supersedes bookingAgent.
        public Or<Organization, Person>? Broker { get; set; }

        /// The date and time the reservation was modified.
        public Or<DateTime>? ModifiedTime { get; set; }

        /// The currency of the price, or a price component when attached to PriceSpecification and its subtypes.
        /// 
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR".
        public Or<string>? PriceCurrency { get; set; }

        /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
        public Or<ProgramMembership>? ProgramMembershipUsed { get; set; }

        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        public Or<Organization, Person>? Provider { get; set; }

        /// The thing -- flight, event, restaurant,etc. being reserved.
        public Or<Thing>? ReservationFor { get; set; }

        /// A unique identifier for the reservation.
        public Or<string>? ReservationId { get; set; }

        /// The current status of the reservation.
        public Or<ReservationStatusType>? ReservationStatus { get; set; }

        /// A ticket associated with the reservation.
        public Or<Ticket>? ReservedTicket { get; set; }

        /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.
        public Or<double, PriceSpecification, string>? TotalPrice { get; set; }

        /// The person or organization the reservation or ticket is for.
        public Or<Organization, Person>? UnderName { get; set; }

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
