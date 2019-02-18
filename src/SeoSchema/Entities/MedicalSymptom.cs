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
    /// Any complaint sensed and expressed by the patient (therefore defined as subjective)  like stomachache, lower-back pain, or fatigue.
    /// <see cref="https://schema.org/MedicalSymptom"/>
    /// </summary>
    public class MedicalSymptom : IEntity
    {
        /// Specifying a cause of something in general. e.g in medicine , one of the causative agent(s) that are most directly responsible for the pathophysiologic process that eventually results in the occurrence.
        public Or<MedicalCause>? Cause { get; set; }

        /// A possible treatment to address this condition, sign or symptom.
        public Or<MedicalTherapy>? PossibleTreatment { get; set; }

        /// The anatomy of the underlying organ system or structures associated with this entity.
        public Or<AnatomicalStructure, AnatomicalSystem, SuperficialAnatomy>? AssociatedAnatomy { get; set; }

        /// One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.
        public Or<DDxElement>? DifferentialDiagnosis { get; set; }

        /// Specifying a drug or medicine used in a medication procedure
        public Or<Drug>? Drug { get; set; }

        /// The characteristics of associated patients, such as age, gender, race etc.
        public Or<string>? Epidemiology { get; set; }

        /// The likely outcome in either the short term or long term of the medical condition.
        public Or<string>? ExpectedPrognosis { get; set; }

        /// The expected progression of the condition if it is not treated and allowed to progress naturally.
        public Or<string>? NaturalProgression { get; set; }

        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        public Or<string>? Pathophysiology { get; set; }

        /// A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.
        public Or<string>? PossibleComplication { get; set; }

        /// A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.
        public Or<MedicalTherapy>? PrimaryPrevention { get; set; }

        /// A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.
        public Or<MedicalRiskFactor>? RiskFactor { get; set; }

        /// A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.
        public Or<MedicalTherapy>? SecondaryPrevention { get; set; }

        /// A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experience of the medical condition.
        public Or<MedicalSignOrSymptom>? SignOrSymptom { get; set; }

        /// The stage of the condition, if applicable.
        public Or<MedicalConditionStage>? Stage { get; set; }

        /// The status of the study (enumerated).
        public Or<EventStatusType, MedicalStudyStatus, string>? Status { get; set; }

        /// A more specific type of the condition, where applicable, for example 'Type 1 Diabetes', 'Type 2 Diabetes', or 'Gestational Diabetes' for Diabetes.
        public Or<string>? Subtype { get; set; }

        /// A medical test typically performed given this condition.
        public Or<MedicalTest>? TypicalTest { get; set; }

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
