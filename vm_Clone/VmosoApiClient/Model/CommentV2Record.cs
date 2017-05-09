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
    /// CommentV2Record
    /// </summary>
    [DataContract]
    public partial class CommentV2Record :  IEquatable<CommentV2Record>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentV2Record" /> class.
        /// </summary>
        /// <param name="Editor">Editor.</param>
        /// <param name="ContentKey">Content Key..</param>
        /// <param name="Creator">Creator.</param>
        /// <param name="ExplicitReadCount">ExplicitReadCount.</param>
        /// <param name="CopyDestination">copy destination email address.</param>
        /// <param name="CommentCID">Comment CID.</param>
        /// <param name="IsRead">is comment read.</param>
        /// <param name="RefmeFlag">Refme flag.</param>
        /// <param name="HighlightText">Comment text with highlight..</param>
        /// <param name="Timeupdated">Comment time edited..</param>
        /// <param name="CreationMethod">Comment creation method..</param>
        /// <param name="CommentListKey">Comment List Key..</param>
        /// <param name="HasEmbeddedObjects">Identifies if the Comment has embedded objects or not.</param>
        /// <param name="ImportantFlag">important flag.</param>
        /// <param name="SubCommentCount">subComment count.</param>
        /// <param name="IsAnonymous">is comment anoynmous.</param>
        /// <param name="Timecreated">Comment creation time..</param>
        /// <param name="Ratings">Ratings.</param>
        /// <param name="CommentID">Comment ID.</param>
        /// <param name="ByContentEmail">byContentEmail.</param>
        /// <param name="CommentPID">Comment PID.</param>
        /// <param name="Text">Comment text..</param>
        /// <param name="Status">Comment status..</param>
        public CommentV2Record(DisplayRecord Editor = null, string ContentKey = null, DisplayRecord Creator = null, ObjectReadInfoRecord ExplicitReadCount = null, string CopyDestination = null, int? CommentCID = null, bool? IsRead = null, bool? RefmeFlag = null, string HighlightText = null, int? Timeupdated = null, string CreationMethod = null, string CommentListKey = null, bool? HasEmbeddedObjects = null, bool? ImportantFlag = null, int? SubCommentCount = null, string IsAnonymous = null, int? Timecreated = null, RatingsRecord Ratings = null, int? CommentID = null, bool? ByContentEmail = null, int? CommentPID = null, string Text = null, string Status = null)
        {
            this.Editor = Editor;
            this.ContentKey = ContentKey;
            this.Creator = Creator;
            this.ExplicitReadCount = ExplicitReadCount;
            this.CopyDestination = CopyDestination;
            this.CommentCID = CommentCID;
            this.IsRead = IsRead;
            this.RefmeFlag = RefmeFlag;
            this.HighlightText = HighlightText;
            this.Timeupdated = Timeupdated;
            this.CreationMethod = CreationMethod;
            this.CommentListKey = CommentListKey;
            this.HasEmbeddedObjects = HasEmbeddedObjects;
            this.ImportantFlag = ImportantFlag;
            this.SubCommentCount = SubCommentCount;
            this.IsAnonymous = IsAnonymous;
            this.Timecreated = Timecreated;
            this.Ratings = Ratings;
            this.CommentID = CommentID;
            this.ByContentEmail = ByContentEmail;
            this.CommentPID = CommentPID;
            this.Text = Text;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets Editor
        /// </summary>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public DisplayRecord Editor { get; set; }
        /// <summary>
        /// Content Key.
        /// </summary>
        /// <value>Content Key.</value>
        [DataMember(Name="contentKey", EmitDefaultValue=false)]
        public string ContentKey { get; set; }
        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name="creator", EmitDefaultValue=false)]
        public DisplayRecord Creator { get; set; }
        /// <summary>
        /// Gets or Sets ExplicitReadCount
        /// </summary>
        [DataMember(Name="explicitReadCount", EmitDefaultValue=false)]
        public ObjectReadInfoRecord ExplicitReadCount { get; set; }
        /// <summary>
        /// copy destination email address
        /// </summary>
        /// <value>copy destination email address</value>
        [DataMember(Name="copyDestination", EmitDefaultValue=false)]
        public string CopyDestination { get; set; }
        /// <summary>
        /// Comment CID
        /// </summary>
        /// <value>Comment CID</value>
        [DataMember(Name="commentCID", EmitDefaultValue=false)]
        public int? CommentCID { get; set; }
        /// <summary>
        /// is comment read
        /// </summary>
        /// <value>is comment read</value>
        [DataMember(Name="isRead", EmitDefaultValue=false)]
        public bool? IsRead { get; set; }
        /// <summary>
        /// Refme flag
        /// </summary>
        /// <value>Refme flag</value>
        [DataMember(Name="refmeFlag", EmitDefaultValue=false)]
        public bool? RefmeFlag { get; set; }
        /// <summary>
        /// Comment text with highlight.
        /// </summary>
        /// <value>Comment text with highlight.</value>
        [DataMember(Name="highlightText", EmitDefaultValue=false)]
        public string HighlightText { get; set; }
        /// <summary>
        /// Comment time edited.
        /// </summary>
        /// <value>Comment time edited.</value>
        [DataMember(Name="timeupdated", EmitDefaultValue=false)]
        public int? Timeupdated { get; set; }
        /// <summary>
        /// Comment creation method.
        /// </summary>
        /// <value>Comment creation method.</value>
        [DataMember(Name="creationMethod", EmitDefaultValue=false)]
        public string CreationMethod { get; set; }
        /// <summary>
        /// Comment List Key.
        /// </summary>
        /// <value>Comment List Key.</value>
        [DataMember(Name="commentListKey", EmitDefaultValue=false)]
        public string CommentListKey { get; set; }
        /// <summary>
        /// Identifies if the Comment has embedded objects or not
        /// </summary>
        /// <value>Identifies if the Comment has embedded objects or not</value>
        [DataMember(Name="hasEmbeddedObjects", EmitDefaultValue=false)]
        public bool? HasEmbeddedObjects { get; set; }
        /// <summary>
        /// important flag
        /// </summary>
        /// <value>important flag</value>
        [DataMember(Name="importantFlag", EmitDefaultValue=false)]
        public bool? ImportantFlag { get; set; }
        /// <summary>
        /// subComment count
        /// </summary>
        /// <value>subComment count</value>
        [DataMember(Name="subCommentCount", EmitDefaultValue=false)]
        public int? SubCommentCount { get; set; }
        /// <summary>
        /// is comment anoynmous
        /// </summary>
        /// <value>is comment anoynmous</value>
        [DataMember(Name="isAnonymous", EmitDefaultValue=false)]
        public string IsAnonymous { get; set; }
        /// <summary>
        /// Comment creation time.
        /// </summary>
        /// <value>Comment creation time.</value>
        [DataMember(Name="timecreated", EmitDefaultValue=false)]
        public int? Timecreated { get; set; }
        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name="ratings", EmitDefaultValue=false)]
        public RatingsRecord Ratings { get; set; }
        /// <summary>
        /// Comment ID
        /// </summary>
        /// <value>Comment ID</value>
        [DataMember(Name="commentID", EmitDefaultValue=false)]
        public int? CommentID { get; set; }
        /// <summary>
        /// byContentEmail
        /// </summary>
        /// <value>byContentEmail</value>
        [DataMember(Name="byContentEmail", EmitDefaultValue=false)]
        public bool? ByContentEmail { get; set; }
        /// <summary>
        /// Comment PID
        /// </summary>
        /// <value>Comment PID</value>
        [DataMember(Name="commentPID", EmitDefaultValue=false)]
        public int? CommentPID { get; set; }
        /// <summary>
        /// Comment text.
        /// </summary>
        /// <value>Comment text.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        /// <summary>
        /// Comment status.
        /// </summary>
        /// <value>Comment status.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentV2Record {\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  ContentKey: ").Append(ContentKey).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  ExplicitReadCount: ").Append(ExplicitReadCount).Append("\n");
            sb.Append("  CopyDestination: ").Append(CopyDestination).Append("\n");
            sb.Append("  CommentCID: ").Append(CommentCID).Append("\n");
            sb.Append("  IsRead: ").Append(IsRead).Append("\n");
            sb.Append("  RefmeFlag: ").Append(RefmeFlag).Append("\n");
            sb.Append("  HighlightText: ").Append(HighlightText).Append("\n");
            sb.Append("  Timeupdated: ").Append(Timeupdated).Append("\n");
            sb.Append("  CreationMethod: ").Append(CreationMethod).Append("\n");
            sb.Append("  CommentListKey: ").Append(CommentListKey).Append("\n");
            sb.Append("  HasEmbeddedObjects: ").Append(HasEmbeddedObjects).Append("\n");
            sb.Append("  ImportantFlag: ").Append(ImportantFlag).Append("\n");
            sb.Append("  SubCommentCount: ").Append(SubCommentCount).Append("\n");
            sb.Append("  IsAnonymous: ").Append(IsAnonymous).Append("\n");
            sb.Append("  Timecreated: ").Append(Timecreated).Append("\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  CommentID: ").Append(CommentID).Append("\n");
            sb.Append("  ByContentEmail: ").Append(ByContentEmail).Append("\n");
            sb.Append("  CommentPID: ").Append(CommentPID).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(obj as CommentV2Record);
        }

        /// <summary>
        /// Returns true if CommentV2Record instances are equal
        /// </summary>
        /// <param name="other">Instance of CommentV2Record to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentV2Record other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Editor == other.Editor ||
                    this.Editor != null &&
                    this.Editor.Equals(other.Editor)
                ) && 
                (
                    this.ContentKey == other.ContentKey ||
                    this.ContentKey != null &&
                    this.ContentKey.Equals(other.ContentKey)
                ) && 
                (
                    this.Creator == other.Creator ||
                    this.Creator != null &&
                    this.Creator.Equals(other.Creator)
                ) && 
                (
                    this.ExplicitReadCount == other.ExplicitReadCount ||
                    this.ExplicitReadCount != null &&
                    this.ExplicitReadCount.Equals(other.ExplicitReadCount)
                ) && 
                (
                    this.CopyDestination == other.CopyDestination ||
                    this.CopyDestination != null &&
                    this.CopyDestination.Equals(other.CopyDestination)
                ) && 
                (
                    this.CommentCID == other.CommentCID ||
                    this.CommentCID != null &&
                    this.CommentCID.Equals(other.CommentCID)
                ) && 
                (
                    this.IsRead == other.IsRead ||
                    this.IsRead != null &&
                    this.IsRead.Equals(other.IsRead)
                ) && 
                (
                    this.RefmeFlag == other.RefmeFlag ||
                    this.RefmeFlag != null &&
                    this.RefmeFlag.Equals(other.RefmeFlag)
                ) && 
                (
                    this.HighlightText == other.HighlightText ||
                    this.HighlightText != null &&
                    this.HighlightText.Equals(other.HighlightText)
                ) && 
                (
                    this.Timeupdated == other.Timeupdated ||
                    this.Timeupdated != null &&
                    this.Timeupdated.Equals(other.Timeupdated)
                ) && 
                (
                    this.CreationMethod == other.CreationMethod ||
                    this.CreationMethod != null &&
                    this.CreationMethod.Equals(other.CreationMethod)
                ) && 
                (
                    this.CommentListKey == other.CommentListKey ||
                    this.CommentListKey != null &&
                    this.CommentListKey.Equals(other.CommentListKey)
                ) && 
                (
                    this.HasEmbeddedObjects == other.HasEmbeddedObjects ||
                    this.HasEmbeddedObjects != null &&
                    this.HasEmbeddedObjects.Equals(other.HasEmbeddedObjects)
                ) && 
                (
                    this.ImportantFlag == other.ImportantFlag ||
                    this.ImportantFlag != null &&
                    this.ImportantFlag.Equals(other.ImportantFlag)
                ) && 
                (
                    this.SubCommentCount == other.SubCommentCount ||
                    this.SubCommentCount != null &&
                    this.SubCommentCount.Equals(other.SubCommentCount)
                ) && 
                (
                    this.IsAnonymous == other.IsAnonymous ||
                    this.IsAnonymous != null &&
                    this.IsAnonymous.Equals(other.IsAnonymous)
                ) && 
                (
                    this.Timecreated == other.Timecreated ||
                    this.Timecreated != null &&
                    this.Timecreated.Equals(other.Timecreated)
                ) && 
                (
                    this.Ratings == other.Ratings ||
                    this.Ratings != null &&
                    this.Ratings.Equals(other.Ratings)
                ) && 
                (
                    this.CommentID == other.CommentID ||
                    this.CommentID != null &&
                    this.CommentID.Equals(other.CommentID)
                ) && 
                (
                    this.ByContentEmail == other.ByContentEmail ||
                    this.ByContentEmail != null &&
                    this.ByContentEmail.Equals(other.ByContentEmail)
                ) && 
                (
                    this.CommentPID == other.CommentPID ||
                    this.CommentPID != null &&
                    this.CommentPID.Equals(other.CommentPID)
                ) && 
                (
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
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
                if (this.Editor != null)
                    hash = hash * 59 + this.Editor.GetHashCode();
                if (this.ContentKey != null)
                    hash = hash * 59 + this.ContentKey.GetHashCode();
                if (this.Creator != null)
                    hash = hash * 59 + this.Creator.GetHashCode();
                if (this.ExplicitReadCount != null)
                    hash = hash * 59 + this.ExplicitReadCount.GetHashCode();
                if (this.CopyDestination != null)
                    hash = hash * 59 + this.CopyDestination.GetHashCode();
                if (this.CommentCID != null)
                    hash = hash * 59 + this.CommentCID.GetHashCode();
                if (this.IsRead != null)
                    hash = hash * 59 + this.IsRead.GetHashCode();
                if (this.RefmeFlag != null)
                    hash = hash * 59 + this.RefmeFlag.GetHashCode();
                if (this.HighlightText != null)
                    hash = hash * 59 + this.HighlightText.GetHashCode();
                if (this.Timeupdated != null)
                    hash = hash * 59 + this.Timeupdated.GetHashCode();
                if (this.CreationMethod != null)
                    hash = hash * 59 + this.CreationMethod.GetHashCode();
                if (this.CommentListKey != null)
                    hash = hash * 59 + this.CommentListKey.GetHashCode();
                if (this.HasEmbeddedObjects != null)
                    hash = hash * 59 + this.HasEmbeddedObjects.GetHashCode();
                if (this.ImportantFlag != null)
                    hash = hash * 59 + this.ImportantFlag.GetHashCode();
                if (this.SubCommentCount != null)
                    hash = hash * 59 + this.SubCommentCount.GetHashCode();
                if (this.IsAnonymous != null)
                    hash = hash * 59 + this.IsAnonymous.GetHashCode();
                if (this.Timecreated != null)
                    hash = hash * 59 + this.Timecreated.GetHashCode();
                if (this.Ratings != null)
                    hash = hash * 59 + this.Ratings.GetHashCode();
                if (this.CommentID != null)
                    hash = hash * 59 + this.CommentID.GetHashCode();
                if (this.ByContentEmail != null)
                    hash = hash * 59 + this.ByContentEmail.GetHashCode();
                if (this.CommentPID != null)
                    hash = hash * 59 + this.CommentPID.GetHashCode();
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }
    }

}
