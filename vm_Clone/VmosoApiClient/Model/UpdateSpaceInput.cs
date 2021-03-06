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
    /// UpdateSpaceInput
    /// </summary>
    [DataContract]
    public partial class UpdateSpaceInput :  IEquatable<UpdateSpaceInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpaceInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSpaceInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSpaceInput" /> class.
        /// </summary>
        /// <param name="SpaceId"> (required).</param>
        /// <param name="AllowAnonymousPost"> (required).</param>
        /// <param name="AllowToLeave"> (required).</param>
        /// <param name="SpaceOptions">.</param>
        /// <param name="Name"> (required).</param>
        /// <param name="AllowOutsideParentWL"> (required).</param>
        /// <param name="Desc"> (required).</param>
        public UpdateSpaceInput(string SpaceId = null, bool? AllowAnonymousPost = null, bool? AllowToLeave = null, List<string> SpaceOptions = null, string Name = null, bool? AllowOutsideParentWL = null, string Desc = null)
        {
            // to ensure "SpaceId" is required (not null)
            if (SpaceId == null)
            {
                throw new InvalidDataException("SpaceId is a required property for UpdateSpaceInput and cannot be null");
            }
            else
            {
                this.SpaceId = SpaceId;
            }
            // to ensure "AllowAnonymousPost" is required (not null)
            if (AllowAnonymousPost == null)
            {
                throw new InvalidDataException("AllowAnonymousPost is a required property for UpdateSpaceInput and cannot be null");
            }
            else
            {
                this.AllowAnonymousPost = AllowAnonymousPost;
            }
            // to ensure "AllowToLeave" is required (not null)
            if (AllowToLeave == null)
            {
                throw new InvalidDataException("AllowToLeave is a required property for UpdateSpaceInput and cannot be null");
            }
            else
            {
                this.AllowToLeave = AllowToLeave;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for UpdateSpaceInput and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "AllowOutsideParentWL" is required (not null)
            if (AllowOutsideParentWL == null)
            {
                throw new InvalidDataException("AllowOutsideParentWL is a required property for UpdateSpaceInput and cannot be null");
            }
            else
            {
                this.AllowOutsideParentWL = AllowOutsideParentWL;
            }
            // to ensure "Desc" is required (not null)
            if (Desc == null)
            {
                throw new InvalidDataException("Desc is a required property for UpdateSpaceInput and cannot be null");
            }
            else
            {
                this.Desc = Desc;
            }
            this.SpaceOptions = SpaceOptions;
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
        [DataMember(Name="allowAnonymousPost", EmitDefaultValue=false)]
        public bool? AllowAnonymousPost { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="allowToLeave", EmitDefaultValue=false)]
        public bool? AllowToLeave { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="spaceOptions", EmitDefaultValue=false)]
        public List<string> SpaceOptions { get; set; }
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
        [DataMember(Name="allowOutsideParentWL", EmitDefaultValue=false)]
        public bool? AllowOutsideParentWL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="desc", EmitDefaultValue=false)]
        public string Desc { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSpaceInput {\n");
            sb.Append("  SpaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  AllowAnonymousPost: ").Append(AllowAnonymousPost).Append("\n");
            sb.Append("  AllowToLeave: ").Append(AllowToLeave).Append("\n");
            sb.Append("  SpaceOptions: ").Append(SpaceOptions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AllowOutsideParentWL: ").Append(AllowOutsideParentWL).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
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
            return this.Equals(obj as UpdateSpaceInput);
        }

        /// <summary>
        /// Returns true if UpdateSpaceInput instances are equal
        /// </summary>
        /// <param name="other">Instance of UpdateSpaceInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSpaceInput other)
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
                    this.AllowAnonymousPost == other.AllowAnonymousPost ||
                    this.AllowAnonymousPost != null &&
                    this.AllowAnonymousPost.Equals(other.AllowAnonymousPost)
                ) && 
                (
                    this.AllowToLeave == other.AllowToLeave ||
                    this.AllowToLeave != null &&
                    this.AllowToLeave.Equals(other.AllowToLeave)
                ) && 
                (
                    this.SpaceOptions == other.SpaceOptions ||
                    this.SpaceOptions != null &&
                    this.SpaceOptions.SequenceEqual(other.SpaceOptions)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AllowOutsideParentWL == other.AllowOutsideParentWL ||
                    this.AllowOutsideParentWL != null &&
                    this.AllowOutsideParentWL.Equals(other.AllowOutsideParentWL)
                ) && 
                (
                    this.Desc == other.Desc ||
                    this.Desc != null &&
                    this.Desc.Equals(other.Desc)
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
                if (this.AllowAnonymousPost != null)
                    hash = hash * 59 + this.AllowAnonymousPost.GetHashCode();
                if (this.AllowToLeave != null)
                    hash = hash * 59 + this.AllowToLeave.GetHashCode();
                if (this.SpaceOptions != null)
                    hash = hash * 59 + this.SpaceOptions.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AllowOutsideParentWL != null)
                    hash = hash * 59 + this.AllowOutsideParentWL.GetHashCode();
                if (this.Desc != null)
                    hash = hash * 59 + this.Desc.GetHashCode();
                return hash;
            }
        }
    }

}
