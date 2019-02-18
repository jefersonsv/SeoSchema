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
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.
    /// 
    /// For GTIN-related fields, see Check Digit calculator and validation guide from GS1.
    /// <see cref="https://schema.org/Offer"/>
    /// </summary>
    public class Offer : IEntity
    {
        /// The payment method(s) accepted by seller for this offer.
        public Or<LoanOrCredit, PaymentMethod>? AcceptedPaymentMethod { get; set; }

        /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
        public Or<Offer>? AddOn { get; set; }

        /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
        public Or<QuantitativeValue>? AdvanceBookingRequirement { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// The geographic area where a service or offered item is provided. Supersedes serviceArea.
        public Or<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// The availability of this item—for example In stock, Out of stock, Pre-order, etc.
        public Or<ItemAvailability>? Availability { get; set; }

        /// The end of the availability of the product or service included in the offer.
        public Or<DateTime>? AvailabilityEnds { get; set; }

        /// The beginning of the availability of the product or service included in the offer.
        public Or<DateTime>? AvailabilityStarts { get; set; }

        /// The place(s) from which the offer can be obtained (e.g. store locations).
        public Or<Place>? AvailableAtOrFrom { get; set; }

        /// The delivery method(s) available for this offer.
        public Or<DeliveryMethod>? AvailableDeliveryMethod { get; set; }

        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        public Or<BusinessFunction>? BusinessFunction { get; set; }

        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        public Or<PhysicalActivityCategory, string, Thing>? Category { get; set; }

        /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
        public Or<QuantitativeValue>? DeliveryLeadTime { get; set; }

        /// The type(s) of customers for which the given offer is valid.
        public Or<BusinessEntityType>? EligibleCustomerType { get; set; }

        /// The duration for which the given offer is valid.
        public Or<QuantitativeValue>? EligibleDuration { get; set; }

        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        public Or<QuantitativeValue>? EligibleQuantity { get; set; }

        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.
        /// 
        /// See also ineligibleRegion.
        public Or<GeoShape, Place, string>? EligibleRegion { get; set; }

        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        public Or<PriceSpecification>? EligibleTransactionVolume { get; set; }

        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin12 { get; set; }

        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin13 { get; set; }

        /// The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin14 { get; set; }

        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin8 { get; set; }

        /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
        public Or<TypeAndQuantityNode>? IncludesObject { get; set; }

        /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.
        /// 
        /// See also eligibleRegion.
        public Or<GeoShape, Place, string>? IneligibleRegion { get; set; }

        /// The current approximate inventory level for the item or items.
        public Or<QuantitativeValue>? InventoryLevel { get; set; }

        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        public Or<OfferItemCondition>? ItemCondition { get; set; }

        /// The item being offered.
        public Or<Product, Service>? ItemOffered { get; set; }

        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        public Or<string>? Mpn { get; set; }

        /// A pointer to the organization or person making the offer. Inverse property: makesOffer.
        public Or<Organization, Person>? OfferedBy { get; set; }

        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.
        /// 
        /// Usage guidelines:
        /// 
        /// 
        /// Use the priceCurrency property (with standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR") instead of including ambiguous symbols such as '$' in the value.
        /// Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
        /// Note that both RDFa and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.
        /// Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.
        public Or<double, string>? Price { get; set; }

        /// The currency of the price, or a price component when attached to PriceSpecification and its subtypes.
        /// 
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR".
        public Or<string>? PriceCurrency { get; set; }

        /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
        public Or<PriceSpecification>? PriceSpecification { get; set; }

        /// The date after which the price is no longer available.
        [Format("yyyy-MM-dd")]
        public Or<DateTime>? PriceValidUntil { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider. Supersedes merchant, vendor.
        public Or<Organization, Person>? Seller { get; set; }

        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        public Or<string>? SerialNumber { get; set; }

        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        public Or<string>? Sku { get; set; }

        /// The date when the item becomes valid.
        public Or<DateTime>? ValidFrom { get; set; }

        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        public Or<DateTime>? ValidThrough { get; set; }

        /// The warranty promise(s) included in the offer. Supersedes warrantyPromise.
        public Or<WarrantyPromise>? Warranty { get; set; }

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
