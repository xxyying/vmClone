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
    /// AcceptNewUserInvitationInput
    /// </summary>
    [DataContract]
    public partial class AcceptNewUserInvitationInput :  IEquatable<AcceptNewUserInvitationInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptNewUserInvitationInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AcceptNewUserInvitationInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptNewUserInvitationInput" /> class.
        /// </summary>
        /// <param name="EmailInvitationRecord">EmailInvitationRecord (required).</param>
        public AcceptNewUserInvitationInput(EmailInvitationRecord EmailInvitationRecord = null)
        {
            // to ensure "EmailInvitationRecord" is required (not null)
            if (EmailInvitationRecord == null)
            {
                throw new InvalidDataException("EmailInvitationRecord is a required property for AcceptNewUserInvitationInput and cannot be null");
            }
            else
            {
                this.EmailInvitationRecord = EmailInvitationRecord;
            }
        }
        
        /// <summary>
        /// Gets or Sets EmailInvitationRecord
        /// </summary>
        [DataMember(Name="emailInvitationRecord", EmitDefaultValue=false)]
        public EmailInvitationRecord EmailInvitationRecord { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcceptNewUserInvitationInput {\n");
            sb.Append("  EmailInvitationRecord: ").Append(EmailInvitationRecord).Append("\n");
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
            return this.Equals(obj as AcceptNewUserInvitationInput);
        }

        /// <summary>
        /// Returns true if AcceptNewUserInvitationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of AcceptNewUserInvitationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcceptNewUserInvitationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailInvitationRecord == other.EmailInvitationRecord ||
                    this.EmailInvitationRecord != null &&
                    this.EmailInvitationRecord.Equals(other.EmailInvitationRecord)
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
                if (this.EmailInvitationRecord != null)
                    hash = hash * 59 + this.EmailInvitationRecord.GetHashCode();
                return hash;
            }
        }
    }

}
