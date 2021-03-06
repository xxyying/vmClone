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
    /// WorkflowPayloadItemRecord
    /// </summary>
    [DataContract]
    public partial class WorkflowPayloadItemRecord :  IEquatable<WorkflowPayloadItemRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPayloadItemRecord" /> class.
        /// </summary>
        /// <param name="Modes">Modes of payload corresponding to {@link $perms}..</param>
        /// <param name="Name">Name of payload..</param>
        /// <param name="Available">Availability flag..</param>
        /// <param name="Perms">Context specific permissions. Different participants may get different lists of permissions..</param>
        /// <param name="Title">Title of payload.</param>
        public WorkflowPayloadItemRecord(List<string> Modes = null, string Name = null, bool? Available = null, List<string> Perms = null, string Title = null)
        {
            this.Modes = Modes;
            this.Name = Name;
            this.Available = Available;
            this.Perms = Perms;
            this.Title = Title;
        }
        
        /// <summary>
        /// Modes of payload corresponding to {@link $perms}.
        /// </summary>
        /// <value>Modes of payload corresponding to {@link $perms}.</value>
        [DataMember(Name="modes", EmitDefaultValue=false)]
        public List<string> Modes { get; set; }
        /// <summary>
        /// Name of payload.
        /// </summary>
        /// <value>Name of payload.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Availability flag.
        /// </summary>
        /// <value>Availability flag.</value>
        [DataMember(Name="available", EmitDefaultValue=false)]
        public bool? Available { get; set; }
        /// <summary>
        /// Context specific permissions. Different participants may get different lists of permissions.
        /// </summary>
        /// <value>Context specific permissions. Different participants may get different lists of permissions.</value>
        [DataMember(Name="perms", EmitDefaultValue=false)]
        public List<string> Perms { get; set; }
        /// <summary>
        /// Title of payload
        /// </summary>
        /// <value>Title of payload</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowPayloadItemRecord {\n");
            sb.Append("  Modes: ").Append(Modes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  Perms: ").Append(Perms).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(obj as WorkflowPayloadItemRecord);
        }

        /// <summary>
        /// Returns true if WorkflowPayloadItemRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowPayloadItemRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowPayloadItemRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Modes == other.Modes ||
                    this.Modes != null &&
                    this.Modes.SequenceEqual(other.Modes)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Available == other.Available ||
                    this.Available != null &&
                    this.Available.Equals(other.Available)
                ) && 
                (
                    this.Perms == other.Perms ||
                    this.Perms != null &&
                    this.Perms.SequenceEqual(other.Perms)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
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
                if (this.Modes != null)
                    hash = hash * 59 + this.Modes.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Available != null)
                    hash = hash * 59 + this.Available.GetHashCode();
                if (this.Perms != null)
                    hash = hash * 59 + this.Perms.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                return hash;
            }
        }
    }

}
