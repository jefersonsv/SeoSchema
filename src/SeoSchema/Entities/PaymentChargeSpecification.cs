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
    /// The costs of settling the payment using a particular payment method.
    /// <see cref="https://schema.org/PaymentChargeSpecification"/>
    /// </summary>
    public class PaymentChargeSpecification : IEntity
    {
        /// The delivery method(s) to which the delivery charge or payment charge specification applies.
        public Or<DeliveryMethod>? AppliesToDeliveryMethod { get; set; }

        /// The payment method(s) to which the payment charge specification applies.
        public Or<PaymentMethod>? AppliesToPaymentMethod { get; set; }

        /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
        public Or<QuantitativeValue>? EligibleQuantity { get; set; }

        /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
        public Or<PriceSpecification>? EligibleTransactionVolume { get; set; }

        /// The highest price if the price is a range.
        public Or<double>? MaxPrice { get; set; }

        /// The lowest price if the price is a range.
        public Or<double>? MinPrice { get; set; }

        /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.
        /// 
        /// Usage guidelines:
        /// 
        /// 
        /// Use the priceCurrency property (with standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR") instead of including ambiguous symbols such as '$' in the value.
        /// Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
        /// Note that both RDFa and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.
        /// Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.
        public Or<double, string>? Price { get; set; }

        /// The currency of the price, or a price component when attached to PriceSpecification and its subtypes.
        /// 
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR".
        public Or<string>? PriceCurrency { get; set; }

        /// The date when the item becomes valid.
        public Or<DateTime>? ValidFrom { get; set; }

        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        public Or<DateTime>? ValidThrough { get; set; }

        /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
        public Or<bool>? ValueAddedTaxIncluded { get; set; }

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
