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
    /// UpdateDocumentInput
    /// </summary>
    [DataContract]
    public partial class UpdateDocumentInput :  IEquatable<UpdateDocumentInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateDocumentInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentInput" /> class.
        /// </summary>
        /// <param name="Document">Document (required).</param>
        /// <param name="Spaces">.</param>
        public UpdateDocumentInput(DocumentV2Record Document = null, List<string> Spaces = null)
        {
            // to ensure "Document" is required (not null)
            if (Document == null)
            {
                throw new InvalidDataException("Document is a required property for UpdateDocumentInput and cannot be null");
            }
            else
            {
                this.Document = Document;
            }
            this.Spaces = Spaces;
        }
        
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public DocumentV2Record Document { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="spaces", EmitDefaultValue=false)]
        public List<string> Spaces { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDocumentInput {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Spaces: ").Append(Spaces).Append("\n");
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
            return this.Equals(obj as UpdateDocumentInput);
        }

        /// <summary>
        /// Returns true if UpdateDocumentInput instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateDocumentInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDocumentInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) && 
                (
                    this.Spaces == other.Spaces ||
                    this.Spaces != null &&
                    this.Spaces.SequenceEqual(other.Spaces)
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
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                if (this.Spaces != null)
                    hash = hash * 59 + this.Spaces.GetHashCode();
                return hash;
            }
        }
    }

}
