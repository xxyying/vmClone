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
    /// ImportUserRecord
    /// </summary>
    [DataContract]
    public partial class ImportUserRecord :  IEquatable<ImportUserRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportUserRecord" /> class.
        /// </summary>
        /// <param name="LastName">last name.</param>
        /// <param name="DisplayName">User display name..</param>
        /// <param name="JobTitle">job title.</param>
        /// <param name="FirstName">first name.</param>
        /// <param name="Phone">User phone.</param>
        /// <param name="Invalid">User is in blacklist or not.</param>
        /// <param name="Company">company.</param>
        /// <param name="IsRegistered">is registered user.</param>
        /// <param name="Id">User id..</param>
        /// <param name="Department">department.</param>
        /// <param name="Key">key for paging in UI..</param>
        /// <param name="Email">User email..</param>
        /// <param name="Status">User status.</param>
        public ImportUserRecord(string LastName = null, string DisplayName = null, string JobTitle = null, string FirstName = null, string Phone = null, string Invalid = null, string Company = null, bool? IsRegistered = null, string Id = null, string Department = null, string Key = null, string Email = null, string Status = null)
        {
            this.LastName = LastName;
            this.DisplayName = DisplayName;
            this.JobTitle = JobTitle;
            this.FirstName = FirstName;
            this.Phone = Phone;
            this.Invalid = Invalid;
            this.Company = Company;
            this.IsRegistered = IsRegistered;
            this.Id = Id;
            this.Department = Department;
            this.Key = Key;
            this.Email = Email;
            this.Status = Status;
        }
        
        /// <summary>
        /// last name
        /// </summary>
        /// <value>last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// User display name.
        /// </summary>
        /// <value>User display name.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// job title
        /// </summary>
        /// <value>job title</value>
        [DataMember(Name="jobTitle", EmitDefaultValue=false)]
        public string JobTitle { get; set; }
        /// <summary>
        /// first name
        /// </summary>
        /// <value>first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// User phone
        /// </summary>
        /// <value>User phone</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// User is in blacklist or not
        /// </summary>
        /// <value>User is in blacklist or not</value>
        [DataMember(Name="invalid", EmitDefaultValue=false)]
        public string Invalid { get; set; }
        /// <summary>
        /// company
        /// </summary>
        /// <value>company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
        /// <summary>
        /// is registered user
        /// </summary>
        /// <value>is registered user</value>
        [DataMember(Name="isRegistered", EmitDefaultValue=false)]
        public bool? IsRegistered { get; set; }
        /// <summary>
        /// User id.
        /// </summary>
        /// <value>User id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// department
        /// </summary>
        /// <value>department</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// key for paging in UI.
        /// </summary>
        /// <value>key for paging in UI.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// User email.
        /// </summary>
        /// <value>User email.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// User status
        /// </summary>
        /// <value>User status</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportUserRecord {\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Invalid: ").Append(Invalid).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as ImportUserRecord);
        }

        /// <summary>
        /// Returns true if ImportUserRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportUserRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportUserRecord other)
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
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Invalid == other.Invalid ||
                    this.Invalid != null &&
                    this.Invalid.Equals(other.Invalid)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.IsRegistered == other.IsRegistered ||
                    this.IsRegistered != null &&
                    this.IsRegistered.Equals(other.IsRegistered)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Invalid != null)
                    hash = hash * 59 + this.Invalid.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.IsRegistered != null)
                    hash = hash * 59 + this.IsRegistered.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }
    }

}
