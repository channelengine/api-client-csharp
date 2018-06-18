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
    /// OrderFilter
    /// </summary>
    [DataContract]
    public partial class OrderFilter :  IEquatable<OrderFilter>, IValidatableObject
    {
        /// <summary>
        /// Defines Statuses
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusesEnum
        {
            
            /// <summary>
            /// Enum INPROGRESS for value: IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            INPROGRESS = 1,
            
            /// <summary>
            /// Enum SHIPPED for value: SHIPPED
            /// </summary>
            [EnumMember(Value = "SHIPPED")]
            SHIPPED = 2,
            
            /// <summary>
            /// Enum INBACKORDER for value: IN_BACKORDER
            /// </summary>
            [EnumMember(Value = "IN_BACKORDER")]
            INBACKORDER = 3,
            
            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            [EnumMember(Value = "CANCELED")]
            CANCELED = 4,
            
            /// <summary>
            /// Enum MANCO for value: MANCO
            /// </summary>
            [EnumMember(Value = "MANCO")]
            MANCO = 5,
            
            /// <summary>
            /// Enum INCOMBI for value: IN_COMBI
            /// </summary>
            [EnumMember(Value = "IN_COMBI")]
            INCOMBI = 6,
            
            /// <summary>
            /// Enum CLOSED for value: CLOSED
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED = 7,
            
            /// <summary>
            /// Enum NEW for value: NEW
            /// </summary>
            [EnumMember(Value = "NEW")]
            NEW = 8,
            
            /// <summary>
            /// Enum RETURNED for value: RETURNED
            /// </summary>
            [EnumMember(Value = "RETURNED")]
            RETURNED = 9,
            
            /// <summary>
            /// Enum REQUIRESCORRECTION for value: REQUIRES_CORRECTION
            /// </summary>
            [EnumMember(Value = "REQUIRES_CORRECTION")]
            REQUIRESCORRECTION = 10
        }


        /// <summary>
        /// Order status(es) to filter on
        /// </summary>
        /// <value>Order status(es) to filter on</value>
        [DataMember(Name="Statuses", EmitDefaultValue=false)]
        public List<StatusesEnum> Statuses { get; set; }
        /// <summary>
        /// Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.
        /// </summary>
        /// <value>Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FulfillmentTypeEnum
        {
            
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 1,
            
            /// <summary>
            /// Enum ONLYMERCHANT for value: ONLY_MERCHANT
            /// </summary>
            [EnumMember(Value = "ONLY_MERCHANT")]
            ONLYMERCHANT = 2,
            
            /// <summary>
            /// Enum ONLYCHANNEL for value: ONLY_CHANNEL
            /// </summary>
            [EnumMember(Value = "ONLY_CHANNEL")]
            ONLYCHANNEL = 3,
            
            /// <summary>
            /// Enum MIXED for value: MIXED
            /// </summary>
            [EnumMember(Value = "MIXED")]
            MIXED = 4
        }

        /// <summary>
        /// Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.
        /// </summary>
        /// <value>Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true.</value>
        [DataMember(Name="FulfillmentType", EmitDefaultValue=false)]
        public FulfillmentTypeEnum? FulfillmentType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFilter" /> class.
        /// </summary>
        /// <param name="statuses">Order status(es) to filter on.</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant.</param>
        /// <param name="excludeMarketplaceFulfilledOrdersAndLines">Exclude order (lines) fulfilled by the marketplace (amazon:FBA, bol:LVB, etc.).</param>
        /// <param name="fulfillmentType">Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true..</param>
        /// <param name="page">The page to filter on. Starts at 1..</param>
        public OrderFilter(List<StatusesEnum> statuses = default(List<StatusesEnum>), List<string> merchantOrderNos = default(List<string>), bool? excludeMarketplaceFulfilledOrdersAndLines = default(bool?), FulfillmentTypeEnum? fulfillmentType = default(FulfillmentTypeEnum?), int? page = default(int?))
        {
            this.Statuses = statuses;
            this.MerchantOrderNos = merchantOrderNos;
            this.ExcludeMarketplaceFulfilledOrdersAndLines = excludeMarketplaceFulfilledOrdersAndLines;
            this.FulfillmentType = fulfillmentType;
            this.Page = page;
        }
        

        /// <summary>
        /// Filter on unique order reference used by the merchant
        /// </summary>
        /// <value>Filter on unique order reference used by the merchant</value>
        [DataMember(Name="MerchantOrderNos", EmitDefaultValue=false)]
        public List<string> MerchantOrderNos { get; set; }

        /// <summary>
        /// Exclude order (lines) fulfilled by the marketplace (amazon:FBA, bol:LVB, etc.)
        /// </summary>
        /// <value>Exclude order (lines) fulfilled by the marketplace (amazon:FBA, bol:LVB, etc.)</value>
        [DataMember(Name="ExcludeMarketplaceFulfilledOrdersAndLines", EmitDefaultValue=false)]
        public bool? ExcludeMarketplaceFulfilledOrdersAndLines { get; set; }


        /// <summary>
        /// The page to filter on. Starts at 1.
        /// </summary>
        /// <value>The page to filter on. Starts at 1.</value>
        [DataMember(Name="Page", EmitDefaultValue=false)]
        public int? Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderFilter {\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  MerchantOrderNos: ").Append(MerchantOrderNos).Append("\n");
            sb.Append("  ExcludeMarketplaceFulfilledOrdersAndLines: ").Append(ExcludeMarketplaceFulfilledOrdersAndLines).Append("\n");
            sb.Append("  FulfillmentType: ").Append(FulfillmentType).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as OrderFilter);
        }

        /// <summary>
        /// Returns true if OrderFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Statuses == input.Statuses ||
                    this.Statuses != null &&
                    this.Statuses.SequenceEqual(input.Statuses)
                ) && 
                (
                    this.MerchantOrderNos == input.MerchantOrderNos ||
                    this.MerchantOrderNos != null &&
                    this.MerchantOrderNos.SequenceEqual(input.MerchantOrderNos)
                ) && 
                (
                    this.ExcludeMarketplaceFulfilledOrdersAndLines == input.ExcludeMarketplaceFulfilledOrdersAndLines ||
                    (this.ExcludeMarketplaceFulfilledOrdersAndLines != null &&
                    this.ExcludeMarketplaceFulfilledOrdersAndLines.Equals(input.ExcludeMarketplaceFulfilledOrdersAndLines))
                ) && 
                (
                    this.FulfillmentType == input.FulfillmentType ||
                    (this.FulfillmentType != null &&
                    this.FulfillmentType.Equals(input.FulfillmentType))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.Statuses != null)
                    hashCode = hashCode * 59 + this.Statuses.GetHashCode();
                if (this.MerchantOrderNos != null)
                    hashCode = hashCode * 59 + this.MerchantOrderNos.GetHashCode();
                if (this.ExcludeMarketplaceFulfilledOrdersAndLines != null)
                    hashCode = hashCode * 59 + this.ExcludeMarketplaceFulfilledOrdersAndLines.GetHashCode();
                if (this.FulfillmentType != null)
                    hashCode = hashCode * 59 + this.FulfillmentType.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
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
