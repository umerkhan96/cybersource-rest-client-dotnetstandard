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
    /// PtsV2PaymentsPost201ResponseOrderInformationAmountDetails
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseOrderInformationAmountDetails :  IEquatable<PtsV2PaymentsPost201ResponseOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="TotalAmount">Amount you requested for the payment or capture.  This value is returned for partial authorizations. This field is also returned on incremental authorizations will contain the aggregated amount from the original authorizations and all the incremental authorizations. .</param>
        /// <param name="AuthorizedAmount">Amount that was authorized.  Returned by authorization service.  #### PIN debit Amount of the purchase.  Returned by PIN debit purchase. .</param>
        /// <param name="Currency">Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency.  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. .</param>
        /// <param name="SettlementAmount">This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder&#39;s account. This field is returned for OCT transactions. .</param>
        /// <param name="SettlementCurrency">This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder&#39;s account. This field is returned for OCT transactions. .</param>
        /// <param name="OriginalAmount">Amount in your original local pricing currency.  This value cannot be negative. You can include a decimal point (.) in this field to denote the currency exponent, but you cannot include any other special characters.  If needed, CyberSource truncates the amount to the correct number of decimal places. .</param>
        /// <param name="OriginalCurrency">Your local pricing currency code.  For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) .</param>
        /// <param name="ProcessorTransactionFee">Amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code. .</param>
        /// <param name="ExchangeRate">The rate of conversion of the currency given in the request to CNY. The conversion happens at the time when Alipay&#39;s trade order is created .</param>
        /// <param name="ForeignCurrency">Currency code for the transaction performed in cross border currency. .</param>
        /// <param name="ForeignAmount">The transaction amount in CNY. .</param>
        /// <param name="DiscountAmount">If coupons/vouchers are used in the transaction, the discount amount redeemed in the settlement currency will be returned. Otherwise, no return. .</param>
        public PtsV2PaymentsPost201ResponseOrderInformationAmountDetails(string TotalAmount = default(string), string AuthorizedAmount = default(string), string Currency = default(string), string SettlementAmount = default(string), string SettlementCurrency = default(string), string OriginalAmount = default(string), string OriginalCurrency = default(string), string ProcessorTransactionFee = default(string), string ExchangeRate = default(string), string ForeignCurrency = default(string), string ForeignAmount = default(string), string DiscountAmount = default(string))
        {
            this.TotalAmount = TotalAmount;
            this.AuthorizedAmount = AuthorizedAmount;
            this.Currency = Currency;
            this.SettlementAmount = SettlementAmount;
            this.SettlementCurrency = SettlementCurrency;
            this.OriginalAmount = OriginalAmount;
            this.OriginalCurrency = OriginalCurrency;
            this.ProcessorTransactionFee = ProcessorTransactionFee;
            this.ExchangeRate = ExchangeRate;
            this.ForeignCurrency = ForeignCurrency;
            this.ForeignAmount = ForeignAmount;
            this.DiscountAmount = DiscountAmount;
        }
        
        /// <summary>
        /// Amount you requested for the payment or capture.  This value is returned for partial authorizations. This field is also returned on incremental authorizations will contain the aggregated amount from the original authorizations and all the incremental authorizations. 
        /// </summary>
        /// <value>Amount you requested for the payment or capture.  This value is returned for partial authorizations. This field is also returned on incremental authorizations will contain the aggregated amount from the original authorizations and all the incremental authorizations. </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Amount that was authorized.  Returned by authorization service.  #### PIN debit Amount of the purchase.  Returned by PIN debit purchase. 
        /// </summary>
        /// <value>Amount that was authorized.  Returned by authorization service.  #### PIN debit Amount of the purchase.  Returned by PIN debit purchase. </value>
        [DataMember(Name="authorizedAmount", EmitDefaultValue=false)]
        public string AuthorizedAmount { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency.  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency.  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder&#39;s account. This field is returned for OCT transactions. 
        /// </summary>
        /// <value>This is a multicurrency field. It contains the transaction amount (field 4), converted to the Currency used to bill the cardholder&#39;s account. This field is returned for OCT transactions. </value>
        [DataMember(Name="settlementAmount", EmitDefaultValue=false)]
        public string SettlementAmount { get; set; }

        /// <summary>
        /// This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder&#39;s account. This field is returned for OCT transactions. 
        /// </summary>
        /// <value>This is a multicurrency-only field. It contains a 3-digit numeric code that identifies the currency used by the issuer to bill the cardholder&#39;s account. This field is returned for OCT transactions. </value>
        [DataMember(Name="settlementCurrency", EmitDefaultValue=false)]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Amount in your original local pricing currency.  This value cannot be negative. You can include a decimal point (.) in this field to denote the currency exponent, but you cannot include any other special characters.  If needed, CyberSource truncates the amount to the correct number of decimal places. 
        /// </summary>
        /// <value>Amount in your original local pricing currency.  This value cannot be negative. You can include a decimal point (.) in this field to denote the currency exponent, but you cannot include any other special characters.  If needed, CyberSource truncates the amount to the correct number of decimal places. </value>
        [DataMember(Name="originalAmount", EmitDefaultValue=false)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// Your local pricing currency code.  For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) 
        /// </summary>
        /// <value>Your local pricing currency code.  For the possible values, see the [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf) </value>
        [DataMember(Name="originalCurrency", EmitDefaultValue=false)]
        public string OriginalCurrency { get; set; }

        /// <summary>
        /// Amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code. 
        /// </summary>
        /// <value>Amount up to N digit after the decimals separator as defined in ISO 4217 for the appropriate currency code. </value>
        [DataMember(Name="processorTransactionFee", EmitDefaultValue=false)]
        public string ProcessorTransactionFee { get; set; }

        /// <summary>
        /// The rate of conversion of the currency given in the request to CNY. The conversion happens at the time when Alipay&#39;s trade order is created 
        /// </summary>
        /// <value>The rate of conversion of the currency given in the request to CNY. The conversion happens at the time when Alipay&#39;s trade order is created </value>
        [DataMember(Name="exchangeRate", EmitDefaultValue=false)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// Currency code for the transaction performed in cross border currency. 
        /// </summary>
        /// <value>Currency code for the transaction performed in cross border currency. </value>
        [DataMember(Name="foreignCurrency", EmitDefaultValue=false)]
        public string ForeignCurrency { get; set; }

        /// <summary>
        /// The transaction amount in CNY. 
        /// </summary>
        /// <value>The transaction amount in CNY. </value>
        [DataMember(Name="foreignAmount", EmitDefaultValue=false)]
        public string ForeignAmount { get; set; }

        /// <summary>
        /// If coupons/vouchers are used in the transaction, the discount amount redeemed in the settlement currency will be returned. Otherwise, no return. 
        /// </summary>
        /// <value>If coupons/vouchers are used in the transaction, the discount amount redeemed in the settlement currency will be returned. Otherwise, no return. </value>
        [DataMember(Name="discountAmount", EmitDefaultValue=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseOrderInformationAmountDetails {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  AuthorizedAmount: ").Append(AuthorizedAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  SettlementAmount: ").Append(SettlementAmount).Append("\n");
            sb.Append("  SettlementCurrency: ").Append(SettlementCurrency).Append("\n");
            sb.Append("  OriginalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  OriginalCurrency: ").Append(OriginalCurrency).Append("\n");
            sb.Append("  ProcessorTransactionFee: ").Append(ProcessorTransactionFee).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ForeignCurrency: ").Append(ForeignCurrency).Append("\n");
            sb.Append("  ForeignAmount: ").Append(ForeignAmount).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.AuthorizedAmount == other.AuthorizedAmount ||
                    this.AuthorizedAmount != null &&
                    this.AuthorizedAmount.Equals(other.AuthorizedAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.SettlementAmount == other.SettlementAmount ||
                    this.SettlementAmount != null &&
                    this.SettlementAmount.Equals(other.SettlementAmount)
                ) && 
                (
                    this.SettlementCurrency == other.SettlementCurrency ||
                    this.SettlementCurrency != null &&
                    this.SettlementCurrency.Equals(other.SettlementCurrency)
                ) && 
                (
                    this.OriginalAmount == other.OriginalAmount ||
                    this.OriginalAmount != null &&
                    this.OriginalAmount.Equals(other.OriginalAmount)
                ) && 
                (
                    this.OriginalCurrency == other.OriginalCurrency ||
                    this.OriginalCurrency != null &&
                    this.OriginalCurrency.Equals(other.OriginalCurrency)
                ) && 
                (
                    this.ProcessorTransactionFee == other.ProcessorTransactionFee ||
                    this.ProcessorTransactionFee != null &&
                    this.ProcessorTransactionFee.Equals(other.ProcessorTransactionFee)
                ) && 
                (
                    this.ExchangeRate == other.ExchangeRate ||
                    this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(other.ExchangeRate)
                ) && 
                (
                    this.ForeignCurrency == other.ForeignCurrency ||
                    this.ForeignCurrency != null &&
                    this.ForeignCurrency.Equals(other.ForeignCurrency)
                ) && 
                (
                    this.ForeignAmount == other.ForeignAmount ||
                    this.ForeignAmount != null &&
                    this.ForeignAmount.Equals(other.ForeignAmount)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.AuthorizedAmount != null)
                    hash = hash * 59 + this.AuthorizedAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.SettlementAmount != null)
                    hash = hash * 59 + this.SettlementAmount.GetHashCode();
                if (this.SettlementCurrency != null)
                    hash = hash * 59 + this.SettlementCurrency.GetHashCode();
                if (this.OriginalAmount != null)
                    hash = hash * 59 + this.OriginalAmount.GetHashCode();
                if (this.OriginalCurrency != null)
                    hash = hash * 59 + this.OriginalCurrency.GetHashCode();
                if (this.ProcessorTransactionFee != null)
                    hash = hash * 59 + this.ProcessorTransactionFee.GetHashCode();
                if (this.ExchangeRate != null)
                    hash = hash * 59 + this.ExchangeRate.GetHashCode();
                if (this.ForeignCurrency != null)
                    hash = hash * 59 + this.ForeignCurrency.GetHashCode();
                if (this.ForeignAmount != null)
                    hash = hash * 59 + this.ForeignAmount.GetHashCode();
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
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
