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
    /// StreamKeyRecordWrapper
    /// </summary>
    [DataContract]
    public partial class StreamKeyRecordWrapper :  IEquatable<StreamKeyRecordWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamKeyRecordWrapper" /> class.
        /// </summary>
        /// <param name="HighlightMatch">highlighted text.</param>
        /// <param name="SortKey">.</param>
        /// <param name="Key">object key.</param>
        public StreamKeyRecordWrapper(string HighlightMatch = null, string SortKey = null, string Key = null)
        {
            this.HighlightMatch = HighlightMatch;
            this.SortKey = SortKey;
            this.Key = Key;
        }
        
        /// <summary>
        /// highlighted text
        /// </summary>
        /// <value>highlighted text</value>
        [DataMember(Name="highlightMatch", EmitDefaultValue=false)]
        public string HighlightMatch { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sort_key", EmitDefaultValue=false)]
        public string SortKey { get; set; }
        /// <summary>
        /// object key
        /// </summary>
        /// <value>object key</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamKeyRecordWrapper {\n");
            sb.Append("  HighlightMatch: ").Append(HighlightMatch).Append("\n");
            sb.Append("  SortKey: ").Append(SortKey).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(obj as StreamKeyRecordWrapper);
        }

        /// <summary>
        /// Returns true if StreamKeyRecordWrapper instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamKeyRecordWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamKeyRecordWrapper other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HighlightMatch == other.HighlightMatch ||
                    this.HighlightMatch != null &&
                    this.HighlightMatch.Equals(other.HighlightMatch)
                ) && 
                (
                    this.SortKey == other.SortKey ||
                    this.SortKey != null &&
                    this.SortKey.Equals(other.SortKey)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
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
                if (this.HighlightMatch != null)
                    hash = hash * 59 + this.HighlightMatch.GetHashCode();
                if (this.SortKey != null)
                    hash = hash * 59 + this.SortKey.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                return hash;
            }
        }
    }

}
