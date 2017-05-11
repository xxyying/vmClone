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
    /// RuleAttributeRecord
    /// </summary>
    [DataContract]
    public partial class RuleAttributeRecord :  IEquatable<RuleAttributeRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleAttributeRecord" /> class.
        /// </summary>
        /// <param name="IsRequired">Should user be required to choose a value ?.</param>
        /// <param name="EnumOptions">RuleAttribute enum options..</param>
        /// <param name="DisplayName">display name..</param>
        /// <param name="DataType">RuleAttribute data type..</param>
        /// <param name="Name">RuleAttribute name..</param>
        /// <param name="IsSingleValue">is attribute single value ?.</param>
        /// <param name="IsHidden">Hide this attribute from user/UI for selecting a choice?.</param>
        public RuleAttributeRecord(bool? IsRequired = null, List<EnumRecord> EnumOptions = null, string DisplayName = null, string DataType = null, string Name = null, bool? IsSingleValue = null, bool? IsHidden = null)
        {
            this.IsRequired = IsRequired;
            this.EnumOptions = EnumOptions;
            this.DisplayName = DisplayName;
            this.DataType = DataType;
            this.Name = Name;
            this.IsSingleValue = IsSingleValue;
            this.IsHidden = IsHidden;
        }
        
        /// <summary>
        /// Should user be required to choose a value ?
        /// </summary>
        /// <value>Should user be required to choose a value ?</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }
        /// <summary>
        /// RuleAttribute enum options.
        /// </summary>
        /// <value>RuleAttribute enum options.</value>
        [DataMember(Name="enumOptions", EmitDefaultValue=false)]
        public List<EnumRecord> EnumOptions { get; set; }
        /// <summary>
        /// display name.
        /// </summary>
        /// <value>display name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// RuleAttribute data type.
        /// </summary>
        /// <value>RuleAttribute data type.</value>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public string DataType { get; set; }
        /// <summary>
        /// RuleAttribute name.
        /// </summary>
        /// <value>RuleAttribute name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// is attribute single value ?
        /// </summary>
        /// <value>is attribute single value ?</value>
        [DataMember(Name="isSingleValue", EmitDefaultValue=false)]
        public bool? IsSingleValue { get; set; }
        /// <summary>
        /// Hide this attribute from user/UI for selecting a choice?
        /// </summary>
        /// <value>Hide this attribute from user/UI for selecting a choice?</value>
        [DataMember(Name="isHidden", EmitDefaultValue=false)]
        public bool? IsHidden { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleAttributeRecord {\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  EnumOptions: ").Append(EnumOptions).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsSingleValue: ").Append(IsSingleValue).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
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
            return this.Equals(obj as RuleAttributeRecord);
        }

        /// <summary>
        /// Returns true if RuleAttributeRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of RuleAttributeRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleAttributeRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
                ) && 
                (
                    this.EnumOptions == other.EnumOptions ||
                    this.EnumOptions != null &&
                    this.EnumOptions.SequenceEqual(other.EnumOptions)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.DataType == other.DataType ||
                    this.DataType != null &&
                    this.DataType.Equals(other.DataType)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.IsSingleValue == other.IsSingleValue ||
                    this.IsSingleValue != null &&
                    this.IsSingleValue.Equals(other.IsSingleValue)
                ) && 
                (
                    this.IsHidden == other.IsHidden ||
                    this.IsHidden != null &&
                    this.IsHidden.Equals(other.IsHidden)
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
                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();
                if (this.EnumOptions != null)
                    hash = hash * 59 + this.EnumOptions.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.DataType != null)
                    hash = hash * 59 + this.DataType.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.IsSingleValue != null)
                    hash = hash * 59 + this.IsSingleValue.GetHashCode();
                if (this.IsHidden != null)
                    hash = hash * 59 + this.IsHidden.GetHashCode();
                return hash;
            }
        }
    }

}