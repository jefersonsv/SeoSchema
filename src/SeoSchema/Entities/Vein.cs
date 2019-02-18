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
    /// A type of blood vessel that specifically carries blood to the heart.
    /// <see cref="https://schema.org/Vein"/>
    /// </summary>
    public class Vein : IEntity
    {
        /// The vasculature that the vein drains into.
        public Or<Vessel>? DrainsTo { get; set; }

        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        public Or<AnatomicalStructure, AnatomicalSystem>? RegionDrained { get; set; }

        /// The anatomical or organ system that the vein flows into; a larger structure that the vein connects to.
        public Or<AnatomicalStructure>? Tributary { get; set; }

        /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
        public Or<string>? AssociatedPathophysiology { get; set; }

        /// Location in the body of the anatomical structure.
        public Or<string>? BodyLocation { get; set; }

        /// Other anatomical structures to which this structure is connected.
        public Or<AnatomicalStructure>? ConnectedTo { get; set; }

        /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
        public Or<ImageObject>? Diagram { get; set; }

        /// Function of the anatomical structure.
        public Or<string>? Function { get; set; }

        /// The anatomical or organ system that this structure is part of.
        public Or<AnatomicalSystem>? PartOfSystem { get; set; }

        /// A medical condition associated with this anatomy.
        public Or<MedicalCondition>? RelatedCondition { get; set; }

        /// A medical therapy related to this anatomy.
        public Or<MedicalTherapy>? RelatedTherapy { get; set; }

        /// Component (sub-)structure(s) that comprise this anatomical structure.
        public Or<AnatomicalStructure>? SubStructure { get; set; }

        /// A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.
        public Or<MedicalCode>? Code { get; set; }

        /// A medical guideline related to this entity.
        public Or<MedicalGuideline>? Guideline { get; set; }

        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        public Or<DrugLegalStatus, MedicalEnumeration, string>? LegalStatus { get; set; }

        /// The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
        public Or<MedicineSystem>? MedicineSystem { get; set; }

        /// If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
        public Or<Organization>? RecognizingAuthority { get; set; }

        /// If applicable, a medical specialty in which this entity is relevant.
        public Or<MedicalSpecialty>? RelevantSpecialty { get; set; }

        /// A medical study or trial related to this entity.
        public Or<MedicalStudy>? Study { get; set; }

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
