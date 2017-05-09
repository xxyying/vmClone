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
    /// UserListRecord
    /// </summary>
    [DataContract]
    public partial class UserListRecord :  IEquatable<UserListRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserListRecord" /> class.
        /// </summary>
        /// <param name="Cc">.</param>
        /// <param name="AssigneeGroups">.</param>
        /// <param name="Bcc">.</param>
        /// <param name="RemovedBcc">.</param>
        /// <param name="BccGroups">.</param>
        /// <param name="RemovedCc">.</param>
        /// <param name="ObserverGroups">.</param>
        /// <param name="Observer">.</param>
        /// <param name="RemovedObserver">.</param>
        /// <param name="Scc">.</param>
        /// <param name="RemovedScc">.</param>
        /// <param name="CcGroups">.</param>
        /// <param name="SccGroups">.</param>
        /// <param name="Assignee">.</param>
        /// <param name="RemovedAssignee">.</param>
        public UserListRecord(List<string> Cc = null, List<string> AssigneeGroups = null, List<string> Bcc = null, List<string> RemovedBcc = null, List<string> BccGroups = null, List<string> RemovedCc = null, List<string> ObserverGroups = null, List<string> Observer = null, List<string> RemovedObserver = null, List<string> Scc = null, List<string> RemovedScc = null, List<string> CcGroups = null, List<string> SccGroups = null, List<string> Assignee = null, List<string> RemovedAssignee = null)
        {
            this.Cc = Cc;
            this.AssigneeGroups = AssigneeGroups;
            this.Bcc = Bcc;
            this.RemovedBcc = RemovedBcc;
            this.BccGroups = BccGroups;
            this.RemovedCc = RemovedCc;
            this.ObserverGroups = ObserverGroups;
            this.Observer = Observer;
            this.RemovedObserver = RemovedObserver;
            this.Scc = Scc;
            this.RemovedScc = RemovedScc;
            this.CcGroups = CcGroups;
            this.SccGroups = SccGroups;
            this.Assignee = Assignee;
            this.RemovedAssignee = RemovedAssignee;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<string> Cc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="assigneeGroups", EmitDefaultValue=false)]
        public List<string> AssigneeGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<string> Bcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedBcc", EmitDefaultValue=false)]
        public List<string> RemovedBcc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="bccGroups", EmitDefaultValue=false)]
        public List<string> BccGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedCc", EmitDefaultValue=false)]
        public List<string> RemovedCc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="observerGroups", EmitDefaultValue=false)]
        public List<string> ObserverGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="observer", EmitDefaultValue=false)]
        public List<string> Observer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedObserver", EmitDefaultValue=false)]
        public List<string> RemovedObserver { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="scc", EmitDefaultValue=false)]
        public List<string> Scc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedScc", EmitDefaultValue=false)]
        public List<string> RemovedScc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="ccGroups", EmitDefaultValue=false)]
        public List<string> CcGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sccGroups", EmitDefaultValue=false)]
        public List<string> SccGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public List<string> Assignee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedAssignee", EmitDefaultValue=false)]
        public List<string> RemovedAssignee { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserListRecord {\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  AssigneeGroups: ").Append(AssigneeGroups).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  RemovedBcc: ").Append(RemovedBcc).Append("\n");
            sb.Append("  BccGroups: ").Append(BccGroups).Append("\n");
            sb.Append("  RemovedCc: ").Append(RemovedCc).Append("\n");
            sb.Append("  ObserverGroups: ").Append(ObserverGroups).Append("\n");
            sb.Append("  Observer: ").Append(Observer).Append("\n");
            sb.Append("  RemovedObserver: ").Append(RemovedObserver).Append("\n");
            sb.Append("  Scc: ").Append(Scc).Append("\n");
            sb.Append("  RemovedScc: ").Append(RemovedScc).Append("\n");
            sb.Append("  CcGroups: ").Append(CcGroups).Append("\n");
            sb.Append("  SccGroups: ").Append(SccGroups).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  RemovedAssignee: ").Append(RemovedAssignee).Append("\n");
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
            return this.Equals(obj as UserListRecord);
        }

        /// <summary>
        /// Returns true if UserListRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of UserListRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserListRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cc == other.Cc ||
                    this.Cc != null &&
                    this.Cc.SequenceEqual(other.Cc)
                ) && 
                (
                    this.AssigneeGroups == other.AssigneeGroups ||
                    this.AssigneeGroups != null &&
                    this.AssigneeGroups.SequenceEqual(other.AssigneeGroups)
                ) && 
                (
                    this.Bcc == other.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.SequenceEqual(other.Bcc)
                ) && 
                (
                    this.RemovedBcc == other.RemovedBcc ||
                    this.RemovedBcc != null &&
                    this.RemovedBcc.SequenceEqual(other.RemovedBcc)
                ) && 
                (
                    this.BccGroups == other.BccGroups ||
                    this.BccGroups != null &&
                    this.BccGroups.SequenceEqual(other.BccGroups)
                ) && 
                (
                    this.RemovedCc == other.RemovedCc ||
                    this.RemovedCc != null &&
                    this.RemovedCc.SequenceEqual(other.RemovedCc)
                ) && 
                (
                    this.ObserverGroups == other.ObserverGroups ||
                    this.ObserverGroups != null &&
                    this.ObserverGroups.SequenceEqual(other.ObserverGroups)
                ) && 
                (
                    this.Observer == other.Observer ||
                    this.Observer != null &&
                    this.Observer.SequenceEqual(other.Observer)
                ) && 
                (
                    this.RemovedObserver == other.RemovedObserver ||
                    this.RemovedObserver != null &&
                    this.RemovedObserver.SequenceEqual(other.RemovedObserver)
                ) && 
                (
                    this.Scc == other.Scc ||
                    this.Scc != null &&
                    this.Scc.SequenceEqual(other.Scc)
                ) && 
                (
                    this.RemovedScc == other.RemovedScc ||
                    this.RemovedScc != null &&
                    this.RemovedScc.SequenceEqual(other.RemovedScc)
                ) && 
                (
                    this.CcGroups == other.CcGroups ||
                    this.CcGroups != null &&
                    this.CcGroups.SequenceEqual(other.CcGroups)
                ) && 
                (
                    this.SccGroups == other.SccGroups ||
                    this.SccGroups != null &&
                    this.SccGroups.SequenceEqual(other.SccGroups)
                ) && 
                (
                    this.Assignee == other.Assignee ||
                    this.Assignee != null &&
                    this.Assignee.SequenceEqual(other.Assignee)
                ) && 
                (
                    this.RemovedAssignee == other.RemovedAssignee ||
                    this.RemovedAssignee != null &&
                    this.RemovedAssignee.SequenceEqual(other.RemovedAssignee)
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
                if (this.Cc != null)
                    hash = hash * 59 + this.Cc.GetHashCode();
                if (this.AssigneeGroups != null)
                    hash = hash * 59 + this.AssigneeGroups.GetHashCode();
                if (this.Bcc != null)
                    hash = hash * 59 + this.Bcc.GetHashCode();
                if (this.RemovedBcc != null)
                    hash = hash * 59 + this.RemovedBcc.GetHashCode();
                if (this.BccGroups != null)
                    hash = hash * 59 + this.BccGroups.GetHashCode();
                if (this.RemovedCc != null)
                    hash = hash * 59 + this.RemovedCc.GetHashCode();
                if (this.ObserverGroups != null)
                    hash = hash * 59 + this.ObserverGroups.GetHashCode();
                if (this.Observer != null)
                    hash = hash * 59 + this.Observer.GetHashCode();
                if (this.RemovedObserver != null)
                    hash = hash * 59 + this.RemovedObserver.GetHashCode();
                if (this.Scc != null)
                    hash = hash * 59 + this.Scc.GetHashCode();
                if (this.RemovedScc != null)
                    hash = hash * 59 + this.RemovedScc.GetHashCode();
                if (this.CcGroups != null)
                    hash = hash * 59 + this.CcGroups.GetHashCode();
                if (this.SccGroups != null)
                    hash = hash * 59 + this.SccGroups.GetHashCode();
                if (this.Assignee != null)
                    hash = hash * 59 + this.Assignee.GetHashCode();
                if (this.RemovedAssignee != null)
                    hash = hash * 59 + this.RemovedAssignee.GetHashCode();
                return hash;
            }
        }
    }

}
