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
    /// TutorialRecord
    /// </summary>
    [DataContract]
    public partial class TutorialRecord :  IEquatable<TutorialRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TutorialRecord" /> class.
        /// </summary>
        /// <param name="Completeprofile">Complete profile.</param>
        /// <param name="Uploadfile">Upload file.</param>
        /// <param name="Filecontent">File content.</param>
        /// <param name="Reviewsettings">Review settings.</param>
        /// <param name="Invite">Invite users.</param>
        /// <param name="Createtask">Create task.</param>
        public TutorialRecord(bool? Completeprofile = null, bool? Uploadfile = null, bool? Filecontent = null, bool? Reviewsettings = null, bool? Invite = null, bool? Createtask = null)
        {
            this.Completeprofile = Completeprofile;
            this.Uploadfile = Uploadfile;
            this.Filecontent = Filecontent;
            this.Reviewsettings = Reviewsettings;
            this.Invite = Invite;
            this.Createtask = Createtask;
        }
        
        /// <summary>
        /// Complete profile
        /// </summary>
        /// <value>Complete profile</value>
        [DataMember(Name="completeprofile", EmitDefaultValue=false)]
        public bool? Completeprofile { get; set; }
        /// <summary>
        /// Upload file
        /// </summary>
        /// <value>Upload file</value>
        [DataMember(Name="uploadfile", EmitDefaultValue=false)]
        public bool? Uploadfile { get; set; }
        /// <summary>
        /// File content
        /// </summary>
        /// <value>File content</value>
        [DataMember(Name="filecontent", EmitDefaultValue=false)]
        public bool? Filecontent { get; set; }
        /// <summary>
        /// Review settings
        /// </summary>
        /// <value>Review settings</value>
        [DataMember(Name="reviewsettings", EmitDefaultValue=false)]
        public bool? Reviewsettings { get; set; }
        /// <summary>
        /// Invite users
        /// </summary>
        /// <value>Invite users</value>
        [DataMember(Name="invite", EmitDefaultValue=false)]
        public bool? Invite { get; set; }
        /// <summary>
        /// Create task
        /// </summary>
        /// <value>Create task</value>
        [DataMember(Name="createtask", EmitDefaultValue=false)]
        public bool? Createtask { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TutorialRecord {\n");
            sb.Append("  Completeprofile: ").Append(Completeprofile).Append("\n");
            sb.Append("  Uploadfile: ").Append(Uploadfile).Append("\n");
            sb.Append("  Filecontent: ").Append(Filecontent).Append("\n");
            sb.Append("  Reviewsettings: ").Append(Reviewsettings).Append("\n");
            sb.Append("  Invite: ").Append(Invite).Append("\n");
            sb.Append("  Createtask: ").Append(Createtask).Append("\n");
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
            return this.Equals(obj as TutorialRecord);
        }

        /// <summary>
        /// Returns true if TutorialRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of TutorialRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TutorialRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Completeprofile == other.Completeprofile ||
                    this.Completeprofile != null &&
                    this.Completeprofile.Equals(other.Completeprofile)
                ) && 
                (
                    this.Uploadfile == other.Uploadfile ||
                    this.Uploadfile != null &&
                    this.Uploadfile.Equals(other.Uploadfile)
                ) && 
                (
                    this.Filecontent == other.Filecontent ||
                    this.Filecontent != null &&
                    this.Filecontent.Equals(other.Filecontent)
                ) && 
                (
                    this.Reviewsettings == other.Reviewsettings ||
                    this.Reviewsettings != null &&
                    this.Reviewsettings.Equals(other.Reviewsettings)
                ) && 
                (
                    this.Invite == other.Invite ||
                    this.Invite != null &&
                    this.Invite.Equals(other.Invite)
                ) && 
                (
                    this.Createtask == other.Createtask ||
                    this.Createtask != null &&
                    this.Createtask.Equals(other.Createtask)
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
                if (this.Completeprofile != null)
                    hash = hash * 59 + this.Completeprofile.GetHashCode();
                if (this.Uploadfile != null)
                    hash = hash * 59 + this.Uploadfile.GetHashCode();
                if (this.Filecontent != null)
                    hash = hash * 59 + this.Filecontent.GetHashCode();
                if (this.Reviewsettings != null)
                    hash = hash * 59 + this.Reviewsettings.GetHashCode();
                if (this.Invite != null)
                    hash = hash * 59 + this.Invite.GetHashCode();
                if (this.Createtask != null)
                    hash = hash * 59 + this.Createtask.GetHashCode();
                return hash;
            }
        }
    }

}