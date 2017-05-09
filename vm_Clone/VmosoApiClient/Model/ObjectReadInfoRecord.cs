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
    /// ObjectReadInfoRecord
    /// </summary>
    [DataContract]
    public partial class ObjectReadInfoRecord :  IEquatable<ObjectReadInfoRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectReadInfoRecord" /> class.
        /// </summary>
        /// <param name="LastReader">LastReader.</param>
        /// <param name="LastReadTime">.</param>
        /// <param name="ReadCount">.</param>
        public ObjectReadInfoRecord(DisplayRecord LastReader = null, int? LastReadTime = null, int? ReadCount = null)
        {
            this.LastReader = LastReader;
            this.LastReadTime = LastReadTime;
            this.ReadCount = ReadCount;
        }
        
        /// <summary>
        /// Gets or Sets LastReader
        /// </summary>
        [DataMember(Name="lastReader", EmitDefaultValue=false)]
        public DisplayRecord LastReader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="lastReadTime", EmitDefaultValue=false)]
        public int? LastReadTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="readCount", EmitDefaultValue=false)]
        public int? ReadCount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectReadInfoRecord {\n");
            sb.Append("  LastReader: ").Append(LastReader).Append("\n");
            sb.Append("  LastReadTime: ").Append(LastReadTime).Append("\n");
            sb.Append("  ReadCount: ").Append(ReadCount).Append("\n");
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
            return this.Equals(obj as ObjectReadInfoRecord);
        }

        /// <summary>
        /// Returns true if ObjectReadInfoRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of ObjectReadInfoRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObjectReadInfoRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastReader == other.LastReader ||
                    this.LastReader != null &&
                    this.LastReader.Equals(other.LastReader)
                ) && 
                (
                    this.LastReadTime == other.LastReadTime ||
                    this.LastReadTime != null &&
                    this.LastReadTime.Equals(other.LastReadTime)
                ) && 
                (
                    this.ReadCount == other.ReadCount ||
                    this.ReadCount != null &&
                    this.ReadCount.Equals(other.ReadCount)
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
                if (this.LastReader != null)
                    hash = hash * 59 + this.LastReader.GetHashCode();
                if (this.LastReadTime != null)
                    hash = hash * 59 + this.LastReadTime.GetHashCode();
                if (this.ReadCount != null)
                    hash = hash * 59 + this.ReadCount.GetHashCode();
                return hash;
            }
        }
    }

}
