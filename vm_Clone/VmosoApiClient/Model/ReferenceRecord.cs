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
    /// ReferenceRecord
    /// </summary>
    [DataContract]
    public partial class ReferenceRecord :  IEquatable<ReferenceRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceRecord" /> class.
        /// </summary>
        /// <param name="Accessible">.</param>
        /// <param name="RefCount">.</param>
        /// <param name="SourceType">inbound or outbound.</param>
        /// <param name="Record">records.</param>
        /// <param name="RefType">.</param>
        public ReferenceRecord(bool? Accessible = null, int? RefCount = null, string SourceType = null, Object Record = null, string RefType = null)
        {
            this.Accessible = Accessible;
            this.RefCount = RefCount;
            this.SourceType = SourceType;
            this.Record = Record;
            this.RefType = RefType;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="accessible", EmitDefaultValue=false)]
        public bool? Accessible { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="refCount", EmitDefaultValue=false)]
        public int? RefCount { get; set; }
        /// <summary>
        /// inbound or outbound
        /// </summary>
        /// <value>inbound or outbound</value>
        [DataMember(Name="sourceType", EmitDefaultValue=false)]
        public string SourceType { get; set; }
        /// <summary>
        /// records
        /// </summary>
        /// <value>records</value>
        [DataMember(Name="record", EmitDefaultValue=false)]
        public Object Record { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="refType", EmitDefaultValue=false)]
        public string RefType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferenceRecord {\n");
            sb.Append("  Accessible: ").Append(Accessible).Append("\n");
            sb.Append("  RefCount: ").Append(RefCount).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  RefType: ").Append(RefType).Append("\n");
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
            return this.Equals(obj as ReferenceRecord);
        }

        /// <summary>
        /// Returns true if ReferenceRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ReferenceRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferenceRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Accessible == other.Accessible ||
                    this.Accessible != null &&
                    this.Accessible.Equals(other.Accessible)
                ) && 
                (
                    this.RefCount == other.RefCount ||
                    this.RefCount != null &&
                    this.RefCount.Equals(other.RefCount)
                ) && 
                (
                    this.SourceType == other.SourceType ||
                    this.SourceType != null &&
                    this.SourceType.Equals(other.SourceType)
                ) && 
                (
                    this.Record == other.Record ||
                    this.Record != null &&
                    this.Record.Equals(other.Record)
                ) && 
                (
                    this.RefType == other.RefType ||
                    this.RefType != null &&
                    this.RefType.Equals(other.RefType)
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
                if (this.Accessible != null)
                    hash = hash * 59 + this.Accessible.GetHashCode();
                if (this.RefCount != null)
                    hash = hash * 59 + this.RefCount.GetHashCode();
                if (this.SourceType != null)
                    hash = hash * 59 + this.SourceType.GetHashCode();
                if (this.Record != null)
                    hash = hash * 59 + this.Record.GetHashCode();
                if (this.RefType != null)
                    hash = hash * 59 + this.RefType.GetHashCode();
                return hash;
            }
        }
    }

}
