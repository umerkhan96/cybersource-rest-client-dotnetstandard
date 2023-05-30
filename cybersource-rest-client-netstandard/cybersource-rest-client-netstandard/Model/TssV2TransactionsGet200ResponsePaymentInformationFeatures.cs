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
    /// TssV2TransactionsGet200ResponsePaymentInformationFeatures
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationFeatures :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationFeatures>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationFeatures" /> class.
        /// </summary>
        /// <param name="AccountFundingSource">This field contains the account funding source. Possible values:   - &#x60;CREDIT&#x60;   - &#x60;DEBIT&#x60;   - &#x60;PREPAID&#x60;   - &#x60;DEFERRED DEBIT&#x60;   - &#x60;CHARGE&#x60; .</param>
        /// <param name="AccountFundingSourceSubType">This field contains the type of prepaid card. Possible values:   - &#x60;Reloadable&#x60;   - &#x60;Non-reloadable&#x60; .</param>
        /// <param name="CardProduct">This field contains the type of issuer product. Example values:   - Visa Classic   - Visa Signature   - Visa Infinite .</param>
        /// <param name="MessageType">This field contains the type of BIN based authentication. Possible values:   - &#x60;S&#x60;: Single Message   - &#x60;D&#x60;: Dual Message .</param>
        /// <param name="AcceptanceLevel">This field contains the acceptance level of the PAN. Possible values:   - &#x60;0&#x60; : Normal   - &#x60;1&#x60; : Monitor   - &#x60;2&#x60; : Refuse   - &#x60;3&#x60; : Not Allowed   - &#x60;4&#x60; : Private   - &#x60;5&#x60; : Test .</param>
        /// <param name="CardPlatform">This field contains the type of card platform. Possible values:   - &#x60;BUSINESS&#x60;   - &#x60;CONSUMER&#x60;   - &#x60;COMMERCIAL&#x60;   - &#x60;GOVERNMENT&#x60; .</param>
        /// <param name="ComboCard">This field indicates the type of combo card. Possible values:   - 0 (Not a combo card)   - 1 (Credit and Prepaid Combo card)   - 2 (Credit and Debit Combo card) .</param>
        public TssV2TransactionsGet200ResponsePaymentInformationFeatures(string AccountFundingSource = default(string), string AccountFundingSourceSubType = default(string), string CardProduct = default(string), string MessageType = default(string), string AcceptanceLevel = default(string), string CardPlatform = default(string), string ComboCard = default(string))
        {
            this.AccountFundingSource = AccountFundingSource;
            this.AccountFundingSourceSubType = AccountFundingSourceSubType;
            this.CardProduct = CardProduct;
            this.MessageType = MessageType;
            this.AcceptanceLevel = AcceptanceLevel;
            this.CardPlatform = CardPlatform;
            this.ComboCard = ComboCard;
        }
        
        /// <summary>
        /// This field contains the account funding source. Possible values:   - &#x60;CREDIT&#x60;   - &#x60;DEBIT&#x60;   - &#x60;PREPAID&#x60;   - &#x60;DEFERRED DEBIT&#x60;   - &#x60;CHARGE&#x60; 
        /// </summary>
        /// <value>This field contains the account funding source. Possible values:   - &#x60;CREDIT&#x60;   - &#x60;DEBIT&#x60;   - &#x60;PREPAID&#x60;   - &#x60;DEFERRED DEBIT&#x60;   - &#x60;CHARGE&#x60; </value>
        [DataMember(Name="accountFundingSource", EmitDefaultValue=false)]
        public string AccountFundingSource { get; set; }

        /// <summary>
        /// This field contains the type of prepaid card. Possible values:   - &#x60;Reloadable&#x60;   - &#x60;Non-reloadable&#x60; 
        /// </summary>
        /// <value>This field contains the type of prepaid card. Possible values:   - &#x60;Reloadable&#x60;   - &#x60;Non-reloadable&#x60; </value>
        [DataMember(Name="accountFundingSourceSubType", EmitDefaultValue=false)]
        public string AccountFundingSourceSubType { get; set; }

        /// <summary>
        /// This field contains the type of issuer product. Example values:   - Visa Classic   - Visa Signature   - Visa Infinite 
        /// </summary>
        /// <value>This field contains the type of issuer product. Example values:   - Visa Classic   - Visa Signature   - Visa Infinite </value>
        [DataMember(Name="cardProduct", EmitDefaultValue=false)]
        public string CardProduct { get; set; }

        /// <summary>
        /// This field contains the type of BIN based authentication. Possible values:   - &#x60;S&#x60;: Single Message   - &#x60;D&#x60;: Dual Message 
        /// </summary>
        /// <value>This field contains the type of BIN based authentication. Possible values:   - &#x60;S&#x60;: Single Message   - &#x60;D&#x60;: Dual Message </value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// This field contains the acceptance level of the PAN. Possible values:   - &#x60;0&#x60; : Normal   - &#x60;1&#x60; : Monitor   - &#x60;2&#x60; : Refuse   - &#x60;3&#x60; : Not Allowed   - &#x60;4&#x60; : Private   - &#x60;5&#x60; : Test 
        /// </summary>
        /// <value>This field contains the acceptance level of the PAN. Possible values:   - &#x60;0&#x60; : Normal   - &#x60;1&#x60; : Monitor   - &#x60;2&#x60; : Refuse   - &#x60;3&#x60; : Not Allowed   - &#x60;4&#x60; : Private   - &#x60;5&#x60; : Test </value>
        [DataMember(Name="acceptanceLevel", EmitDefaultValue=false)]
        public string AcceptanceLevel { get; set; }

        /// <summary>
        /// This field contains the type of card platform. Possible values:   - &#x60;BUSINESS&#x60;   - &#x60;CONSUMER&#x60;   - &#x60;COMMERCIAL&#x60;   - &#x60;GOVERNMENT&#x60; 
        /// </summary>
        /// <value>This field contains the type of card platform. Possible values:   - &#x60;BUSINESS&#x60;   - &#x60;CONSUMER&#x60;   - &#x60;COMMERCIAL&#x60;   - &#x60;GOVERNMENT&#x60; </value>
        [DataMember(Name="cardPlatform", EmitDefaultValue=false)]
        public string CardPlatform { get; set; }

        /// <summary>
        /// This field indicates the type of combo card. Possible values:   - 0 (Not a combo card)   - 1 (Credit and Prepaid Combo card)   - 2 (Credit and Debit Combo card) 
        /// </summary>
        /// <value>This field indicates the type of combo card. Possible values:   - 0 (Not a combo card)   - 1 (Credit and Prepaid Combo card)   - 2 (Credit and Debit Combo card) </value>
        [DataMember(Name="comboCard", EmitDefaultValue=false)]
        public string ComboCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationFeatures {\n");
            sb.Append("  AccountFundingSource: ").Append(AccountFundingSource).Append("\n");
            sb.Append("  AccountFundingSourceSubType: ").Append(AccountFundingSourceSubType).Append("\n");
            sb.Append("  CardProduct: ").Append(CardProduct).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  AcceptanceLevel: ").Append(AcceptanceLevel).Append("\n");
            sb.Append("  CardPlatform: ").Append(CardPlatform).Append("\n");
            sb.Append("  ComboCard: ").Append(ComboCard).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationFeatures);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationFeatures instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationFeatures to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationFeatures other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountFundingSource == other.AccountFundingSource ||
                    this.AccountFundingSource != null &&
                    this.AccountFundingSource.Equals(other.AccountFundingSource)
                ) && 
                (
                    this.AccountFundingSourceSubType == other.AccountFundingSourceSubType ||
                    this.AccountFundingSourceSubType != null &&
                    this.AccountFundingSourceSubType.Equals(other.AccountFundingSourceSubType)
                ) && 
                (
                    this.CardProduct == other.CardProduct ||
                    this.CardProduct != null &&
                    this.CardProduct.Equals(other.CardProduct)
                ) && 
                (
                    this.MessageType == other.MessageType ||
                    this.MessageType != null &&
                    this.MessageType.Equals(other.MessageType)
                ) && 
                (
                    this.AcceptanceLevel == other.AcceptanceLevel ||
                    this.AcceptanceLevel != null &&
                    this.AcceptanceLevel.Equals(other.AcceptanceLevel)
                ) && 
                (
                    this.CardPlatform == other.CardPlatform ||
                    this.CardPlatform != null &&
                    this.CardPlatform.Equals(other.CardPlatform)
                ) && 
                (
                    this.ComboCard == other.ComboCard ||
                    this.ComboCard != null &&
                    this.ComboCard.Equals(other.ComboCard)
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
                if (this.AccountFundingSource != null)
                    hash = hash * 59 + this.AccountFundingSource.GetHashCode();
                if (this.AccountFundingSourceSubType != null)
                    hash = hash * 59 + this.AccountFundingSourceSubType.GetHashCode();
                if (this.CardProduct != null)
                    hash = hash * 59 + this.CardProduct.GetHashCode();
                if (this.MessageType != null)
                    hash = hash * 59 + this.MessageType.GetHashCode();
                if (this.AcceptanceLevel != null)
                    hash = hash * 59 + this.AcceptanceLevel.GetHashCode();
                if (this.CardPlatform != null)
                    hash = hash * 59 + this.CardPlatform.GetHashCode();
                if (this.ComboCard != null)
                    hash = hash * 59 + this.ComboCard.GetHashCode();
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