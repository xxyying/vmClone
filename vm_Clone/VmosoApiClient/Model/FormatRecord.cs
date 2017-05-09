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
    /// FormatRecord
    /// </summary>
    [DataContract]
    public partial class FormatRecord :  IEquatable<FormatRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatRecord" /> class.
        /// </summary>
        /// <param name="Loginuser">Used for File Versioning, Login User Key.</param>
        /// <param name="ReturnRatings">Whether to return ratings.</param>
        /// <param name="RestrictedFilter">Whether to filter flag by restriction..</param>
        /// <param name="ReturnBasicUser">Whether to return only basic user info.</param>
        /// <param name="CountLevelFilter">count level.</param>
        /// <param name="ReturnAcl">Whether to return acl.</param>
        /// <param name="ReturnRelatedObjects">Whether to return related objects.</param>
        /// <param name="ReturnSteps">Whether to return steps.</param>
        /// <param name="ViewingParentKey">Viewing parent key This will generate different IconType when viewing from anchor on link.</param>
        /// <param name="AppMode">Application mode.</param>
        /// <param name="CountsRecursive">calculate the count recursively..</param>
        /// <param name="ReturnSparc">Whether to return SPARC.</param>
        /// <param name="CountFormats">Types of counts to return.</param>
        /// <param name="ObjectFormat">Object format specification... Currently: full names keys.</param>
        /// <param name="ParentIsLink">set if parent is a link.</param>
        /// <param name="ContainerID">Used for File Versioning, ContainerID can be taskID, chatID, postID, spaceID.</param>
        /// <param name="ReturnCounts">Whether to return counts.</param>
        public FormatRecord(string Loginuser = null, bool? ReturnRatings = null, string RestrictedFilter = null, bool? ReturnBasicUser = null, string CountLevelFilter = null, bool? ReturnAcl = null, bool? ReturnRelatedObjects = null, bool? ReturnSteps = null, string ViewingParentKey = null, string AppMode = null, bool? CountsRecursive = null, bool? ReturnSparc = null, List<CountFormatRecord> CountFormats = null, string ObjectFormat = null, bool? ParentIsLink = null, int? ContainerID = null, bool? ReturnCounts = null)
        {
            this.Loginuser = Loginuser;
            this.ReturnRatings = ReturnRatings;
            this.RestrictedFilter = RestrictedFilter;
            this.ReturnBasicUser = ReturnBasicUser;
            this.CountLevelFilter = CountLevelFilter;
            this.ReturnAcl = ReturnAcl;
            this.ReturnRelatedObjects = ReturnRelatedObjects;
            this.ReturnSteps = ReturnSteps;
            this.ViewingParentKey = ViewingParentKey;
            this.AppMode = AppMode;
            this.CountsRecursive = CountsRecursive;
            this.ReturnSparc = ReturnSparc;
            this.CountFormats = CountFormats;
            this.ObjectFormat = ObjectFormat;
            this.ParentIsLink = ParentIsLink;
            this.ContainerID = ContainerID;
            this.ReturnCounts = ReturnCounts;
        }
        
        /// <summary>
        /// Used for File Versioning, Login User Key
        /// </summary>
        /// <value>Used for File Versioning, Login User Key</value>
        [DataMember(Name="loginuser", EmitDefaultValue=false)]
        public string Loginuser { get; set; }
        /// <summary>
        /// Whether to return ratings
        /// </summary>
        /// <value>Whether to return ratings</value>
        [DataMember(Name="return_ratings", EmitDefaultValue=false)]
        public bool? ReturnRatings { get; set; }
        /// <summary>
        /// Whether to filter flag by restriction.
        /// </summary>
        /// <value>Whether to filter flag by restriction.</value>
        [DataMember(Name="restricted_filter", EmitDefaultValue=false)]
        public string RestrictedFilter { get; set; }
        /// <summary>
        /// Whether to return only basic user info
        /// </summary>
        /// <value>Whether to return only basic user info</value>
        [DataMember(Name="return_basic_user", EmitDefaultValue=false)]
        public bool? ReturnBasicUser { get; set; }
        /// <summary>
        /// count level
        /// </summary>
        /// <value>count level</value>
        [DataMember(Name="count_level_filter", EmitDefaultValue=false)]
        public string CountLevelFilter { get; set; }
        /// <summary>
        /// Whether to return acl
        /// </summary>
        /// <value>Whether to return acl</value>
        [DataMember(Name="return_acl", EmitDefaultValue=false)]
        public bool? ReturnAcl { get; set; }
        /// <summary>
        /// Whether to return related objects
        /// </summary>
        /// <value>Whether to return related objects</value>
        [DataMember(Name="return_related_objects", EmitDefaultValue=false)]
        public bool? ReturnRelatedObjects { get; set; }
        /// <summary>
        /// Whether to return steps
        /// </summary>
        /// <value>Whether to return steps</value>
        [DataMember(Name="return_steps", EmitDefaultValue=false)]
        public bool? ReturnSteps { get; set; }
        /// <summary>
        /// Viewing parent key This will generate different IconType when viewing from anchor on link
        /// </summary>
        /// <value>Viewing parent key This will generate different IconType when viewing from anchor on link</value>
        [DataMember(Name="viewing_parent_key", EmitDefaultValue=false)]
        public string ViewingParentKey { get; set; }
        /// <summary>
        /// Application mode
        /// </summary>
        /// <value>Application mode</value>
        [DataMember(Name="app_mode", EmitDefaultValue=false)]
        public string AppMode { get; set; }
        /// <summary>
        /// calculate the count recursively.
        /// </summary>
        /// <value>calculate the count recursively.</value>
        [DataMember(Name="counts_recursive", EmitDefaultValue=false)]
        public bool? CountsRecursive { get; set; }
        /// <summary>
        /// Whether to return SPARC
        /// </summary>
        /// <value>Whether to return SPARC</value>
        [DataMember(Name="return_sparc", EmitDefaultValue=false)]
        public bool? ReturnSparc { get; set; }
        /// <summary>
        /// Types of counts to return
        /// </summary>
        /// <value>Types of counts to return</value>
        [DataMember(Name="count_formats", EmitDefaultValue=false)]
        public List<CountFormatRecord> CountFormats { get; set; }
        /// <summary>
        /// Object format specification... Currently: full names keys
        /// </summary>
        /// <value>Object format specification... Currently: full names keys</value>
        [DataMember(Name="object_format", EmitDefaultValue=false)]
        public string ObjectFormat { get; set; }
        /// <summary>
        /// set if parent is a link
        /// </summary>
        /// <value>set if parent is a link</value>
        [DataMember(Name="parentIsLink", EmitDefaultValue=false)]
        public bool? ParentIsLink { get; set; }
        /// <summary>
        /// Used for File Versioning, ContainerID can be taskID, chatID, postID, spaceID
        /// </summary>
        /// <value>Used for File Versioning, ContainerID can be taskID, chatID, postID, spaceID</value>
        [DataMember(Name="containerID", EmitDefaultValue=false)]
        public int? ContainerID { get; set; }
        /// <summary>
        /// Whether to return counts
        /// </summary>
        /// <value>Whether to return counts</value>
        [DataMember(Name="return_counts", EmitDefaultValue=false)]
        public bool? ReturnCounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormatRecord {\n");
            sb.Append("  Loginuser: ").Append(Loginuser).Append("\n");
            sb.Append("  ReturnRatings: ").Append(ReturnRatings).Append("\n");
            sb.Append("  RestrictedFilter: ").Append(RestrictedFilter).Append("\n");
            sb.Append("  ReturnBasicUser: ").Append(ReturnBasicUser).Append("\n");
            sb.Append("  CountLevelFilter: ").Append(CountLevelFilter).Append("\n");
            sb.Append("  ReturnAcl: ").Append(ReturnAcl).Append("\n");
            sb.Append("  ReturnRelatedObjects: ").Append(ReturnRelatedObjects).Append("\n");
            sb.Append("  ReturnSteps: ").Append(ReturnSteps).Append("\n");
            sb.Append("  ViewingParentKey: ").Append(ViewingParentKey).Append("\n");
            sb.Append("  AppMode: ").Append(AppMode).Append("\n");
            sb.Append("  CountsRecursive: ").Append(CountsRecursive).Append("\n");
            sb.Append("  ReturnSparc: ").Append(ReturnSparc).Append("\n");
            sb.Append("  CountFormats: ").Append(CountFormats).Append("\n");
            sb.Append("  ObjectFormat: ").Append(ObjectFormat).Append("\n");
            sb.Append("  ParentIsLink: ").Append(ParentIsLink).Append("\n");
            sb.Append("  ContainerID: ").Append(ContainerID).Append("\n");
            sb.Append("  ReturnCounts: ").Append(ReturnCounts).Append("\n");
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
            return this.Equals(obj as FormatRecord);
        }

        /// <summary>
        /// Returns true if FormatRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of FormatRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormatRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Loginuser == other.Loginuser ||
                    this.Loginuser != null &&
                    this.Loginuser.Equals(other.Loginuser)
                ) && 
                (
                    this.ReturnRatings == other.ReturnRatings ||
                    this.ReturnRatings != null &&
                    this.ReturnRatings.Equals(other.ReturnRatings)
                ) && 
                (
                    this.RestrictedFilter == other.RestrictedFilter ||
                    this.RestrictedFilter != null &&
                    this.RestrictedFilter.Equals(other.RestrictedFilter)
                ) && 
                (
                    this.ReturnBasicUser == other.ReturnBasicUser ||
                    this.ReturnBasicUser != null &&
                    this.ReturnBasicUser.Equals(other.ReturnBasicUser)
                ) && 
                (
                    this.CountLevelFilter == other.CountLevelFilter ||
                    this.CountLevelFilter != null &&
                    this.CountLevelFilter.Equals(other.CountLevelFilter)
                ) && 
                (
                    this.ReturnAcl == other.ReturnAcl ||
                    this.ReturnAcl != null &&
                    this.ReturnAcl.Equals(other.ReturnAcl)
                ) && 
                (
                    this.ReturnRelatedObjects == other.ReturnRelatedObjects ||
                    this.ReturnRelatedObjects != null &&
                    this.ReturnRelatedObjects.Equals(other.ReturnRelatedObjects)
                ) && 
                (
                    this.ReturnSteps == other.ReturnSteps ||
                    this.ReturnSteps != null &&
                    this.ReturnSteps.Equals(other.ReturnSteps)
                ) && 
                (
                    this.ViewingParentKey == other.ViewingParentKey ||
                    this.ViewingParentKey != null &&
                    this.ViewingParentKey.Equals(other.ViewingParentKey)
                ) && 
                (
                    this.AppMode == other.AppMode ||
                    this.AppMode != null &&
                    this.AppMode.Equals(other.AppMode)
                ) && 
                (
                    this.CountsRecursive == other.CountsRecursive ||
                    this.CountsRecursive != null &&
                    this.CountsRecursive.Equals(other.CountsRecursive)
                ) && 
                (
                    this.ReturnSparc == other.ReturnSparc ||
                    this.ReturnSparc != null &&
                    this.ReturnSparc.Equals(other.ReturnSparc)
                ) && 
                (
                    this.CountFormats == other.CountFormats ||
                    this.CountFormats != null &&
                    this.CountFormats.SequenceEqual(other.CountFormats)
                ) && 
                (
                    this.ObjectFormat == other.ObjectFormat ||
                    this.ObjectFormat != null &&
                    this.ObjectFormat.Equals(other.ObjectFormat)
                ) && 
                (
                    this.ParentIsLink == other.ParentIsLink ||
                    this.ParentIsLink != null &&
                    this.ParentIsLink.Equals(other.ParentIsLink)
                ) && 
                (
                    this.ContainerID == other.ContainerID ||
                    this.ContainerID != null &&
                    this.ContainerID.Equals(other.ContainerID)
                ) && 
                (
                    this.ReturnCounts == other.ReturnCounts ||
                    this.ReturnCounts != null &&
                    this.ReturnCounts.Equals(other.ReturnCounts)
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
                if (this.Loginuser != null)
                    hash = hash * 59 + this.Loginuser.GetHashCode();
                if (this.ReturnRatings != null)
                    hash = hash * 59 + this.ReturnRatings.GetHashCode();
                if (this.RestrictedFilter != null)
                    hash = hash * 59 + this.RestrictedFilter.GetHashCode();
                if (this.ReturnBasicUser != null)
                    hash = hash * 59 + this.ReturnBasicUser.GetHashCode();
                if (this.CountLevelFilter != null)
                    hash = hash * 59 + this.CountLevelFilter.GetHashCode();
                if (this.ReturnAcl != null)
                    hash = hash * 59 + this.ReturnAcl.GetHashCode();
                if (this.ReturnRelatedObjects != null)
                    hash = hash * 59 + this.ReturnRelatedObjects.GetHashCode();
                if (this.ReturnSteps != null)
                    hash = hash * 59 + this.ReturnSteps.GetHashCode();
                if (this.ViewingParentKey != null)
                    hash = hash * 59 + this.ViewingParentKey.GetHashCode();
                if (this.AppMode != null)
                    hash = hash * 59 + this.AppMode.GetHashCode();
                if (this.CountsRecursive != null)
                    hash = hash * 59 + this.CountsRecursive.GetHashCode();
                if (this.ReturnSparc != null)
                    hash = hash * 59 + this.ReturnSparc.GetHashCode();
                if (this.CountFormats != null)
                    hash = hash * 59 + this.CountFormats.GetHashCode();
                if (this.ObjectFormat != null)
                    hash = hash * 59 + this.ObjectFormat.GetHashCode();
                if (this.ParentIsLink != null)
                    hash = hash * 59 + this.ParentIsLink.GetHashCode();
                if (this.ContainerID != null)
                    hash = hash * 59 + this.ContainerID.GetHashCode();
                if (this.ReturnCounts != null)
                    hash = hash * 59 + this.ReturnCounts.GetHashCode();
                return hash;
            }
        }
    }

}
