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
    /// EmailUserListRecord
    /// </summary>
    [DataContract]
    public partial class EmailUserListRecord :  IEquatable<EmailUserListRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailUserListRecord" /> class.
        /// </summary>
        /// <param name="Cc">.</param>
        /// <param name="Observer">.</param>
        /// <param name="RemovedObserver">.</param>
        /// <param name="Scc">.</param>
        /// <param name="RemovedScc">.</param>
        /// <param name="Bcc">.</param>
        /// <param name="RemovedBcc">.</param>
        /// <param name="Assignee">.</param>
        /// <param name="RemovedAssignee">.</param>
        /// <param name="RemovedCc">.</param>
        public EmailUserListRecord(List<string> Cc = null, List<string> Observer = null, List<string> RemovedObserver = null, List<string> Scc = null, List<string> RemovedScc = null, List<string> Bcc = null, List<string> RemovedBcc = null, List<string> Assignee = null, List<string> RemovedAssignee = null, List<string> RemovedCc = null)
        {
            this.Cc = Cc;
            this.Observer = Observer;
            this.RemovedObserver = RemovedObserver;
            this.Scc = Scc;
            this.RemovedScc = RemovedScc;
            this.Bcc = Bcc;
            this.RemovedBcc = RemovedBcc;
            this.Assignee = Assignee;
            this.RemovedAssignee = RemovedAssignee;
            this.RemovedCc = RemovedCc;
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
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public List<string> Assignee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedAssignee", EmitDefaultValue=false)]
        public List<string> RemovedAssignee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="removedCc", EmitDefaultValue=false)]
        public List<string> RemovedCc { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailUserListRecord {\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Observer: ").Append(Observer).Append("\n");
            sb.Append("  RemovedObserver: ").Append(RemovedObserver).Append("\n");
            sb.Append("  Scc: ").Append(Scc).Append("\n");
            sb.Append("  RemovedScc: ").Append(RemovedScc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  RemovedBcc: ").Append(RemovedBcc).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  RemovedAssignee: ").Append(RemovedAssignee).Append("\n");
            sb.Append("  RemovedCc: ").Append(RemovedCc).Append("\n");
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
            return this.Equals(obj as EmailUserListRecord);
        }

        /// <summary>
        /// Returns true if EmailUserListRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of EmailUserListRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailUserListRecord other)
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
                    this.Assignee == other.Assignee ||
                    this.Assignee != null &&
                    this.Assignee.SequenceEqual(other.Assignee)
                ) && 
                (
                    this.RemovedAssignee == other.RemovedAssignee ||
                    this.RemovedAssignee != null &&
                    this.RemovedAssignee.SequenceEqual(other.RemovedAssignee)
                ) && 
                (
                    this.RemovedCc == other.RemovedCc ||
                    this.RemovedCc != null &&
                    this.RemovedCc.SequenceEqual(other.RemovedCc)
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
                if (this.Observer != null)
                    hash = hash * 59 + this.Observer.GetHashCode();
                if (this.RemovedObserver != null)
                    hash = hash * 59 + this.RemovedObserver.GetHashCode();
                if (this.Scc != null)
                    hash = hash * 59 + this.Scc.GetHashCode();
                if (this.RemovedScc != null)
                    hash = hash * 59 + this.RemovedScc.GetHashCode();
                if (this.Bcc != null)
                    hash = hash * 59 + this.Bcc.GetHashCode();
                if (this.RemovedBcc != null)
                    hash = hash * 59 + this.RemovedBcc.GetHashCode();
                if (this.Assignee != null)
                    hash = hash * 59 + this.Assignee.GetHashCode();
                if (this.RemovedAssignee != null)
                    hash = hash * 59 + this.RemovedAssignee.GetHashCode();
                if (this.RemovedCc != null)
                    hash = hash * 59 + this.RemovedCc.GetHashCode();
                return hash;
            }
        }
    }

}
