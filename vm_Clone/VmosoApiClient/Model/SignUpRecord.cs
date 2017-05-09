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
    /// SignUpRecord
    /// </summary>
    [DataContract]
    public partial class SignUpRecord :  IEquatable<SignUpRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignUpRecord" /> class.
        /// </summary>
        /// <param name="LastName">User lastName.</param>
        /// <param name="PromotionCode">Promotion code provided by marketing inviting campaign.</param>
        /// <param name="ContactKey">User contact Key.</param>
        /// <param name="Language">user language.</param>
        /// <param name="AccessToken">User accessToken for register.</param>
        /// <param name="Type">registration type.</param>
        /// <param name="UserKey">User Key for register.</param>
        /// <param name="Target">Target URL.</param>
        /// <param name="UserTimezone">user timezone.</param>
        /// <param name="FirstName">User firstName.</param>
        /// <param name="Password">User password for register.</param>
        /// <param name="CountryCode">Country code for phone number.</param>
        /// <param name="Smscode">Validation code for phone number.</param>
        /// <param name="ConfirmPassword">User confirmpassword.</param>
        /// <param name="ImplicitInvite">Is implicit connected invitation from task/space.</param>
        /// <param name="Username">User name for register.</param>
        public SignUpRecord(string LastName = null, string PromotionCode = null, string ContactKey = null, string Language = null, string AccessToken = null, string Type = null, string UserKey = null, string Target = null, string UserTimezone = null, string FirstName = null, string Password = null, string CountryCode = null, string Smscode = null, string ConfirmPassword = null, bool? ImplicitInvite = null, string Username = null)
        {
            this.LastName = LastName;
            this.PromotionCode = PromotionCode;
            this.ContactKey = ContactKey;
            this.Language = Language;
            this.AccessToken = AccessToken;
            this.Type = Type;
            this.UserKey = UserKey;
            this.Target = Target;
            this.UserTimezone = UserTimezone;
            this.FirstName = FirstName;
            this.Password = Password;
            this.CountryCode = CountryCode;
            this.Smscode = Smscode;
            this.ConfirmPassword = ConfirmPassword;
            this.ImplicitInvite = ImplicitInvite;
            this.Username = Username;
        }
        
        /// <summary>
        /// User lastName
        /// </summary>
        /// <value>User lastName</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Promotion code provided by marketing inviting campaign
        /// </summary>
        /// <value>Promotion code provided by marketing inviting campaign</value>
        [DataMember(Name="promotionCode", EmitDefaultValue=false)]
        public string PromotionCode { get; set; }
        /// <summary>
        /// User contact Key
        /// </summary>
        /// <value>User contact Key</value>
        [DataMember(Name="contactKey", EmitDefaultValue=false)]
        public string ContactKey { get; set; }
        /// <summary>
        /// user language
        /// </summary>
        /// <value>user language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// User accessToken for register
        /// </summary>
        /// <value>User accessToken for register</value>
        [DataMember(Name="accessToken", EmitDefaultValue=false)]
        public string AccessToken { get; set; }
        /// <summary>
        /// registration type
        /// </summary>
        /// <value>registration type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// User Key for register
        /// </summary>
        /// <value>User Key for register</value>
        [DataMember(Name="userKey", EmitDefaultValue=false)]
        public string UserKey { get; set; }
        /// <summary>
        /// Target URL
        /// </summary>
        /// <value>Target URL</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public string Target { get; set; }
        /// <summary>
        /// user timezone
        /// </summary>
        /// <value>user timezone</value>
        [DataMember(Name="user_timezone", EmitDefaultValue=false)]
        public string UserTimezone { get; set; }
        /// <summary>
        /// User firstName
        /// </summary>
        /// <value>User firstName</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// User password for register
        /// </summary>
        /// <value>User password for register</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Country code for phone number
        /// </summary>
        /// <value>Country code for phone number</value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Validation code for phone number
        /// </summary>
        /// <value>Validation code for phone number</value>
        [DataMember(Name="smscode", EmitDefaultValue=false)]
        public string Smscode { get; set; }
        /// <summary>
        /// User confirmpassword
        /// </summary>
        /// <value>User confirmpassword</value>
        [DataMember(Name="confirmPassword", EmitDefaultValue=false)]
        public string ConfirmPassword { get; set; }
        /// <summary>
        /// Is implicit connected invitation from task/space
        /// </summary>
        /// <value>Is implicit connected invitation from task/space</value>
        [DataMember(Name="implicitInvite", EmitDefaultValue=false)]
        public bool? ImplicitInvite { get; set; }
        /// <summary>
        /// User name for register
        /// </summary>
        /// <value>User name for register</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignUpRecord {\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PromotionCode: ").Append(PromotionCode).Append("\n");
            sb.Append("  ContactKey: ").Append(ContactKey).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserKey: ").Append(UserKey).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  UserTimezone: ").Append(UserTimezone).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Smscode: ").Append(Smscode).Append("\n");
            sb.Append("  ConfirmPassword: ").Append(ConfirmPassword).Append("\n");
            sb.Append("  ImplicitInvite: ").Append(ImplicitInvite).Append("\n");
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
            return this.Equals(obj as SignUpRecord);
        }

        /// <summary>
        /// Returns true if SignUpRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SignUpRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignUpRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.PromotionCode == other.PromotionCode ||
                    this.PromotionCode != null &&
                    this.PromotionCode.Equals(other.PromotionCode)
                ) && 
                (
                    this.ContactKey == other.ContactKey ||
                    this.ContactKey != null &&
                    this.ContactKey.Equals(other.ContactKey)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.AccessToken == other.AccessToken ||
                    this.AccessToken != null &&
                    this.AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.UserKey == other.UserKey ||
                    this.UserKey != null &&
                    this.UserKey.Equals(other.UserKey)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                ) && 
                (
                    this.UserTimezone == other.UserTimezone ||
                    this.UserTimezone != null &&
                    this.UserTimezone.Equals(other.UserTimezone)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.Smscode == other.Smscode ||
                    this.Smscode != null &&
                    this.Smscode.Equals(other.Smscode)
                ) && 
                (
                    this.ConfirmPassword == other.ConfirmPassword ||
                    this.ConfirmPassword != null &&
                    this.ConfirmPassword.Equals(other.ConfirmPassword)
                ) && 
                (
                    this.ImplicitInvite == other.ImplicitInvite ||
                    this.ImplicitInvite != null &&
                    this.ImplicitInvite.Equals(other.ImplicitInvite)
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
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.PromotionCode != null)
                    hash = hash * 59 + this.PromotionCode.GetHashCode();
                if (this.ContactKey != null)
                    hash = hash * 59 + this.ContactKey.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.AccessToken != null)
                    hash = hash * 59 + this.AccessToken.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.UserKey != null)
                    hash = hash * 59 + this.UserKey.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                if (this.UserTimezone != null)
                    hash = hash * 59 + this.UserTimezone.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.Smscode != null)
                    hash = hash * 59 + this.Smscode.GetHashCode();
                if (this.ConfirmPassword != null)
                    hash = hash * 59 + this.ConfirmPassword.GetHashCode();
                if (this.ImplicitInvite != null)
                    hash = hash * 59 + this.ImplicitInvite.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                return hash;
            }
        }
    }

}
