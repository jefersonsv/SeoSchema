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
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// <see cref="https://schema.org/HealthInsurancePlan"/>
    /// </summary>
    public class HealthInsurancePlan : IEntity
    {
        /// The URL that goes directly to the summary of benefits and coverage for the specific standard plan or plan variation.
        public Or<Uri>? BenefitsSummaryUrl { get; set; }

        /// A contact point for a person or organization. Supersedes contactPoints.
        public Or<ContactPoint>? ContactPoint { get; set; }

        /// TODO.
        public Or<string>? HealthPlanDrugOption { get; set; }

        /// The tier(s) of drugs offered by this formulary or insurance plan.
        public Or<string>? HealthPlanDrugTier { get; set; }

        /// The 14-character, HIOS-generated Plan ID number. (Plan IDs must be unique, even across different markets.)
        public Or<string>? HealthPlanId { get; set; }

        /// The URL that goes directly to the plan brochure for the specific standard plan or plan variation.
        public Or<Uri>? HealthPlanMarketingUrl { get; set; }

        /// Formularies covered by this plan.
        public Or<HealthPlanFormulary>? IncludesHealthPlanFormulary { get; set; }

        /// Networks covered by this plan.
        public Or<HealthPlanNetwork>? IncludesHealthPlanNetwork { get; set; }

        /// The standard for interpreting thePlan ID. The preferred is "HIOS". See the Centers for Medicare & Medicaid Services for more details.
        public Or<string, Uri>? UsesHealthPlanIdStandard { get; set; }

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
