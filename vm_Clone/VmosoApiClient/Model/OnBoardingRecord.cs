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
    /// OnBoardingRecord
    /// </summary>
    [DataContract]
    public partial class OnBoardingRecord :  IEquatable<OnBoardingRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnBoardingRecord" /> class.
        /// </summary>
        /// <param name="Notification">Setting notification..</param>
        /// <param name="Task">Create task..</param>
        /// <param name="File">Upload file..</param>
        /// <param name="Folder">Add to folder..</param>
        /// <param name="CompletePercentage">Complete percentage..</param>
        /// <param name="Post">post a microblog or content to a space..</param>
        /// <param name="Chat">create a chat..</param>
        /// <param name="Profile">Complete profile..</param>
        /// <param name="Share">share item to contacts or space..</param>
        /// <param name="Invite">Invite people..</param>
        /// <param name="Space">create space..</param>
        public OnBoardingRecord(string Notification = null, string Task = null, string File = null, string Folder = null, string CompletePercentage = null, string Post = null, string Chat = null, string Profile = null, string Share = null, string Invite = null, string Space = null)
        {
            this.Notification = Notification;
            this.Task = Task;
            this.File = File;
            this.Folder = Folder;
            this.CompletePercentage = CompletePercentage;
            this.Post = Post;
            this.Chat = Chat;
            this.Profile = Profile;
            this.Share = Share;
            this.Invite = Invite;
            this.Space = Space;
        }
        
        /// <summary>
        /// Setting notification.
        /// </summary>
        /// <value>Setting notification.</value>
        [DataMember(Name="notification", EmitDefaultValue=false)]
        public string Notification { get; set; }
        /// <summary>
        /// Create task.
        /// </summary>
        /// <value>Create task.</value>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public string Task { get; set; }
        /// <summary>
        /// Upload file.
        /// </summary>
        /// <value>Upload file.</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }
        /// <summary>
        /// Add to folder.
        /// </summary>
        /// <value>Add to folder.</value>
        [DataMember(Name="folder", EmitDefaultValue=false)]
        public string Folder { get; set; }
        /// <summary>
        /// Complete percentage.
        /// </summary>
        /// <value>Complete percentage.</value>
        [DataMember(Name="completePercentage", EmitDefaultValue=false)]
        public string CompletePercentage { get; set; }
        /// <summary>
        /// post a microblog or content to a space.
        /// </summary>
        /// <value>post a microblog or content to a space.</value>
        [DataMember(Name="post", EmitDefaultValue=false)]
        public string Post { get; set; }
        /// <summary>
        /// create a chat.
        /// </summary>
        /// <value>create a chat.</value>
        [DataMember(Name="chat", EmitDefaultValue=false)]
        public string Chat { get; set; }
        /// <summary>
        /// Complete profile.
        /// </summary>
        /// <value>Complete profile.</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public string Profile { get; set; }
        /// <summary>
        /// share item to contacts or space.
        /// </summary>
        /// <value>share item to contacts or space.</value>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public string Share { get; set; }
        /// <summary>
        /// Invite people.
        /// </summary>
        /// <value>Invite people.</value>
        [DataMember(Name="invite", EmitDefaultValue=false)]
        public string Invite { get; set; }
        /// <summary>
        /// create space.
        /// </summary>
        /// <value>create space.</value>
        [DataMember(Name="space", EmitDefaultValue=false)]
        public string Space { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnBoardingRecord {\n");
            sb.Append("  Notification: ").Append(Notification).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  CompletePercentage: ").Append(CompletePercentage).Append("\n");
            sb.Append("  Post: ").Append(Post).Append("\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Invite: ").Append(Invite).Append("\n");
            sb.Append("  Space: ").Append(Space).Append("\n");
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
            return this.Equals(obj as OnBoardingRecord);
        }

        /// <summary>
        /// Returns true if OnBoardingRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of OnBoardingRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnBoardingRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Notification == other.Notification ||
                    this.Notification != null &&
                    this.Notification.Equals(other.Notification)
                ) && 
                (
                    this.Task == other.Task ||
                    this.Task != null &&
                    this.Task.Equals(other.Task)
                ) && 
                (
                    this.File == other.File ||
                    this.File != null &&
                    this.File.Equals(other.File)
                ) && 
                (
                    this.Folder == other.Folder ||
                    this.Folder != null &&
                    this.Folder.Equals(other.Folder)
                ) && 
                (
                    this.CompletePercentage == other.CompletePercentage ||
                    this.CompletePercentage != null &&
                    this.CompletePercentage.Equals(other.CompletePercentage)
                ) && 
                (
                    this.Post == other.Post ||
                    this.Post != null &&
                    this.Post.Equals(other.Post)
                ) && 
                (
                    this.Chat == other.Chat ||
                    this.Chat != null &&
                    this.Chat.Equals(other.Chat)
                ) && 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) && 
                (
                    this.Share == other.Share ||
                    this.Share != null &&
                    this.Share.Equals(other.Share)
                ) && 
                (
                    this.Invite == other.Invite ||
                    this.Invite != null &&
                    this.Invite.Equals(other.Invite)
                ) && 
                (
                    this.Space == other.Space ||
                    this.Space != null &&
                    this.Space.Equals(other.Space)
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
                if (this.Notification != null)
                    hash = hash * 59 + this.Notification.GetHashCode();
                if (this.Task != null)
                    hash = hash * 59 + this.Task.GetHashCode();
                if (this.File != null)
                    hash = hash * 59 + this.File.GetHashCode();
                if (this.Folder != null)
                    hash = hash * 59 + this.Folder.GetHashCode();
                if (this.CompletePercentage != null)
                    hash = hash * 59 + this.CompletePercentage.GetHashCode();
                if (this.Post != null)
                    hash = hash * 59 + this.Post.GetHashCode();
                if (this.Chat != null)
                    hash = hash * 59 + this.Chat.GetHashCode();
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
                if (this.Share != null)
                    hash = hash * 59 + this.Share.GetHashCode();
                if (this.Invite != null)
                    hash = hash * 59 + this.Invite.GetHashCode();
                if (this.Space != null)
                    hash = hash * 59 + this.Space.GetHashCode();
                return hash;
            }
        }
    }

}
