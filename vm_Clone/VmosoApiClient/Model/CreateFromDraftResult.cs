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
    /// 0 : success, 2 : key not found, 100 : unmatched user, 101 : duedate is pass current date, 6 : input invalid, 7 : input missing
    /// </summary>
    [DataContract]
    public partial class CreateFromDraftResult :  IEquatable<CreateFromDraftResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFromDraftResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFromDraftResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFromDraftResult" /> class.
        /// </summary>
        /// <param name="Task">Task (required).</param>
        /// <param name="Hdr">Hdr (required).</param>
        public CreateFromDraftResult(TaskRecord Task = null, ResponseHeaderRecord Hdr = null)
        {
            // to ensure "Task" is required (not null)
            if (Task == null)
            {
                throw new InvalidDataException("Task is a required property for CreateFromDraftResult and cannot be null");
            }
            else
            {
                this.Task = Task;
            }
            // to ensure "Hdr" is required (not null)
            if (Hdr == null)
            {
                throw new InvalidDataException("Hdr is a required property for CreateFromDraftResult and cannot be null");
            }
            else
            {
                this.Hdr = Hdr;
            }
        }
        
        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public TaskRecord Task { get; set; }
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
            sb.Append("class CreateFromDraftResult {\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
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
            return this.Equals(obj as CreateFromDraftResult);
        }

        /// <summary>
        /// Returns true if CreateFromDraftResult instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateFromDraftResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFromDraftResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Task == other.Task ||
                    this.Task != null &&
                    this.Task.Equals(other.Task)
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
                if (this.Task != null)
                    hash = hash * 59 + this.Task.GetHashCode();
                if (this.Hdr != null)
                    hash = hash * 59 + this.Hdr.GetHashCode();
                return hash;
            }
        }
    }

}
