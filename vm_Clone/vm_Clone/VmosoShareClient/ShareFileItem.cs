using System;
using System.IO;
using VmosoApiClient.Model;

namespace VmosoShareClient
{
    public class ShareFileItem : ShareItem
    {
        public FileInfo FileInfo { get; set; }

        public FileRecord Record { get; set;}

        public ShareFileItem(String Title, String Description)
            : base(Title,Description)
        {
        }

    }
}
