using System;
using System.Text;

namespace VmosoStreamClient
{
    public class StreamItem
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public String Type { get; set; }
        public String SubType { get; set; }
        public String RecordType { get; set; }
        public String Link { get; set; }
        public String FileType { get; set; }
        public String LastUpdater { get; set; }
        public String LastUpdaterFirstName { get; set; }
        public String LastUpdaterLastName { get; set; }
        public String LastUpdaterIconKey { get; set; }
        public DateTime TimeUpdated { get; set; }
        public String Version { get; set; }
        public int UnreadCount { get; set; }
        public String SpacePath { get; set; }
        public String LastActionContent { get; set; }
        public String CommentListKey { get; set; }
        public object Record { get; set; }
        public StreamItem()
        {
        }

    }
}
