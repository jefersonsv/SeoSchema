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
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// <see cref="https://schema.org/ParcelDelivery"/>
    /// </summary>
    public class ParcelDelivery : IEntity
    {
        /// Destination address.
        public Or<PostalAddress>? DeliveryAddress { get; set; }

        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        public Or<DeliveryEvent>? DeliveryStatus { get; set; }

        /// The earliest date the package may arrive.
        public Or<DateTime>? ExpectedArrivalFrom { get; set; }

        /// The latest date the package may arrive.
        public Or<DateTime>? ExpectedArrivalUntil { get; set; }

        /// Method used for delivery or shipping.
        public Or<DeliveryMethod>? HasDeliveryMethod { get; set; }

        /// Item(s) being shipped.
        public Or<Product>? ItemShipped { get; set; }

        /// Shipper's address.
        public Or<PostalAddress>? OriginAddress { get; set; }

        /// The overall order the items in this delivery were included in.
        public Or<Order>? PartOfOrder { get; set; }

        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        public Or<Organization, Person>? Provider { get; set; }

        /// Shipper tracking number.
        public Or<string>? TrackingNumber { get; set; }

        /// Tracking url for the parcel delivery.
        public Or<Uri>? TrackingUrl { get; set; }

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
