/* 
 * Vmoso API
 *
 * Vmoso API
 *
 * OpenAPI spec version: 2.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VmosoApiClient.Model
{
    /// <summary>
    /// StreamOptionsV2Record
    /// </summary>
    [DataContract]
    public partial class StreamOptionsV2Record :  IEquatable<StreamOptionsV2Record>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOptionsV2Record" /> class.
        /// </summary>
        /// <param name="RetrieveMetaData">Indicates if the rule metadata needs to be retrieved or not..</param>
        /// <param name="HighlightTag">tag defines keyword highlight.</param>
        /// <param name="Format">return format.</param>
        /// <param name="Filters">Array of FilterOptions..</param>
        /// <param name="RuleKey">Rule key of the rule that needs to be executed to retrieve the objects. Current rule key can be one of the named rules (activities/people/locations)..</param>
        public StreamOptionsV2Record(bool? RetrieveMetaData = null, string HighlightTag = null, string Format = null, List<FilterOptions> Filters = null, string RuleKey = null)
        {
            this.RetrieveMetaData = RetrieveMetaData;
            this.HighlightTag = HighlightTag;
            this.Format = Format;
            this.Filters = Filters;
            this.RuleKey = RuleKey;
        }
        
        /// <summary>
        /// Indicates if the rule metadata needs to be retrieved or not.
        /// </summary>
        /// <value>Indicates if the rule metadata needs to be retrieved or not.</value>
        [DataMember(Name="retrieveMetaData", EmitDefaultValue=false)]
        public bool? RetrieveMetaData { get; set; }
        /// <summary>
        /// tag defines keyword highlight
        /// </summary>
        /// <value>tag defines keyword highlight</value>
        [DataMember(Name="highlightTag", EmitDefaultValue=false)]
        public string HighlightTag { get; set; }
        /// <summary>
        /// return format
        /// </summary>
        /// <value>return format</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }
        /// <summary>
        /// Array of FilterOptions.
        /// </summary>
        /// <value>Array of FilterOptions.</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FilterOptions> Filters { get; set; }
        /// <summary>
        /// Rule key of the rule that needs to be executed to retrieve the objects. Current rule key can be one of the named rules (activities/people/locations).
        /// </summary>
        /// <value>Rule key of the rule that needs to be executed to retrieve the objects. Current rule key can be one of the named rules (activities/people/locations).</value>
        [DataMember(Name="ruleKey", EmitDefaultValue=false)]
        public string RuleKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamOptionsV2Record {\n");
            sb.Append("  RetrieveMetaData: ").Append(RetrieveMetaData).Append("\n");
            sb.Append("  HighlightTag: ").Append(HighlightTag).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  RuleKey: ").Append(RuleKey).Append("\n");
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
            return this.Equals(obj as StreamOptionsV2Record);
        }

        /// <summary>
        /// Returns true if StreamOptionsV2Record instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamOptionsV2Record to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamOptionsV2Record other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RetrieveMetaData == other.RetrieveMetaData ||
                    this.RetrieveMetaData != null &&
                    this.RetrieveMetaData.Equals(other.RetrieveMetaData)
                ) && 
                (
                    this.HighlightTag == other.HighlightTag ||
                    this.HighlightTag != null &&
                    this.HighlightTag.Equals(other.HighlightTag)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) && 
                (
                    this.RuleKey == other.RuleKey ||
                    this.RuleKey != null &&
                    this.RuleKey.Equals(other.RuleKey)
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
                if (this.RetrieveMetaData != null)
                    hash = hash * 59 + this.RetrieveMetaData.GetHashCode();
                if (this.HighlightTag != null)
                    hash = hash * 59 + this.HighlightTag.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.RuleKey != null)
                    hash = hash * 59 + this.RuleKey.GetHashCode();
                return hash;
            }
        }
    }

}
