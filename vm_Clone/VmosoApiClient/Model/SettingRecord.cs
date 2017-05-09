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
    /// SettingRecord
    /// </summary>
    [DataContract]
    public partial class SettingRecord :  IEquatable<SettingRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingRecord" /> class.
        /// </summary>
        /// <param name="Name">Setting name.</param>
        /// <param name="Acl">Setting acl.</param>
        /// <param name="Value">Setting value.</param>
        public SettingRecord(string Name = null, string Acl = null, string Value = null)
        {
            this.Name = Name;
            this.Acl = Acl;
            this.Value = Value;
        }
        
        /// <summary>
        /// Setting name
        /// </summary>
        /// <value>Setting name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Setting acl
        /// </summary>
        /// <value>Setting acl</value>
        [DataMember(Name="acl", EmitDefaultValue=false)]
        public string Acl { get; set; }
        /// <summary>
        /// Setting value
        /// </summary>
        /// <value>Setting value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingRecord {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Acl: ").Append(Acl).Append("\n");
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
            return this.Equals(obj as SettingRecord);
        }

        /// <summary>
        /// Returns true if SettingRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SettingRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Acl == other.Acl ||
                    this.Acl != null &&
                    this.Acl.Equals(other.Acl)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Acl != null)
                    hash = hash * 59 + this.Acl.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }
    }

}
