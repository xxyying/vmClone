using System;
using System.Drawing;
using System.Windows.Forms;

namespace vm_Clone.VmosoPanes
{
  public class MostRecentControlPane : Panel
  {
    private System.Windows.Forms.Label clearAllLabel;
    private System.Windows.Forms.Label viewMoreLabel;

    private Size expectedSize;

    public MostRecentControlPane(Size expectedSize)
    {
      this.expectedSize = expectedSize;
      
      Initialize();
    }

    protected void Initialize()
    {
      //this.clearAllLabel = new System.Windows.Forms.Label();
      this.viewMoreLabel = new System.Windows.Forms.Label();
      
      InitializeMostRecentControlPane();
      InitializeViewMoreLabel();
      //InitializeClearAllLabel();
    }

    public MostRecentControlPane Render()
    {
      return this;
    }

    protected void InitializeMostRecentControlPane()
    {
      this.Size = this.expectedSize;
      this.Name = "MostRecentControlPane";
      this.BackColor = Color.Transparent;
      //this.Controls.AddRange(new Control[] { this.clearAllLabel, this.viewMoreLabel });
      this.Controls.AddRange(new Control[] { this.viewMoreLabel });
    }
    
    protected void InitializeViewMoreLabel()
    {
      this.viewMoreLabel.AutoSize = true;
      this.viewMoreLabel.Text = "More";
      
      this.viewMoreLabel.TabIndex = 1; 
      this.viewMoreLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.viewMoreLabel.Font = new Font(viewMoreLabel.Font, FontStyle.Bold);
      this.viewMoreLabel.ForeColor = Color.Gray;
      this.viewMoreLabel.BorderStyle = BorderStyle.None;
      this.viewMoreLabel.Name = "viewMoreLabel";
      this.viewMoreLabel.Location = new Point((int)(this.Width - this.Width * 0.05 - viewMoreLabel.Width), (int)((this.Height - viewMoreLabel.Height) / 2));
      this.viewMoreLabel.MouseEnter += ViewMoreLabel_OnMouseEnter;
      this.viewMoreLabel.MouseLeave += ViewMoreLabel_OnMouseLeave;
      this.viewMoreLabel.MouseClick += ViewMoreLabel_OnMouseClick;
    }
    
    protected void InitializeClearAllLabel()
    {
      this.clearAllLabel.AutoSize = true;
      this.clearAllLabel.TabIndex = 0;
      
      this.clearAllLabel.TextAlign = ContentAlignment.MiddleCenter;
      this.clearAllLabel.Font = new Font(clearAllLabel.Font, FontStyle.Bold);
      this.clearAllLabel.ForeColor = Color.Gray;
      this.clearAllLabel.BorderStyle = BorderStyle.None;
      this.clearAllLabel.Name = "clearAllLabel";
      this.clearAllLabel.Text = "Clear All";
      this.clearAllLabel.Location = new Point((int)(viewMoreLabel.Location.X - this.Width * 0.05 - clearAllLabel.Width), (int)((this.Height - clearAllLabel.Height) / 2));
      this.clearAllLabel.MouseEnter += ClearAllLabel_OnMouseEnter;
      this.clearAllLabel.MouseLeave += ClearAllLabel_OnMouseLeave;
      this.clearAllLabel.MouseClick += ClearAllLabel_OnMouseClick;
    }

    #region Events Handler Methods of controls
    protected void ViewMoreLabel_OnMouseEnter(object sender, EventArgs e)
    {
      this.viewMoreLabel.ForeColor = Color.Black;
    }

    protected void ViewMoreLabel_OnMouseLeave(object sender, EventArgs e)
    {
      this.viewMoreLabel.ForeColor = Color.Gray;
    }

    protected void ViewMoreLabel_OnMouseClick(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.vmoso.com/myplace");
    }

    protected void ClearAllLabel_OnMouseEnter(object sender, EventArgs e)
    {
      this.clearAllLabel.ForeColor = Color.Black;
    }

    protected void ClearAllLabel_OnMouseLeave(object sedner, EventArgs e)
    {
      this.clearAllLabel.ForeColor = Color.Gray;
    }

    protected void ClearAllLabel_OnMouseClick(object sender, EventArgs e)
    {
      Control control = this.clearAllLabel;

      while (control.Parent != null)
      {
        control = control.Parent;
      }

      control.Dispose();
    }
    #endregion
  }
}
