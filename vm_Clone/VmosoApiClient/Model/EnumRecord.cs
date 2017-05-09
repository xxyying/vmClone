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
    /// EnumRecord
    /// </summary>
    [DataContract]
    public partial class EnumRecord :  IEquatable<EnumRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumRecord" /> class.
        /// </summary>
        /// <param name="Mode">Mode (basic/advanced) in which enum is displayed. If not set then can be displayed in all available modes..</param>
        /// <param name="IsDefault">Flag indicates if this value is the default..</param>
        /// <param name="ParentName">Enum parent name for types categorization..</param>
        /// <param name="Solution">Solution (my/V) in which enum is displayed. If not set then can be displayed in all available solutions..</param>
        /// <param name="Children">Array of EnumRecord..</param>
        /// <param name="DisplayName">Enum display name..</param>
        /// <param name="Value">Enum label key..</param>
        /// <param name="Account">Account (vee/vae) in which enum is displayed. If not set then can be displayed for all available users..</param>
        /// <param name="IsSubFiltered">Flag indicates if this value can be used for subfilters..</param>
        public EnumRecord(string Mode = null, bool? IsDefault = null, string ParentName = null, string Solution = null, List<EnumRecord> Children = null, string DisplayName = null, string Value = null, string Account = null, bool? IsSubFiltered = null)
        {
            this.Mode = Mode;
            this.IsDefault = IsDefault;
            this.ParentName = ParentName;
            this.Solution = Solution;
            this.Children = Children;
            this.DisplayName = DisplayName;
            this.Value = Value;
            this.Account = Account;
            this.IsSubFiltered = IsSubFiltered;
        }
        
        /// <summary>
        /// Mode (basic/advanced) in which enum is displayed. If not set then can be displayed in all available modes.
        /// </summary>
        /// <value>Mode (basic/advanced) in which enum is displayed. If not set then can be displayed in all available modes.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }
        /// <summary>
        /// Flag indicates if this value is the default.
        /// </summary>
        /// <value>Flag indicates if this value is the default.</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Enum parent name for types categorization.
        /// </summary>
        /// <value>Enum parent name for types categorization.</value>
        [DataMember(Name="parentName", EmitDefaultValue=false)]
        public string ParentName { get; set; }
        /// <summary>
        /// Solution (my/V) in which enum is displayed. If not set then can be displayed in all available solutions.
        /// </summary>
        /// <value>Solution (my/V) in which enum is displayed. If not set then can be displayed in all available solutions.</value>
        [DataMember(Name="solution", EmitDefaultValue=false)]
        public string Solution { get; set; }
        /// <summary>
        /// Array of EnumRecord.
        /// </summary>
        /// <value>Array of EnumRecord.</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<EnumRecord> Children { get; set; }
        /// <summary>
        /// Enum display name.
        /// </summary>
        /// <value>Enum display name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Enum label key.
        /// </summary>
        /// <value>Enum label key.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Account (vee/vae) in which enum is displayed. If not set then can be displayed for all available users.
        /// </summary>
        /// <value>Account (vee/vae) in which enum is displayed. If not set then can be displayed for all available users.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }
        /// <summary>
        /// Flag indicates if this value can be used for subfilters.
        /// </summary>
        /// <value>Flag indicates if this value can be used for subfilters.</value>
        [DataMember(Name="isSubFiltered", EmitDefaultValue=false)]
        public bool? IsSubFiltered { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnumRecord {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  ParentName: ").Append(ParentName).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  IsSubFiltered: ").Append(IsSubFiltered).Append("\n");
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
            return this.Equals(obj as EnumRecord);
        }

        /// <summary>
        /// Returns true if EnumRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of EnumRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnumRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.ParentName == other.ParentName ||
                    this.ParentName != null &&
                    this.ParentName.Equals(other.ParentName)
                ) && 
                (
                    this.Solution == other.Solution ||
                    this.Solution != null &&
                    this.Solution.Equals(other.Solution)
                ) && 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.IsSubFiltered == other.IsSubFiltered ||
                    this.IsSubFiltered != null &&
                    this.IsSubFiltered.Equals(other.IsSubFiltered)
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
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                if (this.ParentName != null)
                    hash = hash * 59 + this.ParentName.GetHashCode();
                if (this.Solution != null)
                    hash = hash * 59 + this.Solution.GetHashCode();
                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.IsSubFiltered != null)
                    hash = hash * 59 + this.IsSubFiltered.GetHashCode();
                return hash;
            }
        }
    }

}
