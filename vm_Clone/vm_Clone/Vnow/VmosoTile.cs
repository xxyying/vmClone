using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Drawing.Imaging;
using VmosoBKW.Cache;
using VmosoApiClient.Client;

namespace VmosoBKW
{
  public class VmosoNotifierTile : NotifierUI
  {
    #region Components and Data Record
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Panel SummaryPane;
    private System.Windows.Forms.Panel PersonalPane;
    private System.Windows.Forms.Panel TypeIconPane;

    private System.Windows.Forms.PictureBox closeButton;

    private System.Windows.Forms.PictureBox icon;
    private System.Windows.Forms.PictureBox picture;
    private System.Windows.Forms.PictureBox typeIconPictureBox;
    private System.Windows.Forms.PictureBox unreadCountPircureBox;

    private System.Windows.Forms.Label space;
    private System.Windows.Forms.Label title;
    private System.Windows.Forms.Label userAction;

    private System.Drawing.Size summaryPaneBlank;
    private System.Drawing.Size personalPaneBlank;

    #endregion

    private readonly string iconLocation = Application.StartupPath + "\\Icons";
    private VmosoImageCache imageCache = new VmosoImageCache();
    private int xOffset = 3;
    private int topOffset = 0;
    protected VmosoSession Session { get; set; }

    private string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    public VmosoNotifierTile(Point startRenderPoint, VmosoTileDisplayRecord displayRecord, Size expectedSize, VmosoSession session)
      : base(startRenderPoint, displayRecord, expectedSize)
    {
      this.Session = session;
      InitializeVmosoTile();
    }

    public void InitializeVmosoTile()
    {
      InitializeVmosoComponents();
      InitializeSummaryPane();
      InitializePersonalPane();
      InitializeTypeIconPane();

      InitializeTypeIconPictureBox();

      int closeButtonRadius = this.TypeIconPane.Width > this.TypeIconPane.Height ? this.TypeIconPane.Height : this.TypeIconPane.Width;

      InitializeCloseButton(closeButtonRadius);
      InitializeUnreadCountPictureBox();
      InitializeIcon();
      InitializeSpace();
      InitializeTitle();
      InitializePicture();
      InitializeAction();
      FormSettings();
      InitializeControlsClickEvent();
      InitializeControlOnMouseHoverEvent();
    }

    private void InitializeVmosoComponents()
    {
      //Rectangle workingArea = System.Windows.Forms.Screen.GetWorkingArea(this);
      //expectedSize = new Size((int)(workingArea.Width * 0.14), (int)(workingArea.Height * 0.07));
      //expectedSize = ClientSize;

      this.SummaryPane = new System.Windows.Forms.Panel();
      this.PersonalPane = new System.Windows.Forms.Panel();
      this.TypeIconPane = new System.Windows.Forms.Panel();

      this.icon = new System.Windows.Forms.PictureBox();
      this.closeButton = new System.Windows.Forms.PictureBox();
      this.picture = new System.Windows.Forms.PictureBox();
      this.typeIconPictureBox = new System.Windows.Forms.PictureBox();
      this.space = new System.Windows.Forms.Label();
      this.title = new System.Windows.Forms.Label();
      this.userAction = new System.Windows.Forms.Label();
      this.unreadCountPircureBox = new System.Windows.Forms.PictureBox();
    }

    private void InitializeTypeIconPane()
    {
      System.Windows.Forms.Control[] typeIconPaneControls = new System.Windows.Forms.Control[] { this.typeIconPictureBox, this.closeButton };

      this.TypeIconPane.Controls.AddRange(typeIconPaneControls);
      this.TypeIconPane.Name = "TypeIconPane";
      this.TypeIconPane.Location = new Point(0, 0);
      this.TypeIconPane.Size = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.25));
    }

    private void InitializeSummaryPane()
    {
      System.Windows.Forms.Control[] summaryPaneControls = new System.Windows.Forms.Control[] { this.icon, this.space, this.title, this.unreadCountPircureBox };

      this.SummaryPane.Controls.AddRange(summaryPaneControls);
      this.SummaryPane.Name = "SummaryPane";
      this.SummaryPane.TabIndex = 0;
      this.SummaryPane.Location = new Point(0 + xOffset, (int)(this.expectedSize.Height * 0.25));
      this.SummaryPane.Size = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.375));
      this.SummaryPane.BackColor = Color.White;

      this.summaryPaneBlank = new Size((int)(this.SummaryPane.Width * 0.02), (int)(this.SummaryPane.Height * 0.02));

      summaryPaneBlank.Width = summaryPaneBlank.Width < 1 ? 1 : summaryPaneBlank.Width;
      summaryPaneBlank.Height = summaryPaneBlank.Height < 1 ? 1 : summaryPaneBlank.Height;

    }

    private void InitializePersonalPane()
    {
      System.Windows.Forms.Control[] personalPaneControls = new System.Windows.Forms.Control[] { this.picture, this.userAction };

      this.PersonalPane.Controls.AddRange(personalPaneControls);
      this.PersonalPane.Name = "PersonalPane";
      this.PersonalPane.TabIndex = 1;
      this.PersonalPane.Location = new Point(0 + xOffset, SummaryPane.Location.Y + SummaryPane.Height);
      this.PersonalPane.Size = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.375) - 3);

      this.personalPaneBlank = new Size((int)(this.PersonalPane.Width * 0.02), (int)(this.PersonalPane.Height * 0.02));

      personalPaneBlank.Width = personalPaneBlank.Width < 1 ? 1 : personalPaneBlank.Width;
      personalPaneBlank.Height = personalPaneBlank.Height < 1 ? 1 : personalPaneBlank.Height;
      this.PersonalPane.BackColor = Color.White;
    }

    private void InitializeCloseButton(int radius)
    {
      Image image = CreateCloseButton(radius);

      this.closeButton.Image = image;
      this.closeButton.Size = new Size((int)(radius * 0.58), (int)(radius * 0.58));
      this.closeButton.Location = new Point((int)(this.TypeIconPane.Width * 0.95 - closeButton.Width), (int)((TypeIconPane.Height - closeButton.Height) * 0.5));

      this.closeButton.SizeMode = PictureBoxSizeMode.Zoom;
      this.closeButton.Visible = false;

      this.closeButton.MouseClick += CloseButton_OnMouseClick;
    }

    private void InitializeTypeIconPictureBox()
    {
      int typeIconWidth = this.TypeIconPane.Width > this.TypeIconPane.Height ? this.TypeIconPane.Height : this.TypeIconPane.Width;

      this.typeIconPictureBox.Location = new Point((int)(this.TypeIconPane.Width * 0.5 - typeIconWidth * 0.5), 0);
      this.typeIconPictureBox.Size = new Size(typeIconWidth, typeIconWidth);
      this.typeIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

      try
      {
        switch (displayRecord.character)
        {
          case "engage":
            this.typeIconPictureBox.Image = Properties.GlobalResources.engage;
            this.TypeIconPane.BackColor = ColorTranslator.FromHtml("#ffba09");
            this.BackColor = ColorTranslator.FromHtml("#ffba09");
            break;
          case "connect":
            this.typeIconPictureBox.Image = Properties.GlobalResources.connect;
            this.TypeIconPane.BackColor = ColorTranslator.FromHtml("#27A9E1");
            this.BackColor = ColorTranslator.FromHtml("#27A9E1");
            break;
          case "organize":
            this.typeIconPictureBox.Image = Properties.GlobalResources.organize;
            this.TypeIconPane.BackColor = ColorTranslator.FromHtml("#659A41");
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

    private void InitializeUnreadCountPictureBox()
    {
      //this.unreadCountPircureBox.Location = new Point(summaryPaneBlank.Width, summaryPaneBlank.Height * 2);
      //this.unreadCountPircureBox.Size = new Size(summaryPaneBlank.Width * 3, summaryPaneBlank.Height * 25);

      this.unreadCountPircureBox.Location = new Point(0, summaryPaneBlank.Height * 2);
      this.unreadCountPircureBox.Size = new Size(summaryPaneBlank.Width * 4, summaryPaneBlank.Height * 25);
      this.unreadCountPircureBox.SizeMode = PictureBoxSizeMode.Zoom;

      if (displayRecord.unreadCount > 0)
      {
        this.unreadCountPircureBox.Visible = true;
        //this.unreadCountPircureBox.Image = CountIcon.GetImage(displayRecord.unreadCount.ToString(), this.unreadCountPircureBox.Size);
        this.unreadCountPircureBox.Image = CountIcon.CreateUnreadCountImage(displayRecord.unreadCount, this.unreadCountPircureBox.Size);
      }
      else
      {
        this.unreadCountPircureBox.Visible = false;
      }

    }

    private void InitializeIcon()
    {
      //this.icon.Location = new Point(summaryPaneBlank.Width * 4, summaryPaneBlank.Height * 2);
      //this.icon.Size = new Size(summaryPaneBlank.Width * 5, summaryPaneBlank.Height * 25);
      this.icon.Location = new Point(summaryPaneBlank.Width * 4, summaryPaneBlank.Height * 2);
      this.icon.Size = new Size(summaryPaneBlank.Width * 5, summaryPaneBlank.Height * 25);
      this.icon.SizeMode = PictureBoxSizeMode.Zoom;
      //string iconLocation = "../../../Icons";
      //string iconLocation = "Icons";

      if (!string.IsNullOrEmpty(displayRecord.type))
      {
        switch (displayRecord.type)
        {
          case "TaskRecord":
            if (!string.IsNullOrEmpty(displayRecord.taskType))
            {
              string taskType = displayRecord.taskType;

                if (taskType.Equals("chat"))
                    this.icon.Image = Properties.GlobalResources.task_chat;
                //this.icon.Image = Image.FromFile(Path.Combine(appData, "BroadVision/Icons/chat.png"));
                else if (taskType.Equals("email"))
                    //this.icon.Image = Image.FromFile(Path.Combine(appData, "BroadVision/Icons/email.png"));
                    this.icon.Image = Properties.GlobalResources.email;
                else
                    //this.icon.Image = Image.FromFile(Path.Combine(appData, "BroadVision/Icons/task.png"));
                    this.icon.Image = Properties.GlobalResources.task_action;
                }
            break;
          case "PostV2Record":
            //this.icon.Image = Image.FromFile(Path.Combine(appData, "BroadVision/Icons/post.png"));
            this.icon.Image = Properties.GlobalResources.postV2;
            break;
          case "FileRecord":
            //this.icon.Image = Image.FromFile(Path.Combine(appData, "BroadVision/Icons/file.png"));
            this.icon.Image = Properties.GlobalResources.file_document_doc;
            break;
          case "NoteV2Record":
                        //this.icon.Image = Image.FromFile(Path.Combine(appData, "BroadVision/Icons/note.png"));
                        this.icon.Image = Properties.GlobalResources.document_action;
                        break;
          case "FolderRecord":
            this.icon.Image = Properties.GlobalResources.document_action;
            break;
          case "LinkV2Record":
                        this.icon.Image = Properties.GlobalResources.link;
                        break;
          case "UserObjectRecord":
                        this.icon.Image = Properties.GlobalResources.link;
                        //this.icon.Image = Image.FromFile(iconLocation + "/connect.png");
            break;
          default:
            break;
        }
      }
    }

    private void InitializeSpace()
    {
      this.space.Location = new Point(this.icon.Location.X + this.icon.Width + summaryPaneBlank.Width, this.icon.Location.Y);
      this.space.Size = new Size(this.SummaryPane.Width - summaryPaneBlank.Width * 11, summaryPaneBlank.Height * 10);
      this.space.Text = displayRecord.space;
      this.space.ForeColor = Color.DimGray;
      MeasureVmosoTextHeight(this.space);
    }

    private void InitializeTitle()
    {
      this.title.Location = new Point(this.space.Location.X, this.space.Location.Y + this.space.Height + summaryPaneBlank.Height * 2);
      this.title.Size = new Size(this.SummaryPane.Width - summaryPaneBlank.Width * 11, this.SummaryPane.Height - this.space.Height - summaryPaneBlank.Height * 6);
      this.title.Text = displayRecord.title;

      MeasureVmosoTextHeight(this.title);
    }

    private void InitializePicture()
    {
      
      this.picture.Location = new Point(this.personalPaneBlank.Width, this.personalPaneBlank.Height);
      this.picture.Size = new Size(personalPaneBlank.Width * 8, this.PersonalPane.Height - personalPaneBlank.Height * 4);
      this.picture.SizeMode = PictureBoxSizeMode.Zoom;
      string server = displayRecord.server;
      //this.picture.Image = Image.FromFile(iconLocation + "/Blank_36x36.png");

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
                Stream iconStream = VmosoFileUtils.downloadIcon(Session, displayRecord.iconSmall, Session.UserKey);
                if (iconStream != null)
                {
                    this.picture.Image = Image.FromStream(iconStream);
                }
            }
        }
      }

      this.picture.Region = RoundPictureBox(this.picture);
    }

    private void InitializeAction()
    {

      this.userAction.Location = new Point(this.picture.Location.X + this.picture.Width + personalPaneBlank.Width, this.picture.Location.Y);
      this.userAction.Size = new Size(this.PersonalPane.Width - personalPaneBlank.Width * 11, this.picture.Height);
      this.userAction.AutoSize = false;
      this.userAction.AutoEllipsis = true;
      this.userAction.Font = new Font(userAction.Font.FontFamily, 8.25f, userAction.Font.Style);

      string lastUpdater = displayRecord.actor;
      string time = displayRecord.time;
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
        //this.userAction.Text = lastUpdater + " ";

        if (!string.IsNullOrEmpty(commentId))
        {
          this.userAction.Text += "#" + commentId + " " + text;
        }
        else
        {
          this.userAction.Text += "[" + text + "]";
        }
      }
      //this.userAction.BackColor = Color.LightBlue;
      //MeasureVmosoTextHeight(this.userAction);

    }

    private void FormSettings()
    {
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.TypeIconPane);
      this.Controls.Add(this.SummaryPane);
      this.Controls.Add(this.PersonalPane);
      this.Name = "VmosoTile";
      this.Text = "VmosoTile";
      this.SummaryPane.ResumeLayout(false);
      this.SummaryPane.PerformLayout();
      this.PersonalPane.ResumeLayout(false);
      this.PersonalPane.PerformLayout();
      this.ResumeLayout(false);
    }

    private void MeasureVmosoTextHeight(Label label)
    {
      while (label.Height < System.Windows.Forms.TextRenderer.MeasureText(label.Text,
     new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Height)
      {

        label.Font = new Font(label.Font.FontFamily, label.Font.Size - 0.1f, label.Font.Style);
      }
    }

    private Image FetchPictureFromWeb(string url)
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

    private Region RoundPictureBox(PictureBox pb)
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

    private Image CreateCloseButton(int radius)
    {
      Bitmap bitmap = new Bitmap(radius, radius);
      Graphics graphics = Graphics.FromImage(bitmap);
      SolidBrush drawEllipseBrush = new SolidBrush(Color.White);

      Point point = new Point(0, 0);

      Rectangle boundRectangle = new Rectangle(point, new Size(radius, radius));
      graphics.FillEllipse(drawEllipseBrush, boundRectangle);

      Pen pen = new Pen(this.TypeIconPane.BackColor, 2);

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

    private void InitializeControlsClickEvent()
    {
      foreach (System.Windows.Forms.Control control in this.SummaryPane.Controls)
      {
        control.Click += new EventHandler(Control_OnClick);
      }

      foreach (System.Windows.Forms.Control control in this.PersonalPane.Controls)
      {
        control.Click += new EventHandler(Control_OnClick);
      }

      this.SummaryPane.Click += new EventHandler(Control_OnClick);
      this.PersonalPane.Click += new EventHandler(Control_OnClick);
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

    protected void Control_OnMouseLeave(object sender, EventArgs e)
    {
      if (isStayInForm())
      {
        this.closeButton.Visible = false;
      }
    }

    protected void Control_OnMouseEnter(object sender, EventArgs e)
    {
      this.closeButton.Visible = true;
    }

    protected void CloseButton_OnMouseClick(object sender, MouseEventArgs e)
    {
      this.Dispose();
    }

    protected bool isStayInForm()
    {
      return Cursor.Position.X < this.Location.X || Cursor.Position.Y <= this.Location.Y || Cursor.Position.X > this.Location.X + this.Width || Cursor.Position.Y >= this.Location.Y + this.Height || Cursor.Position.Y >= Screen.GetWorkingArea(this).Location.Y + Screen.GetWorkingArea(this).Height;
    }

    protected override bool ShowWithoutActivation
    {
      get { return true; }
    }

    protected override CreateParams CreateParams
    {
      get
      {
        int WS_EX_TOPMOST = 0x00000008;
        CreateParams cp = base.CreateParams;
        cp.ExStyle |= WS_EX_TOPMOST;
        return cp;
      }
    }

    public void InitializeControlOnMouseHoverEvent()
    {
      foreach (Control control in TypeIconPane.Controls)
      {
        control.MouseEnter += Control_OnMouseEnter;
        control.MouseLeave += Control_OnMouseLeave;
      }

      foreach (Control control in SummaryPane.Controls)
      {
        control.MouseEnter += Control_OnMouseEnter;
        control.MouseLeave += Control_OnMouseLeave;
      }

      foreach (Control control in PersonalPane.Controls)
      {
        control.MouseEnter += Control_OnMouseEnter;
        control.MouseLeave += Control_OnMouseLeave;
      }

      this.MouseEnter += Control_OnMouseEnter;
      this.MouseLeave += Control_OnMouseLeave;

      this.TypeIconPane.MouseEnter += Control_OnMouseEnter;
      this.TypeIconPane.MouseLeave += Control_OnMouseLeave;


      this.SummaryPane.MouseEnter += Control_OnMouseEnter;
      this.SummaryPane.MouseLeave += Control_OnMouseLeave;

      this.PersonalPane.MouseEnter += Control_OnMouseEnter;
      this.PersonalPane.MouseLeave += Control_OnMouseLeave;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

  }
}
