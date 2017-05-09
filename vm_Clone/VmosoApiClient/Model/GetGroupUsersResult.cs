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
    /// 0 : success, 1 : unknown error, 4 : no access, 6 : input invalid
    /// </summary>
    [DataContract]
    public partial class GetGroupUsersResult :  IEquatable<GetGroupUsersResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupUsersResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetGroupUsersResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupUsersResult" /> class.
        /// </summary>
        /// <param name="Pager">Pager (required).</param>
        /// <param name="Count"> (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        /// <param name="Users">.</param>
        public GetGroupUsersResult(ListPageRecord Pager = null, int? Count = null, ResponseHeaderRecord Hdr = null, List<DisplayRecord> Users = null)
        {
            // to ensure "Pager" is required (not null)
            if (Pager == null)
            {
                throw new InvalidDataException("Pager is a required property for GetGroupUsersResult and cannot be null");
            }
            else
            {
                this.Pager = Pager;
            }
            // to ensure "Count" is required (not null)
            if (Count == null)
            {
                throw new InvalidDataException("Count is a required property for GetGroupUsersResult and cannot be null");
            }
            else
            {
                this.Count = Count;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for GetGroupUsersResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
            this.Users = Users;
        }
        
        /// <summary>
        /// Gets or Sets Pager
        /// </summary>
        [DataMember(Name="pager", EmitDefaultValue=false)]
        public ListPageRecord Pager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Gets or Sets Hdr
        /// </summary>
        [DataMember(Name="_hdr", EmitDefaultValue=false)]
        public ResponseHeaderRecord Hdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public List<DisplayRecord> Users { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGroupUsersResult {\n");
            sb.Append("  Pager: ").Append(Pager).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Hdr: ").Append(Hdr).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as GetGroupUsersResult);
        }

        /// <summary>
        /// Returns true if GetGroupUsersResult instances are equal
        /// </summary>
        /// <param name="other">Instance of GetGroupUsersResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGroupUsersResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pager == other.Pager ||
                    this.Pager != null &&
                    this.Pager.Equals(other.Pager)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.Hdr == other.Hdr ||
                    this.Hdr != null &&
                    this.Hdr.Equals(other.Hdr)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.Pager != null)
                    hash = hash * 59 + this.Pager.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
                return hash;
            }
        }
    }

}
