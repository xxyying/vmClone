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
    /// InvitationRecord
    /// </summary>
    [DataContract]
    public partial class InvitationRecord :  IEquatable<InvitationRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationRecord" /> class.
        /// </summary>
        /// <param name="Agent">Invite type..</param>
        /// <param name="Type">Invitation type..</param>
        /// <param name="Timestamp">Timestamp..</param>
        public InvitationRecord(string Agent = null, string Type = null, int? Timestamp = null)
        {
            this.Agent = Agent;
            this.Type = Type;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Invite type.
        /// </summary>
        /// <value>Invite type.</value>
        [DataMember(Name="agent", EmitDefaultValue=false)]
        public string Agent { get; set; }
        /// <summary>
        /// Invitation type.
        /// </summary>
        /// <value>Invitation type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Timestamp.
        /// </summary>
        /// <value>Timestamp.</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationRecord {\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(obj as InvitationRecord);
        }

        /// <summary>
        /// Returns true if InvitationRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of InvitationRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvitationRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Agent == other.Agent ||
                    this.Agent != null &&
                    this.Agent.Equals(other.Agent)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
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
                if (this.Agent != null)
                    hash = hash * 59 + this.Agent.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                return hash;
            }
        }
    }

}
