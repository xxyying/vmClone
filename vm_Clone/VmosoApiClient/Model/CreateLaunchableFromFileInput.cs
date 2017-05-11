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
    /// CreateLaunchableFromFileInput
    /// </summary>
    [DataContract]
    public partial class CreateLaunchableFromFileInput :  IEquatable<CreateLaunchableFromFileInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLaunchableFromFileInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateLaunchableFromFileInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLaunchableFromFileInput" /> class.
        /// </summary>
        /// <param name="Inputfile">Inputfile (required).</param>
        /// <param name="WfForms">.</param>
        /// <param name="WfDataRecord">WfDataRecord (required).</param>
        public CreateLaunchableFromFileInput(FileRecord Inputfile = null, List<SmallObjectRecord> WfForms = null, WorkflowDataRecord WfDataRecord = null)
        {
            // to ensure "Inputfile" is required (not null)
            if (Inputfile == null)
            {
                throw new InvalidDataException("Inputfile is a required property for CreateLaunchableFromFileInput and cannot be null");
            }
            else
            {
                this.Inputfile = Inputfile;
            }
            // to ensure "WfDataRecord" is required (not null)
            if (WfDataRecord == null)
            {
                throw new InvalidDataException("WfDataRecord is a required property for CreateLaunchableFromFileInput and cannot be null");
            }
            else
            {
                this.WfDataRecord = WfDataRecord;
            }
            this.WfForms = WfForms;
        }
        
        /// <summary>
        /// Gets or Sets Inputfile
        /// </summary>
        [DataMember(Name="inputfile", EmitDefaultValue=false)]
        public FileRecord Inputfile { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="wfForms", EmitDefaultValue=false)]
        public List<SmallObjectRecord> WfForms { get; set; }
        /// <summary>
        /// Gets or Sets WfDataRecord
        /// </summary>
        [DataMember(Name="wfDataRecord", EmitDefaultValue=false)]
        public WorkflowDataRecord WfDataRecord { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLaunchableFromFileInput {\n");
            sb.Append("  Inputfile: ").Append(Inputfile).Append("\n");
            sb.Append("  WfForms: ").Append(WfForms).Append("\n");
            sb.Append("  WfDataRecord: ").Append(WfDataRecord).Append("\n");
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
            return this.Equals(obj as CreateLaunchableFromFileInput);
        }

        /// <summary>
        /// Returns true if CreateLaunchableFromFileInput instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateLaunchableFromFileInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateLaunchableFromFileInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Inputfile == other.Inputfile ||
                    this.Inputfile != null &&
                    this.Inputfile.Equals(other.Inputfile)
                ) && 
                (
                    this.WfForms == other.WfForms ||
                    this.WfForms != null &&
                    this.WfForms.SequenceEqual(other.WfForms)
                ) && 
                (
                    this.WfDataRecord == other.WfDataRecord ||
                    this.WfDataRecord != null &&
                    this.WfDataRecord.Equals(other.WfDataRecord)
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
                if (this.Inputfile != null)
                    hash = hash * 59 + this.Inputfile.GetHashCode();
                if (this.WfForms != null)
                    hash = hash * 59 + this.WfForms.GetHashCode();
                if (this.WfDataRecord != null)
                    hash = hash * 59 + this.WfDataRecord.GetHashCode();
                return hash;
            }
        }
    }

}