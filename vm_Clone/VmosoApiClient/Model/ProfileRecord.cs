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
    /// ProfileRecord
    /// </summary>
    [DataContract]
    public partial class ProfileRecord :  IEquatable<ProfileRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileRecord" /> class.
        /// </summary>
        /// <param name="Country">Country.</param>
        /// <param name="DisplayName">Display name.</param>
        /// <param name="IconMedium">Medium icon.</param>
        /// <param name="About">About.</param>
        /// <param name="IconLarge">Large icon.</param>
        /// <param name="ContactType">Contact type.</param>
        /// <param name="Language">Language.</param>
        /// <param name="Linkedin">Linked in.</param>
        /// <param name="JoinTime">Join time.</param>
        /// <param name="Skype">Skype.</param>
        /// <param name="Twitter">Twitter.</param>
        /// <param name="Weibo">Weibo.</param>
        /// <param name="Solution">User solution.</param>
        /// <param name="LastNameRomanized">Last name romanized.</param>
        /// <param name="Company">Company.</param>
        /// <param name="ShowTrusted">Whether show trusted tab.</param>
        /// <param name="FollowFlag">Is following.</param>
        /// <param name="IsDisabled">Check whether user is disabled.</param>
        /// <param name="Department">Department.</param>
        /// <param name="MutualConnectedCount">mutual connected count.</param>
        /// <param name="FirstName">First name.</param>
        /// <param name="JobTitle">Job title.</param>
        /// <param name="IconTiny">Tiny icon.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Qq">QQ.</param>
        /// <param name="SharedTaskCount">Shared task count.</param>
        /// <param name="CopyDestination">copy destination email address.</param>
        /// <param name="Wechat">Wechat.</param>
        /// <param name="LastName">Last name.</param>
        /// <param name="FirstNameRomanized">First name romanized.</param>
        /// <param name="ShowFilterCount">Whether show connected tab.</param>
        /// <param name="ShowConnected">Whether show connected tab.</param>
        /// <param name="UserKey">User Key.</param>
        /// <param name="TimeUpdated">Updated time.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="IsRegistered">Whether is registered.</param>
        /// <param name="IconSmall">Small icon.</param>
        /// <param name="IsContact">Whether is the contact of user.</param>
        public ProfileRecord(string Country = null, string DisplayName = null, string IconMedium = null, string About = null, string IconLarge = null, string ContactType = null, string Language = null, string Linkedin = null, int? JoinTime = null, string Skype = null, string Twitter = null, string Weibo = null, string Solution = null, string LastNameRomanized = null, string Company = null, string ShowTrusted = null, bool? FollowFlag = null, bool? IsDisabled = null, string Department = null, int? MutualConnectedCount = null, string FirstName = null, string JobTitle = null, string IconTiny = null, string Email = null, string Qq = null, int? SharedTaskCount = null, string CopyDestination = null, string Wechat = null, string LastName = null, string FirstNameRomanized = null, string ShowFilterCount = null, string ShowConnected = null, string UserKey = null, int? TimeUpdated = null, string Phone = null, bool? IsRegistered = null, string IconSmall = null, bool? IsContact = null)
        {
            this.Country = Country;
            this.DisplayName = DisplayName;
            this.IconMedium = IconMedium;
            this.About = About;
            this.IconLarge = IconLarge;
            this.ContactType = ContactType;
            this.Language = Language;
            this.Linkedin = Linkedin;
            this.JoinTime = JoinTime;
            this.Skype = Skype;
            this.Twitter = Twitter;
            this.Weibo = Weibo;
            this.Solution = Solution;
            this.LastNameRomanized = LastNameRomanized;
            this.Company = Company;
            this.ShowTrusted = ShowTrusted;
            this.FollowFlag = FollowFlag;
            this.IsDisabled = IsDisabled;
            this.Department = Department;
            this.MutualConnectedCount = MutualConnectedCount;
            this.FirstName = FirstName;
            this.JobTitle = JobTitle;
            this.IconTiny = IconTiny;
            this.Email = Email;
            this.Qq = Qq;
            this.SharedTaskCount = SharedTaskCount;
            this.CopyDestination = CopyDestination;
            this.Wechat = Wechat;
            this.LastName = LastName;
            this.FirstNameRomanized = FirstNameRomanized;
            this.ShowFilterCount = ShowFilterCount;
            this.ShowConnected = ShowConnected;
            this.UserKey = UserKey;
            this.TimeUpdated = TimeUpdated;
            this.Phone = Phone;
            this.IsRegistered = IsRegistered;
            this.IconSmall = IconSmall;
            this.IsContact = IsContact;
        }
        
        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Display name
        /// </summary>
        /// <value>Display name</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Medium icon
        /// </summary>
        /// <value>Medium icon</value>
        [DataMember(Name="iconMedium", EmitDefaultValue=false)]
        public string IconMedium { get; set; }
        /// <summary>
        /// About
        /// </summary>
        /// <value>About</value>
        [DataMember(Name="about", EmitDefaultValue=false)]
        public string About { get; set; }
        /// <summary>
        /// Large icon
        /// </summary>
        /// <value>Large icon</value>
        [DataMember(Name="iconLarge", EmitDefaultValue=false)]
        public string IconLarge { get; set; }
        /// <summary>
        /// Contact type
        /// </summary>
        /// <value>Contact type</value>
        [DataMember(Name="contactType", EmitDefaultValue=false)]
        public string ContactType { get; set; }
        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Linked in
        /// </summary>
        /// <value>Linked in</value>
        [DataMember(Name="linkedin", EmitDefaultValue=false)]
        public string Linkedin { get; set; }
        /// <summary>
        /// Join time
        /// </summary>
        /// <value>Join time</value>
        [DataMember(Name="join_time", EmitDefaultValue=false)]
        public int? JoinTime { get; set; }
        /// <summary>
        /// Skype
        /// </summary>
        /// <value>Skype</value>
        [DataMember(Name="skype", EmitDefaultValue=false)]
        public string Skype { get; set; }
        /// <summary>
        /// Twitter
        /// </summary>
        /// <value>Twitter</value>
        [DataMember(Name="twitter", EmitDefaultValue=false)]
        public string Twitter { get; set; }
        /// <summary>
        /// Weibo
        /// </summary>
        /// <value>Weibo</value>
        [DataMember(Name="weibo", EmitDefaultValue=false)]
        public string Weibo { get; set; }
        /// <summary>
        /// User solution
        /// </summary>
        /// <value>User solution</value>
        [DataMember(Name="solution", EmitDefaultValue=false)]
        public string Solution { get; set; }
        /// <summary>
        /// Last name romanized
        /// </summary>
        /// <value>Last name romanized</value>
        [DataMember(Name="last_name_romanized", EmitDefaultValue=false)]
        public string LastNameRomanized { get; set; }
        /// <summary>
        /// Company
        /// </summary>
        /// <value>Company</value>
        [DataMember(Name="company", EmitDefaultValue=false)]
        public string Company { get; set; }
        /// <summary>
        /// Whether show trusted tab
        /// </summary>
        /// <value>Whether show trusted tab</value>
        [DataMember(Name="show_trusted", EmitDefaultValue=false)]
        public string ShowTrusted { get; set; }
        /// <summary>
        /// Is following
        /// </summary>
        /// <value>Is following</value>
        [DataMember(Name="followFlag", EmitDefaultValue=false)]
        public bool? FollowFlag { get; set; }
        /// <summary>
        /// Check whether user is disabled
        /// </summary>
        /// <value>Check whether user is disabled</value>
        [DataMember(Name="isDisabled", EmitDefaultValue=false)]
        public bool? IsDisabled { get; set; }
        /// <summary>
        /// Department
        /// </summary>
        /// <value>Department</value>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// mutual connected count
        /// </summary>
        /// <value>mutual connected count</value>
        [DataMember(Name="mutualConnectedCount", EmitDefaultValue=false)]
        public int? MutualConnectedCount { get; set; }
        /// <summary>
        /// First name
        /// </summary>
        /// <value>First name</value>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Job title
        /// </summary>
        /// <value>Job title</value>
        [DataMember(Name="job_title", EmitDefaultValue=false)]
        public string JobTitle { get; set; }
        /// <summary>
        /// Tiny icon
        /// </summary>
        /// <value>Tiny icon</value>
        [DataMember(Name="iconTiny", EmitDefaultValue=false)]
        public string IconTiny { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        /// <value>QQ</value>
        [DataMember(Name="qq", EmitDefaultValue=false)]
        public string Qq { get; set; }
        /// <summary>
        /// Shared task count
        /// </summary>
        /// <value>Shared task count</value>
        [DataMember(Name="sharedTaskCount", EmitDefaultValue=false)]
        public int? SharedTaskCount { get; set; }
        /// <summary>
        /// copy destination email address
        /// </summary>
        /// <value>copy destination email address</value>
        [DataMember(Name="copyDestination", EmitDefaultValue=false)]
        public string CopyDestination { get; set; }
        /// <summary>
        /// Wechat
        /// </summary>
        /// <value>Wechat</value>
        [DataMember(Name="wechat", EmitDefaultValue=false)]
        public string Wechat { get; set; }
        /// <summary>
        /// Last name
        /// </summary>
        /// <value>Last name</value>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// First name romanized
        /// </summary>
        /// <value>First name romanized</value>
        [DataMember(Name="first_name_romanized", EmitDefaultValue=false)]
        public string FirstNameRomanized { get; set; }
        /// <summary>
        /// Whether show connected tab
        /// </summary>
        /// <value>Whether show connected tab</value>
        [DataMember(Name="show_filter_count", EmitDefaultValue=false)]
        public string ShowFilterCount { get; set; }
        /// <summary>
        /// Whether show connected tab
        /// </summary>
        /// <value>Whether show connected tab</value>
        [DataMember(Name="show_connected", EmitDefaultValue=false)]
        public string ShowConnected { get; set; }
        /// <summary>
        /// User Key
        /// </summary>
        /// <value>User Key</value>
        [DataMember(Name="userKey", EmitDefaultValue=false)]
        public string UserKey { get; set; }
        /// <summary>
        /// Updated time
        /// </summary>
        /// <value>Updated time</value>
        [DataMember(Name="time_updated", EmitDefaultValue=false)]
        public int? TimeUpdated { get; set; }
        /// <summary>
        /// Phone
        /// </summary>
        /// <value>Phone</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Whether is registered
        /// </summary>
        /// <value>Whether is registered</value>
        [DataMember(Name="isRegistered", EmitDefaultValue=false)]
        public bool? IsRegistered { get; set; }
        /// <summary>
        /// Small icon
        /// </summary>
        /// <value>Small icon</value>
        [DataMember(Name="iconSmall", EmitDefaultValue=false)]
        public string IconSmall { get; set; }
        /// <summary>
        /// Whether is the contact of user
        /// </summary>
        /// <value>Whether is the contact of user</value>
        [DataMember(Name="isContact", EmitDefaultValue=false)]
        public bool? IsContact { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileRecord {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  IconMedium: ").Append(IconMedium).Append("\n");
            sb.Append("  About: ").Append(About).Append("\n");
            sb.Append("  IconLarge: ").Append(IconLarge).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Linkedin: ").Append(Linkedin).Append("\n");
            sb.Append("  JoinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  Skype: ").Append(Skype).Append("\n");
            sb.Append("  Twitter: ").Append(Twitter).Append("\n");
            sb.Append("  Weibo: ").Append(Weibo).Append("\n");
            sb.Append("  Solution: ").Append(Solution).Append("\n");
            sb.Append("  LastNameRomanized: ").Append(LastNameRomanized).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  ShowTrusted: ").Append(ShowTrusted).Append("\n");
            sb.Append("  FollowFlag: ").Append(FollowFlag).Append("\n");
            sb.Append("  IsDisabled: ").Append(IsDisabled).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  MutualConnectedCount: ").Append(MutualConnectedCount).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  IconTiny: ").Append(IconTiny).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Qq: ").Append(Qq).Append("\n");
            sb.Append("  SharedTaskCount: ").Append(SharedTaskCount).Append("\n");
            sb.Append("  CopyDestination: ").Append(CopyDestination).Append("\n");
            sb.Append("  Wechat: ").Append(Wechat).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstNameRomanized: ").Append(FirstNameRomanized).Append("\n");
            sb.Append("  ShowFilterCount: ").Append(ShowFilterCount).Append("\n");
            sb.Append("  ShowConnected: ").Append(ShowConnected).Append("\n");
            sb.Append("  UserKey: ").Append(UserKey).Append("\n");
            sb.Append("  TimeUpdated: ").Append(TimeUpdated).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  IsRegistered: ").Append(IsRegistered).Append("\n");
            sb.Append("  IconSmall: ").Append(IconSmall).Append("\n");
            sb.Append("  IsContact: ").Append(IsContact).Append("\n");
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
            return this.Equals(obj as ProfileRecord);
        }

        /// <summary>
        /// Returns true if ProfileRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.IconMedium == other.IconMedium ||
                    this.IconMedium != null &&
                    this.IconMedium.Equals(other.IconMedium)
                ) && 
                (
                    this.About == other.About ||
                    this.About != null &&
                    this.About.Equals(other.About)
                ) && 
                (
                    this.IconLarge == other.IconLarge ||
                    this.IconLarge != null &&
                    this.IconLarge.Equals(other.IconLarge)
                ) && 
                (
                    this.ContactType == other.ContactType ||
                    this.ContactType != null &&
                    this.ContactType.Equals(other.ContactType)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Linkedin == other.Linkedin ||
                    this.Linkedin != null &&
                    this.Linkedin.Equals(other.Linkedin)
                ) && 
                (
                    this.JoinTime == other.JoinTime ||
                    this.JoinTime != null &&
                    this.JoinTime.Equals(other.JoinTime)
                ) && 
                (
                    this.Skype == other.Skype ||
                    this.Skype != null &&
                    this.Skype.Equals(other.Skype)
                ) && 
                (
                    this.Twitter == other.Twitter ||
                    this.Twitter != null &&
                    this.Twitter.Equals(other.Twitter)
                ) && 
                (
                    this.Weibo == other.Weibo ||
                    this.Weibo != null &&
                    this.Weibo.Equals(other.Weibo)
                ) && 
                (
                    this.Solution == other.Solution ||
                    this.Solution != null &&
                    this.Solution.Equals(other.Solution)
                ) && 
                (
                    this.LastNameRomanized == other.LastNameRomanized ||
                    this.LastNameRomanized != null &&
                    this.LastNameRomanized.Equals(other.LastNameRomanized)
                ) && 
                (
                    this.Company == other.Company ||
                    this.Company != null &&
                    this.Company.Equals(other.Company)
                ) && 
                (
                    this.ShowTrusted == other.ShowTrusted ||
                    this.ShowTrusted != null &&
                    this.ShowTrusted.Equals(other.ShowTrusted)
                ) && 
                (
                    this.FollowFlag == other.FollowFlag ||
                    this.FollowFlag != null &&
                    this.FollowFlag.Equals(other.FollowFlag)
                ) && 
                (
                    this.IsDisabled == other.IsDisabled ||
                    this.IsDisabled != null &&
                    this.IsDisabled.Equals(other.IsDisabled)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.MutualConnectedCount == other.MutualConnectedCount ||
                    this.MutualConnectedCount != null &&
                    this.MutualConnectedCount.Equals(other.MutualConnectedCount)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.JobTitle == other.JobTitle ||
                    this.JobTitle != null &&
                    this.JobTitle.Equals(other.JobTitle)
                ) && 
                (
                    this.IconTiny == other.IconTiny ||
                    this.IconTiny != null &&
                    this.IconTiny.Equals(other.IconTiny)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Qq == other.Qq ||
                    this.Qq != null &&
                    this.Qq.Equals(other.Qq)
                ) && 
                (
                    this.SharedTaskCount == other.SharedTaskCount ||
                    this.SharedTaskCount != null &&
                    this.SharedTaskCount.Equals(other.SharedTaskCount)
                ) && 
                (
                    this.CopyDestination == other.CopyDestination ||
                    this.CopyDestination != null &&
                    this.CopyDestination.Equals(other.CopyDestination)
                ) && 
                (
                    this.Wechat == other.Wechat ||
                    this.Wechat != null &&
                    this.Wechat.Equals(other.Wechat)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.FirstNameRomanized == other.FirstNameRomanized ||
                    this.FirstNameRomanized != null &&
                    this.FirstNameRomanized.Equals(other.FirstNameRomanized)
                ) && 
                (
                    this.ShowFilterCount == other.ShowFilterCount ||
                    this.ShowFilterCount != null &&
                    this.ShowFilterCount.Equals(other.ShowFilterCount)
                ) && 
                (
                    this.ShowConnected == other.ShowConnected ||
                    this.ShowConnected != null &&
                    this.ShowConnected.Equals(other.ShowConnected)
                ) && 
                (
                    this.UserKey == other.UserKey ||
                    this.UserKey != null &&
                    this.UserKey.Equals(other.UserKey)
                ) && 
                (
                    this.TimeUpdated == other.TimeUpdated ||
                    this.TimeUpdated != null &&
                    this.TimeUpdated.Equals(other.TimeUpdated)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.IsRegistered == other.IsRegistered ||
                    this.IsRegistered != null &&
                    this.IsRegistered.Equals(other.IsRegistered)
                ) && 
                (
                    this.IconSmall == other.IconSmall ||
                    this.IconSmall != null &&
                    this.IconSmall.Equals(other.IconSmall)
                ) && 
                (
                    this.IsContact == other.IsContact ||
                    this.IsContact != null &&
                    this.IsContact.Equals(other.IsContact)
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
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.IconMedium != null)
                    hash = hash * 59 + this.IconMedium.GetHashCode();
                if (this.About != null)
                    hash = hash * 59 + this.About.GetHashCode();
                if (this.IconLarge != null)
                    hash = hash * 59 + this.IconLarge.GetHashCode();
                if (this.ContactType != null)
                    hash = hash * 59 + this.ContactType.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Linkedin != null)
                    hash = hash * 59 + this.Linkedin.GetHashCode();
                if (this.JoinTime != null)
                    hash = hash * 59 + this.JoinTime.GetHashCode();
                if (this.Skype != null)
                    hash = hash * 59 + this.Skype.GetHashCode();
                if (this.Twitter != null)
                    hash = hash * 59 + this.Twitter.GetHashCode();
                if (this.Weibo != null)
                    hash = hash * 59 + this.Weibo.GetHashCode();
                if (this.Solution != null)
                    hash = hash * 59 + this.Solution.GetHashCode();
                if (this.LastNameRomanized != null)
                    hash = hash * 59 + this.LastNameRomanized.GetHashCode();
                if (this.Company != null)
                    hash = hash * 59 + this.Company.GetHashCode();
                if (this.ShowTrusted != null)
                    hash = hash * 59 + this.ShowTrusted.GetHashCode();
                if (this.FollowFlag != null)
                    hash = hash * 59 + this.FollowFlag.GetHashCode();
                if (this.IsDisabled != null)
                    hash = hash * 59 + this.IsDisabled.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.MutualConnectedCount != null)
                    hash = hash * 59 + this.MutualConnectedCount.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.JobTitle != null)
                    hash = hash * 59 + this.JobTitle.GetHashCode();
                if (this.IconTiny != null)
                    hash = hash * 59 + this.IconTiny.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Qq != null)
                    hash = hash * 59 + this.Qq.GetHashCode();
                if (this.SharedTaskCount != null)
                    hash = hash * 59 + this.SharedTaskCount.GetHashCode();
                if (this.CopyDestination != null)
                    hash = hash * 59 + this.CopyDestination.GetHashCode();
                if (this.Wechat != null)
                    hash = hash * 59 + this.Wechat.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.FirstNameRomanized != null)
                    hash = hash * 59 + this.FirstNameRomanized.GetHashCode();
                if (this.ShowFilterCount != null)
                    hash = hash * 59 + this.ShowFilterCount.GetHashCode();
                if (this.ShowConnected != null)
                    hash = hash * 59 + this.ShowConnected.GetHashCode();
                if (this.UserKey != null)
                    hash = hash * 59 + this.UserKey.GetHashCode();
                if (this.TimeUpdated != null)
                    hash = hash * 59 + this.TimeUpdated.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.IsRegistered != null)
                    hash = hash * 59 + this.IsRegistered.GetHashCode();
                if (this.IconSmall != null)
                    hash = hash * 59 + this.IconSmall.GetHashCode();
                if (this.IsContact != null)
                    hash = hash * 59 + this.IsContact.GetHashCode();
                return hash;
            }
        }
    }

}
