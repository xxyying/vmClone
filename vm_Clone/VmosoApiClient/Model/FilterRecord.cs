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
    /// FilterRecord
    /// </summary>
    [DataContract]
    public partial class FilterRecord :  IEquatable<FilterRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterRecord" /> class.
        /// </summary>
        /// <param name="DisplayName">Type display/friendly name..</param>
        /// <param name="FilterGroup">Filters Group (preset_type/preset_views/preset_sharing etc).</param>
        /// <param name="DisplayOrder">Display order.</param>
        /// <param name="Description">Description of filter..</param>
        /// <param name="Type">Type of filter (BFS basic/PFS preset)..</param>
        /// <param name="Zones">Zones in which this filter is displayed..</param>
        /// <param name="Mode">Mode (basic/advanced) in which filter is displayed. If not set then can be displayed in all available modes..</param>
        /// <param name="ParentName">Filter parent name for types categorization..</param>
        /// <param name="IsDefault">Flag indicates if this filter is the default..</param>
        /// <param name="Subfilters">Array of Subfilters..</param>
        /// <param name="Solution">Solution (my/V) in which filter is displayed. If not set then can be displayed in all available solutions..</param>
        /// <param name="DisplaySubFilters">Flag indicates if subfilters need to be displayed..</param>
        /// <param name="Children">Array of FilterRecord..</param>
        /// <param name="Name">Filter name..</param>
        /// <param name="Options">Array of FilterOptions..</param>
        /// <param name="Account">Account (vee/vae) in which filter is displayed. If not set then can be displayed in all available solutions..</param>
        public FilterRecord(string DisplayName = null, string FilterGroup = null, int? DisplayOrder = null, string Description = null, string Type = null, List<string> Zones = null, string Mode = null, string ParentName = null, bool? IsDefault = null, List<EnumFilterOptions> Subfilters = null, string Solution = null, bool? DisplaySubFilters = null, List<FilterRecord> Children = null, string Name = null, List<FilterOptions> Options = null, string Account = null)
        {
            this.DisplayName = DisplayName;
            this.FilterGroup = FilterGroup;
            this.DisplayOrder = DisplayOrder;
            this.Description = Description;
            this.Type = Type;
            this.Zones = Zones;
            this.Mode = Mode;
            this.ParentName = ParentName;
            this.IsDefault = IsDefault;
            this.Subfilters = Subfilters;
            this.Solution = Solution;
            this.DisplaySubFilters = DisplaySubFilters;
            this.Children = Children;
            this.Name = Name;
            this.Options = Options;
            this.Account = Account;
        }
        
        /// <summary>
        /// Type display/friendly name.
        /// </summary>
        /// <value>Type display/friendly name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Filters Group (preset_type/preset_views/preset_sharing etc)
        /// </summary>
        /// <value>Filters Group (preset_type/preset_views/preset_sharing etc)</value>
        [DataMember(Name="filterGroup", EmitDefaultValue=false)]
        public string FilterGroup { get; set; }
        /// <summary>
        /// Display order
        /// </summary>
        /// <value>Display order</value>
        [DataMember(Name="displayOrder", EmitDefaultValue=false)]
        public int? DisplayOrder { get; set; }
        /// <summary>
        /// Description of filter.
        /// </summary>
        /// <value>Description of filter.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Type of filter (BFS basic/PFS preset).
        /// </summary>
        /// <value>Type of filter (BFS basic/PFS preset).</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Zones in which this filter is displayed.
        /// </summary>
        /// <value>Zones in which this filter is displayed.</value>
        [DataMember(Name="zones", EmitDefaultValue=false)]
        public List<string> Zones { get; set; }
        /// <summary>
        /// Mode (basic/advanced) in which filter is displayed. If not set then can be displayed in all available modes.
        /// </summary>
        /// <value>Mode (basic/advanced) in which filter is displayed. If not set then can be displayed in all available modes.</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public string Mode { get; set; }
        /// <summary>
        /// Filter parent name for types categorization.
        /// </summary>
        /// <value>Filter parent name for types categorization.</value>
        [DataMember(Name="parentName", EmitDefaultValue=false)]
        public string ParentName { get; set; }
        /// <summary>
        /// Flag indicates if this filter is the default.
        /// </summary>
        /// <value>Flag indicates if this filter is the default.</value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Array of Subfilters.
        /// </summary>
        /// <value>Array of Subfilters.</value>
        [DataMember(Name="subfilters", EmitDefaultValue=false)]
        public List<EnumFilterOptions> Subfilters { get; set; }
        /// <summary>
        /// Solution (my/V) in which filter is displayed. If not set then can be displayed in all available solutions.
        /// </summary>
        /// <value>Solution (my/V) in which filter is displayed. If not set then can be displayed in all available solutions.</value>
        [DataMember(Name="solution", EmitDefaultValue=false)]
        public string Solution { get; set; }
        /// <summary>
        /// Flag indicates if subfilters need to be displayed.
        /// </summary>
        /// <value>Flag indicates if subfilters need to be displayed.</value>
        [DataMember(Name="displaySubFilters", EmitDefaultValue=false)]
        public bool? DisplaySubFilters { get; set; }
        /// <summary>
        /// Array of FilterRecord.
        /// </summary>
        /// <value>Array of FilterRecord.</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<FilterRecord> Children { get; set; }
        /// <summary>
        /// Filter name.
        /// </summary>
        /// <value>Filter name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Array of FilterOptions.
        /// </summary>
        /// <value>Array of FilterOptions.</value>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<FilterOptions> Options { get; set; }
        /// <summary>
        /// Account (vee/vae) in which filter is displayed. If not set then can be displayed in all available solutions.
        /// </summary>
        /// <value>Account (vee/vae) in which filter is displayed. If not set then can be displayed in all available solutions.</value>
        [DataMember(Name="account", EmitDefaultValue=false)]
        public string Account { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterRecord {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FilterGroup: ").Append(FilterGroup).Append("\n");
            sb.Append("  DisplayOrder: ").Append(DisplayOrder).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Zones: ").Append(Zones).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  ParentName: ").Append(ParentName).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Subfilters: ").Append(Subfilters).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
            sb.Append("  DisplaySubFilters: ").Append(DisplaySubFilters).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(obj as FilterRecord);
        }

        /// <summary>
        /// Returns true if FilterRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of FilterRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.FilterGroup == other.FilterGroup ||
                    this.FilterGroup != null &&
                    this.FilterGroup.Equals(other.FilterGroup)
                ) && 
                (
                    this.DisplayOrder == other.DisplayOrder ||
                    this.DisplayOrder != null &&
                    this.DisplayOrder.Equals(other.DisplayOrder)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Zones == other.Zones ||
                    this.Zones != null &&
                    this.Zones.SequenceEqual(other.Zones)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.ParentName == other.ParentName ||
                    this.ParentName != null &&
                    this.ParentName.Equals(other.ParentName)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.Subfilters == other.Subfilters ||
                    this.Subfilters != null &&
                    this.Subfilters.SequenceEqual(other.Subfilters)
                ) && 
                (
                    this.Solution == other.Solution ||
                    this.Solution != null &&
                    this.Solution.Equals(other.Solution)
                ) && 
                (
                    this.DisplaySubFilters == other.DisplaySubFilters ||
                    this.DisplaySubFilters != null &&
                    this.DisplaySubFilters.Equals(other.DisplaySubFilters)
                ) && 
                (
                    this.Children == other.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(other.Children)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.SequenceEqual(other.Options)
                ) && 
                (
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.FilterGroup != null)
                    hash = hash * 59 + this.FilterGroup.GetHashCode();
                if (this.DisplayOrder != null)
                    hash = hash * 59 + this.DisplayOrder.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Zones != null)
                    hash = hash * 59 + this.Zones.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.ParentName != null)
                    hash = hash * 59 + this.ParentName.GetHashCode();
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                if (this.Subfilters != null)
                    hash = hash * 59 + this.Subfilters.GetHashCode();
                if (this.Solution != null)
                    hash = hash * 59 + this.Solution.GetHashCode();
                if (this.DisplaySubFilters != null)
                    hash = hash * 59 + this.DisplaySubFilters.GetHashCode();
                if (this.Children != null)
                    hash = hash * 59 + this.Children.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                return hash;
            }
        }
    }

}
