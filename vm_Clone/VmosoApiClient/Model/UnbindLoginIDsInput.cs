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
    /// UnbindLoginIDsInput
    /// </summary>
    [DataContract]
    public partial class UnbindLoginIDsInput :  IEquatable<UnbindLoginIDsInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnbindLoginIDsInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnbindLoginIDsInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnbindLoginIDsInput" /> class.
        /// </summary>
        /// <param name="Password"> (required).</param>
        /// <param name="Records">.</param>
        public UnbindLoginIDsInput(string Password = null, List<LoginAccountRecord> Records = null)
        {
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for UnbindLoginIDsInput and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            this.Records = Records;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="records", EmitDefaultValue=false)]
        public List<LoginAccountRecord> Records { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnbindLoginIDsInput {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(obj as UnbindLoginIDsInput);
        }

        /// <summary>
        /// Returns true if UnbindLoginIDsInput instances are equal
        /// </summary>
        /// <param name="other">Instance of UnbindLoginIDsInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnbindLoginIDsInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Records == other.Records ||
                    this.Records != null &&
                    this.Records.SequenceEqual(other.Records)
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
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Records != null)
                    hash = hash * 59 + this.Records.GetHashCode();
                return hash;
            }
        }
    }

}