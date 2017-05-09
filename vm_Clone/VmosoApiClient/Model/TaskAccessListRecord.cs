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
    /// TaskAccessListRecord
    /// </summary>
    [DataContract]
    public partial class TaskAccessListRecord :  IEquatable<TaskAccessListRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskAccessListRecord" /> class.
        /// </summary>
        /// <param name="AddedBlacklist">.</param>
        /// <param name="AddedWhitelist">.</param>
        /// <param name="RemovedWhitelist">.</param>
        /// <param name="RemovedBlacklist">.</param>
        public TaskAccessListRecord(List<string> AddedBlacklist = null, List<string> AddedWhitelist = null, List<string> RemovedWhitelist = null, List<string> RemovedBlacklist = null)
        {
            this.AddedBlacklist = AddedBlacklist;
            this.AddedWhitelist = AddedWhitelist;
            this.RemovedWhitelist = RemovedWhitelist;
            this.RemovedBlacklist = RemovedBlacklist;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="addedBlacklist", EmitDefaultValue=false)]
        public List<string> AddedBlacklist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="addedWhitelist", EmitDefaultValue=false)]
        public List<string> AddedWhitelist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedWhitelist", EmitDefaultValue=false)]
        public List<string> RemovedWhitelist { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedBlacklist", EmitDefaultValue=false)]
        public List<string> RemovedBlacklist { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskAccessListRecord {\n");
            sb.Append("  AddedBlacklist: ").Append(AddedBlacklist).Append("\n");
            sb.Append("  AddedWhitelist: ").Append(AddedWhitelist).Append("\n");
            sb.Append("  RemovedWhitelist: ").Append(RemovedWhitelist).Append("\n");
            sb.Append("  RemovedBlacklist: ").Append(RemovedBlacklist).Append("\n");
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
            return this.Equals(obj as TaskAccessListRecord);
        }

        /// <summary>
        /// Returns true if TaskAccessListRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of TaskAccessListRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskAccessListRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AddedBlacklist == other.AddedBlacklist ||
                    this.AddedBlacklist != null &&
                    this.AddedBlacklist.SequenceEqual(other.AddedBlacklist)
                ) && 
                (
                    this.AddedWhitelist == other.AddedWhitelist ||
                    this.AddedWhitelist != null &&
                    this.AddedWhitelist.SequenceEqual(other.AddedWhitelist)
                ) && 
                (
                    this.RemovedWhitelist == other.RemovedWhitelist ||
                    this.RemovedWhitelist != null &&
                    this.RemovedWhitelist.SequenceEqual(other.RemovedWhitelist)
                ) && 
                (
                    this.RemovedBlacklist == other.RemovedBlacklist ||
                    this.RemovedBlacklist != null &&
                    this.RemovedBlacklist.SequenceEqual(other.RemovedBlacklist)
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
                if (this.AddedBlacklist != null)
                    hash = hash * 59 + this.AddedBlacklist.GetHashCode();
                if (this.AddedWhitelist != null)
                    hash = hash * 59 + this.AddedWhitelist.GetHashCode();
                if (this.RemovedWhitelist != null)
                    hash = hash * 59 + this.RemovedWhitelist.GetHashCode();
                if (this.RemovedBlacklist != null)
                    hash = hash * 59 + this.RemovedBlacklist.GetHashCode();
                return hash;
            }
        }
    }

}
