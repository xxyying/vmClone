using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using vm_Clone.Basics;
using VmosoApiClient.Client;

namespace vm_Clone.VmosoPanes
{
  public class TypeIconPane : VmosoTileBasePane
  {

    private PictureBox typeIconPictureBox;
    private PictureBox closeButton;

    public TypeIconPane(Size expectedSize, VmosoTileDisplayRecord displayRecord, bool enableCloseButton)
      : base(expectedSize, displayRecord)
    {
      Initialize(enableCloseButton);
    }

    public void Initialize(bool useCloseButton)
    {
      this.typeIconPictureBox = new PictureBox();
      this.closeButton = new PictureBox();

      InitializeTypeIconPane(useCloseButton);
      InitializePictureBox();

      if (useCloseButton)
        InitializeCloseButton();
    }

    private void InitializeTypeIconPane(bool useCloseButton)
    {
      Control[] controls = useCloseButton ? new System.Windows.Forms.Control[] { this.typeIconPictureBox, this.closeButton } : new System.Windows.Forms.Control[] { this.typeIconPictureBox };
      System.Windows.Forms.Control[] typeIconPaneControls = controls;

      this.Controls.AddRange(typeIconPaneControls);
      this.Name = "TypeIconPane";
      this.Location = new Point(0, 0);
      this.Size = this.expectedSize;
    }

    private void InitializePictureBox()
    {
      int typeIconWidth = this.Width > this.Height ? this.Height : this.Width;

      this.typeIconPictureBox.Location = new Point((int)(this.Width * 0.5 - typeIconWidth * 0.5), 0);
      this.typeIconPictureBox.Size = new Size(typeIconWidth, typeIconWidth);
      this.typeIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void InitializeCloseButton()
    {
      int radius = this.Width > this.Height ? this.Height : this.Width;
      this.closeButton.Name = "CloseButton";
      this.closeButton.Size = new Size((int)(radius * 0.58), (int)(radius * 0.58));
      this.closeButton.Location = new Point((int)(this.Width * 0.95 - closeButton.Width), (int)((this.Height - closeButton.Height) * 0.5));

      this.closeButton.SizeMode = PictureBoxSizeMode.Zoom;
      this.closeButton.Visible = false;

      this.closeButton.MouseClick += CloseButton_OnMouseClick;
    }

    public TypeIconPane Render()
    {
      RenderPictureBox();
      RenderCloseButton();

      return this;
    }

    private void RenderPictureBox()
    {
      try
      {
        switch (displayRecord.character)
        {
          case "engage":
            this.typeIconPictureBox.Image = Properties.GlobalResources.engage;
            this.BackColor = ColorTranslator.FromHtml("#ffba09");
            break;
          case "connect":
            this.typeIconPictureBox.Image = Properties.GlobalResources.connect;
            this.BackColor = ColorTranslator.FromHtml("#27A9E1");

            break;
          case "organize":
            this.typeIconPictureBox.Image = Properties.GlobalResources.organize;
            this.BackColor = ColorTranslator.FromHtml("#659A41");

            break;
          default:
            break;
        }
      }
      catch (Exception)
      {
        return;
      }
    }

    protected void RenderCloseButton()
    {
      int radius = this.Width > this.Height ? this.Height : this.Width;

      Image image = CreateCloseButton(radius);
      this.closeButton.Image = image;
    }

    private Image CreateCloseButton(int radius)
    {
      Bitmap bitmap = new Bitmap(radius, radius);
      Graphics graphics = Graphics.FromImage(bitmap);
      SolidBrush drawEllipseBrush = new SolidBrush(Color.White);

      Point point = new Point(0, 0);

      Rectangle boundRectangle = new Rectangle(point, new Size(radius, radius));
      graphics.FillEllipse(drawEllipseBrush, boundRectangle);

      Pen pen = new Pen(this.BackColor, 2); 

      Point startPoint = new Point((int)(boundRectangle.Location.X + boundRectangle.Width * 0.25), (int)(boundRectangle.Location.Y + boundRectangle.Height * 0.25));
      Point endPoint = new Point((int)(boundRectangle.Location.X + boundRectangle.Width * 0.75), (int)(boundRectangle.Location.Y + boundRectangle.Height * 0.75));
      graphics.DrawLine(pen, startPoint, endPoint);

      startPoint = new Point((int)(boundRectangle.Location.X + boundRectangle.Width * 0.25), (int)(boundRectangle.Location.Y + boundRectangle.Height * 0.75));
      endPoint = new Point((int)(boundRectangle.Location.X + boundRectangle.Width * 0.75), (int)(boundRectangle.Location.Y + boundRectangle.Height * 0.25));
      graphics.DrawLine(pen, startPoint, endPoint);

      MemoryStream mStream = new MemoryStream();
      bitmap.Save(mStream, ImageFormat.Png);

      Image image = Image.FromStream(mStream);

      bitmap.Dispose();
      graphics.Dispose();
      drawEllipseBrush.Dispose();

      return image;
    }

    protected void CloseButton_OnMouseClick(object sender, MouseEventArgs e)
    {
      Control control = this.closeButton;

      while (control.Parent != null)
      {
        control = control.Parent;
      }

      control.Dispose();
    }
  }
}
