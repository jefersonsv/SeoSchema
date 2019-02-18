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
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// <see cref="https://schema.org/Order"/>
    /// </summary>
    public class Order : IEntity
    {
        /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
        public Or<Offer>? AcceptedOffer { get; set; }

        /// The billing address for the order.
        public Or<PostalAddress>? BillingAddress { get; set; }

        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred. Supersedes bookingAgent.
        public Or<Organization, Person>? Broker { get; set; }

        /// A number that confirms the given order or payment has been received.
        public Or<string>? ConfirmationNumber { get; set; }

        /// Party placing the order or paying the invoice.
        public Or<Organization, Person>? Customer { get; set; }

        /// Any discount applied (to an Order).
        public Or<double, string>? Discount { get; set; }

        /// Code used to redeem a discount.
        public Or<string>? DiscountCode { get; set; }

        /// The currency of the discount.
        /// 
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR".
        public Or<string>? DiscountCurrency { get; set; }

        /// Was the offer accepted as a gift for someone other than the buyer.
        public Or<bool>? IsGift { get; set; }

        /// Date order was placed.
        public Or<DateTime>? OrderDate { get; set; }

        /// The delivery of the parcel related to this order or order item.
        public Or<ParcelDelivery>? OrderDelivery { get; set; }

        /// The identifier of the transaction.
        public Or<string>? OrderNumber { get; set; }

        /// The current status of the order.
        public Or<OrderStatus>? OrderStatus { get; set; }

        /// The item ordered.
        public Or<OrderItem, Product>? OrderedItem { get; set; }

        /// The order is being paid as part of the referenced Invoice.
        public Or<Invoice>? PartOfInvoice { get; set; }

        /// The date that payment is due. Supersedes paymentDue.
        public Or<DateTime>? PaymentDueDate { get; set; }

        /// The name of the credit card or other method of payment for the order.
        public Or<PaymentMethod>? PaymentMethod { get; set; }

        /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
        public Or<string>? PaymentMethodId { get; set; }

        /// The URL for sending a payment.
        public Or<Uri>? PaymentUrl { get; set; }

        /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider. Supersedes merchant, vendor.
        public Or<Organization, Person>? Seller { get; set; }

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
