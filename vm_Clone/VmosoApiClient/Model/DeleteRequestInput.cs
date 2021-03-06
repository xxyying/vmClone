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
    /// DeleteRequestInput
    /// </summary>
    [DataContract]
    public partial class DeleteRequestInput :  IEquatable<DeleteRequestInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestInput" /> class.
        /// </summary>
        /// <param name="InvitationType"> (required).</param>
        /// <param name="ContactKey"> (required).</param>
        public DeleteRequestInput(string InvitationType = null, string ContactKey = null)
        {
            // to ensure "InvitationType" is required (not null)
            if (InvitationType == null)
            {
                throw new InvalidDataException("InvitationType is a required property for DeleteRequestInput and cannot be null");
            }
            else
            {
                this.InvitationType = InvitationType;
            }
            // to ensure "ContactKey" is required (not null)
            if (ContactKey == null)
            {
                throw new InvalidDataException("ContactKey is a required property for DeleteRequestInput and cannot be null");
            }
            else
            {
                this.ContactKey = ContactKey;
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
        [DataMember(Name="contactKey", EmitDefaultValue=false)]
        public string ContactKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteRequestInput {\n");
            sb.Append("  InvitationType: ").Append(InvitationType).Append("\n");
            sb.Append("  ContactKey: ").Append(ContactKey).Append("\n");
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
            return this.Equals(obj as DeleteRequestInput);
        }

        /// <summary>
        /// Returns true if DeleteRequestInput instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteRequestInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteRequestInput other)
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
                    this.ContactKey == other.ContactKey ||
                    this.ContactKey != null &&
                    this.ContactKey.Equals(other.ContactKey)
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
                if (this.ContactKey != null)
                    hash = hash * 59 + this.ContactKey.GetHashCode();
                return hash;
            }
        }
    }

}
