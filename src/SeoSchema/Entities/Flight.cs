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
    /// An airline flight.
    /// <see cref="https://schema.org/Flight"/>
    /// </summary>
    public class Flight : IEntity
    {
        /// The kind of aircraft (e.g., "Boeing 747").
        public Or<string, Vehicle>? Aircraft { get; set; }

        /// The airport where the flight terminates.
        public Or<Airport>? ArrivalAirport { get; set; }

        /// Identifier of the flight's arrival gate.
        public Or<string>? ArrivalGate { get; set; }

        /// Identifier of the flight's arrival terminal.
        public Or<string>? ArrivalTerminal { get; set; }

        /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
        public Or<BoardingPolicyType>? BoardingPolicy { get; set; }

        /// The airport where the flight originates.
        public Or<Airport>? DepartureAirport { get; set; }

        /// Identifier of the flight's departure gate.
        public Or<string>? DepartureGate { get; set; }

        /// Identifier of the flight's departure terminal.
        public Or<string>? DepartureTerminal { get; set; }

        /// The estimated time the flight will take.
        public Or<Duration, string>? EstimatedFlightDuration { get; set; }

        /// The distance of the flight.
        public Or<Distance, string>? FlightDistance { get; set; }

        /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
        public Or<string>? FlightNumber { get; set; }

        /// Description of the meals that will be provided or available for purchase.
        public Or<string>? MealService { get; set; }

        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider. Supersedes merchant, vendor.
        public Or<Organization, Person>? Seller { get; set; }

        /// The time when a passenger can check into the flight online.
        public Or<DateTime>? WebCheckinTime { get; set; }

        /// The expected arrival time.
        public Or<DateTime>? ArrivalTime { get; set; }

        /// The expected departure time.
        public Or<DateTime>? DepartureTime { get; set; }

        /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense). Inverse property: isPartOf.
        public Or<CreativeWork, Trip>? HasPart { get; set; }

        /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of. Inverse property: hasPart.
        public Or<CreativeWork, Trip>? IsPartOf { get; set; }

        /// Destination(s) ( Place ) that make up a trip. For a trip where destination order is important use ItemList to specify that order (see examples).
        public Or<ItemList, Place>? Itinerary { get; set; }

        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        public Or<Offer>? Offers { get; set; }

        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        public Or<Organization, Person>? Provider { get; set; }

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
