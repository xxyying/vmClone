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
    /// MarkFavoritesInput
    /// </summary>
    [DataContract]
    public partial class MarkFavoritesInput :  IEquatable<MarkFavoritesInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkFavoritesInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarkFavoritesInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarkFavoritesInput" /> class.
        /// </summary>
        /// <param name="ObjectKeys">.</param>
        /// <param name="Value"> (required).</param>
        public MarkFavoritesInput(List<string> ObjectKeys = null, int? Value = null)
        {
            // to ensure "Value" is required (not null)
            if (Value == null)
            {
                throw new InvalidDataException("Value is a required property for MarkFavoritesInput and cannot be null");
            }
            else
            {
                this.Value = Value;
            }
            this.ObjectKeys = ObjectKeys;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="objectKeys", EmitDefaultValue=false)]
        public List<string> ObjectKeys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarkFavoritesInput {\n");
            sb.Append("  ObjectKeys: ").Append(ObjectKeys).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as MarkFavoritesInput);
        }

        /// <summary>
        /// Returns true if MarkFavoritesInput instances are equal
        /// </summary>
        /// <param name="other">Instance of MarkFavoritesInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarkFavoritesInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectKeys == other.ObjectKeys ||
                    this.ObjectKeys != null &&
                    this.ObjectKeys.SequenceEqual(other.ObjectKeys)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.ObjectKeys != null)
                    hash = hash * 59 + this.ObjectKeys.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
