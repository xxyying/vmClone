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
    /// PairContactFilterRecord
    /// </summary>
    [DataContract]
    public partial class PairContactFilterRecord :  IEquatable<PairContactFilterRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PairContactFilterRecord" /> class.
        /// </summary>
        /// <param name="ContactTypes">Types of contact to find.</param>
        /// <param name="Types">Types of contact to find.</param>
        /// <param name="ContactKey">User key to find contacts with relationships to.</param>
        public PairContactFilterRecord(List<string> ContactTypes = null, List<string> Types = null, string ContactKey = null)
        {
            this.ContactTypes = ContactTypes;
            this.Types = Types;
            this.ContactKey = ContactKey;
        }
        
        /// <summary>
        /// Types of contact to find
        /// </summary>
        /// <value>Types of contact to find</value>
        [DataMember(Name="contact_types", EmitDefaultValue=false)]
        public List<string> ContactTypes { get; set; }
        /// <summary>
        /// Types of contact to find
        /// </summary>
        /// <value>Types of contact to find</value>
        [DataMember(Name="types", EmitDefaultValue=false)]
        public List<string> Types { get; set; }
        /// <summary>
        /// User key to find contacts with relationships to
        /// </summary>
        /// <value>User key to find contacts with relationships to</value>
        [DataMember(Name="contact_key", EmitDefaultValue=false)]
        public string ContactKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PairContactFilterRecord {\n");
            sb.Append("  ContactTypes: ").Append(ContactTypes).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
            sb.Append("  ContactKey: ").Append(ContactKey).Append("\n");
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
            return this.Equals(obj as PairContactFilterRecord);
        }

        /// <summary>
        /// Returns true if PairContactFilterRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of PairContactFilterRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PairContactFilterRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContactTypes == other.ContactTypes ||
                    this.ContactTypes != null &&
                    this.ContactTypes.SequenceEqual(other.ContactTypes)
                ) && 
                (
                    this.Types == other.Types ||
                    this.Types != null &&
                    this.Types.SequenceEqual(other.Types)
                ) && 
                (
                    this.ContactKey == other.ContactKey ||
                    this.ContactKey != null &&
                    this.ContactKey.Equals(other.ContactKey)
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
                if (this.ContactTypes != null)
                    hash = hash * 59 + this.ContactTypes.GetHashCode();
                if (this.Types != null)
                    hash = hash * 59 + this.Types.GetHashCode();
                if (this.ContactKey != null)
                    hash = hash * 59 + this.ContactKey.GetHashCode();
                return hash;
            }
        }
    }

}
