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
    /// TypeFilterV2Record
    /// </summary>
    [DataContract]
    public partial class TypeFilterV2Record :  IEquatable<TypeFilterV2Record>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeFilterV2Record" /> class.
        /// </summary>
        /// <param name="Type">Type:.</param>
        /// <param name="Subtypes">SubTypes:.</param>
        public TypeFilterV2Record(string Type = null, List<string> Subtypes = null)
        {
            this.Type = Type;
            this.Subtypes = Subtypes;
        }
        
        /// <summary>
        /// Type:
        /// </summary>
        /// <value>Type:</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// SubTypes:
        /// </summary>
        /// <value>SubTypes:</value>
        [DataMember(Name="subtypes", EmitDefaultValue=false)]
        public List<string> Subtypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypeFilterV2Record {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Subtypes: ").Append(Subtypes).Append("\n");
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
            return this.Equals(obj as TypeFilterV2Record);
        }

        /// <summary>
        /// Returns true if TypeFilterV2Record instances are equal
        /// </summary>
        /// <param name="other">Instance of TypeFilterV2Record to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypeFilterV2Record other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Subtypes == other.Subtypes ||
                    this.Subtypes != null &&
                    this.Subtypes.SequenceEqual(other.Subtypes)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Subtypes != null)
                    hash = hash * 59 + this.Subtypes.GetHashCode();
                return hash;
            }
        }
    }

}
