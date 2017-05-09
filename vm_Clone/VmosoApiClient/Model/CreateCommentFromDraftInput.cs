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
    /// CreateCommentFromDraftInput
    /// </summary>
    [DataContract]
    public partial class CreateCommentFromDraftInput :  IEquatable<CreateCommentFromDraftInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentFromDraftInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCommentFromDraftInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentFromDraftInput" /> class.
        /// </summary>
        /// <param name="ContentKey"> (required).</param>
        /// <param name="Comment">Comment (required).</param>
        public CreateCommentFromDraftInput(string ContentKey = null, CommentV2Record Comment = null)
        {
            // to ensure "ContentKey" is required (not null)
            if (ContentKey == null)
            {
                throw new InvalidDataException("ContentKey is a required property for CreateCommentFromDraftInput and cannot be null");
            }
            else
            {
                this.ContentKey = ContentKey;
            }
            // to ensure "Comment" is required (not null)
            if (Comment == null)
            {
                throw new InvalidDataException("Comment is a required property for CreateCommentFromDraftInput and cannot be null");
            }
            else
            {
                this.Comment = Comment;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="contentKey", EmitDefaultValue=false)]
        public string ContentKey { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public CommentV2Record Comment { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCommentFromDraftInput {\n");
            sb.Append("  ContentKey: ").Append(ContentKey).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as CreateCommentFromDraftInput);
        }

        /// <summary>
        /// Returns true if CreateCommentFromDraftInput instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateCommentFromDraftInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCommentFromDraftInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContentKey == other.ContentKey ||
                    this.ContentKey != null &&
                    this.ContentKey.Equals(other.ContentKey)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.ContentKey != null)
                    hash = hash * 59 + this.ContentKey.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                return hash;
            }
        }
    }

}
