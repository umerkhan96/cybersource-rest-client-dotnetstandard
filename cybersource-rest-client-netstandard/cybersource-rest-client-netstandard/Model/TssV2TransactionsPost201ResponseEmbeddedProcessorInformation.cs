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
    /// TssV2TransactionsPost201ResponseEmbeddedProcessorInformation
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsPost201ResponseEmbeddedProcessorInformation : IEquatable<TssV2TransactionsPost201ResponseEmbeddedProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsPost201ResponseEmbeddedProcessorInformation" /> class.
        /// </summary>
        /// <param name="Processor">Processor.</param>
        /// <param name="ApprovalCode">Authorization code. Returned only when the processor returns this value.  The length of this value depends on your processor.  Returned by authorization service.  #### PIN debit Authorization code that is returned by the processor.  Returned by PIN debit credit.  #### Elavon Encrypted Account Number Program The returned value is OFFLINE.  #### TSYS Acquiring Solutions The returned value for a successful zero amount authorization is 000000. .</param>
        public TssV2TransactionsPost201ResponseEmbeddedProcessorInformation(TssV2TransactionsGet200ResponseProcessorInformationProcessor Processor = default(TssV2TransactionsGet200ResponseProcessorInformationProcessor), string ApprovalCode = default(string), string RetrievalReferenceNumber = default(string))
        {
            this.Processor = Processor;
            this.ApprovalCode = ApprovalCode;
            this.RetrievalReferenceNumber = RetrievalReferenceNumber;
        }

        /// <summary>
        /// Gets or Sets Processor
        /// </summary>
        [DataMember(Name = "processor", EmitDefaultValue = false)]
        public TssV2TransactionsGet200ResponseProcessorInformationProcessor Processor { get; set; }

        /// <summary>
        /// Authorization code. Returned only when the processor returns this value.  The length of this value depends on your processor.  Returned by authorization service.  #### PIN debit Authorization code that is returned by the processor.  Returned by PIN debit credit.  #### Elavon Encrypted Account Number Program The returned value is OFFLINE.  #### TSYS Acquiring Solutions The returned value for a successful zero amount authorization is 000000. 
        /// </summary>
        /// <value>Authorization code. Returned only when the processor returns this value.  The length of this value depends on your processor.  Returned by authorization service.  #### PIN debit Authorization code that is returned by the processor.  Returned by PIN debit credit.  #### Elavon Encrypted Account Number Program The returned value is OFFLINE.  #### TSYS Acquiring Solutions The returned value for a successful zero amount authorization is 000000. </value>
        [DataMember(Name = "approvalCode", EmitDefaultValue = false)]
        public string ApprovalCode { get; set; }

        [DataMember(Name = "retrievalReferenceNumber", EmitDefaultValue = false)]
        public string RetrievalReferenceNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsPost201ResponseEmbeddedProcessorInformation {\n");
            sb.Append("  Processor: ").Append(Processor).Append("\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  RetrievalReferenceNumber: ").Append(RetrievalReferenceNumber).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsPost201ResponseEmbeddedProcessorInformation);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsPost201ResponseEmbeddedProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsPost201ResponseEmbeddedProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsPost201ResponseEmbeddedProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return
                (
                    this.Processor == other.Processor ||
                    this.Processor != null &&
                    this.Processor.Equals(other.Processor)
                ) &&
                (
                    this.ApprovalCode == other.ApprovalCode ||
                    this.ApprovalCode != null &&
                    this.ApprovalCode.Equals(other.ApprovalCode)
                ) &&
                (
                    this.RetrievalReferenceNumber == other.RetrievalReferenceNumber ||
                    this.RetrievalReferenceNumber != null &&
                    this.RetrievalReferenceNumber.Equals(other.RetrievalReferenceNumber)
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
                if (this.Processor != null)
                    hash = hash * 59 + this.Processor.GetHashCode();
                if (this.ApprovalCode != null)
                    hash = hash * 59 + this.ApprovalCode.GetHashCode();
                if (this.RetrievalReferenceNumber != null)
                    hash = hash * 59 + this.RetrievalReferenceNumber.GetHashCode();
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
