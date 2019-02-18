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
    /// A patient is any person recipient of health care services.
    /// <see cref="https://schema.org/Patient"/>
    /// </summary>
    public class Patient : IEntity
    {
        /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
        public Or<MedicalCondition>? Diagnosis { get; set; }

        /// Specifying a drug or medicine used in a medication procedure
        public Or<Drug>? Drug { get; set; }

        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        public Or<MedicalCondition>? HealthCondition { get; set; }

        /// An additional name for a Person, can be used for a middle name.
        public Or<string>? AdditionalName { get; set; }

        /// Physical address of the item.
        public Or<PostalAddress, string>? Address { get; set; }

        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        public Or<Organization>? Affiliation { get; set; }

        /// An organization that the person is an alumni of. Inverse property: alumni.
        public Or<EducationalOrganization, Organization>? AlumniOf { get; set; }

        /// An award won by or for this item. Supersedes awards.
        public Or<string>? Award { get; set; }

        /// Date of birth.
        public Or<SuperStructs.Date>? BirthDate { get; set; }

        /// The place where the person was born.
        public Or<Place>? BirthPlace { get; set; }

        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        public Or<Brand, Organization>? Brand { get; set; }

        /// A child of the person.
        public Or<Person>? Children { get; set; }

        /// A colleague of the person. Supersedes colleagues.
        public Or<Person, Uri>? Colleague { get; set; }

        /// A contact point for a person or organization. Supersedes contactPoints.
        public Or<ContactPoint>? ContactPoint { get; set; }

        /// Date of death.
        public Or<SuperStructs.Date>? DeathDate { get; set; }

        /// The place where the person died.
        public Or<Place>? DeathPlace { get; set; }

        /// The Dun & Bradstreet DUNS number for identifying an organization or business person.
        public Or<string>? Duns { get; set; }

        /// Email address.
        public Or<string>? Email { get; set; }

        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        public Or<string>? FamilyName { get; set; }

        /// The fax number.
        public Or<string>? FaxNumber { get; set; }

        /// The most generic uni-directional social relation.
        public Or<Person>? Follows { get; set; }

        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        public Or<Organization, Person>? Funder { get; set; }

        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        public Or<GenderType, string>? Gender { get; set; }

        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        public Or<string>? GivenName { get; set; }

        /// The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        public Or<string>? GlobalLocationNumber { get; set; }

        /// The Person's occupation. For past professions, use Role for expressing dates.
        public Or<Occupation>? HasOccupation { get; set; }

        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        public Or<OfferCatalog>? HasOfferCatalog { get; set; }

        /// Points-of-Sales operated by the organization or person.
        public Or<Place>? HasPOS { get; set; }

        /// The height of the item.
        public Or<Distance, QuantitativeValue>? Height { get; set; }

        /// A contact location for a person's residence.
        public Or<ContactPoint, Place>? HomeLocation { get; set; }

        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        public Or<string>? HonorificPrefix { get; set; }

        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        public Or<string>? HonorificSuffix { get; set; }

        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        public Or<string>? IsicV4 { get; set; }

        /// The job title of the person (for example, Financial Manager).
        public Or<string>? JobTitle { get; set; }

        /// The most generic bi-directional social/work relation.
        public Or<Person>? Knows { get; set; }

        /// Of a Person, and less typically of an Organization, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or JobPosting descriptions.
        public Or<string, Thing, Uri>? KnowsAbout { get; set; }

        /// Of a Person, and less typically of an Organization, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the IETF BCP 47 standard.
        public Or<Language, string>? KnowsLanguage { get; set; }

        /// A pointer to products or services offered by the organization or person. Inverse property: offeredBy.
        public Or<Offer>? MakesOffer { get; set; }

        /// An Organization (or ProgramMembership) to which this Person or Organization belongs. Inverse property: member.
        public Or<Organization, ProgramMembership>? MemberOf { get; set; }

        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        public Or<string>? Naics { get; set; }

        /// Nationality of the person.
        public Or<Country>? Nationality { get; set; }

        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        public Or<MonetaryAmount, PriceSpecification>? NetWorth { get; set; }

        /// Products owned by the organization or person.
        public Or<OwnershipInfo, Product>? Owns { get; set; }

        /// A parent of this person. Supersedes parents.
        public Or<Person>? Parent { get; set; }

        /// Event that this person is a performer or participant in.
        public Or<Event>? PerformerIn { get; set; }

        /// The publishingPrinciples property indicates (typically via URL) a document describing the editorial principles of an Organization (or individual e.g. a Person writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a CreativeWork (e.g. NewsArticle) the principles are those of the party primarily responsible for the creation of the CreativeWork.
        /// 
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a funder) can be expressed using schema.org terminology.
        public Or<CreativeWork, Uri>? PublishingPrinciples { get; set; }

        /// The most generic familial relation.
        public Or<Person>? RelatedTo { get; set; }

        /// A pointer to products or services sought by the organization or person (demand).
        public Or<Demand>? Seeks { get; set; }

        /// A sibling of the person. Supersedes siblings.
        public Or<Person>? Sibling { get; set; }

        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        public Or<Organization, Person>? Sponsor { get; set; }

        /// The person's spouse.
        public Or<Person>? Spouse { get; set; }

        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        public Or<string>? TaxID { get; set; }

        /// The telephone number.
        public Or<string>? Telephone { get; set; }

        /// The Value-added Tax ID of the organization or person.
        public Or<string>? VatID { get; set; }

        /// The weight of the product or person.
        public Or<QuantitativeValue>? Weight { get; set; }

        /// A contact location for a person's place of work.
        public Or<ContactPoint, Place>? WorkLocation { get; set; }

        /// Organizations that the person works for.
        public Or<Organization>? WorksFor { get; set; }

        /// Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
        public Or<Class, Enumeration, Property>? SupersededBy { get; set; }

        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        public Or<string>? AudienceType { get; set; }

        /// The geographic area associated with the audience.
        public Or<AdministrativeArea>? GeographicArea { get; set; }

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
