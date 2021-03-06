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
    /// EmailInvitationRecord
    /// </summary>
    [DataContract]
    public partial class EmailInvitationRecord : InvitationRecord,  IEquatable<EmailInvitationRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailInvitationRecord" /> class.
        /// </summary>
        /// <param name="Agent">Invite type..</param>
        /// <param name="Type">Invitation type..</param>
        /// <param name="Timestamp">Timestamp..</param>
        /// <param name="ContactName">Contact name..</param>
        /// <param name="ContactKey">Contact key..</param>
        /// <param name="UKey">Invited user key..</param>
        /// <param name="AccessToken">Invitation access token..</param>
        /// <param name="UserName">User name..</param>
        /// <param name="ImplicitInvite">Is implicit connected invitation from task/space.</param>
        public EmailInvitationRecord(string Agent = null, string Type = null, int? Timestamp = null, string ContactName = null, string ContactKey = null, string UKey = null, string AccessToken = null, string UserName = null, bool? ImplicitInvite = null)
        {
            this.Agent = Agent;
            this.Type = Type;
            this.Timestamp = Timestamp;
            this.ContactName = ContactName;
            this.ContactKey = ContactKey;
            this.UKey = UKey;
            this.AccessToken = AccessToken;
            this.UserName = UserName;
            this.ImplicitInvite = ImplicitInvite;
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
        /// Contact name.
        /// </summary>
        /// <value>Contact name.</value>
        [DataMember(Name="contactName", EmitDefaultValue=false)]
        public string ContactName { get; set; }
        /// <summary>
        /// Contact key.
        /// </summary>
        /// <value>Contact key.</value>
        [DataMember(Name="contactKey", EmitDefaultValue=false)]
        public string ContactKey { get; set; }
        /// <summary>
        /// Invited user key.
        /// </summary>
        /// <value>Invited user key.</value>
        [DataMember(Name="uKey", EmitDefaultValue=false)]
        public string UKey { get; set; }
        /// <summary>
        /// Invitation access token.
        /// </summary>
        /// <value>Invitation access token.</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// User name.
        /// </summary>
        /// <value>User name.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Is implicit connected invitation from task/space
        /// </summary>
        /// <value>Is implicit connected invitation from task/space</value>
        [DataMember(Name="implicitInvite", EmitDefaultValue=false)]
        public bool? ImplicitInvite { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailInvitationRecord {\n");
            sb.Append("  Agent: ").Append(Agent).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  ContactKey: ").Append(ContactKey).Append("\n");
            sb.Append("  UKey: ").Append(UKey).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  ImplicitInvite: ").Append(ImplicitInvite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as EmailInvitationRecord);
        }

        /// <summary>
        /// Returns true if EmailInvitationRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailInvitationRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailInvitationRecord other)
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
                ) && 
                (
                    this.ContactName == other.ContactName ||
                    this.ContactName != null &&
                    this.ContactName.Equals(other.ContactName)
                ) && 
                (
                    this.ContactKey == other.ContactKey ||
                    this.ContactKey != null &&
                    this.ContactKey.Equals(other.ContactKey)
                ) && 
                (
                    this.UKey == other.UKey ||
                    this.UKey != null &&
                    this.UKey.Equals(other.UKey)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.ImplicitInvite == other.ImplicitInvite ||
                    this.ImplicitInvite != null &&
                    this.ImplicitInvite.Equals(other.ImplicitInvite)
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
                if (this.ContactName != null)
                    hash = hash * 59 + this.ContactName.GetHashCode();
                if (this.ContactKey != null)
                    hash = hash * 59 + this.ContactKey.GetHashCode();
                if (this.UKey != null)
                    hash = hash * 59 + this.UKey.GetHashCode();
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.ImplicitInvite != null)
                    hash = hash * 59 + this.ImplicitInvite.GetHashCode();
                return hash;
            }
        }
    }

}
