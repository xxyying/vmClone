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
    /// ReaderListOptionsV2Record
    /// </summary>
    [DataContract]
    public partial class ReaderListOptionsV2Record : ListOptionsRecord,  IEquatable<ReaderListOptionsV2Record>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderListOptionsV2Record" /> class.
        /// </summary>
        /// <param name="FolderKey">Type of ListOptions record..</param>
        /// <param name="Format">Format.</param>
        /// <param name="Type">Type of ListOptions record..</param>
        /// <param name="SearchString">retrieve items by the string..</param>
        /// <param name="SortAttr">Sort Attr... supports:.</param>
        /// <param name="SortDir">Sort direction &#39;ASC&#39; for ascending, &#39;DESC&#39; for descending.</param>
        /// <param name="CommentListType">comment list type: general, scc.</param>
        public ReaderListOptionsV2Record(string FolderKey = null, FormatRecord Format = null, string Type = null, string SearchString = null, string SortAttr = null, string SortDir = null, string CommentListType = null)
        {
            this.FolderKey = FolderKey;
            this.Format = Format;
            this.Type = Type;
            this.SearchString = SearchString;
            this.SortAttr = SortAttr;
            this.SortDir = SortDir;
            this.CommentListType = CommentListType;
        }
        
        /// <summary>
        /// Type of ListOptions record.
        /// </summary>
        /// <value>Type of ListOptions record.</value>
        [DataMember(Name="folderKey", EmitDefaultValue=false)]
        public string FolderKey { get; set; }
        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatRecord Format { get; set; }
        /// <summary>
        /// Type of ListOptions record.
        /// </summary>
        /// <value>Type of ListOptions record.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// retrieve items by the string.
        /// </summary>
        /// <value>retrieve items by the string.</value>
        [DataMember(Name="search_string", EmitDefaultValue=false)]
        public string SearchString { get; set; }
        /// <summary>
        /// Sort Attr... supports:
        /// </summary>
        /// <value>Sort Attr... supports:</value>
        [DataMember(Name="sort_attr", EmitDefaultValue=false)]
        public string SortAttr { get; set; }
        /// <summary>
        /// Sort direction &#39;ASC&#39; for ascending, &#39;DESC&#39; for descending
        /// </summary>
        /// <value>Sort direction &#39;ASC&#39; for ascending, &#39;DESC&#39; for descending</value>
        [DataMember(Name="sort_dir", EmitDefaultValue=false)]
        public string SortDir { get; set; }
        /// <summary>
        /// comment list type: general, scc
        /// </summary>
        /// <value>comment list type: general, scc</value>
        [DataMember(Name="commentList_type", EmitDefaultValue=false)]
        public string CommentListType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReaderListOptionsV2Record {\n");
            sb.Append("  FolderKey: ").Append(FolderKey).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SearchString: ").Append(SearchString).Append("\n");
            sb.Append("  SortAttr: ").Append(SortAttr).Append("\n");
            sb.Append("  SortDir: ").Append(SortDir).Append("\n");
            sb.Append("  CommentListType: ").Append(CommentListType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as ReaderListOptionsV2Record);
        }

        /// <summary>
        /// Returns true if ReaderListOptionsV2Record instances are equal
        /// </summary>
        /// <param name="other">Instance of ReaderListOptionsV2Record to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReaderListOptionsV2Record other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FolderKey == other.FolderKey ||
                    this.FolderKey != null &&
                    this.FolderKey.Equals(other.FolderKey)
                ) && 
                (
                    this.Format == other.Format ||
                    this.Format != null &&
                    this.Format.Equals(other.Format)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.SearchString == other.SearchString ||
                    this.SearchString != null &&
                    this.SearchString.Equals(other.SearchString)
                ) && 
                (
                    this.SortAttr == other.SortAttr ||
                    this.SortAttr != null &&
                    this.SortAttr.Equals(other.SortAttr)
                ) && 
                (
                    this.SortDir == other.SortDir ||
                    this.SortDir != null &&
                    this.SortDir.Equals(other.SortDir)
                ) && 
                (
                    this.CommentListType == other.CommentListType ||
                    this.CommentListType != null &&
                    this.CommentListType.Equals(other.CommentListType)
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
                if (this.FolderKey != null)
                    hash = hash * 59 + this.FolderKey.GetHashCode();
                if (this.Format != null)
                    hash = hash * 59 + this.Format.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.SearchString != null)
                    hash = hash * 59 + this.SearchString.GetHashCode();
                if (this.SortAttr != null)
                    hash = hash * 59 + this.SortAttr.GetHashCode();
                if (this.SortDir != null)
                    hash = hash * 59 + this.SortDir.GetHashCode();
                if (this.CommentListType != null)
                    hash = hash * 59 + this.CommentListType.GetHashCode();
                return hash;
            }
        }
    }

}
