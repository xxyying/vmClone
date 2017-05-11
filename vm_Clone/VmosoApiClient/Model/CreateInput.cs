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
    /// CreateInput
    /// </summary>
    [DataContract]
    public partial class CreateInput :  IEquatable<CreateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInput" /> class.
        /// </summary>
        /// <param name="Inputrecord">Inputrecord (required).</param>
        /// <param name="Option">Option (required).</param>
        public CreateInput(SpaceRecord Inputrecord = null, SpaceCreateOptionsRecord Option = null)
        {
            // to ensure "Inputrecord" is required (not null)
            if (Inputrecord == null)
            {
                throw new InvalidDataException("Inputrecord is a required property for CreateInput and cannot be null");
            }
            else
            {
                this.Inputrecord = Inputrecord;
            }
            // to ensure "Option" is required (not null)
            if (Option == null)
            {
                throw new InvalidDataException("Option is a required property for CreateInput and cannot be null");
            }
            else
            {
                this.Option = Option;
            }
        }
        
        /// <summary>
        /// Gets or Sets Inputrecord
        /// </summary>
        [DataMember(Name="inputrecord", EmitDefaultValue=false)]
        public SpaceRecord Inputrecord { get; set; }
        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public SpaceCreateOptionsRecord Option { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInput {\n");
            sb.Append("  Inputrecord: ").Append(Inputrecord).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(obj as CreateInput);
        }

        /// <summary>
        /// Returns true if CreateInput instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Inputrecord == other.Inputrecord ||
                    this.Inputrecord != null &&
                    this.Inputrecord.Equals(other.Inputrecord)
                ) && 
                (
                    this.Option == other.Option ||
                    this.Option != null &&
                    this.Option.Equals(other.Option)
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
                if (this.Inputrecord != null)
                    hash = hash * 59 + this.Inputrecord.GetHashCode();
                if (this.Option != null)
                    hash = hash * 59 + this.Option.GetHashCode();
                return hash;
            }
        }
    }

}