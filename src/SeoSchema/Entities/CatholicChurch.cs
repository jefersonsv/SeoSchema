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
    /// A Catholic church.
    /// <see cref="https://schema.org/CatholicChurch"/>
    /// </summary>
    public class CatholicChurch : IEntity
    {
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.
        /// 
        /// 
        /// Days are specified using the following two-letter combinations: Mo, Tu, We, Th, Fr, Sa, Su.
        /// Times are specified using 24:00 time. For example, 3pm is specified as 15:00. 
        /// Here is an example: <time itemprop="openingHours" datetime="Tu,Th 16:00-20:00">Tuesdays and Thursdays 4-8pm</time>.
        /// If a business is open 7 days a week, then it can be specified as <time itemprop="openingHours" datetime="Mo-Su">Monday through Sunday, all day</time>.
        public Or<string>? OpeningHours { get; set; }

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
