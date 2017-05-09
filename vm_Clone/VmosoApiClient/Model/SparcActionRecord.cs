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
    /// SparcActionRecord
    /// </summary>
    [DataContract]
    public partial class SparcActionRecord :  IEquatable<SparcActionRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SparcActionRecord" /> class.
        /// </summary>
        /// <param name="Actors">Actors.</param>
        /// <param name="AreNewTile">areNewTile.</param>
        /// <param name="AreTileRead">areTileRead.</param>
        /// <param name="Verb">Verb.</param>
        /// <param name="Sparcsubtype">Sparc subtype.</param>
        /// <param name="Containers">Containers.</param>
        /// <param name="Details">Additional details..</param>
        /// <param name="Id">Action id.</param>
        /// <param name="RefmeFlag">RefmeFlag.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="Sparctype">Sparc type.</param>
        /// <param name="Target">Target.</param>
        public SparcActionRecord(List<StreamRecordWrapper> Actors = null, bool? AreNewTile = null, bool? AreTileRead = null, string Verb = null, string Sparcsubtype = null, List<StreamRecordWrapper> Containers = null, List<StringAttrRecord> Details = null, int? Id = null, bool? RefmeFlag = null, int? Timestamp = null, string Sparctype = null, List<StreamRecordWrapper> Target = null)
        {
            this.Actors = Actors;
            this.AreNewTile = AreNewTile;
            this.AreTileRead = AreTileRead;
            this.Verb = Verb;
            this.Sparcsubtype = Sparcsubtype;
            this.Containers = Containers;
            this.Details = Details;
            this.Id = Id;
            this.RefmeFlag = RefmeFlag;
            this.Timestamp = Timestamp;
            this.Sparctype = Sparctype;
            this.Target = Target;
        }
        
        /// <summary>
        /// Actors
        /// </summary>
        /// <value>Actors</value>
        [DataMember(Name="actors", EmitDefaultValue=false)]
        public List<StreamRecordWrapper> Actors { get; set; }
        /// <summary>
        /// areNewTile
        /// </summary>
        /// <value>areNewTile</value>
        [DataMember(Name="areNewTile", EmitDefaultValue=false)]
        public bool? AreNewTile { get; set; }
        /// <summary>
        /// areTileRead
        /// </summary>
        /// <value>areTileRead</value>
        [DataMember(Name="areTileRead", EmitDefaultValue=false)]
        public bool? AreTileRead { get; set; }
        /// <summary>
        /// Verb
        /// </summary>
        /// <value>Verb</value>
        [DataMember(Name="verb", EmitDefaultValue=false)]
        public string Verb { get; set; }
        /// <summary>
        /// Sparc subtype
        /// </summary>
        /// <value>Sparc subtype</value>
        [DataMember(Name="sparcsubtype", EmitDefaultValue=false)]
        public string Sparcsubtype { get; set; }
        /// <summary>
        /// Containers
        /// </summary>
        /// <value>Containers</value>
        [DataMember(Name="containers", EmitDefaultValue=false)]
        public List<StreamRecordWrapper> Containers { get; set; }
        /// <summary>
        /// Additional details.
        /// </summary>
        /// <value>Additional details.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<StringAttrRecord> Details { get; set; }
        /// <summary>
        /// Action id
        /// </summary>
        /// <value>Action id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// RefmeFlag
        /// </summary>
        /// <value>RefmeFlag</value>
        [DataMember(Name="refmeFlag", EmitDefaultValue=false)]
        public bool? RefmeFlag { get; set; }
        /// <summary>
        /// Timestamp
        /// </summary>
        /// <value>Timestamp</value>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public int? Timestamp { get; set; }
        /// <summary>
        /// Sparc type
        /// </summary>
        /// <value>Sparc type</value>
        [DataMember(Name="sparctype", EmitDefaultValue=false)]
        public string Sparctype { get; set; }
        /// <summary>
        /// Target
        /// </summary>
        /// <value>Target</value>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public List<StreamRecordWrapper> Target { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SparcActionRecord {\n");
            sb.Append("  Actors: ").Append(Actors).Append("\n");
            sb.Append("  AreNewTile: ").Append(AreNewTile).Append("\n");
            sb.Append("  AreTileRead: ").Append(AreTileRead).Append("\n");
            sb.Append("  Verb: ").Append(Verb).Append("\n");
            sb.Append("  Sparcsubtype: ").Append(Sparcsubtype).Append("\n");
            sb.Append("  Containers: ").Append(Containers).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RefmeFlag: ").Append(RefmeFlag).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Sparctype: ").Append(Sparctype).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(obj as SparcActionRecord);
        }

        /// <summary>
        /// Returns true if SparcActionRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of SparcActionRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SparcActionRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Actors == other.Actors ||
                    this.Actors != null &&
                    this.Actors.SequenceEqual(other.Actors)
                ) && 
                (
                    this.AreNewTile == other.AreNewTile ||
                    this.AreNewTile != null &&
                    this.AreNewTile.Equals(other.AreNewTile)
                ) && 
                (
                    this.AreTileRead == other.AreTileRead ||
                    this.AreTileRead != null &&
                    this.AreTileRead.Equals(other.AreTileRead)
                ) && 
                (
                    this.Verb == other.Verb ||
                    this.Verb != null &&
                    this.Verb.Equals(other.Verb)
                ) && 
                (
                    this.Sparcsubtype == other.Sparcsubtype ||
                    this.Sparcsubtype != null &&
                    this.Sparcsubtype.Equals(other.Sparcsubtype)
                ) && 
                (
                    this.Containers == other.Containers ||
                    this.Containers != null &&
                    this.Containers.SequenceEqual(other.Containers)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.RefmeFlag == other.RefmeFlag ||
                    this.RefmeFlag != null &&
                    this.RefmeFlag.Equals(other.RefmeFlag)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Sparctype == other.Sparctype ||
                    this.Sparctype != null &&
                    this.Sparctype.Equals(other.Sparctype)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.SequenceEqual(other.Target)
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
                if (this.Actors != null)
                    hash = hash * 59 + this.Actors.GetHashCode();
                if (this.AreNewTile != null)
                    hash = hash * 59 + this.AreNewTile.GetHashCode();
                if (this.AreTileRead != null)
                    hash = hash * 59 + this.AreTileRead.GetHashCode();
                if (this.Verb != null)
                    hash = hash * 59 + this.Verb.GetHashCode();
                if (this.Sparcsubtype != null)
                    hash = hash * 59 + this.Sparcsubtype.GetHashCode();
                if (this.Containers != null)
                    hash = hash * 59 + this.Containers.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.RefmeFlag != null)
                    hash = hash * 59 + this.RefmeFlag.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Sparctype != null)
                    hash = hash * 59 + this.Sparctype.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                return hash;
            }
        }
    }

}
