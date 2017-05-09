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
    /// JoinSwitchboardInput
    /// </summary>
    [DataContract]
    public partial class JoinSwitchboardInput :  IEquatable<JoinSwitchboardInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinSwitchboardInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JoinSwitchboardInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JoinSwitchboardInput" /> class.
        /// </summary>
        /// <param name="CommentListKey"> (required).</param>
        /// <param name="ContentKey">the content key (required).</param>
        public JoinSwitchboardInput(string CommentListKey = null, string ContentKey = null)
        {
            // to ensure "CommentListKey" is required (not null)
            if (CommentListKey == null)
            {
                throw new InvalidDataException("CommentListKey is a required property for JoinSwitchboardInput and cannot be null");
            }
            else
            {
                this.CommentListKey = CommentListKey;
            }
            // to ensure "ContentKey" is required (not null)
            if (ContentKey == null)
            {
                throw new InvalidDataException("ContentKey is a required property for JoinSwitchboardInput and cannot be null");
            }
            else
            {
                this.ContentKey = ContentKey;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="commentListKey", EmitDefaultValue=false)]
        public string CommentListKey { get; set; }
        /// <summary>
        /// the content key
        /// </summary>
        /// <value>the content key</value>
        [DataMember(Name="contentKey", EmitDefaultValue=false)]
        public string ContentKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JoinSwitchboardInput {\n");
            sb.Append("  CommentListKey: ").Append(CommentListKey).Append("\n");
            sb.Append("  ContentKey: ").Append(ContentKey).Append("\n");
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
            return this.Equals(obj as JoinSwitchboardInput);
        }

        /// <summary>
        /// Returns true if JoinSwitchboardInput instances are equal
        /// </summary>
        /// <param name="other">Instance of JoinSwitchboardInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JoinSwitchboardInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommentListKey == other.CommentListKey ||
                    this.CommentListKey != null &&
                    this.CommentListKey.Equals(other.CommentListKey)
                ) && 
                (
                    this.ContentKey == other.ContentKey ||
                    this.ContentKey != null &&
                    this.ContentKey.Equals(other.ContentKey)
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
                if (this.CommentListKey != null)
                    hash = hash * 59 + this.CommentListKey.GetHashCode();
                if (this.ContentKey != null)
                    hash = hash * 59 + this.ContentKey.GetHashCode();
                return hash;
            }
        }
    }

}
