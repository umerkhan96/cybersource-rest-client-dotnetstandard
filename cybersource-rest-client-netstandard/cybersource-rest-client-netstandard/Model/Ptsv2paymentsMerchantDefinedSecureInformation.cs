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
    /// The object containing the secure data that the merchant defines. 
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsMerchantDefinedSecureInformation :  IEquatable<Ptsv2paymentsMerchantDefinedSecureInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsMerchantDefinedSecureInformation" /> class.
        /// </summary>
        /// <param name="Secure1">The value you assign for your merchant-secure data field 1. .</param>
        /// <param name="Secure2">The value you assign for your merchant-secure data field 2. .</param>
        /// <param name="Secure3">The value you assign for your merchant-secure data field 3. .</param>
        /// <param name="Secure4">The value you assign for your merchant-secure data field 4. .</param>
        public Ptsv2paymentsMerchantDefinedSecureInformation(string Secure1 = default(string), string Secure2 = default(string), string Secure3 = default(string), string Secure4 = default(string))
        {
            this.Secure1 = Secure1;
            this.Secure2 = Secure2;
            this.Secure3 = Secure3;
            this.Secure4 = Secure4;
        }
        
        /// <summary>
        /// The value you assign for your merchant-secure data field 1. 
        /// </summary>
        /// <value>The value you assign for your merchant-secure data field 1. </value>
        [DataMember(Name="secure1", EmitDefaultValue=false)]
        public string Secure1 { get; set; }

        /// <summary>
        /// The value you assign for your merchant-secure data field 2. 
        /// </summary>
        /// <value>The value you assign for your merchant-secure data field 2. </value>
        [DataMember(Name="secure2", EmitDefaultValue=false)]
        public string Secure2 { get; set; }

        /// <summary>
        /// The value you assign for your merchant-secure data field 3. 
        /// </summary>
        /// <value>The value you assign for your merchant-secure data field 3. </value>
        [DataMember(Name="secure3", EmitDefaultValue=false)]
        public string Secure3 { get; set; }

        /// <summary>
        /// The value you assign for your merchant-secure data field 4. 
        /// </summary>
        /// <value>The value you assign for your merchant-secure data field 4. </value>
        [DataMember(Name="secure4", EmitDefaultValue=false)]
        public string Secure4 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsMerchantDefinedSecureInformation {\n");
            sb.Append("  Secure1: ").Append(Secure1).Append("\n");
            sb.Append("  Secure2: ").Append(Secure2).Append("\n");
            sb.Append("  Secure3: ").Append(Secure3).Append("\n");
            sb.Append("  Secure4: ").Append(Secure4).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsMerchantDefinedSecureInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsMerchantDefinedSecureInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsMerchantDefinedSecureInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsMerchantDefinedSecureInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Secure1 == other.Secure1 ||
                    this.Secure1 != null &&
                    this.Secure1.Equals(other.Secure1)
                ) && 
                (
                    this.Secure2 == other.Secure2 ||
                    this.Secure2 != null &&
                    this.Secure2.Equals(other.Secure2)
                ) && 
                (
                    this.Secure3 == other.Secure3 ||
                    this.Secure3 != null &&
                    this.Secure3.Equals(other.Secure3)
                ) && 
                (
                    this.Secure4 == other.Secure4 ||
                    this.Secure4 != null &&
                    this.Secure4.Equals(other.Secure4)
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
                if (this.Secure1 != null)
                    hash = hash * 59 + this.Secure1.GetHashCode();
                if (this.Secure2 != null)
                    hash = hash * 59 + this.Secure2.GetHashCode();
                if (this.Secure3 != null)
                    hash = hash * 59 + this.Secure3.GetHashCode();
                if (this.Secure4 != null)
                    hash = hash * 59 + this.Secure4.GetHashCode();
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