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
    /// A food-related business.
    /// <see cref="https://schema.org/FoodEstablishment"/>
    /// </summary>
    public class FoodEstablishment : IEntity
    {
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings Yes or No.
        public Or<bool, string, Uri>? AcceptsReservations { get; set; }

        /// Either the actual menu as a structured representation, as text, or a URL of the menu. Supersedes menu.
        public Or<Menu, string, Uri>? HasMenu { get; set; }

        /// The cuisine of the restaurant.
        public Or<string>? ServesCuisine { get; set; }

        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        public Or<Rating>? StarRating { get; set; }

        /// The currency accepted.
        /// 
        /// Use standard formats: ISO 4217 currency format e.g. "USD"; Ticker symbol for cryptocurrencies e.g. "BTC"; well known names for Local Exchange Tradings Systems (LETS) and other currency types e.g. "Ithaca HOUR".
        public Or<string>? CurrenciesAccepted { get; set; }

        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.
        /// 
        /// 
        /// Days are specified using the following two-letter combinations: Mo, Tu, We, Th, Fr, Sa, Su.
        /// Times are specified using 24:00 time. For example, 3pm is specified as 15:00. 
        /// Here is an example: <time itemprop="openingHours" datetime="Tu,Th 16:00-20:00">Tuesdays and Thursdays 4-8pm</time>.
        /// If a business is open 7 days a week, then it can be specified as <time itemprop="openingHours" datetime="Mo-Su">Monday through Sunday, all day</time>.
        public Or<string>? OpeningHours { get; set; }

        /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
        public Or<string>? PaymentAccepted { get; set; }

        /// The price range of the business, for example $$$.
        public Or<string>? PriceRange { get; set; }

        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.
        /// 
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        public Or<PropertyValue>? AdditionalProperty { get; set; }

        /// Physical address of the item.
        public Or<PostalAddress, string>? Address { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        public Or<LocationFeatureSpecification>? AmenityFeature { get; set; }

        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.
        /// 
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        public Or<string>? BranchCode { get; set; }

        /// The basic containment relation between a place and one that contains it. Supersedes containedIn. Inverse property: containsPlace.
        public Or<Place>? ContainedInPlace { get; set; }

        /// The basic containment relation between a place and another that it contains. Inverse property: containedInPlace.
        public Or<Place>? ContainsPlace { get; set; }

        /// Upcoming or past event associated with this place, organization, or action. Supersedes events.
        public Or<Event>? Event { get; set; }

        /// The fax number.
        public Or<string>? FaxNumber { get; set; }

        /// The geo coordinates of the place.
        public Or<GeoCoordinates, GeoShape>? Geo { get; set; }

        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyContains { get; set; }

        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyCoveredBy { get; set; }

        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyCovers { get; set; }

        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyCrosses { get; set; }

        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in DE-9IM)
        public Or<GeospatialGeometry, Place>? GeospatiallyDisjoint { get; set; }

        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in DE-9IM. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        public Or<GeospatialGeometry, Place>? GeospatiallyEquals { get; set; }

        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyIntersects { get; set; }

        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyOverlaps { get; set; }

        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in DE-9IM )
        public Or<GeospatialGeometry, Place>? GeospatiallyTouches { get; set; }

        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in DE-9IM.
        public Or<GeospatialGeometry, Place>? GeospatiallyWithin { get; set; }

        /// The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        public Or<string>? GlobalLocationNumber { get; set; }

        /// A URL to a map of the place. Supersedes map, maps.
        public Or<Map, Uri>? HasMap { get; set; }

        /// A flag to signal that the item, event, or place is accessible for free. Supersedes free.
        public Or<bool>? IsAccessibleForFree { get; set; }

        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        public Or<string>? IsicV4 { get; set; }

        /// An associated logo.
        public Or<ImageObject, Uri>? Logo { get; set; }

        /// The total number of individuals that may attend an event or venue.
        public Or<int>? MaximumAttendeeCapacity { get; set; }

        /// The opening hours of a certain place.
        public Or<OpeningHoursSpecification>? OpeningHoursSpecification { get; set; }

        /// A photograph of this place. Supersedes photos.
        public Or<ImageObject, Photograph>? Photo { get; set; }

        /// A flag to signal that the Place is open to public visitors.  If this property is omitted there is no assumed default boolean value
        public Or<bool>? PublicAccess { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        public Or<bool>? SmokingAllowed { get; set; }

        /// The special opening hours of a certain place.
        /// 
        /// Use this to explicitly override general opening hours brought in scope by openingHoursSpecification or openingHours.
        public Or<OpeningHoursSpecification>? SpecialOpeningHoursSpecification { get; set; }

        /// The telephone number.
        public Or<string>? Telephone { get; set; }

        /// For a NewsMediaOrganization or other news-related Organization, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        public Or<CreativeWork, Uri>? ActionableFeedbackPolicy { get; set; }

        /// Alumni of an organization. Inverse property: alumniOf.
        public Or<Person>? Alumni { get; set; }

        /// The geographic area where a service or offered item is provided. Supersedes serviceArea.
        public Or<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// An award won by or for this item. Supersedes awards.
        public Or<string>? Award { get; set; }

        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        public Or<Brand, Organization>? Brand { get; set; }

        /// A contact point for a person or organization. Supersedes contactPoints.
        public Or<ContactPoint>? ContactPoint { get; set; }

        /// For an Organization (e.g. NewsMediaOrganization), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        public Or<CreativeWork, Uri>? CorrectionsPolicy { get; set; }

        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        public Or<Organization>? Department { get; set; }

        /// The date that this organization was dissolved.
        public Or<SuperStructs.Date>? DissolutionDate { get; set; }

        /// Statement on diversity policy by an Organization e.g. a NewsMediaOrganization. For a NewsMediaOrganization, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        public Or<CreativeWork, Uri>? DiversityPolicy { get; set; }

        /// For an Organization (often but not necessarily a NewsMediaOrganization), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        public Or<Article, Uri>? DiversityStaffingReport { get; set; }

        /// The Dun & Bradstreet DUNS number for identifying an organization or business person.
        public Or<string>? Duns { get; set; }

        /// Email address.
        public Or<string>? Email { get; set; }

        /// Someone working for this organization. Supersedes employees.
        public Or<Person>? Employee { get; set; }

        /// Statement about ethics policy, e.g. of a NewsMediaOrganization regarding journalistic and publishing practices, or of a Restaurant, a page describing food source policies. In the case of a NewsMediaOrganization, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        public Or<CreativeWork, Uri>? EthicsPolicy { get; set; }

        /// A person who founded this organization. Supersedes founders.
        public Or<Person>? Founder { get; set; }

        /// The date that this organization was founded.
        public Or<SuperStructs.Date>? FoundingDate { get; set; }

        /// The place where the Organization was founded.
        public Or<Place>? FoundingLocation { get; set; }

        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        public Or<Organization, Person>? Funder { get; set; }

        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        public Or<OfferCatalog>? HasOfferCatalog { get; set; }

        /// Points-of-Sales operated by the organization or person.
        public Or<Place>? HasPOS { get; set; }

        /// Of a Person, and less typically of an Organization, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or JobPosting descriptions.
        public Or<string, Thing, Uri>? KnowsAbout { get; set; }

        /// Of a Person, and less typically of an Organization, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the IETF BCP 47 standard.
        public Or<Language, string>? KnowsLanguage { get; set; }

        /// The official name of the organization, e.g. the registered company name.
        public Or<string>? LegalName { get; set; }

        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        public Or<string>? LeiCode { get; set; }

        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        public Or<Place, PostalAddress, string>? Location { get; set; }

        /// A pointer to products or services offered by the organization or person. Inverse property: offeredBy.
        public Or<Offer>? MakesOffer { get; set; }

        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals. Supersedes members, musicGroupMember. Inverse property: memberOf.
        public Or<Organization, Person>? Member { get; set; }

        /// An Organization (or ProgramMembership) to which this Person or Organization belongs. Inverse property: member.
        public Or<Organization, ProgramMembership>? MemberOf { get; set; }

        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        public Or<string>? Naics { get; set; }

        /// The number of employees in an organization e.g. business.
        public Or<QuantitativeValue>? NumberOfEmployees { get; set; }

        /// For an Organization (often but not necessarily a NewsMediaOrganization), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the funder is also available and can be used to make basic funder information machine-readable.
        public Or<AboutPage, CreativeWork, string, Uri>? OwnershipFundingInfo { get; set; }

        /// Products owned by the organization or person.
        public Or<OwnershipInfo, Product>? Owns { get; set; }

        /// The larger organization that this organization is a subOrganization of, if any. Supersedes branchOf. Inverse property: subOrganization.
        public Or<Organization>? ParentOrganization { get; set; }

        /// The publishingPrinciples property indicates (typically via URL) a document describing the editorial principles of an Organization (or individual e.g. a Person writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a CreativeWork (e.g. NewsArticle) the principles are those of the party primarily responsible for the creation of the CreativeWork.
        /// 
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a funder) can be expressed using schema.org terminology.
        public Or<CreativeWork, Uri>? PublishingPrinciples { get; set; }

        /// A pointer to products or services sought by the organization or person (demand).
        public Or<Demand>? Seeks { get; set; }

        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        public Or<Organization, Person>? Sponsor { get; set; }

        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property. Inverse property: parentOrganization.
        public Or<Organization>? SubOrganization { get; set; }

        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        public Or<string>? TaxID { get; set; }

        /// For an Organization (typically a NewsMediaOrganization), a statement about policy on use of unnamed sources and the decision process required.
        public Or<CreativeWork, Uri>? UnnamedSourcesPolicy { get; set; }

        /// The Value-added Tax ID of the organization or person.
        public Or<string>? VatID { get; set; }

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
