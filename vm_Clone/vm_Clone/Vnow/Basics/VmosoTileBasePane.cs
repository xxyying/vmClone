using System;
using System.Windows.Forms;
using System.Drawing;
using VmosoApiClient.Client;


namespace vm_Clone.Basics
{
  public class VmosoTileBasePane : Panel
  {
    protected Size expectedSize;
    protected VmosoTileDisplayRecord displayRecord;
    protected int xOffset;

    public VmosoTileBasePane(Size expectedSize, VmosoTileDisplayRecord displayRecord)
    {
      this.expectedSize = expectedSize;
      this.displayRecord = displayRecord;
      this.xOffset = 3;
    }

    protected void MeasureVmosoTextHeight(Label label)
    {
      while (label.Height < System.Windows.Forms.TextRenderer.MeasureText(label.Text,
     new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Height)
      {
        label.Font = new Font(label.Font.FontFamily, label.Font.Size - 0.1f, label.Font.Style);
      }
    }

        protected Image FetchPictureFromWeb(string url)
        {
            try
            {
                System.Net.HttpWebRequest httpWebRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
                System.Net.HttpWebResponse httpWebReponse = (System.Net.HttpWebResponse)httpWebRequest.GetResponse();
                System.IO.Stream stream = httpWebReponse.GetResponseStream();

                return Image.FromStream(stream);
            }
            catch (Exception)
            {
                return Properties.GlobalResources.vmoso_login;
            }
        }

    protected Region RoundPictureBox(PictureBox pb)
    {
      System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
      Rectangle bound = pb.DisplayRectangle;

      if (bound.Width > bound.Height)
        bound.Width = bound.Height;
      else if (bound.Width < bound.Height)
        bound.Height = bound.Width;

      graphicsPath.AddEllipse(bound);

      return new Region(graphicsPath);
    }

    protected bool IsOutsideOfPane()
    {
      return Cursor.Position.X < this.Location.X || Cursor.Position.Y < this.Location.Y || Cursor.Position.X > this.Location.X + this.Width || Cursor.Position.Y > this.Location.Y + this.Height || Cursor.Position.Y >= Screen.GetWorkingArea(this).Location.Y + Screen.GetWorkingArea(this).Height;
    }
  }
}
