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
    /// A placeholder for multiple similar products of the same kind.
    /// <see cref="https://schema.org/SomeProducts"/>
    /// </summary>
    public class SomeProducts : IEntity
    {
        /// The current approximate inventory level for the item or items.
        public Or<QuantitativeValue>? InventoryLevel { get; set; }

        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.
        /// 
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        public Or<PropertyValue>? AdditionalProperty { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// An intended audience, i.e. a group for whom something was created. Supersedes serviceAudience.
        public Or<Audience>? Audience { get; set; }

        /// An award won by or for this item. Supersedes awards.
        public Or<string>? Award { get; set; }

        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        public Or<Brand, Organization>? Brand { get; set; }

        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        public Or<PhysicalActivityCategory, string, Thing>? Category { get; set; }

        /// The color of the product.
        public Or<string>? Color { get; set; }

        /// The depth of the item.
        public Or<Distance, QuantitativeValue>? Depth { get; set; }

        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin12 { get; set; }

        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin13 { get; set; }

        /// The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin14 { get; set; }

        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin8 { get; set; }

        /// The height of the item.
        public Or<Distance, QuantitativeValue>? Height { get; set; }

        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        public Or<Product>? IsAccessoryOrSparePartFor { get; set; }

        /// A pointer to another product (or multiple products) for which this product is a consumable.
        public Or<Product>? IsConsumableFor { get; set; }

        /// A pointer to another, somehow related product (or multiple products).
        public Or<Product, Service>? IsRelatedTo { get; set; }

        /// A pointer to another, functionally similar product (or multiple products).
        public Or<Product, Service>? IsSimilarTo { get; set; }

        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        public Or<OfferItemCondition>? ItemCondition { get; set; }

        /// An associated logo.
        public Or<ImageObject, Uri>? Logo { get; set; }

        /// The manufacturer of the product.
        public Or<Organization>? Manufacturer { get; set; }

        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        public Or<Product, string, Uri>? Material { get; set; }

        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        public Or<ProductModel, string>? Model { get; set; }

        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        public Or<string>? Mpn { get; set; }

        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        public Or<Offer>? Offers { get; set; }

        /// The product identifier, such as ISBN. For example: meta itemprop="productID" content="isbn:123-456-789".
        public Or<string>? ProductID { get; set; }

        /// The date of production of the item, e.g. vehicle.
        public Or<SuperStructs.Date>? ProductionDate { get; set; }

        /// The date the item e.g. vehicle was purchased by the current owner.
        public Or<SuperStructs.Date>? PurchaseDate { get; set; }

        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        public Or<SuperStructs.Date>? ReleaseDate { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        public Or<string>? Sku { get; set; }

        /// The weight of the product or person.
        public Or<QuantitativeValue>? Weight { get; set; }

        /// The width of the item.
        public Or<Distance, QuantitativeValue>? Width { get; set; }

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
