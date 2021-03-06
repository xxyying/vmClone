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
    /// SessionCredentialRecord
    /// </summary>
    [DataContract]
    public partial class SessionCredentialRecord :  IEquatable<SessionCredentialRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCredentialRecord" /> class.
        /// </summary>
        /// <param name="Svcpoint">Service call endpoint..</param>
        /// <param name="Name">Session name. This would be the HTTP cookie name to send session token..</param>
        /// <param name="Secret">Session secret shared between client and server..</param>
        /// <param name="Who">Key of authenticated principal..</param>
        /// <param name="Token">Session token..</param>
        public SessionCredentialRecord(string Svcpoint = null, string Name = null, string Secret = null, string Who = null, string Token = null)
        {
            this.Svcpoint = Svcpoint;
            this.Name = Name;
            this.Secret = Secret;
            this.Who = Who;
            this.Token = Token;
        }
        
        /// <summary>
        /// Service call endpoint.
        /// </summary>
        /// <value>Service call endpoint.</value>
        [DataMember(Name="svcpoint", EmitDefaultValue=false)]
        public string Svcpoint { get; set; }
        /// <summary>
        /// Session name. This would be the HTTP cookie name to send session token.
        /// </summary>
        /// <value>Session name. This would be the HTTP cookie name to send session token.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Session secret shared between client and server.
        /// </summary>
        /// <value>Session secret shared between client and server.</value>
        [DataMember(Name="secret", EmitDefaultValue=false)]
        public string Secret { get; set; }
        /// <summary>
        /// Key of authenticated principal.
        /// </summary>
        /// <value>Key of authenticated principal.</value>
        [DataMember(Name="who", EmitDefaultValue=false)]
        public string Who { get; set; }
        /// <summary>
        /// Session token.
        /// </summary>
        /// <value>Session token.</value>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionCredentialRecord {\n");
            sb.Append("  Svcpoint: ").Append(Svcpoint).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  Who: ").Append(Who).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(obj as SessionCredentialRecord);
        }

        /// <summary>
        /// Returns true if SessionCredentialRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SessionCredentialRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionCredentialRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Svcpoint == other.Svcpoint ||
                    this.Svcpoint != null &&
                    this.Svcpoint.Equals(other.Svcpoint)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Secret == other.Secret ||
                    this.Secret != null &&
                    this.Secret.Equals(other.Secret)
                ) && 
                (
                    this.Who == other.Who ||
                    this.Who != null &&
                    this.Who.Equals(other.Who)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
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
                if (this.Svcpoint != null)
                    hash = hash * 59 + this.Svcpoint.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Secret != null)
                    hash = hash * 59 + this.Secret.GetHashCode();
                if (this.Who != null)
                    hash = hash * 59 + this.Who.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                return hash;
            }
        }
    }

}
