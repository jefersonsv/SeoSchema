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
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// <see cref="https://schema.org/QualitativeValue"/>
    /// </summary>
    public class QualitativeValue : IEntity
    {
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.
        /// 
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        public Or<PropertyValue>? AdditionalProperty { get; set; }

        /// This ordering relation for qualitative values indicates that the subject is equal to the object.
        public Or<QualitativeValue>? Equal { get; set; }

        /// This ordering relation for qualitative values indicates that the subject is greater than the object.
        public Or<QualitativeValue>? Greater { get; set; }

        /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
        public Or<QualitativeValue>? GreaterOrEqual { get; set; }

        /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
        public Or<QualitativeValue>? Lesser { get; set; }

        /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
        public Or<QualitativeValue>? LesserOrEqual { get; set; }

        /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
        public Or<QualitativeValue>? NonEqual { get; set; }

        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        public Or<Enumeration, PropertyValue, QualitativeValue, QuantitativeValue, StructuredValue>? ValueReference { get; set; }

        /// Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
        public Or<Class, Enumeration, Property>? SupersededBy { get; set; }

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
