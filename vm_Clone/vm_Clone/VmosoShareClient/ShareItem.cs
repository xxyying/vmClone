using System;
using VmosoApiClient.Model;
using System.Collections.Generic;
using System.Drawing;

namespace VmosoShareClient
{
    public class ShareItem
    {
        public String Key { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }

        private Bitmap Icon;
        public List<ShareSpace> Spaces { get; set; }

        public ShareItem()
        {
            Spaces = new List<ShareSpace>();
        }

        public ShareItem(String Title, String Description)
        {
            this.Title = Title;
            this.Description = Description;
            Spaces = new List<ShareSpace>();

        }

        public void SetIcon(Bitmap Icon)
        {
            this.Icon = Icon;
        }

        public Bitmap GetIcon()
        {
            return this.Icon;
        }

    }
}
