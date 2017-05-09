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
    /// InviteEmailAddressInput
    /// </summary>
    [DataContract]
    public partial class InviteEmailAddressInput :  IEquatable<InviteEmailAddressInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteEmailAddressInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteEmailAddressInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteEmailAddressInput" /> class.
        /// </summary>
        /// <param name="InvitationType"> (required).</param>
        /// <param name="EmailFlag"> (required).</param>
        /// <param name="InvitedUserNames"> (required).</param>
        /// <param name="InvitationMsg"> (required).</param>
        public InviteEmailAddressInput(string InvitationType = null, bool? EmailFlag = null, string InvitedUserNames = null, string InvitationMsg = null)
        {
            // to ensure "InvitationType" is required (not null)
            if (InvitationType == null)
            {
                throw new InvalidDataException("InvitationType is a required property for InviteEmailAddressInput and cannot be null");
            }
            else
            {
                this.InvitationType = InvitationType;
            }
            // to ensure "EmailFlag" is required (not null)
            if (EmailFlag == null)
            {
                throw new InvalidDataException("EmailFlag is a required property for InviteEmailAddressInput and cannot be null");
            }
            else
            {
                this.EmailFlag = EmailFlag;
            }
            // to ensure "InvitedUserNames" is required (not null)
            if (InvitedUserNames == null)
            {
                throw new InvalidDataException("InvitedUserNames is a required property for InviteEmailAddressInput and cannot be null");
            }
            else
            {
                this.InvitedUserNames = InvitedUserNames;
            }
            // to ensure "InvitationMsg" is required (not null)
            if (InvitationMsg == null)
            {
                throw new InvalidDataException("InvitationMsg is a required property for InviteEmailAddressInput and cannot be null");
            }
            else
            {
                this.InvitationMsg = InvitationMsg;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="invitationType", EmitDefaultValue=false)]
        public string InvitationType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="emailFlag", EmitDefaultValue=false)]
        public bool? EmailFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="invitedUserNames", EmitDefaultValue=false)]
        public string InvitedUserNames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="invitationMsg", EmitDefaultValue=false)]
        public string InvitationMsg { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteEmailAddressInput {\n");
            sb.Append("  InvitationType: ").Append(InvitationType).Append("\n");
            sb.Append("  EmailFlag: ").Append(EmailFlag).Append("\n");
            sb.Append("  InvitedUserNames: ").Append(InvitedUserNames).Append("\n");
            sb.Append("  InvitationMsg: ").Append(InvitationMsg).Append("\n");
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
            return this.Equals(obj as InviteEmailAddressInput);
        }

        /// <summary>
        /// Returns true if InviteEmailAddressInput instances are equal
        /// </summary>
        /// <param name="other">Instance of InviteEmailAddressInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteEmailAddressInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InvitationType == other.InvitationType ||
                    this.InvitationType != null &&
                    this.InvitationType.Equals(other.InvitationType)
                ) && 
                (
                    this.EmailFlag == other.EmailFlag ||
                    this.EmailFlag != null &&
                    this.EmailFlag.Equals(other.EmailFlag)
                ) && 
                (
                    this.InvitedUserNames == other.InvitedUserNames ||
                    this.InvitedUserNames != null &&
                    this.InvitedUserNames.Equals(other.InvitedUserNames)
                ) && 
                (
                    this.InvitationMsg == other.InvitationMsg ||
                    this.InvitationMsg != null &&
                    this.InvitationMsg.Equals(other.InvitationMsg)
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
                if (this.InvitationType != null)
                    hash = hash * 59 + this.InvitationType.GetHashCode();
                if (this.EmailFlag != null)
                    hash = hash * 59 + this.EmailFlag.GetHashCode();
                if (this.InvitedUserNames != null)
                    hash = hash * 59 + this.InvitedUserNames.GetHashCode();
                if (this.InvitationMsg != null)
                    hash = hash * 59 + this.InvitationMsg.GetHashCode();
                return hash;
            }
        }
    }

}
