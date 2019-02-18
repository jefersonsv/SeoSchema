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
    /// A listing that describes a job opening in a certain organization.
    /// <see cref="https://schema.org/JobPosting"/>
    /// </summary>
    public class JobPosting : IEntity
    {
        /// The base salary of the job or of an employee in an EmployeeRole.
        public Or<MonetaryAmount, double, PriceSpecification>? BaseSalary { get; set; }

        /// Publication date for the job posting.
        public Or<SuperStructs.Date>? DatePosted { get; set; }

        /// Educational background needed for the position or Occupation.
        public Or<string>? EducationRequirements { get; set; }

        /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
        public Or<string>? EmploymentType { get; set; }

        /// A property describing the estimated salary for a job posting based on a variety of variables including, but not limited to industry, job title, and location. The estimated salary is usually computed by outside organizations and therefore the hiring organization is not bound to this estimated salary.
        public Or<MonetaryAmount, MonetaryAmountDistribution, double, PriceSpecification>? EstimatedSalary { get; set; }

        /// Description of skills and experience needed for the position or Occupation.
        public Or<string>? ExperienceRequirements { get; set; }

        /// Organization offering the job position.
        public Or<Organization>? HiringOrganization { get; set; }

        /// Description of bonus and commission compensation aspects of the job. Supersedes incentives.
        public Or<string>? IncentiveCompensation { get; set; }

        /// The industry associated with the job position.
        public Or<string>? Industry { get; set; }

        /// Description of benefits associated with the job. Supersedes benefits.
        public Or<string>? JobBenefits { get; set; }

        /// A (typically single) geographic location associated with the job position.
        public Or<Place>? JobLocation { get; set; }

        /// Category or categories describing the job. Use BLS O*NET-SOC taxonomy: http://www.onetcenter.org/taxonomy.html. Ideally includes textual label and formal code, with the property repeated for each applicable value.
        public Or<string>? OccupationalCategory { get; set; }

        /// Specific qualifications required for this role or Occupation.
        public Or<string>? Qualifications { get; set; }

        /// The Occupation for the JobPosting.
        public Or<Occupation>? RelevantOccupation { get; set; }

        /// Responsibilities associated with this role or Occupation.
        public Or<string>? Responsibilities { get; set; }

        /// The currency (coded using ISO 4217 ) used for the main salary information in this job posting or for this employee.
        public Or<string>? SalaryCurrency { get; set; }

        /// Skills required to fulfill this role.
        public Or<string>? Skills { get; set; }

        /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
        public Or<string>? SpecialCommitments { get; set; }

        /// The title of the job.
        public Or<string>? Title { get; set; }

        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        public Or<DateTime>? ValidThrough { get; set; }

        /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
        public Or<string>? WorkHours { get; set; }

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
