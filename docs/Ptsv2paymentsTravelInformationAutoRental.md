# CyberSource.Model.Ptsv2paymentsTravelInformationAutoRental
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NoShowIndicator** | **bool?** | No Show Indicator provides an indicator noting that the individual did not show up after making a reservation for a vehicle. Possible values: - true - false  | [optional] 
**CustomerName** | **string** | Name of the individual making the rental agreement.  Valid data lengths by card:  |Card Specific Validation|VISA|MasterCard|Discover|AMEX| |- -- |- -- |- -- |- -- | | Filed Length| 40| 40| 29| 26| | Field Type| AN| ANS| AN| AN| | M/O/C| O| M| M| M|  | [optional] 
**VehicleClass** | **string** | Classification of the rented auto.  **NOTE** For VISA, this is a 2-byte optional code.  Valid values for American Express &amp; MasterCard:  |American Express |MasterCard |Description| |- -- |- -- |- -- | | 0001| 0001| Mini| | 0002| 0002| Subcompact| | 0003| 0003| Economy| | 0004| 0004| Compact| | 0005| 0005| Midsize| | 0006| 0006| Intermediate| | 0007| 0007| Standard| | 0008| 0008| Fulll size| | 0009| 0009| Luxury| | 0010| 0010| Premium| | 0011| 0011| Minivan| | 0012| 0012| 12-passenger van| | 0013| 0013| Moving van| | 0014| 0014| 15-passenger van| | 0015| 0015| Cargo van| | 0016| 0016| 12-foot truck| | 0017| 0017| 20-foot truck| | 0018| 0018| 24-foot truck| | 0019| 0019| 26-foot truck| | 0020| 0020| Moped| | 0021| 0021| Stretch| | 0022| 0022| Regular| | 0023| 0023| Unique| | 0024| 0024| Exotic| | 0025| 0025| Small/medium truck| | 0026| 0026| Large truck| | 0027| 0027| Small SUV| | 0028| 0028| Medium SUV| | 0029| 0029| Large SUV| | 0030| 0030| Exotic SUV| | 9999| 9999| Miscellaneous|  Additional Values allowed **only** for &#x60;American Express&#x60;:  |American Express|MasterCard|Description| |- -- |- -- |- -- | | 0031| NA| Four Wheel Drive| | 0032| NA| Special| | 0099| NA| Taxi|  | [optional] 
**DistanceTravelled** | **string** | Total number of miles driven by the customer. This field is supported only for MasterCard and American Express.  | [optional] 
**DistanceUnit** | **string** | Miles/Kilometers Indicator shows whether the “miles” fields are expressed in miles or kilometers.  Allowed values: - &#x60;K&#x60; - Kilometers - &#x60;M&#x60; - Miles  | [optional] 
**ReturnDateTime** | **string** | Date/time the auto was returned to the rental agency. Format: &#x60;&#x60;yyyy-MM-dd HH-mm-ss z&#x60;&#x60; This field is supported for Visa, MasterCard, and American Express.  | [optional] 
**RentalDateTime** | **string** | Date/time the auto was picked up from the rental agency. Format: &#x60;yyyy-MM-dd HH-mm-ss z&#x60; This field is supported for Visa, MasterCard, and American Express.  | [optional] 
**MaxFreeDistance** | **string** | Maximum number of free miles or kilometers allowed to a customer for the duration of the auto rental agreement. This field is supported only for MasterCard and American Express.  | [optional] 
**InsuranceIndicator** | **bool?** | Used for MC and Discover  Valid values: - &#x60;true&#x60; - Yes (insurance was purchased) - &#x60;false&#x60; - No (insurance was not purchased)  | [optional] 
**ProgramCode** | **string** | Used to identify special circumstances applicable to the Card Transaction or Cardholder, such as \&quot;renter” or ”show”.  This code is &#x60;2 digit&#x60; value agreed by Merchant and processor.  | [optional] 
**ReturnAddress** | [**Ptsv2paymentsTravelInformationAutoRentalReturnAddress**](Ptsv2paymentsTravelInformationAutoRentalReturnAddress.md) |  | [optional] 
**RentalAddress** | [**Ptsv2paymentsTravelInformationAutoRentalRentalAddress**](Ptsv2paymentsTravelInformationAutoRentalRentalAddress.md) |  | [optional] 
**AgreementNumber** | **string** | Auto rental agency’s agreement (invoice) number provided to the customer. It is used to trace any inquiries about transactions. This field is supported for Visa, MasterCard, and American Express. This Merchant-defined value, which may be composed of any combination of characters and/or numerals, may become part of the descriptive bill on the Cardmember&#39;s statement.  | [optional] 
**OdometerReading** | **string** | Odometer reading at time of vehicle rental.  | [optional] 
**VehicleIdentificationNumber** | **string** | This field contains a unique identifier assigned by the company to the vehicle.  | [optional] 
**CompanyId** | **string** | Corporate Identifier provides the unique identifier of the corporation or entity renting the vehicle:  |Card Specific Validation|VISA|MasterCard|Discover|AMEX| |- -- |- -- |- -- |- -- | | Filed Length| NA| 12| NA| NA| | Field Type| NA| AN| NA| NA| | M/O/C| NA| O| NA| NA|  | [optional] 
**NumberOfAdditionalDrivers** | **string** | The number of additional drivers included on the rental agreement not including the individual who signed the rental agreement.  | [optional] 
**DriverAge** | **string** | Age of the driver renting the vehicle.  | [optional] 
**SpecialProgramCode** | **string** | Program code used to identify special circumstances, such as “frequent renter” or “no show” status for the renter. Possible values: - &#x60;0&#x60;: not applicable (default) - &#x60;1&#x60;: frequent renter - &#x60;2&#x60;: no show  For authorizations, this field is supported only for Visa.  For captures, this field is supported for Visa, MasterCard, and American Express.  Code for special programs applicable to the Card Transaction or the Cardholder.  | [optional] 
**VehicleMake** | **string** | Make of the vehicle being rented (e.g., Chevrolet or Ford).  | [optional] 
**VehicleModel** | **string** | Model of the vehicle being rented (e.g., Cavalier or Focus).  | [optional] 
**TimePeriod** | **string** | Indicates the time period for which the vehicle rental rate applies (e.g., daily, weekly or monthly). Daily, Weekly and Monthly are valid values.  | [optional] 
**CommodityCode** | **string** | Commodity code or International description code used to classify the item. Contact your acquirer for a list of codes.  | [optional] 
**CustomerServicePhoneNumber** | **string** | Customer service telephone number that is used to resolve questions or disputes. Include the area code, exchange, and number. This field is supported only for MasterCard and American Express.  | [optional] 
**TaxDetails** | [**Ptsv2paymentsTravelInformationAutoRentalTaxDetails**](Ptsv2paymentsTravelInformationAutoRentalTaxDetails.md) |  | [optional] 
**InsuranceAmount** | **string** | Insurance charges. Field is conditional and can include decimal point.  | [optional] 
**OneWayDropOffAmount** | **string** | Extra charges incurred for a one-way rental agreement for the auto. This field is supported only for Visa.  | [optional] 
**AdjustedAmountIndicator** | **string** | For **MasterCard** and **Discover**: Adjusted amount indicator code that indicates any miscellaneous charges incurred after the auto was returned. Possible values: - &#x60;A&#x60; - Drop-off charges - &#x60;B&#x60; - Delivery charges - &#x60;C&#x60; - Parking expenses - &#x60;D&#x60; - Extra hours - &#x60;E&#x60; - Violations - &#x60;X&#x60; - More than one of the above charges  For **American Express**: Audit indicator code that indicates any adjustment for mileage, fuel, auto damage, etc. made to a rental agreement and whether the cardholder was notified.  Possible value for the authorization service: - &#x60;A&#x60; (default): adjustment amount greater than 0 (zero)  Possible values for the capture service: - &#x60;X&#x60; - Multiple adjustments - &#x60;Y&#x60; - One adjustment only; Cardmember notified - &#x60;Z&#x60; - One adjustment only; Cardmember not notified. This value is used as the default if the request does not include this field and includes an adjustment amount greater than 0 (zero). This is an optional field.  | [optional] 
**AdjustedAmount** | **string** | Adjusted Amount indicates whether any miscellaneous charges were incurred after the vehicle was returned.  For authorizations, this field is supported only for American Express.  For captures, this field is supported only for MasterCard and American Express. **NOTE** For American Express, this field is required if the &#x60;travelInformation.autoRental.adjustedAmountIndicator&#x60; field is included in the request and has a value; otherwise, this field is optional.  For all other card types, this field is ignored.  | [optional] 
**FuelCharges** | **string** | Extra gasoline charges that extend beyond the basic rental agreement. This field is supported only for Visa.  | [optional] 
**WeeklyRentalRate** | **string** | Weekly Rental Amount provides the amount charged for a seven-day rental period. Field - Time Period needs to be populated with Weekly if this field is present  | [optional] 
**DailyRentalRate** | **string** | Daily auto rental rate charged. This field is supported only for MasterCard and American Express.  Field - Time Period needs to be populated with Daily if this field is present  | [optional] 
**RatePerMile** | **string** | Rate charged for each mile. This field is supported only for MasterCard and American Express.  | [optional] 
**MileageCharge** | **string** | Regular Mileage Charge provides the amount charged for regular miles traveled during vehicle rental. Two decimal places  | [optional] 
**ExtraMileageCharge** | **string** | Extra mileage charges that extend beyond the basic rental agreement. This field is supported only for Visa.  | [optional] 
**LateFeeAmount** | **string** | Extra charges related to a late return of the rented auto. This field is supported only for Visa.  | [optional] 
**TowingCharge** | **string** | (Towing Charges) provides the amount charged to tow the rental vehicle.  | [optional] 
**ExtraCharge** | **string** | (Extra Charges) provides the extra charges associated with the vehicle rental.  | [optional] 
**GpsCharge** | **string** | Amount charged for renting a Global Positioning Service (GPS).  | [optional] 
**PhoneCharge** | **string** | Additional charges incurred for phone usage included on the total bill.  | [optional] 
**ParkingViolationCharge** | **string** | Extra charges incurred due to a parking violation for the auto. This field is supported only for Visa.  | [optional] 
**OtherCharges** | **string** | Total amount charged for all other miscellaneous charges not previously defined.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
