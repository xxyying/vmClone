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
    /// 0 : success, 2 : item not found, 4 : user has not been granted access to item, 6 : invalid input
    /// </summary>
    [DataContract]
    public partial class GetCommentsResult :  IEquatable<GetCommentsResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommentsResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCommentsResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCommentsResult" /> class.
        /// </summary>
        /// <param name="CommentListKeyOut"> (required).</param>
        /// <param name="Comments">.</param>
        /// <param name="FirstLevelCount"> (required).</param>
        /// <param name="Pager">Pager (required).</param>
        /// <param name="ParentCreatorKey"> (required).</param>
        /// <param name="CanComment"> (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        public GetCommentsResult(string CommentListKeyOut = null, List<CommentV2Record> Comments = null, int? FirstLevelCount = null, ListPageRecord Pager = null, string ParentCreatorKey = null, bool? CanComment = null, ResponseHeaderRecord Hdr = null)
        {
            // to ensure "CommentListKeyOut" is required (not null)
            if (CommentListKeyOut == null)
            {
                throw new InvalidDataException("CommentListKeyOut is a required property for GetCommentsResult and cannot be null");
            }
            else
            {
                this.CommentListKeyOut = CommentListKeyOut;
            }
            // to ensure "FirstLevelCount" is required (not null)
            if (FirstLevelCount == null)
            {
                throw new InvalidDataException("FirstLevelCount is a required property for GetCommentsResult and cannot be null");
            }
            else
            {
                this.FirstLevelCount = FirstLevelCount;
            }
            // to ensure "Pager" is required (not null)
            if (Pager == null)
            {
                throw new InvalidDataException("Pager is a required property for GetCommentsResult and cannot be null");
            }
            else
            {
                this.Pager = Pager;
            }
            // to ensure "ParentCreatorKey" is required (not null)
            if (ParentCreatorKey == null)
            {
                throw new InvalidDataException("ParentCreatorKey is a required property for GetCommentsResult and cannot be null");
            }
            else
            {
                this.ParentCreatorKey = ParentCreatorKey;
            }
            // to ensure "CanComment" is required (not null)
            if (CanComment == null)
            {
                throw new InvalidDataException("CanComment is a required property for GetCommentsResult and cannot be null");
            }
            else
            {
                this.CanComment = CanComment;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for GetCommentsResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
            this.Comments = Comments;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commentListKeyOut", EmitDefaultValue=false)]
        public string CommentListKeyOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public List<CommentV2Record> Comments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="firstLevelCount", EmitDefaultValue=false)]
        public int? FirstLevelCount { get; set; }
        /// <summary>
        /// Gets or Sets Pager
        /// </summary>
        [DataMember(Name="pager", EmitDefaultValue=false)]
        public ListPageRecord Pager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="parentCreatorKey", EmitDefaultValue=false)]
        public string ParentCreatorKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="canComment", EmitDefaultValue=false)]
        public bool? CanComment { get; set; }
        /// <summary>
        /// Gets or Sets Hdr
        /// </summary>
        [DataMember(Name="_hdr", EmitDefaultValue=false)]
        public ResponseHeaderRecord Hdr { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCommentsResult {\n");
            sb.Append("  CommentListKeyOut: ").Append(CommentListKeyOut).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  FirstLevelCount: ").Append(FirstLevelCount).Append("\n");
            sb.Append("  Pager: ").Append(Pager).Append("\n");
            sb.Append("  ParentCreatorKey: ").Append(ParentCreatorKey).Append("\n");
            sb.Append("  CanComment: ").Append(CanComment).Append("\n");
            sb.Append("  Hdr: ").Append(Hdr).Append("\n");
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
            return this.Equals(obj as GetCommentsResult);
        }

        /// <summary>
        /// Returns true if GetCommentsResult instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCommentsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCommentsResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommentListKeyOut == other.CommentListKeyOut ||
                    this.CommentListKeyOut != null &&
                    this.CommentListKeyOut.Equals(other.CommentListKeyOut)
                ) && 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.SequenceEqual(other.Comments)
                ) && 
                (
                    this.FirstLevelCount == other.FirstLevelCount ||
                    this.FirstLevelCount != null &&
                    this.FirstLevelCount.Equals(other.FirstLevelCount)
                ) && 
                (
                    this.Pager == other.Pager ||
                    this.Pager != null &&
                    this.Pager.Equals(other.Pager)
                ) && 
                (
                    this.ParentCreatorKey == other.ParentCreatorKey ||
                    this.ParentCreatorKey != null &&
                    this.ParentCreatorKey.Equals(other.ParentCreatorKey)
                ) && 
                (
                    this.CanComment == other.CanComment ||
                    this.CanComment != null &&
                    this.CanComment.Equals(other.CanComment)
                ) && 
                (
                    this.Hdr == other.Hdr ||
                    this.Hdr != null &&
                    this.Hdr.Equals(other.Hdr)
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
                if (this.CommentListKeyOut != null)
                    hash = hash * 59 + this.CommentListKeyOut.GetHashCode();
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.FirstLevelCount != null)
                    hash = hash * 59 + this.FirstLevelCount.GetHashCode();
                if (this.Pager != null)
                    hash = hash * 59 + this.Pager.GetHashCode();
                if (this.ParentCreatorKey != null)
                    hash = hash * 59 + this.ParentCreatorKey.GetHashCode();
                if (this.CanComment != null)
                    hash = hash * 59 + this.CanComment.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                return hash;
            }
        }
    }

}
