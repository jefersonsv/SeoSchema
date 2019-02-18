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
    /// A contact point—for example, a Customer Complaints department.
    /// <see cref="https://schema.org/ContactPoint"/>
    /// </summary>
    public class ContactPoint : IEntity
    {
        /// The geographic area where a service or offered item is provided. Supersedes serviceArea.
        public Or<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// A language someone may use with or at the item, service or place. Please use one of the language codes from the IETF BCP 47 standard. See also inLanguage
        public Or<Language, string>? AvailableLanguage { get; set; }

        /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
        public Or<ContactPointOption>? ContactOption { get; set; }

        /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
        public Or<string>? ContactType { get; set; }

        /// Email address.
        public Or<string>? Email { get; set; }

        /// The fax number.
        public Or<string>? FaxNumber { get; set; }

        /// The hours during which this service or contact is available.
        public Or<OpeningHoursSpecification>? HoursAvailable { get; set; }

        /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
        public Or<Product, string>? ProductSupported { get; set; }

        /// The telephone number.
        public Or<string>? Telephone { get; set; }
    }
}
