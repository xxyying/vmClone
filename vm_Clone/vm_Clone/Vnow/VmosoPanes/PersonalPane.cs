using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using VmosoBKW.Cache;
using VmosoApiClient.Client;

namespace VmosoBKW.VmosoPanes
{
  public class PersonalPane : Basics.VmosoTileBasePane
  {
    private System.Windows.Forms.PictureBox picture;
    private System.Windows.Forms.Label userAction;

    private System.Drawing.Size personalPaneBlank;

    private VmosoImageCache imageCache;
        private VmosoSession Session;

    public PersonalPane(Size expectedSize, VmosoTileDisplayRecord displayRecord, VmosoSession session)
      : base(expectedSize, displayRecord)
    {
      this.Session = session;
      Initialize();
    }

    public void Initialize()
    {
      this.picture = new PictureBox();
      this.userAction = new Label();
      this.imageCache = new VmosoImageCache();

      InitializePersonalPane();
      InitializePicture();
      InitializeAction();
      InitializeControlsClickEvent();
    }

    public PersonalPane Render()
    {
      RenderPicture();
      RenderAction();

      return this;
    }

    private void InitializePersonalPane()
    {
      System.Windows.Forms.Control[] personalPaneControls = new System.Windows.Forms.Control[] { this.picture, this.userAction };

      this.Controls.AddRange(personalPaneControls);
      this.Name = "PersonalPane";
      this.TabIndex = 1;
      this.Size = this.expectedSize;

      this.personalPaneBlank = new Size((int)(this.Width * 0.02), (int)(this.Height * 0.02));

      this.personalPaneBlank.Width = personalPaneBlank.Width < 1 ? 1 : personalPaneBlank.Width;
      this.personalPaneBlank.Height = personalPaneBlank.Height < 1 ? 1 : personalPaneBlank.Height;
      this.BackColor = Color.White;
    }

    private void InitializePicture()
    {
      this.picture.Location = new Point(this.personalPaneBlank.Width, this.personalPaneBlank.Height);
      this.picture.Size = new Size(personalPaneBlank.Width * 8, this.Height - personalPaneBlank.Height * 4);
      this.picture.SizeMode = PictureBoxSizeMode.Zoom;

    }

    private void InitializeAction()
    {
      this.userAction.Location = new Point(this.picture.Location.X + this.picture.Width + personalPaneBlank.Width, this.picture.Location.Y);
      this.userAction.Size = new Size(this.Width - personalPaneBlank.Width * 11, this.picture.Height);
      this.userAction.AutoSize = false;
      this.userAction.AutoEllipsis = true;
      this.userAction.Font = new Font(userAction.Font.FontFamily, 8.25f, userAction.Font.Style);
    }

    private void RenderPicture()
    {
      string server = displayRecord.server;
      this.picture.Image = Properties.GlobalResources.blank;
      
      if (!string.IsNullOrEmpty(displayRecord.iconSmall))
      {
        if (!displayRecord.isRegistered && displayRecord.character.Equals("engage"))
        {
          this.picture.Image = FetchPictureFromWeb(server + "/resource/vmoso/default/images/avatar/" + displayRecord.iconSmall + ".png");
        }
        else
        {
          //object userImage = imageCache.GetObject(displayRecord.iconSmall + ".png");
            object userImage = null;
          if (userImage != null)
          {
            this.picture.Image = (Image)userImage;
          }
          else
          {
            userImage = GetUserIcon(displayRecord.iconSmall);
            if (userImage != null)
            {
                //imageCache.SaveObject(userImage, displayRecord.iconSmall + ".png");
                this.picture.Image = GetUserIcon(displayRecord.iconSmall);
            }
          }
        }
      }

      this.picture.Region = RoundPictureBox(this.picture);
    }

    private void RenderAction()
    {
      string lastUpdater = displayRecord.actor;
      string time = VmosoTimeHelper.ConvertTime(displayRecord.timestamp);
      string commentId = displayRecord.commentID;
      string text = displayRecord.text;
      bool isLoginNotif = displayRecord.isLoginNotif;

      if (isLoginNotif)
      {
        if (!string.IsNullOrEmpty(displayRecord.loginStatus) && displayRecord.loginStatus.Equals("Online"))
          this.userAction.Text = lastUpdater + " is Online";
        else if (!string.IsNullOrEmpty(displayRecord.loginStatus) && displayRecord.loginStatus.Equals("Offline"))
          this.userAction.Text = lastUpdater + " is Offline";
      }
      else
      {
        this.userAction.Text = lastUpdater + " (" + time + ") ";

        if (!string.IsNullOrEmpty(commentId))
        {
          this.userAction.Text += "#" + commentId + " " + text;
        }
        else
        {
          this.userAction.Text += "[" + text + "]";
        }
      }
    }

    protected void InitializeControlsClickEvent()
    {
      foreach (Control control in this.Controls)
      {
        control.Click += new EventHandler(Control_OnClick);
      }

      this.Click += new EventHandler(Control_OnClick);
    }

    protected void Control_OnClick(object sender, EventArgs e)
    {
      try
      {
        System.Diagnostics.Process.Start(displayRecord.url);
      }
      catch (Exception)
      {

        return;
      }
    }

    protected byte[] ImageToByteArray(Image image)
    {
      MemoryStream mStream = new MemoryStream();
      image.Save(mStream, ImageFormat.Png);
      return mStream.ToArray();
    }

    protected Image ByteArrayToImage(byte[] imageBytes)
    {
      MemoryStream mStream = new MemoryStream();
      Image image = Image.FromStream(mStream);
      return image;
    }

    protected Image GetUserIcon(String iconKey)
    {
        try
        {
            return Image.FromStream(VmosoFileUtils.downloadIcon(Session, iconKey, Session.UserKey));
        }
        catch (Exception)
        {
            return Properties.GlobalResources.vmoso_login;
        }
    }

    }
}
