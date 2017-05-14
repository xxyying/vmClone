using System;
using VmosoApiClient.Model;
using System.Collections.Generic;
using System.Drawing;

namespace VmosoShareClient
{
    public class ShareLinkItem : ShareItem
    {
        public Uri Link { get; set; }

        public LinkV2Record Record { get; set;}

        public ShareLinkItem(String Title, String Description)
            : base(Title,Description)
        {
        }

    }
}
