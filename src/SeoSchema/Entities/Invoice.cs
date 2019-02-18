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
    /// A statement of the money due for goods or services; a bill.
    /// <see cref="https://schema.org/Invoice"/>
    /// </summary>
    public class Invoice : IEntity
    {
        /// The identifier for the account the payment will be applied to.
        public Or<string>? AccountId { get; set; }

        /// The time interval used to compute the invoice.
        public Or<Duration>? BillingPeriod { get; set; }

        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. Supersedes bookingAgent.
        public Or<Organization, Person>? Broker { get; set; }

        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        public Or<PhysicalActivityCategory, string, Thing>? Category { get; set; }

        /// A number that confirms the given order or payment has been received.
        public Or<string>? ConfirmationNumber { get; set; }

        /// Party placing the order or paying the invoice.
        public Or<Organization, Person>? Customer { get; set; }

        /// The minimum payment required at this time.
        public Or<MonetaryAmount, PriceSpecification>? MinimumPaymentDue { get; set; }

        /// The date that payment is due. Supersedes paymentDue.
        public Or<DateTime>? PaymentDueDate { get; set; }

        /// The name of the credit card or other method of payment for the order.
        public Or<PaymentMethod>? PaymentMethod { get; set; }

        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        public Or<string>? PaymentMethodId { get; set; }

        /// The status of payment; whether the invoice has been paid or not.
        public Or<PaymentStatusType, string>? PaymentStatus { get; set; }

        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller. Supersedes carrier.
        public Or<Organization, Person>? Provider { get; set; }

        /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
        public Or<Order>? ReferencesOrder { get; set; }

        /// The date the invoice is scheduled to be paid.
        public Or<SuperStructs.Date>? ScheduledPaymentDate { get; set; }

        /// The total amount due.
        public Or<MonetaryAmount, PriceSpecification>? TotalPaymentDue { get; set; }

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
