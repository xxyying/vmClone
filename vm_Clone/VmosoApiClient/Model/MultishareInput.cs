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
    /// MultishareInput
    /// </summary>
    [DataContract]
    public partial class MultishareInput :  IEquatable<MultishareInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultishareInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultishareInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultishareInput" /> class.
        /// </summary>
        /// <param name="Options">Options (required).</param>
        /// <param name="Destinationkeys">.</param>
        /// <param name="Itemkeys">.</param>
        public MultishareInput(SpaceShareOptionsRecord Options = null, List<string> Destinationkeys = null, List<string> Itemkeys = null)
        {
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for MultishareInput and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            this.Destinationkeys = Destinationkeys;
            this.Itemkeys = Itemkeys;
        }
        
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public SpaceShareOptionsRecord Options { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="destinationkeys", EmitDefaultValue=false)]
        public List<string> Destinationkeys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="itemkeys", EmitDefaultValue=false)]
        public List<string> Itemkeys { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultishareInput {\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Destinationkeys: ").Append(Destinationkeys).Append("\n");
            sb.Append("  Itemkeys: ").Append(Itemkeys).Append("\n");
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
            return this.Equals(obj as MultishareInput);
        }

        /// <summary>
        /// Returns true if MultishareInput instances are equal
        /// </summary>
        /// <param name="other">Instance of MultishareInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultishareInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.Destinationkeys == other.Destinationkeys ||
                    this.Destinationkeys != null &&
                    this.Destinationkeys.SequenceEqual(other.Destinationkeys)
                ) && 
                (
                    this.Itemkeys == other.Itemkeys ||
                    this.Itemkeys != null &&
                    this.Itemkeys.SequenceEqual(other.Itemkeys)
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
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.Destinationkeys != null)
                    hash = hash * 59 + this.Destinationkeys.GetHashCode();
                if (this.Itemkeys != null)
                    hash = hash * 59 + this.Itemkeys.GetHashCode();
                return hash;
            }
        }
    }

}