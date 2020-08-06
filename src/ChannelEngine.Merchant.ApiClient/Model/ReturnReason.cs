/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = ChannelEngine.Merchant.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// Defines ReturnReason
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReturnReason
    {
        /// <summary>
        /// Enum PRODUCTDEFECT for value: PRODUCT_DEFECT
        /// </summary>
        [EnumMember(Value = "PRODUCT_DEFECT")]
        PRODUCTDEFECT = 1,

        /// <summary>
        /// Enum PRODUCTUNSATISFACTORY for value: PRODUCT_UNSATISFACTORY
        /// </summary>
        [EnumMember(Value = "PRODUCT_UNSATISFACTORY")]
        PRODUCTUNSATISFACTORY = 2,

        /// <summary>
        /// Enum WRONGPRODUCT for value: WRONG_PRODUCT
        /// </summary>
        [EnumMember(Value = "WRONG_PRODUCT")]
        WRONGPRODUCT = 3,

        /// <summary>
        /// Enum TOOMANYPRODUCTS for value: TOO_MANY_PRODUCTS
        /// </summary>
        [EnumMember(Value = "TOO_MANY_PRODUCTS")]
        TOOMANYPRODUCTS = 4,

        /// <summary>
        /// Enum REFUSED for value: REFUSED
        /// </summary>
        [EnumMember(Value = "REFUSED")]
        REFUSED = 5,

        /// <summary>
        /// Enum REFUSEDDAMAGED for value: REFUSED_DAMAGED
        /// </summary>
        [EnumMember(Value = "REFUSED_DAMAGED")]
        REFUSEDDAMAGED = 6,

        /// <summary>
        /// Enum WRONGADDRESS for value: WRONG_ADDRESS
        /// </summary>
        [EnumMember(Value = "WRONG_ADDRESS")]
        WRONGADDRESS = 7,

        /// <summary>
        /// Enum NOTCOLLECTED for value: NOT_COLLECTED
        /// </summary>
        [EnumMember(Value = "NOT_COLLECTED")]
        NOTCOLLECTED = 8,

        /// <summary>
        /// Enum WRONGSIZE for value: WRONG_SIZE
        /// </summary>
        [EnumMember(Value = "WRONG_SIZE")]
        WRONGSIZE = 9,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 10

    }

}