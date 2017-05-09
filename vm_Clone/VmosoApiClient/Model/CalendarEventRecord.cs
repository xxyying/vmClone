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
    /// CalendarEventRecord
    /// </summary>
    [DataContract]
    public partial class CalendarEventRecord : ContentRecord,  IEquatable<CalendarEventRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarEventRecord" /> class.
        /// </summary>
        /// <param name="Editor">Editor.</param>
        /// <param name="FavoriteFlag">.</param>
        /// <param name="Type">Type of content record..</param>
        /// <param name="Userrecord">Userrecord.</param>
        /// <param name="Timeupdated">Last update time for content record..</param>
        /// <param name="Tags">Array of tag labels for this content..</param>
        /// <param name="ImportantFlag">.</param>
        /// <param name="Aclrecord">Aclrecord.</param>
        /// <param name="Timecreated">Time created for content record..</param>
        /// <param name="HideFlag">hide flag..</param>
        /// <param name="Subtype">Subtype of content record..</param>
        /// <param name="PinFlag">pin flag..</param>
        /// <param name="FollowFlag">.</param>
        /// <param name="NaviKey">Navigation Key ; store navigation group letter.</param>
        /// <param name="SyncToLocalFlag">.</param>
        /// <param name="Key">Key of content record..</param>
        /// <param name="PinTime">pin time..</param>
        /// <param name="Status">Status of content record..</param>
        /// <param name="Commentcount">Comment count for event..</param>
        /// <param name="Folders">The folders where the calendar event resides; needed because CalendarEventRecord is a ContentRecord..</param>
        /// <param name="StartDateTime">The event start date and time; corresponds to the DTSTART property..</param>
        /// <param name="Timezone">The time zone for the event; corresponds to the TZID property..</param>
        /// <param name="RecurrenceDateTimes">The recurrence date-times for the event; corresponds to the RDATE property..</param>
        /// <param name="Description">The event description; corresponds to the DESCRIPTION property..</param>
        /// <param name="ExceptionDateTimes">The exception date-times for the event; corresponds to the EXDATE property..</param>
        /// <param name="Location">The event location; corresponds to the LOCATION property..</param>
        /// <param name="RecurrenceRule">The recurrence rule for the event; corresponds to the RRULE property..</param>
        /// <param name="Title">The event title; corresponds to the SUMMARY property..</param>
        /// <param name="EndDateTime">The event end date and time; corresponds to the DTEND property..</param>
        public CalendarEventRecord(DisplayRecord Editor = null, string FavoriteFlag = null, string Type = null, DisplayRecord Userrecord = null, int? Timeupdated = null, Object Tags = null, string ImportantFlag = null, ACLRecord Aclrecord = null, int? Timecreated = null, bool? HideFlag = null, string Subtype = null, bool? PinFlag = null, bool? FollowFlag = null, string NaviKey = null, bool? SyncToLocalFlag = null, string Key = null, int? PinTime = null, string Status = null, int? Commentcount = null, List<FolderRecord> Folders = null, string StartDateTime = null, string Timezone = null, string RecurrenceDateTimes = null, string Description = null, string ExceptionDateTimes = null, string Location = null, string RecurrenceRule = null, string Title = null, string EndDateTime = null)
        {
            this.Editor = Editor;
            this.FavoriteFlag = FavoriteFlag;
            this.Type = Type;
            this.Userrecord = Userrecord;
            this.Timeupdated = Timeupdated;
            this.Tags = Tags;
            this.ImportantFlag = ImportantFlag;
            this.Aclrecord = Aclrecord;
            this.Timecreated = Timecreated;
            this.HideFlag = HideFlag;
            this.Subtype = Subtype;
            this.PinFlag = PinFlag;
            this.FollowFlag = FollowFlag;
            this.NaviKey = NaviKey;
            this.SyncToLocalFlag = SyncToLocalFlag;
            this.Key = Key;
            this.PinTime = PinTime;
            this.Status = Status;
            this.Commentcount = Commentcount;
            this.Folders = Folders;
            this.StartDateTime = StartDateTime;
            this.Timezone = Timezone;
            this.RecurrenceDateTimes = RecurrenceDateTimes;
            this.Description = Description;
            this.ExceptionDateTimes = ExceptionDateTimes;
            this.Location = Location;
            this.RecurrenceRule = RecurrenceRule;
            this.Title = Title;
            this.EndDateTime = EndDateTime;
        }
        
        /// <summary>
        /// Gets or Sets Editor
        /// </summary>
        [DataMember(Name="editor", EmitDefaultValue=false)]
        public DisplayRecord Editor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="favoriteFlag", EmitDefaultValue=false)]
        public string FavoriteFlag { get; set; }
        /// <summary>
        /// Type of content record.
        /// </summary>
        /// <value>Type of content record.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Userrecord
        /// </summary>
        [DataMember(Name="userrecord", EmitDefaultValue=false)]
        public DisplayRecord Userrecord { get; set; }
        /// <summary>
        /// Last update time for content record.
        /// </summary>
        /// <value>Last update time for content record.</value>
        [DataMember(Name="timeupdated", EmitDefaultValue=false)]
        public int? Timeupdated { get; set; }
        /// <summary>
        /// Array of tag labels for this content.
        /// </summary>
        /// <value>Array of tag labels for this content.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public Object Tags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="importantFlag", EmitDefaultValue=false)]
        public string ImportantFlag { get; set; }
        /// <summary>
        /// Gets or Sets Aclrecord
        /// </summary>
        [DataMember(Name="aclrecord", EmitDefaultValue=false)]
        public ACLRecord Aclrecord { get; set; }
        /// <summary>
        /// Time created for content record.
        /// </summary>
        /// <value>Time created for content record.</value>
        [DataMember(Name="timecreated", EmitDefaultValue=false)]
        public int? Timecreated { get; set; }
        /// <summary>
        /// hide flag.
        /// </summary>
        /// <value>hide flag.</value>
        [DataMember(Name="hideFlag", EmitDefaultValue=false)]
        public bool? HideFlag { get; set; }
        /// <summary>
        /// Subtype of content record.
        /// </summary>
        /// <value>Subtype of content record.</value>
        [DataMember(Name="subtype", EmitDefaultValue=false)]
        public string Subtype { get; set; }
        /// <summary>
        /// pin flag.
        /// </summary>
        /// <value>pin flag.</value>
        [DataMember(Name="pinFlag", EmitDefaultValue=false)]
        public bool? PinFlag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="followFlag", EmitDefaultValue=false)]
        public bool? FollowFlag { get; set; }
        /// <summary>
        /// Navigation Key ; store navigation group letter
        /// </summary>
        /// <value>Navigation Key ; store navigation group letter</value>
        [DataMember(Name="naviKey", EmitDefaultValue=false)]
        public string NaviKey { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="syncToLocalFlag", EmitDefaultValue=false)]
        public bool? SyncToLocalFlag { get; set; }
        /// <summary>
        /// Key of content record.
        /// </summary>
        /// <value>Key of content record.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// pin time.
        /// </summary>
        /// <value>pin time.</value>
        [DataMember(Name="pinTime", EmitDefaultValue=false)]
        public int? PinTime { get; set; }
        /// <summary>
        /// Status of content record.
        /// </summary>
        /// <value>Status of content record.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Comment count for event.
        /// </summary>
        /// <value>Comment count for event.</value>
        [DataMember(Name="commentcount", EmitDefaultValue=false)]
        public int? Commentcount { get; set; }
        /// <summary>
        /// The folders where the calendar event resides; needed because CalendarEventRecord is a ContentRecord.
        /// </summary>
        /// <value>The folders where the calendar event resides; needed because CalendarEventRecord is a ContentRecord.</value>
        [DataMember(Name="folders", EmitDefaultValue=false)]
        public List<FolderRecord> Folders { get; set; }
        /// <summary>
        /// The event start date and time; corresponds to the DTSTART property.
        /// </summary>
        /// <value>The event start date and time; corresponds to the DTSTART property.</value>
        [DataMember(Name="startDateTime", EmitDefaultValue=false)]
        public string StartDateTime { get; set; }
        /// <summary>
        /// The time zone for the event; corresponds to the TZID property.
        /// </summary>
        /// <value>The time zone for the event; corresponds to the TZID property.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }
        /// <summary>
        /// The recurrence date-times for the event; corresponds to the RDATE property.
        /// </summary>
        /// <value>The recurrence date-times for the event; corresponds to the RDATE property.</value>
        [DataMember(Name="recurrenceDateTimes", EmitDefaultValue=false)]
        public string RecurrenceDateTimes { get; set; }
        /// <summary>
        /// The event description; corresponds to the DESCRIPTION property.
        /// </summary>
        /// <value>The event description; corresponds to the DESCRIPTION property.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The exception date-times for the event; corresponds to the EXDATE property.
        /// </summary>
        /// <value>The exception date-times for the event; corresponds to the EXDATE property.</value>
        [DataMember(Name="exceptionDateTimes", EmitDefaultValue=false)]
        public string ExceptionDateTimes { get; set; }
        /// <summary>
        /// The event location; corresponds to the LOCATION property.
        /// </summary>
        /// <value>The event location; corresponds to the LOCATION property.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }
        /// <summary>
        /// The recurrence rule for the event; corresponds to the RRULE property.
        /// </summary>
        /// <value>The recurrence rule for the event; corresponds to the RRULE property.</value>
        [DataMember(Name="recurrenceRule", EmitDefaultValue=false)]
        public string RecurrenceRule { get; set; }
        /// <summary>
        /// The event title; corresponds to the SUMMARY property.
        /// </summary>
        /// <value>The event title; corresponds to the SUMMARY property.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// The event end date and time; corresponds to the DTEND property.
        /// </summary>
        /// <value>The event end date and time; corresponds to the DTEND property.</value>
        [DataMember(Name="endDateTime", EmitDefaultValue=false)]
        public string EndDateTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CalendarEventRecord {\n");
            sb.Append("  Editor: ").Append(Editor).Append("\n");
            sb.Append("  FavoriteFlag: ").Append(FavoriteFlag).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Userrecord: ").Append(Userrecord).Append("\n");
            sb.Append("  Timeupdated: ").Append(Timeupdated).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  ImportantFlag: ").Append(ImportantFlag).Append("\n");
            sb.Append("  Aclrecord: ").Append(Aclrecord).Append("\n");
            sb.Append("  Timecreated: ").Append(Timecreated).Append("\n");
            sb.Append("  HideFlag: ").Append(HideFlag).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
            sb.Append("  PinFlag: ").Append(PinFlag).Append("\n");
            sb.Append("  FollowFlag: ").Append(FollowFlag).Append("\n");
            sb.Append("  NaviKey: ").Append(NaviKey).Append("\n");
            sb.Append("  SyncToLocalFlag: ").Append(SyncToLocalFlag).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  PinTime: ").Append(PinTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Commentcount: ").Append(Commentcount).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  RecurrenceDateTimes: ").Append(RecurrenceDateTimes).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExceptionDateTimes: ").Append(ExceptionDateTimes).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  RecurrenceRule: ").Append(RecurrenceRule).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as CalendarEventRecord);
        }

        /// <summary>
        /// Returns true if CalendarEventRecord instances are equal
        /// </summary>
        /// <param name="other">Instance of CalendarEventRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalendarEventRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Editor == other.Editor ||
                    this.Editor != null &&
                    this.Editor.Equals(other.Editor)
                ) && 
                (
                    this.FavoriteFlag == other.FavoriteFlag ||
                    this.FavoriteFlag != null &&
                    this.FavoriteFlag.Equals(other.FavoriteFlag)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Userrecord == other.Userrecord ||
                    this.Userrecord != null &&
                    this.Userrecord.Equals(other.Userrecord)
                ) && 
                (
                    this.Timeupdated == other.Timeupdated ||
                    this.Timeupdated != null &&
                    this.Timeupdated.Equals(other.Timeupdated)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.Equals(other.Tags)
                ) && 
                (
                    this.ImportantFlag == other.ImportantFlag ||
                    this.ImportantFlag != null &&
                    this.ImportantFlag.Equals(other.ImportantFlag)
                ) && 
                (
                    this.Aclrecord == other.Aclrecord ||
                    this.Aclrecord != null &&
                    this.Aclrecord.Equals(other.Aclrecord)
                ) && 
                (
                    this.Timecreated == other.Timecreated ||
                    this.Timecreated != null &&
                    this.Timecreated.Equals(other.Timecreated)
                ) && 
                (
                    this.HideFlag == other.HideFlag ||
                    this.HideFlag != null &&
                    this.HideFlag.Equals(other.HideFlag)
                ) && 
                (
                    this.Subtype == other.Subtype ||
                    this.Subtype != null &&
                    this.Subtype.Equals(other.Subtype)
                ) && 
                (
                    this.PinFlag == other.PinFlag ||
                    this.PinFlag != null &&
                    this.PinFlag.Equals(other.PinFlag)
                ) && 
                (
                    this.FollowFlag == other.FollowFlag ||
                    this.FollowFlag != null &&
                    this.FollowFlag.Equals(other.FollowFlag)
                ) && 
                (
                    this.NaviKey == other.NaviKey ||
                    this.NaviKey != null &&
                    this.NaviKey.Equals(other.NaviKey)
                ) && 
                (
                    this.SyncToLocalFlag == other.SyncToLocalFlag ||
                    this.SyncToLocalFlag != null &&
                    this.SyncToLocalFlag.Equals(other.SyncToLocalFlag)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.PinTime == other.PinTime ||
                    this.PinTime != null &&
                    this.PinTime.Equals(other.PinTime)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Commentcount == other.Commentcount ||
                    this.Commentcount != null &&
                    this.Commentcount.Equals(other.Commentcount)
                ) && 
                (
                    this.Folders == other.Folders ||
                    this.Folders != null &&
                    this.Folders.SequenceEqual(other.Folders)
                ) && 
                (
                    this.StartDateTime == other.StartDateTime ||
                    this.StartDateTime != null &&
                    this.StartDateTime.Equals(other.StartDateTime)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.RecurrenceDateTimes == other.RecurrenceDateTimes ||
                    this.RecurrenceDateTimes != null &&
                    this.RecurrenceDateTimes.Equals(other.RecurrenceDateTimes)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.ExceptionDateTimes == other.ExceptionDateTimes ||
                    this.ExceptionDateTimes != null &&
                    this.ExceptionDateTimes.Equals(other.ExceptionDateTimes)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.RecurrenceRule == other.RecurrenceRule ||
                    this.RecurrenceRule != null &&
                    this.RecurrenceRule.Equals(other.RecurrenceRule)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.EndDateTime == other.EndDateTime ||
                    this.EndDateTime != null &&
                    this.EndDateTime.Equals(other.EndDateTime)
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
                if (this.Editor != null)
                    hash = hash * 59 + this.Editor.GetHashCode();
                if (this.FavoriteFlag != null)
                    hash = hash * 59 + this.FavoriteFlag.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Userrecord != null)
                    hash = hash * 59 + this.Userrecord.GetHashCode();
                if (this.Timeupdated != null)
                    hash = hash * 59 + this.Timeupdated.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.ImportantFlag != null)
                    hash = hash * 59 + this.ImportantFlag.GetHashCode();
                if (this.Aclrecord != null)
                    hash = hash * 59 + this.Aclrecord.GetHashCode();
                if (this.Timecreated != null)
                    hash = hash * 59 + this.Timecreated.GetHashCode();
                if (this.HideFlag != null)
                    hash = hash * 59 + this.HideFlag.GetHashCode();
                if (this.Subtype != null)
                    hash = hash * 59 + this.Subtype.GetHashCode();
                if (this.PinFlag != null)
                    hash = hash * 59 + this.PinFlag.GetHashCode();
                if (this.FollowFlag != null)
                    hash = hash * 59 + this.FollowFlag.GetHashCode();
                if (this.NaviKey != null)
                    hash = hash * 59 + this.NaviKey.GetHashCode();
                if (this.SyncToLocalFlag != null)
                    hash = hash * 59 + this.SyncToLocalFlag.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.PinTime != null)
                    hash = hash * 59 + this.PinTime.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Commentcount != null)
                    hash = hash * 59 + this.Commentcount.GetHashCode();
                if (this.Folders != null)
                    hash = hash * 59 + this.Folders.GetHashCode();
                if (this.StartDateTime != null)
                    hash = hash * 59 + this.StartDateTime.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.RecurrenceDateTimes != null)
                    hash = hash * 59 + this.RecurrenceDateTimes.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.ExceptionDateTimes != null)
                    hash = hash * 59 + this.ExceptionDateTimes.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.RecurrenceRule != null)
                    hash = hash * 59 + this.RecurrenceRule.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.EndDateTime != null)
                    hash = hash * 59 + this.EndDateTime.GetHashCode();
                return hash;
            }
        }
    }

}
