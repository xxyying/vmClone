using System;
using System.Windows.Forms;
using System.Drawing;
using VmosoBKW.Basics;
using VmosoApiClient.Client;

namespace VmosoBKW.VmosoPanes
{
  public class SummaryPane : VmosoTileBasePane
  {
    private PictureBox icon;
    private Label space;
    private Label title;
    private PictureBox unreadCountPircureBox;

    private Size summaryPaneBlank;

    public SummaryPane(Size expectedSize, VmosoTileDisplayRecord displayRecord)
      : base(expectedSize, displayRecord)
    {
      Initialize();
    }

    private void Initialize()
    {
      this.icon = new System.Windows.Forms.PictureBox();
      this.space = new System.Windows.Forms.Label();
      this.title = new System.Windows.Forms.Label();
      this.unreadCountPircureBox = new System.Windows.Forms.PictureBox();
      
      InitializeSummaryPane(); 
      InitializeUnreadCountPictureBox(); 
      InitializeIcon();
      InitializeSpace();
      InitializeTitle();
      InitializeControlsClickEvent();
    }

    public SummaryPane Render()
    {
      RenderUnreadCountPictureBox();
      RenderIcon();

      return this;
    }

    private void InitializeSummaryPane()
    {
      System.Windows.Forms.Control[] summaryPaneControls = new System.Windows.Forms.Control[] { this.icon, this.space, this.title, this.unreadCountPircureBox };

      this.Controls.AddRange(summaryPaneControls);
      this.Name = "SummaryPane";
      this.TabIndex = 0;

      this.Size = this.expectedSize;
      this.BackColor = Color.White;
      //this.BackColor = ColorTranslator.FromHtml("#1CA9C9");
      this.summaryPaneBlank = new Size((int)(this.Width * 0.02), (int)(this.Height * 0.02));

      summaryPaneBlank.Width = summaryPaneBlank.Width < 1 ? 1 : summaryPaneBlank.Width;
      summaryPaneBlank.Height = summaryPaneBlank.Height < 1 ? 1 : summaryPaneBlank.Height;
    }

    private void InitializeUnreadCountPictureBox()
    {
      this.unreadCountPircureBox.Location = new Point(0, summaryPaneBlank.Height * 2);
      this.unreadCountPircureBox.Size = new Size(summaryPaneBlank.Width * 4, summaryPaneBlank.Height * 25);
      this.unreadCountPircureBox.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void InitializeIcon()
    {
      this.icon.Location = new Point(summaryPaneBlank.Width * 4, summaryPaneBlank.Height * 2);
      this.icon.Size = new Size(summaryPaneBlank.Width * 5, summaryPaneBlank.Height * 25);
      this.icon.SizeMode = PictureBoxSizeMode.Zoom;
    }

    private void InitializeSpace()
    {
      this.space.Location = new Point(this.icon.Location.X + this.icon.Width + summaryPaneBlank.Width, this.icon.Location.Y);
      this.space.Size = new Size(this.Width - summaryPaneBlank.Width * 11, summaryPaneBlank.Height * 10);
      this.space.Text = displayRecord.space;
      this.space.ForeColor = Color.DimGray;
      MeasureVmosoTextHeight(this.space);
    }

    private void InitializeTitle()
    {
      this.title.Location = new Point(this.space.Location.X, this.space.Location.Y + this.space.Height + summaryPaneBlank.Height * 2);
      this.title.Size = new Size(this.Width - summaryPaneBlank.Width * 11, this.Height - this.space.Height - summaryPaneBlank.Height * 6);
      this.title.Text = displayRecord.title; 
      MeasureVmosoTextHeight(this.title);
    }

    private void RenderIcon()
    {
      if (!string.IsNullOrEmpty(displayRecord.type))
      {
        switch (displayRecord.type)
        {
          case "TaskRecord":
            if (!string.IsNullOrEmpty(displayRecord.taskType))
            {
              string taskType = displayRecord.taskType;

                if (taskType.Equals("chat"))
                    this.icon.Image = Properties.GlobalResources.chat;
              else if (taskType.Equals("email"))
                    this.icon.Image = Properties.GlobalResources.email;
              else
                    this.icon.Image = Properties.GlobalResources.task;
            }
            break;
          case "PostV2Record":
            this.icon.Image = Properties.GlobalResources.post;
            break;
          case "FileRecord":
            this.icon.Image = Properties.GlobalResources.file;
            break;
          case "NoteV2Record":
            this.icon.Image = Properties.GlobalResources.note;
            //this.icon.Image = Image.FromFile(iconLocation + "/note.png");
            break;
          case "FolderRecord":
            this.icon.Image = Properties.GlobalResources.organize;
            break;
          case "LinkV2Record":
            this.icon.Image = Properties.GlobalResources.bookmark;
            break;
          default:
            break;
        }
      }
    }

    private void RenderUnreadCountPictureBox()
    {
      if (displayRecord.unreadCount > 0)
      {
        this.unreadCountPircureBox.Visible = true;
        this.unreadCountPircureBox.Image = CountIcon.CreateUnreadCountImage(displayRecord.unreadCount, this.unreadCountPircureBox.Size);
      }
      else
      {
        this.unreadCountPircureBox.Visible = false;
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
  }
}
