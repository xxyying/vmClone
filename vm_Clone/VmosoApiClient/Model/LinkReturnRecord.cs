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
    /// LinkReturnRecord
    /// </summary>
    [DataContract]
    public partial class LinkReturnRecord :  IEquatable<LinkReturnRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkReturnRecord" /> class.
        /// </summary>
        /// <param name="Url">Basic url.</param>
        /// <param name="EmailDestination">Email destination.</param>
        /// <param name="AHARichText">Rich text.</param>
        public LinkReturnRecord(string Url = null, string EmailDestination = null, string AHARichText = null)
        {
            this.Url = Url;
            this.EmailDestination = EmailDestination;
            this.AHARichText = AHARichText;
        }
        
        /// <summary>
        /// Basic url
        /// </summary>
        /// <value>Basic url</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Email destination
        /// </summary>
        /// <value>Email destination</value>
        [DataMember(Name="email_destination", EmitDefaultValue=false)]
        public string EmailDestination { get; set; }
        /// <summary>
        /// Rich text
        /// </summary>
        /// <value>Rich text</value>
        [DataMember(Name="AHA_rich_text", EmitDefaultValue=false)]
        public string AHARichText { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinkReturnRecord {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  EmailDestination: ").Append(EmailDestination).Append("\n");
            sb.Append("  AHARichText: ").Append(AHARichText).Append("\n");
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
            return this.Equals(obj as LinkReturnRecord);
        }

        /// <summary>
        /// Returns true if LinkReturnRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of LinkReturnRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkReturnRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.EmailDestination == other.EmailDestination ||
                    this.EmailDestination != null &&
                    this.EmailDestination.Equals(other.EmailDestination)
                ) && 
                (
                    this.AHARichText == other.AHARichText ||
                    this.AHARichText != null &&
                    this.AHARichText.Equals(other.AHARichText)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.EmailDestination != null)
                    hash = hash * 59 + this.EmailDestination.GetHashCode();
                if (this.AHARichText != null)
                    hash = hash * 59 + this.AHARichText.GetHashCode();
                return hash;
            }
        }
    }

}
