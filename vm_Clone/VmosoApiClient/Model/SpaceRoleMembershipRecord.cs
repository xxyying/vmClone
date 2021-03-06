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
    /// SpaceRoleMembershipRecord
    /// </summary>
    [DataContract]
    public partial class SpaceRoleMembershipRecord :  IEquatable<SpaceRoleMembershipRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceRoleMembershipRecord" /> class.
        /// </summary>
        /// <param name="Viewers">Viewer list.</param>
        /// <param name="Readers">Reader list.</param>
        /// <param name="Roles">Roles.</param>
        /// <param name="Members">Member list.</param>
        /// <param name="Owners">Owner list.</param>
        /// <param name="Admins">Admin list.</param>
        /// <param name="Observers">Observer list.</param>
        /// <param name="Moderators">Moderator list.</param>
        public SpaceRoleMembershipRecord(string Viewers = null, string Readers = null, string Roles = null, string Members = null, string Owners = null, string Admins = null, string Observers = null, string Moderators = null)
        {
            this.Viewers = Viewers;
            this.Readers = Readers;
            this.Roles = Roles;
            this.Members = Members;
            this.Owners = Owners;
            this.Admins = Admins;
            this.Observers = Observers;
            this.Moderators = Moderators;
        }
        
        /// <summary>
        /// Viewer list
        /// </summary>
        /// <value>Viewer list</value>
        [DataMember(Name="viewers", EmitDefaultValue=false)]
        public string Viewers { get; set; }
        /// <summary>
        /// Reader list
        /// </summary>
        /// <value>Reader list</value>
        [DataMember(Name="readers", EmitDefaultValue=false)]
        public string Readers { get; set; }
        /// <summary>
        /// Roles
        /// </summary>
        /// <value>Roles</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public string Roles { get; set; }
        /// <summary>
        /// Member list
        /// </summary>
        /// <value>Member list</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public string Members { get; set; }
        /// <summary>
        /// Owner list
        /// </summary>
        /// <value>Owner list</value>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public string Owners { get; set; }
        /// <summary>
        /// Admin list
        /// </summary>
        /// <value>Admin list</value>
        [DataMember(Name="admins", EmitDefaultValue=false)]
        public string Admins { get; set; }
        /// <summary>
        /// Observer list
        /// </summary>
        /// <value>Observer list</value>
        [DataMember(Name="observers", EmitDefaultValue=false)]
        public string Observers { get; set; }
        /// <summary>
        /// Moderator list
        /// </summary>
        /// <value>Moderator list</value>
        [DataMember(Name="moderators", EmitDefaultValue=false)]
        public string Moderators { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpaceRoleMembershipRecord {\n");
            sb.Append("  Viewers: ").Append(Viewers).Append("\n");
            sb.Append("  Readers: ").Append(Readers).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Admins: ").Append(Admins).Append("\n");
            sb.Append("  Observers: ").Append(Observers).Append("\n");
            sb.Append("  Moderators: ").Append(Moderators).Append("\n");
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
            return this.Equals(obj as SpaceRoleMembershipRecord);
        }

        /// <summary>
        /// Returns true if SpaceRoleMembershipRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SpaceRoleMembershipRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpaceRoleMembershipRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Viewers == other.Viewers ||
                    this.Viewers != null &&
                    this.Viewers.Equals(other.Viewers)
                ) && 
                (
                    this.Readers == other.Readers ||
                    this.Readers != null &&
                    this.Readers.Equals(other.Readers)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.Equals(other.Roles)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.Equals(other.Members)
                ) && 
                (
                    this.Owners == other.Owners ||
                    this.Owners != null &&
                    this.Owners.Equals(other.Owners)
                ) && 
                (
                    this.Admins == other.Admins ||
                    this.Admins != null &&
                    this.Admins.Equals(other.Admins)
                ) && 
                (
                    this.Observers == other.Observers ||
                    this.Observers != null &&
                    this.Observers.Equals(other.Observers)
                ) && 
                (
                    this.Moderators == other.Moderators ||
                    this.Moderators != null &&
                    this.Moderators.Equals(other.Moderators)
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
                if (this.Viewers != null)
                    hash = hash * 59 + this.Viewers.GetHashCode();
                if (this.Readers != null)
                    hash = hash * 59 + this.Readers.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
                if (this.Owners != null)
                    hash = hash * 59 + this.Owners.GetHashCode();
                if (this.Admins != null)
                    hash = hash * 59 + this.Admins.GetHashCode();
                if (this.Observers != null)
                    hash = hash * 59 + this.Observers.GetHashCode();
                if (this.Moderators != null)
                    hash = hash * 59 + this.Moderators.GetHashCode();
                return hash;
            }
        }
    }

}
