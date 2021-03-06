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
    /// RemoveObjectsInput
    /// </summary>
    [DataContract]
    public partial class RemoveObjectsInput :  IEquatable<RemoveObjectsInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectsInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoveObjectsInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveObjectsInput" /> class.
        /// </summary>
        /// <param name="SpaceId"> (required).</param>
        /// <param name="ItemKeys">.</param>
        /// <param name="ExtraFolderKeys">.</param>
        public RemoveObjectsInput(string SpaceId = null, List<string> ItemKeys = null, List<string> ExtraFolderKeys = null)
        {
            // to ensure "SpaceId" is required (not null)
            if (SpaceId == null)
            {
                throw new InvalidDataException("SpaceId is a required property for RemoveObjectsInput and cannot be null");
            }
            else
            {
                this.SpaceId = SpaceId;
            }
            this.ItemKeys = ItemKeys;
            this.ExtraFolderKeys = ExtraFolderKeys;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="spaceId", EmitDefaultValue=false)]
        public string SpaceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="itemKeys", EmitDefaultValue=false)]
        public List<string> ItemKeys { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="extraFolderKeys", EmitDefaultValue=false)]
        public List<string> ExtraFolderKeys { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoveObjectsInput {\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  ItemKeys: ").Append(ItemKeys).Append("\n");
            sb.Append("  ExtraFolderKeys: ").Append(ExtraFolderKeys).Append("\n");
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
            return this.Equals(obj as RemoveObjectsInput);
        }

        /// <summary>
        /// Returns true if RemoveObjectsInput instances are equal
        /// </summary>
        /// <param name="other">Instance of RemoveObjectsInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoveObjectsInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SpaceId == other.SpaceId ||
                    this.SpaceId != null &&
                    this.SpaceId.Equals(other.SpaceId)
                ) && 
                (
                    this.ItemKeys == other.ItemKeys ||
                    this.ItemKeys != null &&
                    this.ItemKeys.SequenceEqual(other.ItemKeys)
                ) && 
                (
                    this.ExtraFolderKeys == other.ExtraFolderKeys ||
                    this.ExtraFolderKeys != null &&
                    this.ExtraFolderKeys.SequenceEqual(other.ExtraFolderKeys)
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
                if (this.SpaceId != null)
                    hash = hash * 59 + this.SpaceId.GetHashCode();
                if (this.ItemKeys != null)
                    hash = hash * 59 + this.ItemKeys.GetHashCode();
                if (this.ExtraFolderKeys != null)
                    hash = hash * 59 + this.ExtraFolderKeys.GetHashCode();
                return hash;
            }
        }
    }

}
