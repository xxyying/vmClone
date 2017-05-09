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
    /// 
    /// </summary>
    [DataContract]
    public partial class GetPreviewInfoResult :  IEquatable<GetPreviewInfoResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreviewInfoResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPreviewInfoResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreviewInfoResult" /> class.
        /// </summary>
        /// <param name="PreviewPath"> (required).</param>
        /// <param name="PreviewType"> (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        public GetPreviewInfoResult(string PreviewPath = null, string PreviewType = null, ResponseHeaderRecord Hdr = null)
        {
            // to ensure "PreviewPath" is required (not null)
            if (PreviewPath == null)
            {
                throw new InvalidDataException("PreviewPath is a required property for GetPreviewInfoResult and cannot be null");
            }
            else
            {
                this.PreviewPath = PreviewPath;
            }
            // to ensure "PreviewType" is required (not null)
            if (PreviewType == null)
            {
                throw new InvalidDataException("PreviewType is a required property for GetPreviewInfoResult and cannot be null");
            }
            else
            {
                this.PreviewType = PreviewType;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for GetPreviewInfoResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewPath", EmitDefaultValue=false)]
        public string PreviewPath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewType", EmitDefaultValue=false)]
        public string PreviewType { get; set; }
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
            sb.Append("class GetPreviewInfoResult {\n");
            sb.Append("  PreviewPath: ").Append(PreviewPath).Append("\n");
            sb.Append("  PreviewType: ").Append(PreviewType).Append("\n");
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
            return this.Equals(obj as GetPreviewInfoResult);
        }

        /// <summary>
        /// Returns true if GetPreviewInfoResult instances are equal
        /// </summary>
        /// <param name="other">Instance of GetPreviewInfoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPreviewInfoResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreviewPath == other.PreviewPath ||
                    this.PreviewPath != null &&
                    this.PreviewPath.Equals(other.PreviewPath)
                ) && 
                (
                    this.PreviewType == other.PreviewType ||
                    this.PreviewType != null &&
                    this.PreviewType.Equals(other.PreviewType)
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
                if (this.PreviewPath != null)
                    hash = hash * 59 + this.PreviewPath.GetHashCode();
                if (this.PreviewType != null)
                    hash = hash * 59 + this.PreviewType.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                return hash;
            }
        }
    }

}
