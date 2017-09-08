/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.3.0
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

namespace ChannelEngine.Api.Client.Model
{
    /// <summary>
    /// ChannelCancellationLineResponse
    /// </summary>
    [DataContract]
    public partial class ChannelCancellationLineResponse :  IEquatable<ChannelCancellationLineResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCancellationLineResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChannelCancellationLineResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCancellationLineResponse" /> class.
        /// </summary>
        /// <param name="ChannelProductNo">ChannelProductNo (required).</param>
        /// <param name="Quantity">Quantity (required).</param>
        public ChannelCancellationLineResponse(string ChannelProductNo = default(string), int? Quantity = default(int?))
        {
            // to ensure "ChannelProductNo" is required (not null)
            if (ChannelProductNo == null)
            {
                throw new InvalidDataException("ChannelProductNo is a required property for ChannelCancellationLineResponse and cannot be null");
            }
            else
            {
                this.ChannelProductNo = ChannelProductNo;
            }
            // to ensure "Quantity" is required (not null)
            if (Quantity == null)
            {
                throw new InvalidDataException("Quantity is a required property for ChannelCancellationLineResponse and cannot be null");
            }
            else
            {
                this.Quantity = Quantity;
            }
        }
        
        /// <summary>
        /// Gets or Sets ChannelProductNo
        /// </summary>
        [DataMember(Name="ChannelProductNo", EmitDefaultValue=false)]
        public string ChannelProductNo { get; set; }
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="Quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelCancellationLineResponse {\n");
            sb.Append("  ChannelProductNo: ").Append(ChannelProductNo).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(obj as ChannelCancellationLineResponse);
        }

        /// <summary>
        /// Returns true if ChannelCancellationLineResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelCancellationLineResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelCancellationLineResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChannelProductNo == other.ChannelProductNo ||
                    this.ChannelProductNo != null &&
                    this.ChannelProductNo.Equals(other.ChannelProductNo)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                if (this.ChannelProductNo != null)
                    hash = hash * 59 + this.ChannelProductNo.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
