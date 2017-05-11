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
    /// RegisterDeviceInput
    /// </summary>
    [DataContract]
    public partial class RegisterDeviceInput :  IEquatable<RegisterDeviceInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDeviceInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegisterDeviceInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterDeviceInput" /> class.
        /// </summary>
        /// <param name="Devicealias"> (required).</param>
        /// <param name="Deviceid"> (required).</param>
        /// <param name="Devicetype"> (required).</param>
        public RegisterDeviceInput(string Devicealias = null, string Deviceid = null, string Devicetype = null)
        {
            // to ensure "Devicealias" is required (not null)
            if (Devicealias == null)
            {
                throw new InvalidDataException("Devicealias is a required property for RegisterDeviceInput and cannot be null");
            }
            else
            {
                this.Devicealias = Devicealias;
            }
            // to ensure "Deviceid" is required (not null)
            if (Deviceid == null)
            {
                throw new InvalidDataException("Deviceid is a required property for RegisterDeviceInput and cannot be null");
            }
            else
            {
                this.Deviceid = Deviceid;
            }
            // to ensure "Devicetype" is required (not null)
            if (Devicetype == null)
            {
                throw new InvalidDataException("Devicetype is a required property for RegisterDeviceInput and cannot be null");
            }
            else
            {
                this.Devicetype = Devicetype;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="devicealias", EmitDefaultValue=false)]
        public string Devicealias { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="deviceid", EmitDefaultValue=false)]
        public string Deviceid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="devicetype", EmitDefaultValue=false)]
        public string Devicetype { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterDeviceInput {\n");
            sb.Append("  Devicealias: ").Append(Devicealias).Append("\n");
            sb.Append("  Deviceid: ").Append(Deviceid).Append("\n");
            sb.Append("  Devicetype: ").Append(Devicetype).Append("\n");
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
            return this.Equals(obj as RegisterDeviceInput);
        }

        /// <summary>
        /// Returns true if RegisterDeviceInput instances are equal
        /// </summary>
        /// <param name="other">Instance of RegisterDeviceInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegisterDeviceInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Devicealias == other.Devicealias ||
                    this.Devicealias != null &&
                    this.Devicealias.Equals(other.Devicealias)
                ) && 
                (
                    this.Deviceid == other.Deviceid ||
                    this.Deviceid != null &&
                    this.Deviceid.Equals(other.Deviceid)
                ) && 
                (
                    this.Devicetype == other.Devicetype ||
                    this.Devicetype != null &&
                    this.Devicetype.Equals(other.Devicetype)
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
                if (this.Devicealias != null)
                    hash = hash * 59 + this.Devicealias.GetHashCode();
                if (this.Deviceid != null)
                    hash = hash * 59 + this.Deviceid.GetHashCode();
                if (this.Devicetype != null)
                    hash = hash * 59 + this.Devicetype.GetHashCode();
                return hash;
            }
        }
    }

}