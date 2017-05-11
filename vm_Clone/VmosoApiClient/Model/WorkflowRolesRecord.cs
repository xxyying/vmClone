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
    /// WorkflowRolesRecord
    /// </summary>
    [DataContract]
    public partial class WorkflowRolesRecord :  IEquatable<WorkflowRolesRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRolesRecord" /> class.
        /// </summary>
        /// <param name="Roles">Names of assigned roles..</param>
        /// <param name="Who">Participant key..</param>
        public WorkflowRolesRecord(List<string> Roles = null, string Who = null)
        {
            this.Roles = Roles;
            this.Who = Who;
        }
        
        /// <summary>
        /// Names of assigned roles.
        /// </summary>
        /// <value>Names of assigned roles.</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public List<string> Roles { get; set; }
        /// <summary>
        /// Participant key.
        /// </summary>
        /// <value>Participant key.</value>
        [DataMember(Name="who", EmitDefaultValue=false)]
        public string Who { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowRolesRecord {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Who: ").Append(Who).Append("\n");
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
            return this.Equals(obj as WorkflowRolesRecord);
        }

        /// <summary>
        /// Returns true if WorkflowRolesRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowRolesRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowRolesRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    this.Who == other.Who ||
                    this.Who != null &&
                    this.Who.Equals(other.Who)
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
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.Who != null)
                    hash = hash * 59 + this.Who.GetHashCode();
                return hash;
            }
        }
    }

}