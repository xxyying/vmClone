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
    /// UserHistoryRecord
    /// </summary>
    [DataContract]
    public partial class UserHistoryRecord :  IEquatable<UserHistoryRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHistoryRecord" /> class.
        /// </summary>
        /// <param name="Pinned">.</param>
        /// <param name="CreationTime">.</param>
        /// <param name="DisplayRecord">DisplayRecord.</param>
        /// <param name="Subtype">.</param>
        /// <param name="Objectkey">Object key, if exists.</param>
        /// <param name="Type">.</param>
        /// <param name="Url">.</param>
        public UserHistoryRecord(bool? Pinned = null, int? CreationTime = null, Record DisplayRecord = null, string Subtype = null, string Objectkey = null, string Type = null, string Url = null)
        {
            this.Pinned = Pinned;
            this.CreationTime = CreationTime;
            this.DisplayRecord = DisplayRecord;
            this.Subtype = Subtype;
            this.Objectkey = Objectkey;
            this.Type = Type;
            this.Url = Url;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pinned", EmitDefaultValue=false)]
        public bool? Pinned { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public int? CreationTime { get; set; }
        /// <summary>
        /// Gets or Sets DisplayRecord
        /// </summary>
        [DataMember(Name="displayRecord", EmitDefaultValue=false)]
        public Record DisplayRecord { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="subtype", EmitDefaultValue=false)]
        public string Subtype { get; set; }
        /// <summary>
        /// Object key, if exists
        /// </summary>
        /// <value>Object key, if exists</value>
        [DataMember(Name="objectkey", EmitDefaultValue=false)]
        public string Objectkey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserHistoryRecord {\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  DisplayRecord: ").Append(DisplayRecord).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  Objectkey: ").Append(Objectkey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as UserHistoryRecord);
        }

        /// <summary>
        /// Returns true if UserHistoryRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of UserHistoryRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserHistoryRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pinned == other.Pinned ||
                    this.Pinned != null &&
                    this.Pinned.Equals(other.Pinned)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.DisplayRecord == other.DisplayRecord ||
                    this.DisplayRecord != null &&
                    this.DisplayRecord.Equals(other.DisplayRecord)
                ) && 
                (
                    this.Subtype == other.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(other.Subtype)
                ) && 
                (
                    this.Objectkey == other.Objectkey ||
                    this.Objectkey != null &&
                    this.Objectkey.Equals(other.Objectkey)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Pinned != null)
                    hash = hash * 59 + this.Pinned.GetHashCode();
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                if (this.DisplayRecord != null)
                    hash = hash * 59 + this.DisplayRecord.GetHashCode();
                if (this.Subtype != null)
                    hash = hash * 59 + this.Subtype.GetHashCode();
                if (this.Objectkey != null)
                    hash = hash * 59 + this.Objectkey.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                return hash;
            }
        }
    }

}
