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
    /// FraudMarkingActionRequest
    /// </summary>
    [DataContract]
    public partial class FraudMarkingActionRequest :  IEquatable<FraudMarkingActionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudMarkingActionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FraudMarkingActionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FraudMarkingActionRequest" /> class.
        /// </summary>
        /// <param name="RiskInformation">RiskInformation (required).</param>
        /// <param name="ClientReferenceInformation">ClientReferenceInformation.</param>
        public FraudMarkingActionRequest(Riskv1decisionsidmarkingRiskInformation RiskInformation = default(Riskv1decisionsidmarkingRiskInformation), Riskv1liststypeentriesClientReferenceInformation ClientReferenceInformation = default(Riskv1liststypeentriesClientReferenceInformation))
        {
            this.RiskInformation = RiskInformation;
            this.ClientReferenceInformation = ClientReferenceInformation;
        }
        
        /// <summary>
        /// Gets or Sets RiskInformation
        /// </summary>
        [DataMember(Name="riskInformation", EmitDefaultValue=false)]
        public Riskv1decisionsidmarkingRiskInformation RiskInformation { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferenceInformation
        /// </summary>
        [DataMember(Name="clientReferenceInformation", EmitDefaultValue=false)]
        public Riskv1liststypeentriesClientReferenceInformation ClientReferenceInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FraudMarkingActionRequest {\n");
            sb.Append("  RiskInformation: ").Append(RiskInformation).Append("\n");
            sb.Append("  ClientReferenceInformation: ").Append(ClientReferenceInformation).Append("\n");
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
            return this.Equals(obj as FraudMarkingActionRequest);
        }

        /// <summary>
        /// Returns true if FraudMarkingActionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of FraudMarkingActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FraudMarkingActionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RiskInformation == other.RiskInformation ||
                    this.RiskInformation != null &&
                    this.RiskInformation.Equals(other.RiskInformation)
                ) && 
                (
                    this.ClientReferenceInformation == other.ClientReferenceInformation ||
                    this.ClientReferenceInformation != null &&
                    this.ClientReferenceInformation.Equals(other.ClientReferenceInformation)
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
                if (this.RiskInformation != null)
                    hash = hash * 59 + this.RiskInformation.GetHashCode();
                if (this.ClientReferenceInformation != null)
                    hash = hash * 59 + this.ClientReferenceInformation.GetHashCode();
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
