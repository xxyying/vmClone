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
    public partial class GetPreviewStatusResult :  IEquatable<GetPreviewStatusResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreviewStatusResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetPreviewStatusResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreviewStatusResult" /> class.
        /// </summary>
        /// <param name="PreviewPageCount"> (required).</param>
        /// <param name="ConversionPercent"> (required).</param>
        /// <param name="PreviewVideoFormat"> (required).</param>
        /// <param name="PreviewStatus"> (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        /// <param name="IsPreviewReady"> (required).</param>
        /// <param name="PreviewMsg"> (required).</param>
        /// <param name="PreviewCompressedFile">.</param>
        public GetPreviewStatusResult(string PreviewPageCount = null, string ConversionPercent = null, string PreviewVideoFormat = null, string PreviewStatus = null, ResponseHeaderRecord Hdr = null, string IsPreviewReady = null, string PreviewMsg = null, List<CompressedFileRecord> PreviewCompressedFile = null)
        {
            // to ensure "PreviewPageCount" is required (not null)
            if (PreviewPageCount == null)
            {
                throw new InvalidDataException("PreviewPageCount is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.PreviewPageCount = PreviewPageCount;
            }
            // to ensure "ConversionPercent" is required (not null)
            if (ConversionPercent == null)
            {
                throw new InvalidDataException("ConversionPercent is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.ConversionPercent = ConversionPercent;
            }
            // to ensure "PreviewVideoFormat" is required (not null)
            if (PreviewVideoFormat == null)
            {
                throw new InvalidDataException("PreviewVideoFormat is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.PreviewVideoFormat = PreviewVideoFormat;
            }
            // to ensure "PreviewStatus" is required (not null)
            if (PreviewStatus == null)
            {
                throw new InvalidDataException("PreviewStatus is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.PreviewStatus = PreviewStatus;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
            // to ensure "IsPreviewReady" is required (not null)
            if (IsPreviewReady == null)
            {
                throw new InvalidDataException("IsPreviewReady is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.IsPreviewReady = IsPreviewReady;
            }
            // to ensure "PreviewMsg" is required (not null)
            if (PreviewMsg == null)
            {
                throw new InvalidDataException("PreviewMsg is a required property for GetPreviewStatusResult and cannot be null");
            }
            else
            {
                this.PreviewMsg = PreviewMsg;
            }
            this.PreviewCompressedFile = PreviewCompressedFile;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewPageCount", EmitDefaultValue=false)]
        public string PreviewPageCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="conversionPercent", EmitDefaultValue=false)]
        public string ConversionPercent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewVideoFormat", EmitDefaultValue=false)]
        public string PreviewVideoFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewStatus", EmitDefaultValue=false)]
        public string PreviewStatus { get; set; }
        /// <summary>
        /// Gets or Sets Hdr
        /// </summary>
        [DataMember(Name="_hdr", EmitDefaultValue=false)]
        public ResponseHeaderRecord Hdr { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isPreviewReady", EmitDefaultValue=false)]
        public string IsPreviewReady { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewMsg", EmitDefaultValue=false)]
        public string PreviewMsg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="previewCompressedFile", EmitDefaultValue=false)]
        public List<CompressedFileRecord> PreviewCompressedFile { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPreviewStatusResult {\n");
            sb.Append("  PreviewPageCount: ").Append(PreviewPageCount).Append("\n");
            sb.Append("  ConversionPercent: ").Append(ConversionPercent).Append("\n");
            sb.Append("  PreviewVideoFormat: ").Append(PreviewVideoFormat).Append("\n");
            sb.Append("  PreviewStatus: ").Append(PreviewStatus).Append("\n");
            sb.Append("  Hdr: ").Append(Hdr).Append("\n");
            sb.Append("  IsPreviewReady: ").Append(IsPreviewReady).Append("\n");
            sb.Append("  PreviewMsg: ").Append(PreviewMsg).Append("\n");
            sb.Append("  PreviewCompressedFile: ").Append(PreviewCompressedFile).Append("\n");
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
            return this.Equals(obj as GetPreviewStatusResult);
        }

        /// <summary>
        /// Returns true if GetPreviewStatusResult instances are equal
        /// </summary>
        /// <param name="other">Instance of GetPreviewStatusResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPreviewStatusResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PreviewPageCount == other.PreviewPageCount ||
                    this.PreviewPageCount != null &&
                    this.PreviewPageCount.Equals(other.PreviewPageCount)
                ) && 
                (
                    this.ConversionPercent == other.ConversionPercent ||
                    this.ConversionPercent != null &&
                    this.ConversionPercent.Equals(other.ConversionPercent)
                ) && 
                (
                    this.PreviewVideoFormat == other.PreviewVideoFormat ||
                    this.PreviewVideoFormat != null &&
                    this.PreviewVideoFormat.Equals(other.PreviewVideoFormat)
                ) && 
                (
                    this.PreviewStatus == other.PreviewStatus ||
                    this.PreviewStatus != null &&
                    this.PreviewStatus.Equals(other.PreviewStatus)
                ) && 
                (
                    this.Hdr == other.Hdr ||
                    this.Hdr != null &&
                    this.Hdr.Equals(other.Hdr)
                ) && 
                (
                    this.IsPreviewReady == other.IsPreviewReady ||
                    this.IsPreviewReady != null &&
                    this.IsPreviewReady.Equals(other.IsPreviewReady)
                ) && 
                (
                    this.PreviewMsg == other.PreviewMsg ||
                    this.PreviewMsg != null &&
                    this.PreviewMsg.Equals(other.PreviewMsg)
                ) && 
                (
                    this.PreviewCompressedFile == other.PreviewCompressedFile ||
                    this.PreviewCompressedFile != null &&
                    this.PreviewCompressedFile.SequenceEqual(other.PreviewCompressedFile)
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
                if (this.PreviewPageCount != null)
                    hash = hash * 59 + this.PreviewPageCount.GetHashCode();
                if (this.ConversionPercent != null)
                    hash = hash * 59 + this.ConversionPercent.GetHashCode();
                if (this.PreviewVideoFormat != null)
                    hash = hash * 59 + this.PreviewVideoFormat.GetHashCode();
                if (this.PreviewStatus != null)
                    hash = hash * 59 + this.PreviewStatus.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                if (this.IsPreviewReady != null)
                    hash = hash * 59 + this.IsPreviewReady.GetHashCode();
                if (this.PreviewMsg != null)
                    hash = hash * 59 + this.PreviewMsg.GetHashCode();
                if (this.PreviewCompressedFile != null)
                    hash = hash * 59 + this.PreviewCompressedFile.GetHashCode();
                return hash;
            }
        }
    }

}
