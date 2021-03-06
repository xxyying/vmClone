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
    /// AttachmentsOpRecord
    /// </summary>
    [DataContract]
    public partial class AttachmentsOpRecord :  IEquatable<AttachmentsOpRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsOpRecord" /> class.
        /// </summary>
        /// <param name="RemovedKeys">removed attachmentKeys.</param>
        /// <param name="AddedKeys">added attachmentsKeys.</param>
        /// <param name="AddByEmail">whether add by email.</param>
        public AttachmentsOpRecord(List<string> RemovedKeys = null, List<string> AddedKeys = null, bool? AddByEmail = null)
        {
            this.RemovedKeys = RemovedKeys;
            this.AddedKeys = AddedKeys;
            this.AddByEmail = AddByEmail;
        }
        
        /// <summary>
        /// removed attachmentKeys
        /// </summary>
        /// <value>removed attachmentKeys</value>
        [DataMember(Name="removedKeys", EmitDefaultValue=false)]
        public List<string> RemovedKeys { get; set; }
        /// <summary>
        /// added attachmentsKeys
        /// </summary>
        /// <value>added attachmentsKeys</value>
        [DataMember(Name="addedKeys", EmitDefaultValue=false)]
        public List<string> AddedKeys { get; set; }
        /// <summary>
        /// whether add by email
        /// </summary>
        /// <value>whether add by email</value>
        [DataMember(Name="addByEmail", EmitDefaultValue=false)]
        public bool? AddByEmail { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentsOpRecord {\n");
            sb.Append("  RemovedKeys: ").Append(RemovedKeys).Append("\n");
            sb.Append("  AddedKeys: ").Append(AddedKeys).Append("\n");
            sb.Append("  AddByEmail: ").Append(AddByEmail).Append("\n");
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
            return this.Equals(obj as AttachmentsOpRecord);
        }

        /// <summary>
        /// Returns true if AttachmentsOpRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentsOpRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentsOpRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RemovedKeys == other.RemovedKeys ||
                    this.RemovedKeys != null &&
                    this.RemovedKeys.SequenceEqual(other.RemovedKeys)
                ) && 
                (
                    this.AddedKeys == other.AddedKeys ||
                    this.AddedKeys != null &&
                    this.AddedKeys.SequenceEqual(other.AddedKeys)
                ) && 
                (
                    this.AddByEmail == other.AddByEmail ||
                    this.AddByEmail != null &&
                    this.AddByEmail.Equals(other.AddByEmail)
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
                if (this.RemovedKeys != null)
                    hash = hash * 59 + this.RemovedKeys.GetHashCode();
                if (this.AddedKeys != null)
                    hash = hash * 59 + this.AddedKeys.GetHashCode();
                if (this.AddByEmail != null)
                    hash = hash * 59 + this.AddByEmail.GetHashCode();
                return hash;
            }
        }
    }

}
