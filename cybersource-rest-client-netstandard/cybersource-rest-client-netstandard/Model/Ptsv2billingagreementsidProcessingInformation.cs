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
    /// Ptsv2billingagreementsidProcessingInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2billingagreementsidProcessingInformation :  IEquatable<Ptsv2billingagreementsidProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2billingagreementsidProcessingInformation" /> class.
        /// </summary>
        /// <param name="CommerceIndicator">Type of transaction. Used to determine fees based on channel.  Possible values:    - aesk: American Express SafeKey authentication was successful.   - aesk_attempted: American Express SafeKey authentication was attempted but did not succeed. • install: Installment payment.   - install_internet: Non-U.S. e-commerce (Internet) installment payment. This value is supported only on Visa Platform Connect.   - internet (default for authorizations): E-commerce order placed using a web site.   - js: JCB J/Secure authentication was successful.   - js_attempted: JCB J/Secure authentication was attempted but did not succeed.   - moto: Mail order or telephone order.   - moto_cc: Mail order or telephone order from a call center. This value is supported only on the Asia, Middle East, and Africa Gateway.   - pb: ProtectBuy authentication was successful.   - pb_attempted: ProtectBuy authentication was attempted but did not succeed.   - recurring: Recurring payment that is a U.S. transaction or non-U.S. mail order / telephone order (MOTO) transaction.   - recurring_internet: Recurring payment that is a non-U.S. e-commerce (Internet) transaction.   - retail: Card-present transaction.   - spa: For Mastercard Identity Check: Authentication was successful or was attempted but did not succeed. The e-commerce indicator for all Mastercard Identity Check transactions, including authentication attempts, must be set to spa.   - spa_attempted: Authentication for a co-badged Mastercard and Cartes Bancaires card was attempted but did not succeed.   - spa_failure: – For Mastercard Identity Check: Authentication failed. This value is supported only on Elavon, HSBC, and Streamline.   - vbv: – For Visa Secure: Authentication was successful.   - vbv_attempted: – For Visa Secure: Authentication was attempted but did not succeed.   - vbv_failure: – For Visa Secure: Authentication failed. This value is supported only on HSBC and Streamline. .</param>
        /// <param name="ActionList">- Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service. - Use &#x60;BILLING_AGREEMENT_CREATE&#x60; when Paypal billing agreements service is requested. - Use &#x60;UPDATE_AGREEMENT&#x60; - Use &#x60;CANCEL_AGREEMENT&#x60; - Use &#x60;AP_UPDATE_AGREEMENT&#x60; when Alternative Payment update mandate service is requested. - Use &#x60;AP_CANCEL_AGREEMENT&#x60; when Alternative Payment revoke mandate service is requested. - Use &#x60;AP_REFRESH_AGREEMENT_STATUS&#x60; when Alternative Payment mandate status service is requested. .</param>
        public Ptsv2billingagreementsidProcessingInformation(string CommerceIndicator = default(string), List<string> ActionList = default(List<string>))
        {
            this.CommerceIndicator = CommerceIndicator;
            this.ActionList = ActionList;
        }
        
        /// <summary>
        /// Type of transaction. Used to determine fees based on channel.  Possible values:    - aesk: American Express SafeKey authentication was successful.   - aesk_attempted: American Express SafeKey authentication was attempted but did not succeed. • install: Installment payment.   - install_internet: Non-U.S. e-commerce (Internet) installment payment. This value is supported only on Visa Platform Connect.   - internet (default for authorizations): E-commerce order placed using a web site.   - js: JCB J/Secure authentication was successful.   - js_attempted: JCB J/Secure authentication was attempted but did not succeed.   - moto: Mail order or telephone order.   - moto_cc: Mail order or telephone order from a call center. This value is supported only on the Asia, Middle East, and Africa Gateway.   - pb: ProtectBuy authentication was successful.   - pb_attempted: ProtectBuy authentication was attempted but did not succeed.   - recurring: Recurring payment that is a U.S. transaction or non-U.S. mail order / telephone order (MOTO) transaction.   - recurring_internet: Recurring payment that is a non-U.S. e-commerce (Internet) transaction.   - retail: Card-present transaction.   - spa: For Mastercard Identity Check: Authentication was successful or was attempted but did not succeed. The e-commerce indicator for all Mastercard Identity Check transactions, including authentication attempts, must be set to spa.   - spa_attempted: Authentication for a co-badged Mastercard and Cartes Bancaires card was attempted but did not succeed.   - spa_failure: – For Mastercard Identity Check: Authentication failed. This value is supported only on Elavon, HSBC, and Streamline.   - vbv: – For Visa Secure: Authentication was successful.   - vbv_attempted: – For Visa Secure: Authentication was attempted but did not succeed.   - vbv_failure: – For Visa Secure: Authentication failed. This value is supported only on HSBC and Streamline. 
        /// </summary>
        /// <value>Type of transaction. Used to determine fees based on channel.  Possible values:    - aesk: American Express SafeKey authentication was successful.   - aesk_attempted: American Express SafeKey authentication was attempted but did not succeed. • install: Installment payment.   - install_internet: Non-U.S. e-commerce (Internet) installment payment. This value is supported only on Visa Platform Connect.   - internet (default for authorizations): E-commerce order placed using a web site.   - js: JCB J/Secure authentication was successful.   - js_attempted: JCB J/Secure authentication was attempted but did not succeed.   - moto: Mail order or telephone order.   - moto_cc: Mail order or telephone order from a call center. This value is supported only on the Asia, Middle East, and Africa Gateway.   - pb: ProtectBuy authentication was successful.   - pb_attempted: ProtectBuy authentication was attempted but did not succeed.   - recurring: Recurring payment that is a U.S. transaction or non-U.S. mail order / telephone order (MOTO) transaction.   - recurring_internet: Recurring payment that is a non-U.S. e-commerce (Internet) transaction.   - retail: Card-present transaction.   - spa: For Mastercard Identity Check: Authentication was successful or was attempted but did not succeed. The e-commerce indicator for all Mastercard Identity Check transactions, including authentication attempts, must be set to spa.   - spa_attempted: Authentication for a co-badged Mastercard and Cartes Bancaires card was attempted but did not succeed.   - spa_failure: – For Mastercard Identity Check: Authentication failed. This value is supported only on Elavon, HSBC, and Streamline.   - vbv: – For Visa Secure: Authentication was successful.   - vbv_attempted: – For Visa Secure: Authentication was attempted but did not succeed.   - vbv_failure: – For Visa Secure: Authentication failed. This value is supported only on HSBC and Streamline. </value>
        [DataMember(Name="commerceIndicator", EmitDefaultValue=false)]
        public string CommerceIndicator { get; set; }

        /// <summary>
        /// - Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service. - Use &#x60;BILLING_AGREEMENT_CREATE&#x60; when Paypal billing agreements service is requested. - Use &#x60;UPDATE_AGREEMENT&#x60; - Use &#x60;CANCEL_AGREEMENT&#x60; - Use &#x60;AP_UPDATE_AGREEMENT&#x60; when Alternative Payment update mandate service is requested. - Use &#x60;AP_CANCEL_AGREEMENT&#x60; when Alternative Payment revoke mandate service is requested. - Use &#x60;AP_REFRESH_AGREEMENT_STATUS&#x60; when Alternative Payment mandate status service is requested. 
        /// </summary>
        /// <value>- Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service. - Use &#x60;BILLING_AGREEMENT_CREATE&#x60; when Paypal billing agreements service is requested. - Use &#x60;UPDATE_AGREEMENT&#x60; - Use &#x60;CANCEL_AGREEMENT&#x60; - Use &#x60;AP_UPDATE_AGREEMENT&#x60; when Alternative Payment update mandate service is requested. - Use &#x60;AP_CANCEL_AGREEMENT&#x60; when Alternative Payment revoke mandate service is requested. - Use &#x60;AP_REFRESH_AGREEMENT_STATUS&#x60; when Alternative Payment mandate status service is requested. </value>
        [DataMember(Name="actionList", EmitDefaultValue=false)]
        public List<string> ActionList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2billingagreementsidProcessingInformation {\n");
            sb.Append("  CommerceIndicator: ").Append(CommerceIndicator).Append("\n");
            sb.Append("  ActionList: ").Append(ActionList).Append("\n");
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
            return this.Equals(obj as Ptsv2billingagreementsidProcessingInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2billingagreementsidProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2billingagreementsidProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2billingagreementsidProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommerceIndicator == other.CommerceIndicator ||
                    this.CommerceIndicator != null &&
                    this.CommerceIndicator.Equals(other.CommerceIndicator)
                ) && 
                (
                    this.ActionList == other.ActionList ||
                    this.ActionList != null &&
                    this.ActionList.SequenceEqual(other.ActionList)
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
                if (this.CommerceIndicator != null)
                    hash = hash * 59 + this.CommerceIndicator.GetHashCode();
                if (this.ActionList != null)
                    hash = hash * 59 + this.ActionList.GetHashCode();
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