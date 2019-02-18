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
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// <see cref="https://schema.org/LocationFeatureSpecification"/>
    /// </summary>
    public class LocationFeatureSpecification : IEntity
    {
        /// The hours during which this service or contact is available.
        public Or<OpeningHoursSpecification>? HoursAvailable { get; set; }

        /// The date when the item becomes valid.
        public Or<DateTime>? ValidFrom { get; set; }

        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        public Or<DateTime>? ValidThrough { get; set; }

        /// The upper value of some characteristic or property.
        public Or<double>? MaxValue { get; set; }

        /// A technique or technology used in a Dataset (or DataDownload, DataCatalog),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using variableMeasured). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.
        /// 
        /// For example, if variableMeasured is: molecule concentration, measurementTechnique could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".
        /// 
        /// If the variableMeasured is "depression rating", the measurementTechnique could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".
        /// 
        /// If there are several variableMeasured properties recorded for some given data object, use a PropertyValue for each variableMeasured and attach the corresponding measurementTechnique.
        public Or<string, Uri>? MeasurementTechnique { get; set; }

        /// The lower value of some characteristic or property.
        public Or<double>? MinValue { get; set; }

        /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
        /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
        /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
        /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
        public Or<string, Uri>? PropertyID { get; set; }

        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        public Or<string, Uri>? UnitCode { get; set; }

        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// unitCode.
        public Or<string>? UnitText { get; set; }

        /// The value of the quantitative value or property value node.
        /// 
        /// 
        /// For QuantitativeValue and MonetaryAmount, the recommended type for values is 'Number'.
        /// For PropertyValue, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.
        public Or<bool, double, StructuredValue, string>? Value { get; set; }

        /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        public Or<Enumeration, PropertyValue, QualitativeValue, QuantitativeValue, StructuredValue>? ValueReference { get; set; }

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
