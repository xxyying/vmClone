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
    /// 
    /// </summary>
    [DataContract]
    public partial class RestrictedValidationResult :  IEquatable<RestrictedValidationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedValidationResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestrictedValidationResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictedValidationResult" /> class.
        /// </summary>
        /// <param name="IsValid"> (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        /// <param name="RejectedUsers">.</param>
        public RestrictedValidationResult(bool? IsValid = null, ResponseHeaderRecord Hdr = null, List<string> RejectedUsers = null)
        {
            // to ensure "IsValid" is required (not null)
            if (IsValid == null)
            {
                throw new InvalidDataException("IsValid is a required property for RestrictedValidationResult and cannot be null");
            }
            else
            {
                this.IsValid = IsValid;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for RestrictedValidationResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
            this.RejectedUsers = RejectedUsers;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }
        /// <summary>
        /// Gets or Sets Hdr
        /// </summary>
        [DataMember(Name="_hdr", EmitDefaultValue=false)]
        public ResponseHeaderRecord Hdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="rejectedUsers", EmitDefaultValue=false)]
        public List<string> RejectedUsers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestrictedValidationResult {\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Hdr: ").Append(Hdr).Append("\n");
            sb.Append("  RejectedUsers: ").Append(RejectedUsers).Append("\n");
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
            return this.Equals(obj as RestrictedValidationResult);
        }

        /// <summary>
        /// Returns true if RestrictedValidationResult instances are equal
        /// </summary>
        /// <param name="other">Instance of RestrictedValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestrictedValidationResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsValid == other.IsValid ||
                    this.IsValid != null &&
                    this.IsValid.Equals(other.IsValid)
                ) && 
                (
                    this.Hdr == other.Hdr ||
                    this.Hdr != null &&
                    this.Hdr.Equals(other.Hdr)
                ) && 
                (
                    this.RejectedUsers == other.RejectedUsers ||
                    this.RejectedUsers != null &&
                    this.RejectedUsers.SequenceEqual(other.RejectedUsers)
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
                if (this.IsValid != null)
                    hash = hash * 59 + this.IsValid.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                if (this.RejectedUsers != null)
                    hash = hash * 59 + this.RejectedUsers.GetHashCode();
                return hash;
            }
        }
    }

}
