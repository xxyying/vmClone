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
    /// CloneToTemplateInput
    /// </summary>
    [DataContract]
    public partial class CloneToTemplateInput :  IEquatable<CloneToTemplateInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneToTemplateInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CloneToTemplateInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneToTemplateInput" /> class.
        /// </summary>
        /// <param name="TplName"> (required).</param>
        public CloneToTemplateInput(string TplName = null)
        {
            // to ensure "TplName" is required (not null)
            if (TplName == null)
            {
                throw new InvalidDataException("TplName is a required property for CloneToTemplateInput and cannot be null");
            }
            else
            {
                this.TplName = TplName;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="tplName", EmitDefaultValue=false)]
        public string TplName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneToTemplateInput {\n");
            sb.Append("  TplName: ").Append(TplName).Append("\n");
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
            return this.Equals(obj as CloneToTemplateInput);
        }

        /// <summary>
        /// Returns true if CloneToTemplateInput instances are equal
        /// </summary>
        /// <param name="other">Instance of CloneToTemplateInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneToTemplateInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TplName == other.TplName ||
                    this.TplName != null &&
                    this.TplName.Equals(other.TplName)
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
                if (this.TplName != null)
                    hash = hash * 59 + this.TplName.GetHashCode();
                return hash;
            }
        }
    }

}