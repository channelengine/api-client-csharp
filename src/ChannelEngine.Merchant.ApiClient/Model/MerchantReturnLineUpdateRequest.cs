/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.0.0
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
using SwaggerDateConverter = ChannelEngine.Merchant.ApiClient.Client.SwaggerDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// MerchantReturnLineUpdateRequest
    /// </summary>
    [DataContract]
    public partial class MerchantReturnLineUpdateRequest :  IEquatable<MerchantReturnLineUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnLineUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnLineUpdateRequest" /> class.
        /// </summary>
        /// <param name="merchantProductNo">The unique product reference used by the Merchant (sku) (required).</param>
        /// <param name="acceptedQuantity">The amount of items that have been accepted (required).</param>
        /// <param name="rejectedQuantity">The amount of items that have been rejected (required).</param>
        public MerchantReturnLineUpdateRequest(string merchantProductNo = default(string), int? acceptedQuantity = default(int?), int? rejectedQuantity = default(int?))
        {
            // to ensure "merchantProductNo" is required (not null)
            if (merchantProductNo == null)
            {
                throw new InvalidDataException("merchantProductNo is a required property for MerchantReturnLineUpdateRequest and cannot be null");
            }
            else
            {
                this.MerchantProductNo = merchantProductNo;
            }
            // to ensure "acceptedQuantity" is required (not null)
            if (acceptedQuantity == null)
            {
                throw new InvalidDataException("acceptedQuantity is a required property for MerchantReturnLineUpdateRequest and cannot be null");
            }
            else
            {
                this.AcceptedQuantity = acceptedQuantity;
            }
            // to ensure "rejectedQuantity" is required (not null)
            if (rejectedQuantity == null)
            {
                throw new InvalidDataException("rejectedQuantity is a required property for MerchantReturnLineUpdateRequest and cannot be null");
            }
            else
            {
                this.RejectedQuantity = rejectedQuantity;
            }
        }
        
        /// <summary>
        /// The unique product reference used by the Merchant (sku)
        /// </summary>
        /// <value>The unique product reference used by the Merchant (sku)</value>
        [DataMember(Name="MerchantProductNo", EmitDefaultValue=false)]
        public string MerchantProductNo { get; set; }

        /// <summary>
        /// The amount of items that have been accepted
        /// </summary>
        /// <value>The amount of items that have been accepted</value>
        [DataMember(Name="AcceptedQuantity", EmitDefaultValue=false)]
        public int? AcceptedQuantity { get; set; }

        /// <summary>
        /// The amount of items that have been rejected
        /// </summary>
        /// <value>The amount of items that have been rejected</value>
        [DataMember(Name="RejectedQuantity", EmitDefaultValue=false)]
        public int? RejectedQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnLineUpdateRequest {\n");
            sb.Append("  MerchantProductNo: ").Append(MerchantProductNo).Append("\n");
            sb.Append("  AcceptedQuantity: ").Append(AcceptedQuantity).Append("\n");
            sb.Append("  RejectedQuantity: ").Append(RejectedQuantity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MerchantReturnLineUpdateRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnLineUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnLineUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnLineUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantProductNo == input.MerchantProductNo ||
                    (this.MerchantProductNo != null &&
                    this.MerchantProductNo.Equals(input.MerchantProductNo))
                ) && 
                (
                    this.AcceptedQuantity == input.AcceptedQuantity ||
                    (this.AcceptedQuantity != null &&
                    this.AcceptedQuantity.Equals(input.AcceptedQuantity))
                ) && 
                (
                    this.RejectedQuantity == input.RejectedQuantity ||
                    (this.RejectedQuantity != null &&
                    this.RejectedQuantity.Equals(input.RejectedQuantity))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.MerchantProductNo != null)
                    hashCode = hashCode * 59 + this.MerchantProductNo.GetHashCode();
                if (this.AcceptedQuantity != null)
                    hashCode = hashCode * 59 + this.AcceptedQuantity.GetHashCode();
                if (this.RejectedQuantity != null)
                    hashCode = hashCode * 59 + this.RejectedQuantity.GetHashCode();
                return hashCode;
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
