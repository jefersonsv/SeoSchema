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
    /// A Property value specification.
    /// <see cref="https://schema.org/PropertyValueSpecification"/>
    /// </summary>
    public class PropertyValueSpecification : IEntity
    {
        /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
        public Or<string, Thing>? DefaultValue { get; set; }

        /// The upper value of some characteristic or property.
        public Or<double>? MaxValue { get; set; }

        /// The lower value of some characteristic or property.
        public Or<double>? MinValue { get; set; }

        /// Whether multiple values are allowed for the property.  Default is false.
        public Or<bool>? MultipleValues { get; set; }

        /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
        public Or<bool>? ReadonlyValue { get; set; }

        /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
        public Or<double>? StepValue { get; set; }

        /// Specifies the allowed range for number of characters in a literal value.
        public Or<double>? ValueMaxLength { get; set; }

        /// Specifies the minimum allowed range for number of characters in a literal value.
        public Or<double>? ValueMinLength { get; set; }

        /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
        public Or<string>? ValueName { get; set; }

        /// Specifies a regular expression for testing literal values according to the HTML spec.
        public Or<string>? ValuePattern { get; set; }

        /// Whether the property must be filled in to complete the action.  Default is false.
        public Or<bool>? ValueRequired { get; set; }

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
