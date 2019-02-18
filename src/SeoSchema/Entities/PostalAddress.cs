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
    /// The mailing address.
    /// <see cref="https://schema.org/PostalAddress"/>
    /// </summary>
    public class PostalAddress : IEntity
    {
        /// The country. For example, USA. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        public Or<Country, string>? AddressCountry { get; set; }

        /// The locality. For example, Mountain View.
        public Or<string>? AddressLocality { get; set; }

        /// The region. For example, CA.
        public Or<string>? AddressRegion { get; set; }

        /// The post office box number for PO box addresses.
        public Or<string>? PostOfficeBoxNumber { get; set; }

        /// The postal code. For example, 94043.
        public Or<string>? PostalCode { get; set; }

        /// The street address. For example, 1600 Amphitheatre Pkwy.
        public Or<string>? StreetAddress { get; set; }

        /// The geographic area where a service or offered item is provided. Supersedes serviceArea.
        public Or<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the IETF BCP 47 standard. See also inLanguage
        public Or<Language, string>? AvailableLanguage { get; set; }

        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        public Or<ContactPointOption>? ContactOption { get; set; }

        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        public Or<string>? ContactType { get; set; }

        /// Email address.
        public Or<string>? Email { get; set; }

        /// The fax number.
        public Or<string>? FaxNumber { get; set; }

        /// The hours during which this service or contact is available.
        public Or<OpeningHoursSpecification>? HoursAvailable { get; set; }

        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        public Or<Product, string>? ProductSupported { get; set; }

        /// The telephone number.
        public Or<string>? Telephone { get; set; }

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
