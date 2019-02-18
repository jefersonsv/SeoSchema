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
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// <see cref="https://schema.org/EngineSpecification"/>
    /// </summary>
    public class EngineSpecification : IEntity
    {
        /// The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. 
        /// 
        /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
        /// * Note 1: You can link to information about how the given value has been determined using the valueReference property.
        /// * Note 2: You can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? EngineDisplacement { get; set; }

        /// The power of the vehicle's engine.
        ///     Typical unit code(s): KWT for kilowatt, BHP for brake horsepower, N12 for metric horsepower (PS, with 1 PS = 735,49875 W)
        /// 
        /// 
        /// Note 1: There are many different ways of measuring an engine's power. For an overview, see  http://en.wikipedia.org/wiki/Horsepower#Enginepowertest_codes.
        /// Note 2: You can link to information about how the given value has been determined using the valueReference property.
        /// Note 3: You can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? EnginePower { get; set; }

        /// The type of engine or engines powering the vehicle.
        public Or<QualitativeValue, string, Uri>? EngineType { get; set; }

        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        public Or<QualitativeValue, string, Uri>? FuelType { get; set; }

        /// The torque (turning force) of the vehicle's engine.
        /// 
        /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch
        /// 
        /// 
        /// Note 1: You can link to information about how the given value has been determined (e.g. reference RPM) using the valueReference property.
        /// Note 2: You can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? Torque { get; set; }

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
