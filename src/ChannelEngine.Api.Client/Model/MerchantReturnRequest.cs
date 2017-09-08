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
    /// MerchantReturnRequest
    /// </summary>
    [DataContract]
    public partial class MerchantReturnRequest :  IEquatable<MerchantReturnRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="MerchantReturnRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MerchantReturnRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantReturnRequest" /> class.
        /// </summary>
        /// <param name="MerchantOrderNo">MerchantOrderNo (required).</param>
        /// <param name="MerchantReturnNo">MerchantReturnNo (required).</param>
        /// <param name="Lines">Lines (required).</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="CustomerComment">CustomerComment.</param>
        /// <param name="MerchantComment">MerchantComment.</param>
        /// <param name="RefundInclVat">RefundInclVat.</param>
        /// <param name="RefundExclVat">RefundExclVat.</param>
        public MerchantReturnRequest(string MerchantOrderNo = default(string), string MerchantReturnNo = default(string), List<MerchantReturnLineRequest> Lines = default(List<MerchantReturnLineRequest>), ReasonEnum? Reason = default(ReasonEnum?), string CustomerComment = default(string), string MerchantComment = default(string), double? RefundInclVat = default(double?), double? RefundExclVat = default(double?))
        {
            // to ensure "MerchantOrderNo" is required (not null)
            if (MerchantOrderNo == null)
            {
                throw new InvalidDataException("MerchantOrderNo is a required property for MerchantReturnRequest and cannot be null");
            }
            else
            {
                this.MerchantOrderNo = MerchantOrderNo;
            }
            // to ensure "MerchantReturnNo" is required (not null)
            if (MerchantReturnNo == null)
            {
                throw new InvalidDataException("MerchantReturnNo is a required property for MerchantReturnRequest and cannot be null");
            }
            else
            {
                this.MerchantReturnNo = MerchantReturnNo;
            }
            // to ensure "Lines" is required (not null)
            if (Lines == null)
            {
                throw new InvalidDataException("Lines is a required property for MerchantReturnRequest and cannot be null");
            }
            else
            {
                this.Lines = Lines;
            }
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
        /// Gets or Sets MerchantReturnNo
        /// </summary>
        [DataMember(Name="MerchantReturnNo", EmitDefaultValue=false)]
        public string MerchantReturnNo { get; set; }
        /// <summary>
        /// Gets or Sets Lines
        /// </summary>
        [DataMember(Name="Lines", EmitDefaultValue=false)]
        public List<MerchantReturnLineRequest> Lines { get; set; }
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
            sb.Append("class MerchantReturnRequest {\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  MerchantReturnNo: ").Append(MerchantReturnNo).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MerchantReturnRequest);
        }

        /// <summary>
        /// Returns true if MerchantReturnRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MerchantReturnRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantReturnRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantOrderNo == other.MerchantOrderNo ||
                    this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(other.MerchantOrderNo)
                ) && 
                (
                    this.MerchantReturnNo == other.MerchantReturnNo ||
                    this.MerchantReturnNo != null &&
                    this.MerchantReturnNo.Equals(other.MerchantReturnNo)
                ) && 
                (
                    this.Lines == other.Lines ||
                    this.Lines != null &&
                    this.Lines.SequenceEqual(other.Lines)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.CustomerComment == other.CustomerComment ||
                    this.CustomerComment != null &&
                    this.CustomerComment.Equals(other.CustomerComment)
                ) && 
                (
                    this.MerchantComment == other.MerchantComment ||
                    this.MerchantComment != null &&
                    this.MerchantComment.Equals(other.MerchantComment)
                ) && 
                (
                    this.RefundInclVat == other.RefundInclVat ||
                    this.RefundInclVat != null &&
                    this.RefundInclVat.Equals(other.RefundInclVat)
                ) && 
                (
                    this.RefundExclVat == other.RefundExclVat ||
                    this.RefundExclVat != null &&
                    this.RefundExclVat.Equals(other.RefundExclVat)
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
                if (this.MerchantOrderNo != null)
                    hash = hash * 59 + this.MerchantOrderNo.GetHashCode();
                if (this.MerchantReturnNo != null)
                    hash = hash * 59 + this.MerchantReturnNo.GetHashCode();
                if (this.Lines != null)
                    hash = hash * 59 + this.Lines.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.CustomerComment != null)
                    hash = hash * 59 + this.CustomerComment.GetHashCode();
                if (this.MerchantComment != null)
                    hash = hash * 59 + this.MerchantComment.GetHashCode();
                if (this.RefundInclVat != null)
                    hash = hash * 59 + this.RefundInclVat.GetHashCode();
                if (this.RefundExclVat != null)
                    hash = hash * 59 + this.RefundExclVat.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // CustomerComment (string) maxLength
            if(this.CustomerComment != null && this.CustomerComment.Length > 4001)
            {
                yield return new ValidationResult("Invalid value for CustomerComment, length must be less than 4001.", new [] { "CustomerComment" });
            }

            // CustomerComment (string) minLength
            if(this.CustomerComment != null && this.CustomerComment.Length < 0)
            {
                yield return new ValidationResult("Invalid value for CustomerComment, length must be greater than 0.", new [] { "CustomerComment" });
            }

            // MerchantComment (string) maxLength
            if(this.MerchantComment != null && this.MerchantComment.Length > 4001)
            {
                yield return new ValidationResult("Invalid value for MerchantComment, length must be less than 4001.", new [] { "MerchantComment" });
            }

            // MerchantComment (string) minLength
            if(this.MerchantComment != null && this.MerchantComment.Length < 0)
            {
                yield return new ValidationResult("Invalid value for MerchantComment, length must be greater than 0.", new [] { "MerchantComment" });
            }

            yield break;
        }
    }

}
