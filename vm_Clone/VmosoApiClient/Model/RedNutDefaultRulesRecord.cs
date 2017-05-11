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
    /// RedNutDefaultRulesRecord
    /// </summary>
    [DataContract]
    public partial class RedNutDefaultRulesRecord :  IEquatable<RedNutDefaultRulesRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedNutDefaultRulesRecord" /> class.
        /// </summary>
        /// <param name="Activities">Keys of activities rules..</param>
        /// <param name="Locations">Keys of locations rules..</param>
        /// <param name="People">Keys of people rules..</param>
        public RedNutDefaultRulesRecord(List<string> Activities = null, List<string> Locations = null, List<string> People = null)
        {
            this.Activities = Activities;
            this.Locations = Locations;
            this.People = People;
        }
        
        /// <summary>
        /// Keys of activities rules.
        /// </summary>
        /// <value>Keys of activities rules.</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<string> Activities { get; set; }
        /// <summary>
        /// Keys of locations rules.
        /// </summary>
        /// <value>Keys of locations rules.</value>
        [DataMember(Name="locations", EmitDefaultValue=false)]
        public List<string> Locations { get; set; }
        /// <summary>
        /// Keys of people rules.
        /// </summary>
        /// <value>Keys of people rules.</value>
        [DataMember(Name="people", EmitDefaultValue=false)]
        public List<string> People { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedNutDefaultRulesRecord {\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
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
            return this.Equals(obj as RedNutDefaultRulesRecord);
        }

        /// <summary>
        /// Returns true if RedNutDefaultRulesRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of RedNutDefaultRulesRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedNutDefaultRulesRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
                ) && 
                (
                    this.Locations == other.Locations ||
                    this.Locations != null &&
                    this.Locations.SequenceEqual(other.Locations)
                ) && 
                (
                    this.People == other.People ||
                    this.People != null &&
                    this.People.SequenceEqual(other.People)
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
                if (this.Activities != null)
                    hash = hash * 59 + this.Activities.GetHashCode();
                if (this.Locations != null)
                    hash = hash * 59 + this.Locations.GetHashCode();
                if (this.People != null)
                    hash = hash * 59 + this.People.GetHashCode();
                return hash;
            }
        }
    }

}