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
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge make a clear difference between them.
    /// <see cref="https://schema.org/Drug"/>
    /// </summary>
    public class Drug : IEntity
    {
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        public Or<string>? ActiveIngredient { get; set; }

        /// A route by which this drug may be administered, e.g. 'oral'.
        public Or<string>? AdministrationRoute { get; set; }

        /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
        public Or<string>? AlcoholWarning { get; set; }

        /// An available dosage strength for the drug.
        public Or<DrugStrength>? AvailableStrength { get; set; }

        /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
        public Or<string>? BreastfeedingWarning { get; set; }

        /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD). Supersedes clincalPharmacology.
        public Or<string>? ClinicalPharmacology { get; set; }

        /// Cost per unit of the drug, as reported by the source being tagged.
        public Or<DrugCost>? Cost { get; set; }

        /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
        public Or<string>? DosageForm { get; set; }

        /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
        public Or<DoseSchedule>? DoseSchedule { get; set; }

        /// The class of drug this belongs to (e.g., statins).
        public Or<DrugClass>? DrugClass { get; set; }

        /// The unit in which the drug is measured, e.g. '5 mg tablet'.
        public Or<string>? DrugUnit { get; set; }

        /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
        public Or<string>? FoodWarning { get; set; }

        /// The insurance plans that cover this drug.
        public Or<HealthInsurancePlan>? IncludedInHealthInsurancePlan { get; set; }

        /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
        public Or<Drug>? InteractingDrug { get; set; }

        /// True if the drug is available in a generic form (regardless of name).
        public Or<bool>? IsAvailableGenerically { get; set; }

        /// True if this item's name is a proprietary/brand name (vs. generic name).
        public Or<bool>? IsProprietary { get; set; }

        /// Link to the drug's label details.
        public Or<Uri>? LabelDetails { get; set; }

        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        public Or<DrugLegalStatus, MedicalEnumeration, string>? LegalStatus { get; set; }

        /// The manufacturer of the product.
        public Or<Organization>? Manufacturer { get; set; }

        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        public Or<MaximumDoseSchedule>? MaximumIntake { get; set; }

        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        public Or<string>? MechanismOfAction { get; set; }

        /// The generic name of this drug or supplement.
        public Or<string>? NonProprietaryName { get; set; }

        /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
        public Or<string>? Overdosage { get; set; }

        /// Pregnancy category of this drug.
        public Or<DrugPregnancyCategory>? PregnancyCategory { get; set; }

        /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
        public Or<string>? PregnancyWarning { get; set; }

        /// Link to prescribing information for the drug.
        public Or<Uri>? PrescribingInfo { get; set; }

        /// Indicates the status of drug prescription eg. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
        public Or<DrugPrescriptionStatus, string>? PrescriptionStatus { get; set; }

        /// Proprietary name given to the diet plan, typically by its originator or creator.
        public Or<string>? ProprietaryName { get; set; }

        /// Any other drug related to this one, for example commonly-prescribed alternatives.
        public Or<Drug>? RelatedDrug { get; set; }

        /// The RxCUI drug identifier from RXNORM.
        public Or<string>? Rxcui { get; set; }

        /// Any FDA or other warnings about the drug (text or URL).
        public Or<string, Uri>? Warning { get; set; }

        /// A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.
        public Or<MedicalCode>? Code { get; set; }

        /// A medical guideline related to this entity.
        public Or<MedicalGuideline>? Guideline { get; set; }

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
