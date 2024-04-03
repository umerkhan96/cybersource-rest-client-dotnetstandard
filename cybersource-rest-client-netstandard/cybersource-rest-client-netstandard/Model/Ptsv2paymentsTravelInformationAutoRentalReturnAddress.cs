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
    /// Ptsv2paymentsTravelInformationAutoRentalReturnAddress
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsTravelInformationAutoRentalReturnAddress :  IEquatable<Ptsv2paymentsTravelInformationAutoRentalReturnAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsTravelInformationAutoRentalReturnAddress" /> class.
        /// </summary>
        /// <param name="City">City where the auto was returned to the rental agency. .</param>
        /// <param name="State">State in which the auto was returned to the rental agency. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  For authorizations, this field is supported for Visa, MasterCard, and American Express.  For captures, this field is supported only for MasterCard and American Express. .</param>
        /// <param name="Country">Country where the auto was returned to the rental agency. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf). .</param>
        /// <param name="LocationId">Code, address, phone number, etc. used to identify the location of the auto rental return. This field is supported only for MasterCard and American Express. .</param>
        /// <param name="Address1">When merchant wants to send the rental address&#39;s street address. .</param>
        /// <param name="PostalCode">When merchant wants to send the return address&#39;s postal code. .</param>
        /// <param name="Location">This field contains the location where the taxi passenger was dropped off or where the auto rental vehicle was returned. .</param>
        public Ptsv2paymentsTravelInformationAutoRentalReturnAddress(string City = default(string), string State = default(string), string Country = default(string), string LocationId = default(string), string Address1 = default(string), string PostalCode = default(string), string Location = default(string))
        {
            this.City = City;
            this.State = State;
            this.Country = Country;
            this.LocationId = LocationId;
            this.Address1 = Address1;
            this.PostalCode = PostalCode;
            this.Location = Location;
        }
        
        /// <summary>
        /// City where the auto was returned to the rental agency. 
        /// </summary>
        /// <value>City where the auto was returned to the rental agency. </value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// State in which the auto was returned to the rental agency. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  For authorizations, this field is supported for Visa, MasterCard, and American Express.  For captures, this field is supported only for MasterCard and American Express. 
        /// </summary>
        /// <value>State in which the auto was returned to the rental agency. Use the [State, Province, and Territory Codes for the United States and Canada](https://developer.cybersource.com/library/documentation/sbc/quickref/states_and_provinces.pdf).  For authorizations, this field is supported for Visa, MasterCard, and American Express.  For captures, this field is supported only for MasterCard and American Express. </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Country where the auto was returned to the rental agency. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf). 
        /// </summary>
        /// <value>Country where the auto was returned to the rental agency. Use the [ISO Standard Country Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/countries_alpha_list.pdf). </value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Code, address, phone number, etc. used to identify the location of the auto rental return. This field is supported only for MasterCard and American Express. 
        /// </summary>
        /// <value>Code, address, phone number, etc. used to identify the location of the auto rental return. This field is supported only for MasterCard and American Express. </value>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public string LocationId { get; set; }

        /// <summary>
        /// When merchant wants to send the rental address&#39;s street address. 
        /// </summary>
        /// <value>When merchant wants to send the rental address&#39;s street address. </value>
        [DataMember(Name="address1", EmitDefaultValue=false)]
        public string Address1 { get; set; }

        /// <summary>
        /// When merchant wants to send the return address&#39;s postal code. 
        /// </summary>
        /// <value>When merchant wants to send the return address&#39;s postal code. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// This field contains the location where the taxi passenger was dropped off or where the auto rental vehicle was returned. 
        /// </summary>
        /// <value>This field contains the location where the taxi passenger was dropped off or where the auto rental vehicle was returned. </value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsTravelInformationAutoRentalReturnAddress {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsTravelInformationAutoRentalReturnAddress);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsTravelInformationAutoRentalReturnAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsTravelInformationAutoRentalReturnAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsTravelInformationAutoRentalReturnAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Address1 == other.Address1 ||
                    this.Address1 != null &&
                    this.Address1.Equals(other.Address1)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.Address1 != null)
                    hash = hash * 59 + this.Address1.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
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
