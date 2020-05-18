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
    /// TssV2TransactionsPost201ResponseEmbeddedApplicationInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedApplicationInformation :  IEquatable<TssV2TransactionsPost201ResponseEmbeddedApplicationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedApplicationInformation" /> class.
        /// </summary>
        /// <param name="Status">The status of the submitted transaction..</param>
        /// <param name="ReasonCode">Indicates the reason why a request succeeded or failed and possible action to take if a request fails.  For details, see the appendix of reason codes in the documentation for the relevant payment method. .</param>
        /// <param name="RCode">Indicates whether the service request was successful. Possible values:  - &#x60;-1&#x60;: An error occurred. - &#x60;0&#x60;: The request was declined. - &#x60;1&#x60;: The request was successful.  For details, see &#x60;auth_rcode&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) .</param>
        /// <param name="RFlag">One-word description of the result of the application.  For details, see &#x60;auth_rflag&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) .</param>
        /// <param name="Applications">Applications.</param>
        /// <param name="ReturnCode">The description for this field is not available..</param>
        public TssV2TransactionsPost201ResponseEmbeddedApplicationInformation(string Status = default(string), string ReasonCode = default(string), string RCode = default(string), string RFlag = default(string), List<TssV2TransactionsGet200ResponseApplicationInformationApplications> Applications = default(List<TssV2TransactionsGet200ResponseApplicationInformationApplications>), string ReturnCode = default(string))
        {
            this.Status = Status;
            this.ReasonCode = ReasonCode;
            this.RCode = RCode;
            this.RFlag = RFlag;
            this.Applications = Applications;
            this.ReturnCode = ReturnCode;
        }
        
        /// <summary>
        /// The status of the submitted transaction.
        /// </summary>
        /// <value>The status of the submitted transaction.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates the reason why a request succeeded or failed and possible action to take if a request fails.  For details, see the appendix of reason codes in the documentation for the relevant payment method. 
        /// </summary>
        /// <value>Indicates the reason why a request succeeded or failed and possible action to take if a request fails.  For details, see the appendix of reason codes in the documentation for the relevant payment method. </value>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// Indicates whether the service request was successful. Possible values:  - &#x60;-1&#x60;: An error occurred. - &#x60;0&#x60;: The request was declined. - &#x60;1&#x60;: The request was successful.  For details, see &#x60;auth_rcode&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) 
        /// </summary>
        /// <value>Indicates whether the service request was successful. Possible values:  - &#x60;-1&#x60;: An error occurred. - &#x60;0&#x60;: The request was declined. - &#x60;1&#x60;: The request was successful.  For details, see &#x60;auth_rcode&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) </value>
        [DataMember(Name="rCode", EmitDefaultValue=false)]
        public string RCode { get; set; }

        /// <summary>
        /// One-word description of the result of the application.  For details, see &#x60;auth_rflag&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) 
        /// </summary>
        /// <value>One-word description of the result of the application.  For details, see &#x60;auth_rflag&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) </value>
        [DataMember(Name="rFlag", EmitDefaultValue=false)]
        public string RFlag { get; set; }

        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<TssV2TransactionsGet200ResponseApplicationInformationApplications> Applications { get; set; }

        /// <summary>
        /// The description for this field is not available.
        /// </summary>
        /// <value>The description for this field is not available.</value>
        [DataMember(Name="returnCode", EmitDefaultValue=false)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedApplicationInformation {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
            sb.Append("  RCode: ").Append(RCode).Append("\n");
            sb.Append("  RFlag: ").Append(RFlag).Append("\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  ReturnCode: ").Append(ReturnCode).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedApplicationInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedApplicationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedApplicationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedApplicationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.ReasonCode == other.ReasonCode ||
                    this.ReasonCode != null &&
                    this.ReasonCode.Equals(other.ReasonCode)
                ) && 
                (
                    this.RCode == other.RCode ||
                    this.RCode != null &&
                    this.RCode.Equals(other.RCode)
                ) && 
                (
                    this.RFlag == other.RFlag ||
                    this.RFlag != null &&
                    this.RFlag.Equals(other.RFlag)
                ) && 
                (
                    this.Applications == other.Applications ||
                    this.Applications != null &&
                    this.Applications.SequenceEqual(other.Applications)
                ) && 
                (
                    this.ReturnCode == other.ReturnCode ||
                    this.ReturnCode != null &&
                    this.ReturnCode.Equals(other.ReturnCode)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.ReasonCode != null)
                    hash = hash * 59 + this.ReasonCode.GetHashCode();
                if (this.RCode != null)
                    hash = hash * 59 + this.RCode.GetHashCode();
                if (this.RFlag != null)
                    hash = hash * 59 + this.RFlag.GetHashCode();
                if (this.Applications != null)
                    hash = hash * 59 + this.Applications.GetHashCode();
                if (this.ReturnCode != null)
                    hash = hash * 59 + this.ReturnCode.GetHashCode();
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