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
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// <see cref="https://schema.org/Car"/>
    /// </summary>
    public class Car : IEntity
    {
        /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.
        public Or<string>? AcrissCode { get; set; }

        /// The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.
        /// 
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// 
        /// 
        /// Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference
        /// Note 3: Note that you can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? RoofLoad { get; set; }

        /// The time needed to accelerate the vehicle from a given start velocity to a given target velocity.
        /// 
        /// Typical unit code(s): SEC for seconds
        /// 
        /// 
        /// Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the name of the QuantitativeValue, or use valueReference with a QuantitativeValue of 0..60 mph or 0..100 km/h to specify the reference speeds.
        public Or<QuantitativeValue>? AccelerationTime { get; set; }

        /// Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
        public Or<QualitativeValue, string, Uri>? BodyType { get; set; }

        /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.
        /// 
        /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet
        /// 
        /// Note: You can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? CargoVolume { get; set; }

        /// The date of the first registration of the vehicle with the respective public authorities.
        public Or<SuperStructs.Date>? DateVehicleFirstRegistered { get; set; }

        /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
        public Or<DriveWheelConfigurationValue, string>? DriveWheelConfiguration { get; set; }

        /// The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
        public Or<double>? EmissionsCO2 { get; set; }

        /// The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.
        /// 
        /// Typical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
        public Or<QuantitativeValue>? FuelCapacity { get; set; }

        /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).
        /// 
        /// 
        /// Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use unitText to indicate the unit of measurement, e.g. L/100 km.
        /// Note 2: There are two ways of indicating the fuel consumption, fuelConsumption (e.g. 8 liters per 100 km) and fuelEfficiency (e.g. 30 miles per gallon). They are reciprocal.
        /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use valueReference to link the value for the fuel consumption to another value.
        public Or<QuantitativeValue>? FuelConsumption { get; set; }

        /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).
        /// 
        /// 
        /// Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use unitText to indicate the unit of measurement, e.g. mpg or km/L.
        /// Note 2: There are two ways of indicating the fuel consumption, fuelConsumption (e.g. 8 liters per 100 km) and fuelEfficiency (e.g. 30 miles per gallon). They are reciprocal.
        /// Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use valueReference to link the value for the fuel economy to another value.
        public Or<QuantitativeValue>? FuelEfficiency { get; set; }

        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        public Or<QualitativeValue, string, Uri>? FuelType { get; set; }

        /// A textual description of known damages, both repaired and unrepaired.
        public Or<string>? KnownVehicleDamages { get; set; }

        /// Indicates that the vehicle meets the respective emission standard.
        public Or<QualitativeValue, string, Uri>? MeetsEmissionStandard { get; set; }

        /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.
        /// 
        /// Typical unit code(s): KMT for kilometers, SMI for statute miles
        public Or<QuantitativeValue>? MileageFromOdometer { get; set; }

        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        public Or<SuperStructs.Date>? ModelDate { get; set; }

        /// The number or type of airbags in the vehicle.
        public Or<double, string>? NumberOfAirbags { get; set; }

        /// The number of axles.
        /// 
        /// Typical unit code(s): C62
        public Or<double, QuantitativeValue>? NumberOfAxles { get; set; }

        /// The number of doors.
        /// 
        /// Typical unit code(s): C62
        public Or<double, QuantitativeValue>? NumberOfDoors { get; set; }

        /// The total number of forward gears available for the transmission system of the vehicle.
        /// 
        /// Typical unit code(s): C62
        public Or<double, QuantitativeValue>? NumberOfForwardGears { get; set; }

        /// The number of owners of the vehicle, including the current one.
        /// 
        /// Typical unit code(s): C62
        public Or<double, QuantitativeValue>? NumberOfPreviousOwners { get; set; }

        /// The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.
        /// 
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// 
        /// 
        /// Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of weight and payload
        /// Note 2: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 3: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// Note 4: Note that you can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? Payload { get; set; }

        /// The date of production of the item, e.g. vehicle.
        public Or<SuperStructs.Date>? ProductionDate { get; set; }

        /// The date the item e.g. vehicle was purchased by the current owner.
        public Or<SuperStructs.Date>? PurchaseDate { get; set; }

        /// The number of persons that can be seated (e.g. in a vehicle), both in terms of the physical space available, and in terms of limitations set by law.
        /// 
        /// Typical unit code(s): C62 for persons
        public Or<double, QuantitativeValue>? SeatingCapacity { get; set; }

        /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by maxValue should be the maximum speed achievable under regular conditions.
        /// 
        /// Typical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot
        /// 
        /// *Note 1: Use minValue and maxValue to indicate the range. Typically, the minimal value is zero.
        /// * Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the valueReference property.
        public Or<QuantitativeValue>? Speed { get; set; }

        /// The position of the steering wheel or similar device (mostly for cars).
        public Or<SteeringPositionValue>? SteeringPosition { get; set; }

        /// The permitted vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR)
        /// 
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// 
        /// 
        /// Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// Note 3: Note that you can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? TongueWeight { get; set; }

        /// The permitted weight of a trailer attached to the vehicle.
        /// 
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// * Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// * Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// * Note 3: Note that you can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? TrailerWeight { get; set; }

        /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
        public Or<string>? VehicleConfiguration { get; set; }

        /// Information about the engine or engines of the vehicle.
        public Or<EngineSpecification>? VehicleEngine { get; set; }

        /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
        public Or<string>? VehicleIdentificationNumber { get; set; }

        /// The color or color combination of the interior of the vehicle.
        public Or<string>? VehicleInteriorColor { get; set; }

        /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
        public Or<string>? VehicleInteriorType { get; set; }

        /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
        public Or<SuperStructs.Date>? VehicleModelDate { get; set; }

        /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.
        /// 
        /// Typical unit code(s): C62 for persons.
        public Or<double, QuantitativeValue>? VehicleSeatingCapacity { get; set; }

        /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
        public Or<CarUsageType, string>? VehicleSpecialUsage { get; set; }

        /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
        public Or<QualitativeValue, string, Uri>? VehicleTransmission { get; set; }

        /// The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.
        /// 
        /// Typical unit code(s): KGM for kilogram, LBR for pound
        /// 
        /// 
        /// Note 1: You can indicate additional information in the name of the QuantitativeValue node.
        /// Note 2: You may also link to a QualitativeValue node that provides additional information using valueReference.
        /// Note 3: Note that you can use minValue and maxValue to indicate ranges.
        public Or<QuantitativeValue>? WeightTotal { get; set; }

        /// The distance between the centers of the front and rear wheels.
        /// 
        /// Typical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet
        public Or<QuantitativeValue>? Wheelbase { get; set; }

        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.
        /// 
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        public Or<PropertyValue>? AdditionalProperty { get; set; }

        /// The overall rating, based on a collection of reviews or ratings, of the item.
        public Or<AggregateRating>? AggregateRating { get; set; }

        /// An intended audience, i.e. a group for whom something was created. Supersedes serviceAudience.
        public Or<Audience>? Audience { get; set; }

        /// An award won by or for this item. Supersedes awards.
        public Or<string>? Award { get; set; }

        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        public Or<Brand, Organization>? Brand { get; set; }

        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        public Or<PhysicalActivityCategory, string, Thing>? Category { get; set; }

        /// The color of the product.
        public Or<string>? Color { get; set; }

        /// The depth of the item.
        public Or<Distance, QuantitativeValue>? Depth { get; set; }

        /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin12 { get; set; }

        /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin13 { get; set; }

        /// The GTIN-14 code of the product, or the product to which the offer refers. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin14 { get; set; }

        /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See GS1 GTIN Summary for more details.
        public Or<string>? Gtin8 { get; set; }

        /// The height of the item.
        public Or<Distance, QuantitativeValue>? Height { get; set; }

        /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
        public Or<Product>? IsAccessoryOrSparePartFor { get; set; }

        /// A pointer to another product (or multiple products) for which this product is a consumable.
        public Or<Product>? IsConsumableFor { get; set; }

        /// A pointer to another, somehow related product (or multiple products).
        public Or<Product, Service>? IsRelatedTo { get; set; }

        /// A pointer to another, functionally similar product (or multiple products).
        public Or<Product, Service>? IsSimilarTo { get; set; }

        /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
        public Or<OfferItemCondition>? ItemCondition { get; set; }

        /// An associated logo.
        public Or<ImageObject, Uri>? Logo { get; set; }

        /// The manufacturer of the product.
        public Or<Organization>? Manufacturer { get; set; }

        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        public Or<Product, string, Uri>? Material { get; set; }

        /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
        public Or<ProductModel, string>? Model { get; set; }

        /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
        public Or<string>? Mpn { get; set; }

        /// An offer to provide this item—for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        public Or<Offer>? Offers { get; set; }

        /// The product identifier, such as ISBN. For example: meta itemprop="productID" content="isbn:123-456-789".
        public Or<string>? ProductID { get; set; }

        /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
        public Or<SuperStructs.Date>? ReleaseDate { get; set; }

        /// A review of the item. Supersedes reviews.
        public Or<Review>? Review { get; set; }

        /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
        public Or<string>? Sku { get; set; }

        /// The weight of the product or person.
        public Or<QuantitativeValue>? Weight { get; set; }

        /// The width of the item.
        public Or<Distance, QuantitativeValue>? Width { get; set; }

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
