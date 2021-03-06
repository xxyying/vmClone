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
    /// WorkflowStateRecord
    /// </summary>
    [DataContract]
    public partial class WorkflowStateRecord :  IEquatable<WorkflowStateRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowStateRecord" /> class.
        /// </summary>
        /// <param name="StepKey">Key of current step, if available..</param>
        /// <param name="UstateTally">Tally of user states. Each user state applicable to the step has an entry to indicate the number of logical users in that state..</param>
        /// <param name="LastAction">LastAction.</param>
        /// <param name="StepState">State of step..</param>
        /// <param name="Active">Whether workflow is active. This is a boolean flag based on whether {@link $step} is an active step..</param>
        /// <param name="Step">Name of current step, if any..</param>
        /// <param name="StepPrev">Name of previous step, if any..</param>
        public WorkflowStateRecord(string StepKey = null, List<IntegerAttrRecord> UstateTally = null, WorkflowActionRecord LastAction = null, string StepState = null, bool? Active = null, string Step = null, string StepPrev = null)
        {
            this.StepKey = StepKey;
            this.UstateTally = UstateTally;
            this.LastAction = LastAction;
            this.StepState = StepState;
            this.Active = Active;
            this.Step = Step;
            this.StepPrev = StepPrev;
        }
        
        /// <summary>
        /// Key of current step, if available.
        /// </summary>
        /// <value>Key of current step, if available.</value>
        [DataMember(Name="stepKey", EmitDefaultValue=false)]
        public string StepKey { get; set; }
        /// <summary>
        /// Tally of user states. Each user state applicable to the step has an entry to indicate the number of logical users in that state.
        /// </summary>
        /// <value>Tally of user states. Each user state applicable to the step has an entry to indicate the number of logical users in that state.</value>
        [DataMember(Name="ustateTally", EmitDefaultValue=false)]
        public List<IntegerAttrRecord> UstateTally { get; set; }
        /// <summary>
        /// Gets or Sets LastAction
        /// </summary>
        [DataMember(Name="lastAction", EmitDefaultValue=false)]
        public WorkflowActionRecord LastAction { get; set; }
        /// <summary>
        /// State of step.
        /// </summary>
        /// <value>State of step.</value>
        [DataMember(Name="stepState", EmitDefaultValue=false)]
        public string StepState { get; set; }
        /// <summary>
        /// Whether workflow is active. This is a boolean flag based on whether {@link $step} is an active step.
        /// </summary>
        /// <value>Whether workflow is active. This is a boolean flag based on whether {@link $step} is an active step.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Name of current step, if any.
        /// </summary>
        /// <value>Name of current step, if any.</value>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public string Step { get; set; }
        /// <summary>
        /// Name of previous step, if any.
        /// </summary>
        /// <value>Name of previous step, if any.</value>
        [DataMember(Name="stepPrev", EmitDefaultValue=false)]
        public string StepPrev { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowStateRecord {\n");
            sb.Append("  StepKey: ").Append(StepKey).Append("\n");
            sb.Append("  UstateTally: ").Append(UstateTally).Append("\n");
            sb.Append("  LastAction: ").Append(LastAction).Append("\n");
            sb.Append("  StepState: ").Append(StepState).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  StepPrev: ").Append(StepPrev).Append("\n");
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
            return this.Equals(obj as WorkflowStateRecord);
        }

        /// <summary>
        /// Returns true if WorkflowStateRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowStateRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowStateRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StepKey == other.StepKey ||
                    this.StepKey != null &&
                    this.StepKey.Equals(other.StepKey)
                ) && 
                (
                    this.UstateTally == other.UstateTally ||
                    this.UstateTally != null &&
                    this.UstateTally.SequenceEqual(other.UstateTally)
                ) && 
                (
                    this.LastAction == other.LastAction ||
                    this.LastAction != null &&
                    this.LastAction.Equals(other.LastAction)
                ) && 
                (
                    this.StepState == other.StepState ||
                    this.StepState != null &&
                    this.StepState.Equals(other.StepState)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.Step == other.Step ||
                    this.Step != null &&
                    this.Step.Equals(other.Step)
                ) && 
                (
                    this.StepPrev == other.StepPrev ||
                    this.StepPrev != null &&
                    this.StepPrev.Equals(other.StepPrev)
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
                if (this.StepKey != null)
                    hash = hash * 59 + this.StepKey.GetHashCode();
                if (this.UstateTally != null)
                    hash = hash * 59 + this.UstateTally.GetHashCode();
                if (this.LastAction != null)
                    hash = hash * 59 + this.LastAction.GetHashCode();
                if (this.StepState != null)
                    hash = hash * 59 + this.StepState.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.Step != null)
                    hash = hash * 59 + this.Step.GetHashCode();
                if (this.StepPrev != null)
                    hash = hash * 59 + this.StepPrev.GetHashCode();
                return hash;
            }
        }
    }

}
