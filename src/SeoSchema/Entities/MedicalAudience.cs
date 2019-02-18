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
    /// Target audiences for medical web pages. Enumerated type.
    /// <see cref="https://schema.org/MedicalAudience"/>
    /// </summary>
    public class MedicalAudience : IEntity
    {
        /// Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
        public Or<Class, Enumeration, Property>? SupersededBy { get; set; }

        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        public Or<string>? AudienceType { get; set; }

        /// The geographic area associated with the audience.
        public Or<AdministrativeArea>? GeographicArea { get; set; }

        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        public Or<MedicalCondition>? HealthCondition { get; set; }

        /// Audiences defined by a person's gender.
        public Or<string>? RequiredGender { get; set; }

        /// Audiences defined by a person's maximum age.
        public Or<int>? RequiredMaxAge { get; set; }

        /// Audiences defined by a person's minimum age.
        public Or<int>? RequiredMinAge { get; set; }

        /// The gender of the person or audience.
        public Or<string>? SuggestedGender { get; set; }

        /// Maximal age recommended for viewing content.
        public Or<double>? SuggestedMaxAge { get; set; }

        /// Minimal age recommended for viewing content.
        public Or<double>? SuggestedMinAge { get; set; }

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
