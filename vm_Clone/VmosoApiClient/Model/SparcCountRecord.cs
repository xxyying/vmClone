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
    /// SparcCountRecord
    /// </summary>
    [DataContract]
    public partial class SparcCountRecord :  IEquatable<SparcCountRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SparcCountRecord" /> class.
        /// </summary>
        /// <param name="Summary">Summary count.</param>
        /// <param name="SummaryNewCount">New unread summary count.</param>
        /// <param name="Associations">Associations count.</param>
        /// <param name="References">References count.</param>
        /// <param name="ContentNewCount">New unread content count.</param>
        /// <param name="ParticipantsNewCount">New unread participant count.</param>
        /// <param name="TotalNewCount">New unread total count.</param>
        /// <param name="Content">Content count.</param>
        /// <param name="Total">total count.</param>
        /// <param name="ReferencesNewCount">New unread references count.</param>
        /// <param name="AssociationsNewCount">New unread associations count.</param>
        /// <param name="Key">Tile key.</param>
        /// <param name="Participants">Participant count.</param>
        public SparcCountRecord(int? Summary = null, int? SummaryNewCount = null, int? Associations = null, int? References = null, int? ContentNewCount = null, int? ParticipantsNewCount = null, int? TotalNewCount = null, int? Content = null, int? Total = null, int? ReferencesNewCount = null, int? AssociationsNewCount = null, string Key = null, int? Participants = null)
        {
            this.Summary = Summary;
            this.SummaryNewCount = SummaryNewCount;
            this.Associations = Associations;
            this.References = References;
            this.ContentNewCount = ContentNewCount;
            this.ParticipantsNewCount = ParticipantsNewCount;
            this.TotalNewCount = TotalNewCount;
            this.Content = Content;
            this.Total = Total;
            this.ReferencesNewCount = ReferencesNewCount;
            this.AssociationsNewCount = AssociationsNewCount;
            this.Key = Key;
            this.Participants = Participants;
        }
        
        /// <summary>
        /// Summary count
        /// </summary>
        /// <value>Summary count</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public int? Summary { get; set; }
        /// <summary>
        /// New unread summary count
        /// </summary>
        /// <value>New unread summary count</value>
        [DataMember(Name="summaryNewCount", EmitDefaultValue=false)]
        public int? SummaryNewCount { get; set; }
        /// <summary>
        /// Associations count
        /// </summary>
        /// <value>Associations count</value>
        [DataMember(Name="associations", EmitDefaultValue=false)]
        public int? Associations { get; set; }
        /// <summary>
        /// References count
        /// </summary>
        /// <value>References count</value>
        [DataMember(Name="references", EmitDefaultValue=false)]
        public int? References { get; set; }
        /// <summary>
        /// New unread content count
        /// </summary>
        /// <value>New unread content count</value>
        [DataMember(Name="contentNewCount", EmitDefaultValue=false)]
        public int? ContentNewCount { get; set; }
        /// <summary>
        /// New unread participant count
        /// </summary>
        /// <value>New unread participant count</value>
        [DataMember(Name="participantsNewCount", EmitDefaultValue=false)]
        public int? ParticipantsNewCount { get; set; }
        /// <summary>
        /// New unread total count
        /// </summary>
        /// <value>New unread total count</value>
        [DataMember(Name="totalNewCount", EmitDefaultValue=false)]
        public int? TotalNewCount { get; set; }
        /// <summary>
        /// Content count
        /// </summary>
        /// <value>Content count</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public int? Content { get; set; }
        /// <summary>
        /// total count
        /// </summary>
        /// <value>total count</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }
        /// <summary>
        /// New unread references count
        /// </summary>
        /// <value>New unread references count</value>
        [DataMember(Name="referencesNewCount", EmitDefaultValue=false)]
        public int? ReferencesNewCount { get; set; }
        /// <summary>
        /// New unread associations count
        /// </summary>
        /// <value>New unread associations count</value>
        [DataMember(Name="associationsNewCount", EmitDefaultValue=false)]
        public int? AssociationsNewCount { get; set; }
        /// <summary>
        /// Tile key
        /// </summary>
        /// <value>Tile key</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Participant count
        /// </summary>
        /// <value>Participant count</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public int? Participants { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SparcCountRecord {\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  SummaryNewCount: ").Append(SummaryNewCount).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
            sb.Append("  ContentNewCount: ").Append(ContentNewCount).Append("\n");
            sb.Append("  ParticipantsNewCount: ").Append(ParticipantsNewCount).Append("\n");
            sb.Append("  TotalNewCount: ").Append(TotalNewCount).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  ReferencesNewCount: ").Append(ReferencesNewCount).Append("\n");
            sb.Append("  AssociationsNewCount: ").Append(AssociationsNewCount).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
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
            return this.Equals(obj as SparcCountRecord);
        }

        /// <summary>
        /// Returns true if SparcCountRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SparcCountRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SparcCountRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.SummaryNewCount == other.SummaryNewCount ||
                    this.SummaryNewCount != null &&
                    this.SummaryNewCount.Equals(other.SummaryNewCount)
                ) && 
                (
                    this.Associations == other.Associations ||
                    this.Associations != null &&
                    this.Associations.Equals(other.Associations)
                ) && 
                (
                    this.References == other.References ||
                    this.References != null &&
                    this.References.Equals(other.References)
                ) && 
                (
                    this.ContentNewCount == other.ContentNewCount ||
                    this.ContentNewCount != null &&
                    this.ContentNewCount.Equals(other.ContentNewCount)
                ) && 
                (
                    this.ParticipantsNewCount == other.ParticipantsNewCount ||
                    this.ParticipantsNewCount != null &&
                    this.ParticipantsNewCount.Equals(other.ParticipantsNewCount)
                ) && 
                (
                    this.TotalNewCount == other.TotalNewCount ||
                    this.TotalNewCount != null &&
                    this.TotalNewCount.Equals(other.TotalNewCount)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.ReferencesNewCount == other.ReferencesNewCount ||
                    this.ReferencesNewCount != null &&
                    this.ReferencesNewCount.Equals(other.ReferencesNewCount)
                ) && 
                (
                    this.AssociationsNewCount == other.AssociationsNewCount ||
                    this.AssociationsNewCount != null &&
                    this.AssociationsNewCount.Equals(other.AssociationsNewCount)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.Equals(other.Participants)
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
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();
                if (this.SummaryNewCount != null)
                    hash = hash * 59 + this.SummaryNewCount.GetHashCode();
                if (this.Associations != null)
                    hash = hash * 59 + this.Associations.GetHashCode();
                if (this.References != null)
                    hash = hash * 59 + this.References.GetHashCode();
                if (this.ContentNewCount != null)
                    hash = hash * 59 + this.ContentNewCount.GetHashCode();
                if (this.ParticipantsNewCount != null)
                    hash = hash * 59 + this.ParticipantsNewCount.GetHashCode();
                if (this.TotalNewCount != null)
                    hash = hash * 59 + this.TotalNewCount.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                if (this.ReferencesNewCount != null)
                    hash = hash * 59 + this.ReferencesNewCount.GetHashCode();
                if (this.AssociationsNewCount != null)
                    hash = hash * 59 + this.AssociationsNewCount.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                return hash;
            }
        }
    }

}