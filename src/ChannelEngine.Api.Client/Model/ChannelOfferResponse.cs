/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.4.1
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
using SwaggerDateConverter = ChannelEngine.Api.Client.Client.SwaggerDateConverter;

namespace ChannelEngine.Api.Client.Model
{
    /// <summary>
    /// ChannelOfferResponse
    /// </summary>
    [DataContract]
    public partial class ChannelOfferResponse :  IEquatable<ChannelOfferResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelOfferResponse" /> class.
        /// </summary>
        /// <param name="ChannelProductNo">ChannelProductNo.</param>
        /// <param name="Price">Price.</param>
        /// <param name="Stock">Stock.</param>
        public ChannelOfferResponse(string ChannelProductNo = default(string), double? Price = default(double?), int? Stock = default(int?))
        {
            this.ChannelProductNo = ChannelProductNo;
            this.Price = Price;
            this.Stock = Stock;
        }
        
        /// <summary>
        /// Gets or Sets ChannelProductNo
        /// </summary>
        [DataMember(Name="ChannelProductNo", EmitDefaultValue=false)]
        public string ChannelProductNo { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="Price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets Stock
        /// </summary>
        [DataMember(Name="Stock", EmitDefaultValue=false)]
        public int? Stock { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelOfferResponse {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Stock: ").Append(Stock).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChannelOfferResponse);
        }

        /// <summary>
        /// Returns true if ChannelOfferResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelOfferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelOfferResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChannelProductNo == input.ChannelProductNo ||
                    (this.ChannelProductNo != null &&
                    this.ChannelProductNo.Equals(input.ChannelProductNo))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Stock == input.Stock ||
                    (this.Stock != null &&
                    this.Stock.Equals(input.Stock))
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
                if (this.ChannelProductNo != null)
                    hashCode = hashCode * 59 + this.ChannelProductNo.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Stock != null)
                    hashCode = hashCode * 59 + this.Stock.GetHashCode();
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
