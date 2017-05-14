using System;
using System.Text;
using VmosoApiClient.Model;

namespace VmosoStreamClient
{
    public class StreamComment
    {
        public String ContentKey { get; set; }
        public String ContentRecordType { get; set; }
        public String Text { get; set; }
        public int CommentId { get; set; }
        public int CommentCId { get; set; }
        public int CommentPId { get; set; }
        public String CommentListKey { get; set; }
        public int SubCommentCount { get; set; }
        public String Owner { get; set; }
        public String OwnerCapitals { get; set; }
        public String OwnerKey { get; set; }
        public String OwnerIconKey { get; set; }
        public DateTime TimeUpdated { get; set; }
        public CommentV2Record Record { get; set; }
        public StreamComment()
        {
        }

        public StreamComment(CommentV2Record commentRecord, String parentRecordType)
        {
            this.Record = commentRecord;
            this.ContentRecordType = parentRecordType;
            this.ContentKey = commentRecord.ContentKey;
            this.CommentId = (int)commentRecord.CommentID;
            this.CommentCId = (int)commentRecord.CommentCID;
            this.CommentPId = (int)commentRecord.CommentPID;
            this.CommentListKey = commentRecord.CommentListKey;
            if (commentRecord.SubCommentCount != null)
            {
                this.SubCommentCount = (int)commentRecord.SubCommentCount;
            }
            this.Text = commentRecord.Text;
            this.Owner = commentRecord.Creator.DisplayName;
            String capitals = "";
            string[] words = this.Owner.Split(' ');
            int count = 0;
            foreach (string word in words)
            {
                capitals += word.Substring(0, 1);
                count++;
                if (count == 2) break;
            }
            this.OwnerCapitals = capitals;
            this.OwnerKey = commentRecord.Creator.Key;
            this.OwnerIconKey = commentRecord.Creator.IconSmall;
            Double timeUpdated = Convert.ToDouble(commentRecord.Timeupdated);
            this.TimeUpdated = UnixTimeStampToDateTime(timeUpdated);

        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }


    }

}

