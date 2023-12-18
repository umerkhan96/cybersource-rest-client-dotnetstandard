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
    /// Ptsv1pushfundstransferMerchantInformationMerchantDescriptor
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferMerchantInformationMerchantDescriptor :  IEquatable<Ptsv1pushfundstransferMerchantInformationMerchantDescriptor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferMerchantInformationMerchantDescriptor" /> class.
        /// </summary>
        /// <param name="AdministrativeArea">The state where the merchant is located.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf  Note This field is supported only for businesses located in the U.S. or Canada. .</param>
        /// <param name="Contact">For the descriptions, used-by information, data types, and lengths for these fields, see merchant_descriptor_contact field description in Credit Card Services Using the SCMP API.- -&gt; Contact information for the merchant.  Note These are the maximum data lengths for the following payment processors:  FDC Compass (13) Chase Paymentech (13). .</param>
        /// <param name="Country">Merchant&#39;s country.  Country code for your business location. Use the ISO Standard Alpha Country Codes This value might be displayed on the cardholder&#39;s statement.  See https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  Note If your business is located in the U.S. or Canada and you include this field in a request, you must also include merchantInformation.merchantDescriptor.administrativeArea. .</param>
        /// <param name="Locality">Merchant&#39;s City.  City for your business location. This value might be displayed on the cardholder&#39;s statement. .</param>
        /// <param name="Name">Merchant&#39;s business name. This name is displayed on the cardholder&#39;s statement.  Chase Paymentech, Visa Platform Connect: length 22 .</param>
        /// <param name="PostalCode">Merchant&#39;s postal code. This value might be displayed on the cardholder&#39;s statement.  If your business is domiciled in the U.S., you can use a 5-digit or 9-digit postal code. A 9-digit postal code must follow this format: [5 digits][dash][4 digits] Example: 12345-6789  If your business is domiciled in Canada, you can use a 6-digit or 9-digit postal code. A 6-digit postal code must follow this format: [alpha][numeric][alpha][space] [numeric][alpha][numeric] Example: A1B 2C3 .</param>
        public Ptsv1pushfundstransferMerchantInformationMerchantDescriptor(string AdministrativeArea = default(string), string Contact = default(string), string Country = default(string), string Locality = default(string), string Name = default(string), string PostalCode = default(string))
        {
            this.AdministrativeArea = AdministrativeArea;
            this.Contact = Contact;
            this.Country = Country;
            this.Locality = Locality;
            this.Name = Name;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// The state where the merchant is located.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf  Note This field is supported only for businesses located in the U.S. or Canada. 
        /// </summary>
        /// <value>The state where the merchant is located.  See https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf  Note This field is supported only for businesses located in the U.S. or Canada. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// For the descriptions, used-by information, data types, and lengths for these fields, see merchant_descriptor_contact field description in Credit Card Services Using the SCMP API.- -&gt; Contact information for the merchant.  Note These are the maximum data lengths for the following payment processors:  FDC Compass (13) Chase Paymentech (13). 
        /// </summary>
        /// <value>For the descriptions, used-by information, data types, and lengths for these fields, see merchant_descriptor_contact field description in Credit Card Services Using the SCMP API.- -&gt; Contact information for the merchant.  Note These are the maximum data lengths for the following payment processors:  FDC Compass (13) Chase Paymentech (13). </value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Merchant&#39;s country.  Country code for your business location. Use the ISO Standard Alpha Country Codes This value might be displayed on the cardholder&#39;s statement.  See https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  Note If your business is located in the U.S. or Canada and you include this field in a request, you must also include merchantInformation.merchantDescriptor.administrativeArea. 
        /// </summary>
        /// <value>Merchant&#39;s country.  Country code for your business location. Use the ISO Standard Alpha Country Codes This value might be displayed on the cardholder&#39;s statement.  See https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf  Note If your business is located in the U.S. or Canada and you include this field in a request, you must also include merchantInformation.merchantDescriptor.administrativeArea. </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Merchant&#39;s City.  City for your business location. This value might be displayed on the cardholder&#39;s statement. 
        /// </summary>
        /// <value>Merchant&#39;s City.  City for your business location. This value might be displayed on the cardholder&#39;s statement. </value>
        [DataMember(Name="locality", EmitDefaultValue=false)]
        public string Locality { get; set; }

        /// <summary>
        /// Merchant&#39;s business name. This name is displayed on the cardholder&#39;s statement.  Chase Paymentech, Visa Platform Connect: length 22 
        /// </summary>
        /// <value>Merchant&#39;s business name. This name is displayed on the cardholder&#39;s statement.  Chase Paymentech, Visa Platform Connect: length 22 </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Merchant&#39;s postal code. This value might be displayed on the cardholder&#39;s statement.  If your business is domiciled in the U.S., you can use a 5-digit or 9-digit postal code. A 9-digit postal code must follow this format: [5 digits][dash][4 digits] Example: 12345-6789  If your business is domiciled in Canada, you can use a 6-digit or 9-digit postal code. A 6-digit postal code must follow this format: [alpha][numeric][alpha][space] [numeric][alpha][numeric] Example: A1B 2C3 
        /// </summary>
        /// <value>Merchant&#39;s postal code. This value might be displayed on the cardholder&#39;s statement.  If your business is domiciled in the U.S., you can use a 5-digit or 9-digit postal code. A 9-digit postal code must follow this format: [5 digits][dash][4 digits] Example: 12345-6789  If your business is domiciled in Canada, you can use a 6-digit or 9-digit postal code. A 6-digit postal code must follow this format: [alpha][numeric][alpha][space] [numeric][alpha][numeric] Example: A1B 2C3 </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferMerchantInformationMerchantDescriptor {\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Locality: ").Append(Locality).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferMerchantInformationMerchantDescriptor);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferMerchantInformationMerchantDescriptor instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferMerchantInformationMerchantDescriptor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferMerchantInformationMerchantDescriptor other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                ) && 
                (
                    this.Contact == other.Contact ||
                    this.Contact != null &&
                    this.Contact.Equals(other.Contact)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.Locality == other.Locality ||
                    this.Locality != null &&
                    this.Locality.Equals(other.Locality)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
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
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                if (this.Contact != null)
                    hash = hash * 59 + this.Contact.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Locality != null)
                    hash = hash * 59 + this.Locality.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
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
