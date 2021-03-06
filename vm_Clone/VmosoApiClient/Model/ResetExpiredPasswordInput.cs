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
    /// ResetExpiredPasswordInput
    /// </summary>
    [DataContract]
    public partial class ResetExpiredPasswordInput :  IEquatable<ResetExpiredPasswordInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetExpiredPasswordInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResetExpiredPasswordInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetExpiredPasswordInput" /> class.
        /// </summary>
        /// <param name="OldPassword"> (required).</param>
        /// <param name="NewPassword"> (required).</param>
        /// <param name="ConfirmPassword"> (required).</param>
        /// <param name="Username"> (required).</param>
        public ResetExpiredPasswordInput(string OldPassword = null, string NewPassword = null, string ConfirmPassword = null, string Username = null)
        {
            // to ensure "OldPassword" is required (not null)
            if (OldPassword == null)
            {
                throw new InvalidDataException("OldPassword is a required property for ResetExpiredPasswordInput and cannot be null");
            }
            else
            {
                this.OldPassword = OldPassword;
            }
            // to ensure "NewPassword" is required (not null)
            if (NewPassword == null)
            {
                throw new InvalidDataException("NewPassword is a required property for ResetExpiredPasswordInput and cannot be null");
            }
            else
            {
                this.NewPassword = NewPassword;
            }
            // to ensure "ConfirmPassword" is required (not null)
            if (ConfirmPassword == null)
            {
                throw new InvalidDataException("ConfirmPassword is a required property for ResetExpiredPasswordInput and cannot be null");
            }
            else
            {
                this.ConfirmPassword = ConfirmPassword;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for ResetExpiredPasswordInput and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="oldPassword", EmitDefaultValue=false)]
        public string OldPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="newPassword", EmitDefaultValue=false)]
        public string NewPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="confirmPassword", EmitDefaultValue=false)]
        public string ConfirmPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetExpiredPasswordInput {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
            sb.Append("  ConfirmPassword: ").Append(ConfirmPassword).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(obj as ResetExpiredPasswordInput);
        }

        /// <summary>
        /// Returns true if ResetExpiredPasswordInput instances are equal
        /// </summary>
        /// <param name="other">Instance of ResetExpiredPasswordInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResetExpiredPasswordInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OldPassword == other.OldPassword ||
                    this.OldPassword != null &&
                    this.OldPassword.Equals(other.OldPassword)
                ) && 
                (
                    this.NewPassword == other.NewPassword ||
                    this.NewPassword != null &&
                    this.NewPassword.Equals(other.NewPassword)
                ) && 
                (
                    this.ConfirmPassword == other.ConfirmPassword ||
                    this.ConfirmPassword != null &&
                    this.ConfirmPassword.Equals(other.ConfirmPassword)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.OldPassword != null)
                    hash = hash * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hash = hash * 59 + this.NewPassword.GetHashCode();
                if (this.ConfirmPassword != null)
                    hash = hash * 59 + this.ConfirmPassword.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }
    }

}
