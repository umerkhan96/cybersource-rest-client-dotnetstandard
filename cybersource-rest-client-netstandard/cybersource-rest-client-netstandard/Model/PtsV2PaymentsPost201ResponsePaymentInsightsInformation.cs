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
    /// PtsV2PaymentsPost201ResponsePaymentInsightsInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInsightsInformation :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInsightsInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInsightsInformation" /> class.
        /// </summary>
        /// <param name="ResponseInsights">ResponseInsights.</param>
        public PtsV2PaymentsPost201ResponsePaymentInsightsInformation(PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights ResponseInsights = default(PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights))
        {
            this.ResponseInsights = ResponseInsights;
        }
        
        /// <summary>
        /// Gets or Sets ResponseInsights
        /// </summary>
        [DataMember(Name="responseInsights", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights ResponseInsights { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInsightsInformation {\n");
            sb.Append("  ResponseInsights: ").Append(ResponseInsights).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInsightsInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInsightsInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInsightsInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInsightsInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResponseInsights == other.ResponseInsights ||
                    this.ResponseInsights != null &&
                    this.ResponseInsights.Equals(other.ResponseInsights)
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
                if (this.ResponseInsights != null)
                    hash = hash * 59 + this.ResponseInsights.GetHashCode();
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