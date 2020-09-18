/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Vasv2taxOrderInformation
    /// </summary>
    [DataContract]
    public partial class Vasv2taxOrderInformation :  IEquatable<Vasv2taxOrderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vasv2taxOrderInformation" /> class.
        /// </summary>
        /// <param name="AmountDetails">AmountDetails.</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="ShippingDetails">ShippingDetails.</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="LineItems">LineItems.</param>
        /// <param name="InvoiceDetails">InvoiceDetails.</param>
        /// <param name="OrderAcceptance">OrderAcceptance.</param>
        /// <param name="OrderOrigin">OrderOrigin.</param>
        public Vasv2taxOrderInformation(RiskV1DecisionsPost201ResponseOrderInformationAmountDetails AmountDetails = default(RiskV1DecisionsPost201ResponseOrderInformationAmountDetails), Vasv2taxOrderInformationBillTo BillTo = default(Vasv2taxOrderInformationBillTo), Vasv2taxOrderInformationShippingDetails ShippingDetails = default(Vasv2taxOrderInformationShippingDetails), Vasv2taxOrderInformationShipTo ShipTo = default(Vasv2taxOrderInformationShipTo), List<Vasv2taxOrderInformationLineItems> LineItems = default(List<Vasv2taxOrderInformationLineItems>), Vasv2taxOrderInformationInvoiceDetails InvoiceDetails = default(Vasv2taxOrderInformationInvoiceDetails), Vasv2taxOrderInformationOrderAcceptance OrderAcceptance = default(Vasv2taxOrderInformationOrderAcceptance), Vasv2taxOrderInformationOrderOrigin OrderOrigin = default(Vasv2taxOrderInformationOrderOrigin))
        {
            this.AmountDetails = AmountDetails;
            this.BillTo = BillTo;
            this.ShippingDetails = ShippingDetails;
            this.ShipTo = ShipTo;
            this.LineItems = LineItems;
            this.InvoiceDetails = InvoiceDetails;
            this.OrderAcceptance = OrderAcceptance;
            this.OrderOrigin = OrderOrigin;
        }
        
        /// <summary>
        /// Gets or Sets AmountDetails
        /// </summary>
        [DataMember(Name="amountDetails", EmitDefaultValue=false)]
        public RiskV1DecisionsPost201ResponseOrderInformationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public Vasv2taxOrderInformationBillTo BillTo { get; set; }

        /// <summary>
        /// Gets or Sets ShippingDetails
        /// </summary>
        [DataMember(Name="shippingDetails", EmitDefaultValue=false)]
        public Vasv2taxOrderInformationShippingDetails ShippingDetails { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="shipTo", EmitDefaultValue=false)]
        public Vasv2taxOrderInformationShipTo ShipTo { get; set; }

        /// <summary>
        /// Gets or Sets LineItems
        /// </summary>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<Vasv2taxOrderInformationLineItems> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceDetails
        /// </summary>
        [DataMember(Name="invoiceDetails", EmitDefaultValue=false)]
        public Vasv2taxOrderInformationInvoiceDetails InvoiceDetails { get; set; }

        /// <summary>
        /// Gets or Sets OrderAcceptance
        /// </summary>
        [DataMember(Name="orderAcceptance", EmitDefaultValue=false)]
        public Vasv2taxOrderInformationOrderAcceptance OrderAcceptance { get; set; }

        /// <summary>
        /// Gets or Sets OrderOrigin
        /// </summary>
        [DataMember(Name="orderOrigin", EmitDefaultValue=false)]
        public Vasv2taxOrderInformationOrderOrigin OrderOrigin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vasv2taxOrderInformation {\n");
            sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  ShippingDetails: ").Append(ShippingDetails).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  InvoiceDetails: ").Append(InvoiceDetails).Append("\n");
            sb.Append("  OrderAcceptance: ").Append(OrderAcceptance).Append("\n");
            sb.Append("  OrderOrigin: ").Append(OrderOrigin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Vasv2taxOrderInformation);
        }

        /// <summary>
        /// Returns true if Vasv2taxOrderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Vasv2taxOrderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vasv2taxOrderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountDetails == other.AmountDetails ||
                    this.AmountDetails != null &&
                    this.AmountDetails.Equals(other.AmountDetails)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this.ShippingDetails == other.ShippingDetails ||
                    this.ShippingDetails != null &&
                    this.ShippingDetails.Equals(other.ShippingDetails)
                ) && 
                (
                    this.ShipTo == other.ShipTo ||
                    this.ShipTo != null &&
                    this.ShipTo.Equals(other.ShipTo)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.InvoiceDetails == other.InvoiceDetails ||
                    this.InvoiceDetails != null &&
                    this.InvoiceDetails.Equals(other.InvoiceDetails)
                ) && 
                (
                    this.OrderAcceptance == other.OrderAcceptance ||
                    this.OrderAcceptance != null &&
                    this.OrderAcceptance.Equals(other.OrderAcceptance)
                ) && 
                (
                    this.OrderOrigin == other.OrderOrigin ||
                    this.OrderOrigin != null &&
                    this.OrderOrigin.Equals(other.OrderOrigin)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AmountDetails != null)
                    hash = hash * 59 + this.AmountDetails.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this.ShippingDetails != null)
                    hash = hash * 59 + this.ShippingDetails.GetHashCode();
                if (this.ShipTo != null)
                    hash = hash * 59 + this.ShipTo.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.InvoiceDetails != null)
                    hash = hash * 59 + this.InvoiceDetails.GetHashCode();
                if (this.OrderAcceptance != null)
                    hash = hash * 59 + this.OrderAcceptance.GetHashCode();
                if (this.OrderOrigin != null)
                    hash = hash * 59 + this.OrderOrigin.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}