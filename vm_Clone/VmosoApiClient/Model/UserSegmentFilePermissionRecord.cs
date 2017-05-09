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
    /// UserSegmentFilePermissionRecord
    /// </summary>
    [DataContract]
    public partial class UserSegmentFilePermissionRecord :  IEquatable<UserSegmentFilePermissionRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSegmentFilePermissionRecord" /> class.
        /// </summary>
        /// <param name="Name">User segment name.</param>
        /// <param name="ReshareUnlimited">Flag to indicate if resharers should have unlimited access. If true, when file is attached to container its default permissions are Download, Share, Preview. Else false, file is granted just Preview permission..</param>
        /// <param name="Permission">Permission.</param>
        public UserSegmentFilePermissionRecord(string Name = null, bool? ReshareUnlimited = null, string Permission = null)
        {
            this.Name = Name;
            this.ReshareUnlimited = ReshareUnlimited;
            this.Permission = Permission;
        }
        
        /// <summary>
        /// User segment name
        /// </summary>
        /// <value>User segment name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Flag to indicate if resharers should have unlimited access. If true, when file is attached to container its default permissions are Download, Share, Preview. Else false, file is granted just Preview permission.
        /// </summary>
        /// <value>Flag to indicate if resharers should have unlimited access. If true, when file is attached to container its default permissions are Download, Share, Preview. Else false, file is granted just Preview permission.</value>
        [DataMember(Name="reshareUnlimited", EmitDefaultValue=false)]
        public bool? ReshareUnlimited { get; set; }
        /// <summary>
        /// Permission
        /// </summary>
        /// <value>Permission</value>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public string Permission { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSegmentFilePermissionRecord {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReshareUnlimited: ").Append(ReshareUnlimited).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
            return this.Equals(obj as UserSegmentFilePermissionRecord);
        }

        /// <summary>
        /// Returns true if UserSegmentFilePermissionRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSegmentFilePermissionRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSegmentFilePermissionRecord other)
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
                    this.ReshareUnlimited == other.ReshareUnlimited ||
                    this.ReshareUnlimited != null &&
                    this.ReshareUnlimited.Equals(other.ReshareUnlimited)
                ) && 
                (
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
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
                if (this.ReshareUnlimited != null)
                    hash = hash * 59 + this.ReshareUnlimited.GetHashCode();
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                return hash;
            }
        }
    }

}
