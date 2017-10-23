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
    /// MerchantReturnResponse
    /// </summary>
    [DataContract]
    public partial class MerchantReturnResponse :  IEquatable<MerchantReturnResponse>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReasonEnum
        {
            
            /// <summary>
            /// Enum PRODUCTDEFECT for "PRODUCT_DEFECT"
            /// </summary>
            [EnumMember(Value = "PRODUCT_DEFECT")]
            PRODUCTDEFECT,
            
            /// <summary>
            /// Enum PRODUCTUNSATISFACTORY for "PRODUCT_UNSATISFACTORY"
            /// </summary>
            [EnumMember(Value = "PRODUCT_UNSATISFACTORY")]
            PRODUCTUNSATISFACTORY,
            
            /// <summary>
            /// Enum REFUSED for "REFUSED"
            /// </summary>
            [EnumMember(Value = "REFUSED")]
            REFUSED,
            
            /// <summary>
            /// Enum REFUSEDDAMAGED for "REFUSED_DAMAGED"
            /// </summary>
            [EnumMember(Value = "REFUSED_DAMAGED")]
            REFUSEDDAMAGED,
            
            /// <summary>
            /// Enum WRONGADDRESS for "WRONG_ADDRESS"
            /// </summary>
            [EnumMember(Value = "WRONG_ADDRESS")]
            WRONGADDRESS,
            
            /// <summary>
            /// Enum NOTCOLLECTED for "NOT_COLLECTED"
            /// </summary>
            [EnumMember(Value = "NOT_COLLECTED")]
            NOTCOLLECTED,
            
            /// <summary>
            /// Enum OTHER for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="Reason", EmitDefaultValue=false)]
        public ReasonEnum? Reason { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnResponse" /> class.
        /// </summary>
        /// <param name="MerchantOrderNo">MerchantOrderNo.</param>
        /// <param name="Lines">Lines.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="CustomerComment">CustomerComment.</param>
        /// <param name="MerchantComment">MerchantComment.</param>
        /// <param name="RefundInclVat">RefundInclVat.</param>
        /// <param name="RefundExclVat">RefundExclVat.</param>
        public MerchantReturnResponse(string MerchantOrderNo = default(string), List<MerchantReturnLineResponse> Lines = default(List<MerchantReturnLineResponse>), ReasonEnum? Reason = default(ReasonEnum?), string CustomerComment = default(string), string MerchantComment = default(string), double? RefundInclVat = default(double?), double? RefundExclVat = default(double?))
        {
            this.MerchantOrderNo = MerchantOrderNo;
            this.Lines = Lines;
            this.Reason = Reason;
            this.CustomerComment = CustomerComment;
            this.MerchantComment = MerchantComment;
            this.RefundInclVat = RefundInclVat;
            this.RefundExclVat = RefundExclVat;
        }
        
        /// <summary>
        /// Gets or Sets MerchantOrderNo
        /// </summary>
        [DataMember(Name="MerchantOrderNo", EmitDefaultValue=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<MerchantReturnLineResponse> Lines { get; set; }


        /// <summary>
        /// Gets or Sets CustomerComment
        /// </summary>
        [DataMember(Name="CustomerComment", EmitDefaultValue=false)]
        public string CustomerComment { get; set; }

        /// <summary>
        /// Gets or Sets MerchantComment
        /// </summary>
        [DataMember(Name="MerchantComment", EmitDefaultValue=false)]
        public string MerchantComment { get; set; }

        /// <summary>
        /// Gets or Sets RefundInclVat
        /// </summary>
        [DataMember(Name="RefundInclVat", EmitDefaultValue=false)]
        public double? RefundInclVat { get; set; }

        /// <summary>
        /// Gets or Sets RefundExclVat
        /// </summary>
        [DataMember(Name="RefundExclVat", EmitDefaultValue=false)]
        public double? RefundExclVat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantReturnResponse {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  Lines: ").Append(Lines).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  CustomerComment: ").Append(CustomerComment).Append("\n");
            sb.Append("  MerchantComment: ").Append(MerchantComment).Append("\n");
            sb.Append("  RefundInclVat: ").Append(RefundInclVat).Append("\n");
            sb.Append("  RefundExclVat: ").Append(RefundExclVat).Append("\n");
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
            return this.Equals(input as MerchantReturnResponse);
        }

        /// <summary>
        /// Returns true if MerchantReturnResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantReturnResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.Lines == input.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(input.Lines)
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.CustomerComment == input.CustomerComment ||
                    (this.CustomerComment != null &&
                    this.CustomerComment.Equals(input.CustomerComment))
                ) && 
                (
                    this.MerchantComment == input.MerchantComment ||
                    (this.MerchantComment != null &&
                    this.MerchantComment.Equals(input.MerchantComment))
                ) && 
                (
                    this.RefundInclVat == input.RefundInclVat ||
                    (this.RefundInclVat != null &&
                    this.RefundInclVat.Equals(input.RefundInclVat))
                ) && 
                (
                    this.RefundExclVat == input.RefundExclVat ||
                    (this.RefundExclVat != null &&
                    this.RefundExclVat.Equals(input.RefundExclVat))
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
                if (this.MerchantOrderNo != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.Lines != null)
                    hashCode = hashCode * 59 + this.Lines.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.CustomerComment != null)
                    hashCode = hashCode * 59 + this.CustomerComment.GetHashCode();
                if (this.MerchantComment != null)
                    hashCode = hashCode * 59 + this.MerchantComment.GetHashCode();
                if (this.RefundInclVat != null)
                    hashCode = hashCode * 59 + this.RefundInclVat.GetHashCode();
                if (this.RefundExclVat != null)
                    hashCode = hashCode * 59 + this.RefundExclVat.GetHashCode();
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
            // CustomerComment (string) maxLength
            if(this.CustomerComment != null && this.CustomerComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be less than 4001.", new [] { "CustomerComment" });
            }

            // CustomerComment (string) minLength
            if(this.CustomerComment != null && this.CustomerComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerComment, length must be greater than 0.", new [] { "CustomerComment" });
            }

            // MerchantComment (string) maxLength
            if(this.MerchantComment != null && this.MerchantComment.Length > 4001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be less than 4001.", new [] { "MerchantComment" });
            }

            // MerchantComment (string) minLength
            if(this.MerchantComment != null && this.MerchantComment.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantComment, length must be greater than 0.", new [] { "MerchantComment" });
            }

            yield break;
        }
    }

}
