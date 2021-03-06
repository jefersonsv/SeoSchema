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
    /// A trip on a commercial bus line.
    /// <see cref="https://schema.org/BusTrip"/>
    /// </summary>
    public class BusTrip : IEntity
    {
        /// The stop or station from which the bus arrives.
        public Or<BusStation, BusStop>? ArrivalBusStop { get; set; }

        /// The name of the bus (e.g. Bolt Express).
        public Or<string>? BusName { get; set; }

        /// The unique identifier for the bus.
        public Or<string>? BusNumber { get; set; }

        /// The stop or station from which the bus departs.
        public Or<BusStation, BusStop>? DepartureBusStop { get; set; }

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
