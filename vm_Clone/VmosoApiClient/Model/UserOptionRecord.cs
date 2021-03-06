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
    /// UserOptionRecord
    /// </summary>
    [DataContract]
    public partial class UserOptionRecord :  IEquatable<UserOptionRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserOptionRecord" /> class.
        /// </summary>
        /// <param name="AddType">if operation via email, addType &#x3D; &#39;email&#39;.</param>
        /// <param name="RmUserKeys">remove users.</param>
        /// <param name="GroupKeys">groups on member picker.</param>
        /// <param name="UserEmails">useremails on member picker.</param>
        /// <param name="AddedUserKeys">users on member picker.</param>
        /// <param name="RmUserEmails">.</param>
        /// <param name="AccessList">AccessList.</param>
        /// <param name="UserType">userType &#39;cc&#39; or &#39;assignees&#39;.</param>
        public UserOptionRecord(string AddType = null, List<string> RmUserKeys = null, List<string> GroupKeys = null, List<string> UserEmails = null, List<string> AddedUserKeys = null, List<string> RmUserEmails = null, TaskAccessListRecord AccessList = null, string UserType = null)
        {
            this.AddType = AddType;
            this.RmUserKeys = RmUserKeys;
            this.GroupKeys = GroupKeys;
            this.UserEmails = UserEmails;
            this.AddedUserKeys = AddedUserKeys;
            this.RmUserEmails = RmUserEmails;
            this.AccessList = AccessList;
            this.UserType = UserType;
        }
        
        /// <summary>
        /// if operation via email, addType &#x3D; &#39;email&#39;
        /// </summary>
        /// <value>if operation via email, addType &#x3D; &#39;email&#39;</value>
        [DataMember(Name="addType", EmitDefaultValue=false)]
        public string AddType { get; set; }
        /// <summary>
        /// remove users
        /// </summary>
        /// <value>remove users</value>
        [DataMember(Name="rmUserKeys", EmitDefaultValue=false)]
        public List<string> RmUserKeys { get; set; }
        /// <summary>
        /// groups on member picker
        /// </summary>
        /// <value>groups on member picker</value>
        [DataMember(Name="groupKeys", EmitDefaultValue=false)]
        public List<string> GroupKeys { get; set; }
        /// <summary>
        /// useremails on member picker
        /// </summary>
        /// <value>useremails on member picker</value>
        [DataMember(Name="userEmails", EmitDefaultValue=false)]
        public List<string> UserEmails { get; set; }
        /// <summary>
        /// users on member picker
        /// </summary>
        /// <value>users on member picker</value>
        [DataMember(Name="addedUserKeys", EmitDefaultValue=false)]
        public List<string> AddedUserKeys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="rmUserEmails", EmitDefaultValue=false)]
        public List<string> RmUserEmails { get; set; }
        /// <summary>
        /// Gets or Sets AccessList
        /// </summary>
        [DataMember(Name="accessList", EmitDefaultValue=false)]
        public TaskAccessListRecord AccessList { get; set; }
        /// <summary>
        /// userType &#39;cc&#39; or &#39;assignees&#39;
        /// </summary>
        /// <value>userType &#39;cc&#39; or &#39;assignees&#39;</value>
        [DataMember(Name="userType", EmitDefaultValue=false)]
        public string UserType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOptionRecord {\n");
            sb.Append("  AddType: ").Append(AddType).Append("\n");
            sb.Append("  RmUserKeys: ").Append(RmUserKeys).Append("\n");
            sb.Append("  GroupKeys: ").Append(GroupKeys).Append("\n");
            sb.Append("  UserEmails: ").Append(UserEmails).Append("\n");
            sb.Append("  AddedUserKeys: ").Append(AddedUserKeys).Append("\n");
            sb.Append("  RmUserEmails: ").Append(RmUserEmails).Append("\n");
            sb.Append("  AccessList: ").Append(AccessList).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
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
            return this.Equals(obj as UserOptionRecord);
        }

        /// <summary>
        /// Returns true if UserOptionRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of UserOptionRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserOptionRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddType == other.AddType ||
                    this.AddType != null &&
                    this.AddType.Equals(other.AddType)
                ) && 
                (
                    this.RmUserKeys == other.RmUserKeys ||
                    this.RmUserKeys != null &&
                    this.RmUserKeys.SequenceEqual(other.RmUserKeys)
                ) && 
                (
                    this.GroupKeys == other.GroupKeys ||
                    this.GroupKeys != null &&
                    this.GroupKeys.SequenceEqual(other.GroupKeys)
                ) && 
                (
                    this.UserEmails == other.UserEmails ||
                    this.UserEmails != null &&
                    this.UserEmails.SequenceEqual(other.UserEmails)
                ) && 
                (
                    this.AddedUserKeys == other.AddedUserKeys ||
                    this.AddedUserKeys != null &&
                    this.AddedUserKeys.SequenceEqual(other.AddedUserKeys)
                ) && 
                (
                    this.RmUserEmails == other.RmUserEmails ||
                    this.RmUserEmails != null &&
                    this.RmUserEmails.SequenceEqual(other.RmUserEmails)
                ) && 
                (
                    this.AccessList == other.AccessList ||
                    this.AccessList != null &&
                    this.AccessList.Equals(other.AccessList)
                ) && 
                (
                    this.UserType == other.UserType ||
                    this.UserType != null &&
                    this.UserType.Equals(other.UserType)
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
                if (this.AddType != null)
                    hash = hash * 59 + this.AddType.GetHashCode();
                if (this.RmUserKeys != null)
                    hash = hash * 59 + this.RmUserKeys.GetHashCode();
                if (this.GroupKeys != null)
                    hash = hash * 59 + this.GroupKeys.GetHashCode();
                if (this.UserEmails != null)
                    hash = hash * 59 + this.UserEmails.GetHashCode();
                if (this.AddedUserKeys != null)
                    hash = hash * 59 + this.AddedUserKeys.GetHashCode();
                if (this.RmUserEmails != null)
                    hash = hash * 59 + this.RmUserEmails.GetHashCode();
                if (this.AccessList != null)
                    hash = hash * 59 + this.AccessList.GetHashCode();
                if (this.UserType != null)
                    hash = hash * 59 + this.UserType.GetHashCode();
                return hash;
            }
        }
    }

}
