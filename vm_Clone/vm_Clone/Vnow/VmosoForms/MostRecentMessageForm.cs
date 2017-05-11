using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace vm_Clone.VmosoForms
{
  public class MostRecentMessageForm : Form
  {
    const string SUMMARYPANENAME = "SummaryPane";
    const string PERSONALPANENAME = "PersonalPane";

    private Size expectedSize;
    private Point startPoint;
    private Stack<Panel> panels;
    private Panel controlPanel;
    private Control closeButton;

    public MostRecentMessageForm(Size expectedSize, Point startPoint)
    {
      this.expectedSize = expectedSize;
      this.startPoint = startPoint;
      this.panels = new Stack<Panel>();

      InitializeMostRecentMessageForm();
    }

    protected void InitializeMostRecentMessageForm()
    {
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.Manual;
      this.MinimumSize = new Size(1, 1);
      this.Size = this.expectedSize;
      this.Name = "MostRecentMessageForm";
      this.BackColor = ColorTranslator.FromHtml("#ffba09");
    }

    public void AddTile(Panel panel)
    {
      this.panels.Push(panel);
    }

    public void AddMessageControl(Panel panel)
    {
      this.controlPanel = panel;
    }

    public MostRecentMessageForm Render()
    {
      if (controlPanel == null)
        return this;

      int xOffset = 3;
      int blankBtwPanes_Y = 1;
      int blankToControl = 0;
      int yblanks = 0;

      while (panels.Count > 0)
      {
        Panel panel = panels.Pop();
        startPoint.Y -= panel.Height;
        this.Controls.Add(panel);
        panel.Location = new Point(0 + xOffset, this.Height);
        this.Height += panel.Height;

        if (panel.Name.Equals(PERSONALPANENAME))
        { 
          yblanks++;
          this.Height += blankBtwPanes_Y;
        }
      }

      startPoint.Y -= controlPanel.Height + blankToControl * 2 + yblanks * blankBtwPanes_Y;
      this.Controls.Add(controlPanel);
      controlPanel.Location = new Point(0 + xOffset, this.Height + blankToControl);
      this.Height += controlPanel.Height + blankToControl * 2;
      this.Location = startPoint;

      EnableCloseButton();

      return this;
    }

    protected bool IsOutsideOfForm()
    {
      return Cursor.Position.X < this.Location.X || Cursor.Position.Y < this.Location.Y || Cursor.Position.X > this.Location.X + this.Width || Cursor.Position.Y > this.Location.Y + this.Height || Cursor.Position.Y >= Screen.GetWorkingArea(this).Location.Y + Screen.GetWorkingArea(this).Height;
    }

    protected void GetAllSubControls(Control control, ref List<Control> controls)
    {
      controls.Add(control);

      foreach (Control ctrl in control.Controls)
      {
        GetAllSubControls(ctrl, ref controls);
      }
    }

    public void EnableCloseButton()
    {
      List<Control> controls = new List<Control>();

      GetAllSubControls(this, ref controls);

      this.closeButton = new Control();

      foreach (Control ctrl in controls)
      {
        if (!string.IsNullOrEmpty(ctrl.Name) && ctrl.Name.Equals("CloseButton"))
        {
          this.closeButton = ctrl;
          break;
        }
      }

      foreach (Control ctrl in controls)
      {
        ctrl.MouseEnter += Control_MouseEnter;
        ctrl.MouseLeave += Control_MouseLeave;
      }
    }

    protected override bool ShowWithoutActivation
    {
      get { return true; }
    }

    private void Control_MouseEnter(object sender, EventArgs e)
    {
      this.closeButton.Visible = true;
    }

    private void Control_MouseLeave(object sender, EventArgs e)
    {
      if (IsOutsideOfForm())
        this.closeButton.Visible = false;
    }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MostRecentMessageForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MostRecentMessageForm";
            this.Load += new System.EventHandler(this.MostRecentMessageForm_Load);
            this.ResumeLayout(false);

        }

        private void MostRecentMessageForm_Load(object sender, EventArgs e)
        {

        }
    }

}
