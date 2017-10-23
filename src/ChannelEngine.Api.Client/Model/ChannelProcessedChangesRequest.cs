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
    /// ChannelProcessedChangesRequest
    /// </summary>
    [DataContract]
    public partial class ChannelProcessedChangesRequest :  IEquatable<ChannelProcessedChangesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelProcessedChangesRequest" /> class.
        /// </summary>
        /// <param name="Created">A collection of pairs of merchant and channel references  of the products which are successfully created. The channel references  are saved such that in subsequent calls these can be used instead of the   merchant references..</param>
        /// <param name="Updated">The channel references of the products which are successfully updated..</param>
        /// <param name="Removed">The channel references of the products which are successfully removed..</param>
        public ChannelProcessedChangesRequest(List<ChannelReferencesRequest> Created = default(List<ChannelReferencesRequest>), List<string> Updated = default(List<string>), List<string> Removed = default(List<string>))
        {
            this.Created = Created;
            this.Updated = Updated;
            this.Removed = Removed;
        }
        
        /// <summary>
        /// A collection of pairs of merchant and channel references  of the products which are successfully created. The channel references  are saved such that in subsequent calls these can be used instead of the   merchant references.
        /// </summary>
        /// <value>A collection of pairs of merchant and channel references  of the products which are successfully created. The channel references  are saved such that in subsequent calls these can be used instead of the   merchant references.</value>
        [DataMember(Name="Created", EmitDefaultValue=false)]
        public List<ChannelReferencesRequest> Created { get; set; }

        /// <summary>
        /// The channel references of the products which are successfully updated.
        /// </summary>
        /// <value>The channel references of the products which are successfully updated.</value>
        [DataMember(Name="Updated", EmitDefaultValue=false)]
        public List<string> Updated { get; set; }

        /// <summary>
        /// The channel references of the products which are successfully removed.
        /// </summary>
        /// <value>The channel references of the products which are successfully removed.</value>
        [DataMember(Name="Removed", EmitDefaultValue=false)]
        public List<string> Removed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelProcessedChangesRequest {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
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
            return this.Equals(input as ChannelProcessedChangesRequest);
        }

        /// <summary>
        /// Returns true if ChannelProcessedChangesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChannelProcessedChangesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelProcessedChangesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    this.Created != null &&
                    this.Created.SequenceEqual(input.Created)
                ) && 
                (
                    this.Updated == input.Updated ||
                    this.Updated != null &&
                    this.Updated.SequenceEqual(input.Updated)
                ) && 
                (
                    this.Removed == input.Removed ||
                    this.Removed != null &&
                    this.Removed.SequenceEqual(input.Removed)
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.Removed != null)
                    hashCode = hashCode * 59 + this.Removed.GetHashCode();
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
