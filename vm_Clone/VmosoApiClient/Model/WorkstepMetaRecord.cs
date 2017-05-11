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
    /// WorkstepMetaRecord
    /// </summary>
    [DataContract]
    public partial class WorkstepMetaRecord :  IEquatable<WorkstepMetaRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstepMetaRecord" /> class.
        /// </summary>
        /// <param name="Next">List of possible next steps..</param>
        /// <param name="Payloads">Information of step-specific payloads..</param>
        /// <param name="DisplayName">Step display name..</param>
        /// <param name="Roles">List of roles active in the step..</param>
        /// <param name="Name">Step name..</param>
        /// <param name="Description">Step description..</param>
        /// <param name="Alias">Step alias name. @deprecated Use $displayName instead..</param>
        public WorkstepMetaRecord(List<string> Next = null, List<WorkflowPayloadMetaRecord> Payloads = null, string DisplayName = null, List<string> Roles = null, string Name = null, string Description = null, string Alias = null)
        {
            this.Next = Next;
            this.Payloads = Payloads;
            this.DisplayName = DisplayName;
            this.Roles = Roles;
            this.Name = Name;
            this.Description = Description;
            this.Alias = Alias;
        }
        
        /// <summary>
        /// List of possible next steps.
        /// </summary>
        /// <value>List of possible next steps.</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public List<string> Next { get; set; }
        /// <summary>
        /// Information of step-specific payloads.
        /// </summary>
        /// <value>Information of step-specific payloads.</value>
        [DataMember(Name="payloads", EmitDefaultValue=false)]
        public List<WorkflowPayloadMetaRecord> Payloads { get; set; }
        /// <summary>
        /// Step display name.
        /// </summary>
        /// <value>Step display name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// List of roles active in the step.
        /// </summary>
        /// <value>List of roles active in the step.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Step name.
        /// </summary>
        /// <value>Step name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Step description.
        /// </summary>
        /// <value>Step description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Step alias name. @deprecated Use $displayName instead.
        /// </summary>
        /// <value>Step alias name. @deprecated Use $displayName instead.</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkstepMetaRecord {\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Payloads: ").Append(Payloads).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
            return this.Equals(obj as WorkstepMetaRecord);
        }

        /// <summary>
        /// Returns true if WorkstepMetaRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkstepMetaRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkstepMetaRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.SequenceEqual(other.Next)
                ) && 
                (
                    this.Payloads == other.Payloads ||
                    this.Payloads != null &&
                    this.Payloads.SequenceEqual(other.Payloads)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Alias == other.Alias ||
                    this.Alias != null &&
                    this.Alias.Equals(other.Alias)
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
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode();
                if (this.Payloads != null)
                    hash = hash * 59 + this.Payloads.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Alias != null)
                    hash = hash * 59 + this.Alias.GetHashCode();
                return hash;
            }
        }
    }

}