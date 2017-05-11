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
    /// GetDuplicatesInput
    /// </summary>
    [DataContract]
    public partial class GetDuplicatesInput :  IEquatable<GetDuplicatesInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDuplicatesInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDuplicatesInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDuplicatesInput" /> class.
        /// </summary>
        /// <param name="Name"> (required).</param>
        /// <param name="ObjectID"> (required).</param>
        public GetDuplicatesInput(string Name = null, string ObjectID = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for GetDuplicatesInput and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "ObjectID" is required (not null)
            if (ObjectID == null)
            {
                throw new InvalidDataException("ObjectID is a required property for GetDuplicatesInput and cannot be null");
            }
            else
            {
                this.ObjectID = ObjectID;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="objectID", EmitDefaultValue=false)]
        public string ObjectID { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDuplicatesInput {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ObjectID: ").Append(ObjectID).Append("\n");
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
            return this.Equals(obj as GetDuplicatesInput);
        }

        /// <summary>
        /// Returns true if GetDuplicatesInput instances are equal
        /// </summary>
        /// <param name="other">Instance of GetDuplicatesInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDuplicatesInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ObjectID == other.ObjectID ||
                    this.ObjectID != null &&
                    this.ObjectID.Equals(other.ObjectID)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ObjectID != null)
                    hash = hash * 59 + this.ObjectID.GetHashCode();
                return hash;
            }
        }
    }

}