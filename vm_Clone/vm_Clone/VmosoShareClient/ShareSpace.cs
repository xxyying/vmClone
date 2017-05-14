using System;
using VmosoApiClient.Model;

namespace VmosoShareClient
{
    public class ShareSpace
    {
        public String Key { get; set; }
        public String Name { get; set; }
        public SpaceV2Record Record { get; set;}

        public ShareSpace(String Key, String Name, SpaceV2Record Record)
        {
            this.Key = Key;
            this.Name = Name;
            this.Record = Record;

        }


    }
}
