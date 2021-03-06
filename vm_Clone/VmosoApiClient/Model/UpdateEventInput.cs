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
    /// UpdateEventInput
    /// </summary>
    [DataContract]
    public partial class UpdateEventInput :  IEquatable<UpdateEventInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateEventInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEventInput" /> class.
        /// </summary>
        /// <param name="Task">Task (required).</param>
        /// <param name="Pg">Pg (required).</param>
        /// <param name="Options">Options (required).</param>
        /// <param name="CalendarEvent">CalendarEvent (required).</param>
        public UpdateEventInput(TaskRecord Task = null, PaginationRecord Pg = null, CalendarEventInstancesOptionsRecord Options = null, CalendarEventV2Record CalendarEvent = null)
        {
            // to ensure "Task" is required (not null)
            if (Task == null)
            {
                throw new InvalidDataException("Task is a required property for UpdateEventInput and cannot be null");
            }
            else
            {
                this.Task = Task;
            }
            // to ensure "Pg" is required (not null)
            if (Pg == null)
            {
                throw new InvalidDataException("Pg is a required property for UpdateEventInput and cannot be null");
            }
            else
            {
                this.Pg = Pg;
            }
            // to ensure "Options" is required (not null)
            if (Options == null)
            {
                throw new InvalidDataException("Options is a required property for UpdateEventInput and cannot be null");
            }
            else
            {
                this.Options = Options;
            }
            // to ensure "CalendarEvent" is required (not null)
            if (CalendarEvent == null)
            {
                throw new InvalidDataException("CalendarEvent is a required property for UpdateEventInput and cannot be null");
            }
            else
            {
                this.CalendarEvent = CalendarEvent;
            }
        }
        
        /// <summary>
        /// Gets or Sets Task
        /// </summary>
        [DataMember(Name="task", EmitDefaultValue=false)]
        public TaskRecord Task { get; set; }
        /// <summary>
        /// Gets or Sets Pg
        /// </summary>
        [DataMember(Name="pg", EmitDefaultValue=false)]
        public PaginationRecord Pg { get; set; }
        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public CalendarEventInstancesOptionsRecord Options { get; set; }
        /// <summary>
        /// Gets or Sets CalendarEvent
        /// </summary>
        [DataMember(Name="calendarEvent", EmitDefaultValue=false)]
        public CalendarEventV2Record CalendarEvent { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateEventInput {\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  Pg: ").Append(Pg).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  CalendarEvent: ").Append(CalendarEvent).Append("\n");
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
            return this.Equals(obj as UpdateEventInput);
        }

        /// <summary>
        /// Returns true if UpdateEventInput instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateEventInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateEventInput other)
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
                    this.Pg == other.Pg ||
                    this.Pg != null &&
                    this.Pg.Equals(other.Pg)
                ) && 
                (
                    this.Options == other.Options ||
                    this.Options != null &&
                    this.Options.Equals(other.Options)
                ) && 
                (
                    this.CalendarEvent == other.CalendarEvent ||
                    this.CalendarEvent != null &&
                    this.CalendarEvent.Equals(other.CalendarEvent)
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
                if (this.Pg != null)
                    hash = hash * 59 + this.Pg.GetHashCode();
                if (this.Options != null)
                    hash = hash * 59 + this.Options.GetHashCode();
                if (this.CalendarEvent != null)
                    hash = hash * 59 + this.CalendarEvent.GetHashCode();
                return hash;
            }
        }
    }

}
