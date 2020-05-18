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
    /// Ptsv2paymentsTokenInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsTokenInformation :  IEquatable<Ptsv2paymentsTokenInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsTokenInformation" /> class.
        /// </summary>
        /// <param name="Jti">TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV). .</param>
        /// <param name="TransientTokenJwt">Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result. .</param>
        public Ptsv2paymentsTokenInformation(string Jti = default(string), string TransientTokenJwt = default(string))
        {
            this.Jti = Jti;
            this.TransientTokenJwt = TransientTokenJwt;
        }
        
        /// <summary>
        /// TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV). 
        /// </summary>
        /// <value>TMS Transient Token, 64 hexadecimal id value representing captured payment credentials (including Sensitive Authentication Data, e.g. CVV). </value>
        [DataMember(Name="jti", EmitDefaultValue=false)]
        public string Jti { get; set; }

        /// <summary>
        /// Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result. 
        /// </summary>
        /// <value>Flex API Transient Token encoded as JWT (JSON Web Token), e.g. Flex microform or Unified Payment checkout result. </value>
        [DataMember(Name="transientTokenJwt", EmitDefaultValue=false)]
        public string TransientTokenJwt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsTokenInformation {\n");
            sb.Append("  Jti: ").Append(Jti).Append("\n");
            sb.Append("  TransientTokenJwt: ").Append(TransientTokenJwt).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsTokenInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsTokenInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsTokenInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsTokenInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Jti == other.Jti ||
                    this.Jti != null &&
                    this.Jti.Equals(other.Jti)
                ) && 
                (
                    this.TransientTokenJwt == other.TransientTokenJwt ||
                    this.TransientTokenJwt != null &&
                    this.TransientTokenJwt.Equals(other.TransientTokenJwt)
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
                if (this.Jti != null)
                    hash = hash * 59 + this.Jti.GetHashCode();
                if (this.TransientTokenJwt != null)
                    hash = hash * 59 + this.TransientTokenJwt.GetHashCode();
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
            // Jti (string) maxLength
            if(this.Jti != null && this.Jti.Length >= 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Jti, length must be less than or equal to 64.", new [] { "Jti" });
            }

            yield break;
        }
    }

}