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
    /// StreamRecordWrapper
    /// </summary>
    [DataContract]
    public partial class StreamRecordWrapper :  IEquatable<StreamRecordWrapper>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamRecordWrapper" /> class.
        /// </summary>
        /// <param name="TotalCounts">TotalCounts.</param>
        /// <param name="ActivityTime">.</param>
        /// <param name="HighlightMatch">highlighted text.</param>
        /// <param name="Ratings">Ratings.</param>
        /// <param name="Record">.</param>
        /// <param name="Recordtype">.</param>
        /// <param name="IsNewTile">.</param>
        /// <param name="BadgeCounts">BadgeCounts.</param>
        /// <param name="LastAction">LastAction.</param>
        /// <param name="IsLocal">Whether this object is local.</param>
        /// <param name="SortKey">.</param>
        public StreamRecordWrapper(SparcCountRecord TotalCounts = null, string ActivityTime = null, string HighlightMatch = null, RatingsRecord Ratings = null, Object Record = null, string Recordtype = null, bool? IsNewTile = null, SparcCountRecord BadgeCounts = null, SparcActionRecord LastAction = null, bool? IsLocal = null, string SortKey = null)
        {
            this.TotalCounts = TotalCounts;
            this.ActivityTime = ActivityTime;
            this.HighlightMatch = HighlightMatch;
            this.Ratings = Ratings;
            this.Record = Record;
            this.Recordtype = Recordtype;
            this.IsNewTile = IsNewTile;
            this.BadgeCounts = BadgeCounts;
            this.LastAction = LastAction;
            this.IsLocal = IsLocal;
            this.SortKey = SortKey;
        }
        
        /// <summary>
        /// Gets or Sets TotalCounts
        /// </summary>
        [DataMember(Name="total_counts", EmitDefaultValue=false)]
        public SparcCountRecord TotalCounts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="activity_time", EmitDefaultValue=false)]
        public string ActivityTime { get; set; }
        /// <summary>
        /// highlighted text
        /// </summary>
        /// <value>highlighted text</value>
        [DataMember(Name="highlightMatch", EmitDefaultValue=false)]
        public string HighlightMatch { get; set; }
        /// <summary>
        /// Gets or Sets Ratings
        /// </summary>
        [DataMember(Name="ratings", EmitDefaultValue=false)]
        public RatingsRecord Ratings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="record", EmitDefaultValue=false)]
        public Object Record { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="recordtype", EmitDefaultValue=false)]
        public string Recordtype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isNewTile", EmitDefaultValue=false)]
        public bool? IsNewTile { get; set; }
        /// <summary>
        /// Gets or Sets BadgeCounts
        /// </summary>
        [DataMember(Name="badge_counts", EmitDefaultValue=false)]
        public SparcCountRecord BadgeCounts { get; set; }
        /// <summary>
        /// Gets or Sets LastAction
        /// </summary>
        [DataMember(Name="last_action", EmitDefaultValue=false)]
        public SparcActionRecord LastAction { get; set; }
        /// <summary>
        /// Whether this object is local
        /// </summary>
        /// <value>Whether this object is local</value>
        [DataMember(Name="is_local", EmitDefaultValue=false)]
        public bool? IsLocal { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="sort_key", EmitDefaultValue=false)]
        public string SortKey { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamRecordWrapper {\n");
            sb.Append("  TotalCounts: ").Append(TotalCounts).Append("\n");
            sb.Append("  ActivityTime: ").Append(ActivityTime).Append("\n");
            sb.Append("  HighlightMatch: ").Append(HighlightMatch).Append("\n");
            sb.Append("  Ratings: ").Append(Ratings).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  Recordtype: ").Append(Recordtype).Append("\n");
            sb.Append("  IsNewTile: ").Append(IsNewTile).Append("\n");
            sb.Append("  BadgeCounts: ").Append(BadgeCounts).Append("\n");
            sb.Append("  LastAction: ").Append(LastAction).Append("\n");
            sb.Append("  IsLocal: ").Append(IsLocal).Append("\n");
            sb.Append("  SortKey: ").Append(SortKey).Append("\n");
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
            return this.Equals(obj as StreamRecordWrapper);
        }

        /// <summary>
        /// Returns true if StreamRecordWrapper instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamRecordWrapper to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamRecordWrapper other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalCounts == other.TotalCounts ||
                    this.TotalCounts != null &&
                    this.TotalCounts.Equals(other.TotalCounts)
                ) && 
                (
                    this.ActivityTime == other.ActivityTime ||
                    this.ActivityTime != null &&
                    this.ActivityTime.Equals(other.ActivityTime)
                ) && 
                (
                    this.HighlightMatch == other.HighlightMatch ||
                    this.HighlightMatch != null &&
                    this.HighlightMatch.Equals(other.HighlightMatch)
                ) && 
                (
                    this.Ratings == other.Ratings ||
                    this.Ratings != null &&
                    this.Ratings.Equals(other.Ratings)
                ) && 
                (
                    this.Record == other.Record ||
                    this.Record != null &&
                    this.Record.Equals(other.Record)
                ) && 
                (
                    this.Recordtype == other.Recordtype ||
                    this.Recordtype != null &&
                    this.Recordtype.Equals(other.Recordtype)
                ) && 
                (
                    this.IsNewTile == other.IsNewTile ||
                    this.IsNewTile != null &&
                    this.IsNewTile.Equals(other.IsNewTile)
                ) && 
                (
                    this.BadgeCounts == other.BadgeCounts ||
                    this.BadgeCounts != null &&
                    this.BadgeCounts.Equals(other.BadgeCounts)
                ) && 
                (
                    this.LastAction == other.LastAction ||
                    this.LastAction != null &&
                    this.LastAction.Equals(other.LastAction)
                ) && 
                (
                    this.IsLocal == other.IsLocal ||
                    this.IsLocal != null &&
                    this.IsLocal.Equals(other.IsLocal)
                ) && 
                (
                    this.SortKey == other.SortKey ||
                    this.SortKey != null &&
                    this.SortKey.Equals(other.SortKey)
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
                if (this.TotalCounts != null)
                    hash = hash * 59 + this.TotalCounts.GetHashCode();
                if (this.ActivityTime != null)
                    hash = hash * 59 + this.ActivityTime.GetHashCode();
                if (this.HighlightMatch != null)
                    hash = hash * 59 + this.HighlightMatch.GetHashCode();
                if (this.Ratings != null)
                    hash = hash * 59 + this.Ratings.GetHashCode();
                if (this.Record != null)
                    hash = hash * 59 + this.Record.GetHashCode();
                if (this.Recordtype != null)
                    hash = hash * 59 + this.Recordtype.GetHashCode();
                if (this.IsNewTile != null)
                    hash = hash * 59 + this.IsNewTile.GetHashCode();
                if (this.BadgeCounts != null)
                    hash = hash * 59 + this.BadgeCounts.GetHashCode();
                if (this.LastAction != null)
                    hash = hash * 59 + this.LastAction.GetHashCode();
                if (this.IsLocal != null)
                    hash = hash * 59 + this.IsLocal.GetHashCode();
                if (this.SortKey != null)
                    hash = hash * 59 + this.SortKey.GetHashCode();
                return hash;
            }
        }
    }

}
