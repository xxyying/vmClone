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
    /// 0 : success, 1 : unknown error, 4 : no access, 10 : invalid rule, 99999999 : empty result for getting object type
    /// </summary>
    [DataContract]
    public partial class CheckRuleResult :  IEquatable<CheckRuleResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRuleResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckRuleResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRuleResult" /> class.
        /// </summary>
        /// <param name="Stream">Stream (required).</param>
        /// <param name="ACL">ACL (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        public CheckRuleResult(Record Stream = null, TaskACLRecord ACL = null, ResponseHeaderRecord Hdr = null)
        {
            // to ensure "Stream" is required (not null)
            if (Stream == null)
            {
                throw new InvalidDataException("Stream is a required property for CheckRuleResult and cannot be null");
            }
            else
            {
                this.Stream = Stream;
            }
            // to ensure "ACL" is required (not null)
            if (ACL == null)
            {
                throw new InvalidDataException("ACL is a required property for CheckRuleResult and cannot be null");
            }
            else
            {
                this.ACL = ACL;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for CheckRuleResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
        }
        
        /// <summary>
        /// Gets or Sets Stream
        /// </summary>
        [DataMember(Name="stream", EmitDefaultValue=false)]
        public Record Stream { get; set; }
        /// <summary>
        /// Gets or Sets ACL
        /// </summary>
        [DataMember(Name="ACL", EmitDefaultValue=false)]
        public TaskACLRecord ACL { get; set; }
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
            sb.Append("class CheckRuleResult {\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
            sb.Append("  ACL: ").Append(ACL).Append("\n");
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
            return this.Equals(obj as CheckRuleResult);
        }

        /// <summary>
        /// Returns true if CheckRuleResult instances are equal
        /// </summary>
        /// <param name="other">Instance of CheckRuleResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckRuleResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Stream == other.Stream ||
                    this.Stream != null &&
                    this.Stream.Equals(other.Stream)
                ) && 
                (
                    this.ACL == other.ACL ||
                    this.ACL != null &&
                    this.ACL.Equals(other.ACL)
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
                if (this.Stream != null)
                    hash = hash * 59 + this.Stream.GetHashCode();
                if (this.ACL != null)
                    hash = hash * 59 + this.ACL.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                return hash;
            }
        }
    }

}