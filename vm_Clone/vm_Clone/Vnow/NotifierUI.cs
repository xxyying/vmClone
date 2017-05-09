using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VmosoBKW
{
  public  class NotifierUI : System.Windows.Forms.Form
  {
    protected int defaultBarWidth = 460;
    protected int defaultBarHeight = 70;
    protected int defaultAppearingTimerInterval = 10;
    protected int defaultDisappearingTimerInterval = 10;
    protected int appearingTime = 1000;
    protected int showTime = 10000;
    protected int disappearingTime = 1000;
    protected int moveDistance;
    protected int moveBarDist;
    protected int realBarWidth;
    protected int realBarHeight;
    protected int interval;
    protected Timer timer = new Timer();
    protected Timer moveTimer = new Timer();
    protected Rectangle workingArea;
    protected Point moveStartPoint;
    protected Point moveTo;
    protected Point nextAT;
    protected Point startRenderPoint;
    protected VmosoTileDisplayRecord displayRecord;
    protected Size expectedSize;

    public event EventHandler OnShownStatus;
    public event EventHandler OnHiddenStatus;
    public event EventHandler OnDisappearingStatus;

    int counter = 0;

    #region ShowWindowCommands
    protected enum ShowWindowCommands
    {
      /// <summary>
      /// Hides the window and activates another window.
      /// </summary>
      Hide = 0,
      /// <summary>
      /// Activates and displays a window. If the window is minimized or 
      /// maximized, the system restores it to its original size and position.
      /// An application should specify this flag when displaying the window 
      /// for the first time.
      /// </summary>
      Normal = 1,
      /// <summary>
      /// Activates the window and displays it as a minimized window.
      /// </summary>
      ShowMinimized = 2,
      /// <summary>
      /// Maximizes the specified window.
      /// </summary>
      Maximize = 3, // is this the right value?
      /// <summary>
      /// Activates the window and displays it as a maximized window.
      /// </summary>       
      ShowMaximized = 3,
      /// <summary>
      /// Displays a window in its most recent size and position. This value 
      /// is similar to <see cref="Win32.ShowWindowCommand.Normal"/>, except 
      /// the window is not activated.
      /// </summary>
      ShowNoActivate = 4,
      /// <summary>
      /// Activates the window and displays it in its current size and position. 
      /// </summary>
      Show = 5,
      /// <summary>
      /// Minimizes the specified window and activates the next top-level 
      /// window in the Z order.
      /// </summary>
      Minimize = 6,
      /// <summary>
      /// Displays the window as a minimized window. This value is similar to
      /// <see cref="Win32.ShowWindowCommand.ShowMinimized"/>, except the 
      /// window is not activated.
      /// </summary>
      ShowMinNoActive = 7,
      /// <summary>
      /// Displays the window in its current size and position. This value is 
      /// similar to <see cref="Win32.ShowWindowCommand.Show"/>, except the 
      /// window is not activated.
      /// </summary>
      ShowNA = 8,
      /// <summary>
      /// Activates and displays the window. If the window is minimized or 
      /// maximized, the system restores it to its original size and position. 
      /// An application should specify this flag when restoring a minimized window.
      /// </summary>
      Restore = 9,
      /// <summary>
      /// Sets the show state based on the SW_* value specified in the 
      /// STARTUPINFO structure passed to the CreateProcess function by the 
      /// program that started the application.
      /// </summary>
      ShowDefault = 10,
      /// <summary>
      ///  <b>Windows 2000/XP:</b> Minimizes a window, even if the thread 
      /// that owns the window is not responding. This flag should only be 
      /// used when minimizing windows from a different thread.
      /// </summary>
      ForceMinimize = 11
    }
    #endregion

    public NotifierBarStatus notifierBarStatus { get; set; }
    public bool renderFinished { get; set; }

    #region Constructors
    public NotifierUI(Point startRenderPoint, VmosoTileDisplayRecord displayRecord, Size expectedSize)
    {
      Rectangle workingArea = System.Windows.Forms.Screen.GetWorkingArea(this);

      if (expectedSize.Width > 0 && expectedSize.Height > 0)
      {
        this.expectedSize = expectedSize;
        this.ClientSize = expectedSize;
      }
      else
      {
        this.expectedSize = new Size((int)(workingArea.Width * 0.14), (int)(workingArea.Height * 0.07));
        this.ClientSize = new Size((int)(workingArea.Width * 0.14), (int)(workingArea.Height * 0.07));
      }
      
      this.startRenderPoint = startRenderPoint;
      this.StartPosition = FormStartPosition.Manual;
      this.FormBorderStyle = FormBorderStyle.None;
      this.interval = defaultAppearingTimerInterval;
      this.timer.Tick += new EventHandler(OnTick);
      this.moveTimer.Tick += new EventHandler(MoveTimerEvent);
      this.realBarHeight = this.ClientSize.Height;
      this.realBarWidth = this.ClientSize.Width;
      this.displayRecord = displayRecord;
      this.ShowInTaskbar = false;
      InitializeForm();
    }

    public void InitializeDisplayRecord(VmosoTileDisplayRecord displayRecord)
    {
      this.displayRecord = displayRecord;
    }

    //public NotifierUI(int appearingTime, int showTime, int disappearingTime, int realBarHeight, Point startRenderPoint)
    //{ 
    //  this.FormBorderStyle = FormBorderStyle.None;
    //  //this.timer.Enabled = true;
    //  this.interval = defaultAppearingTimerInterval;
    //  //this.timer.Tick += new EventHandler(OnTick);

    //  this.moveTimer.Tick += new EventHandler(MoveTimerEvent);
    //  InitializeForm();
    //  this.realBarHeight = realBarHeight > 0?realBarHeight : defaultBarHeight;

    //  this.appearingTime = appearingTime;
    //  this.showTime = showTime;
    //  this.disappearingTime = disappearingTime;
    //  this.startRenderPoint = startRenderPoint;

    //  //Calculate notifier pop up speed, we do not want it pop out too slow because it not meaningful.
    //  //So the speed must greater or equals to 1
    //  //this.moveDistance = realBarHeiht / (ShowTime / defaultTimerInterval) < 1 ? 1 : this.Size.Height / (ShowTime / defaultTimerInterval);

    //}

    #endregion

    [DllImport("user32.dll")]

    private static extern Boolean ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

    public void ShowMessage()
    {
      switch (notifierBarStatus)
      {
        case NotifierBarStatus.hidden:
          notifierBarStatus = NotifierBarStatus.appearing;
          this.moveDistance = realBarHeight * defaultAppearingTimerInterval / appearingTime;
          if (moveDistance < 1)
          {
            moveDistance = 1;
            interval = appearingTime / realBarHeight;
          }
          timer.Interval = interval;
          renderFinished = false;
          timer.Start();

          break;
        case NotifierBarStatus.disappearing:
          notifierBarStatus = NotifierBarStatus.disappearing;
          renderFinished = false;
          timer.Start();
          break;
        default:
          break;
      }
      
      ShowWindow(this.Handle, ShowWindowCommands.ShowNoActivate);
    }
    

    protected void OnTick(object obj, EventArgs args)
    {
      Point point = this.Location;
      int y = point.Y;
      
      switch (notifierBarStatus)
      {
        case NotifierBarStatus.hidden:
          break;
        case NotifierBarStatus.appearing:
          y -= moveDistance;
          break;
        case NotifierBarStatus.shown:
          timer.Stop();
          renderFinished = false;
          notifierBarStatus = NotifierBarStatus.disappearing;
          interval = defaultDisappearingTimerInterval;
          this.moveDistance = this.Size.Height * defaultAppearingTimerInterval / appearingTime;
          if (moveDistance < 1)
          {
            moveDistance = 1;
            interval = disappearingTime / this.Size.Height;
          }
          timer.Interval = interval;

          timer.Start();
          break;
        case NotifierBarStatus.disappearing:
          y += moveDistance;
          break;
      }
      if (startRenderPoint.Y - y >= realBarHeight)
      {
        if (notifierBarStatus == NotifierBarStatus.appearing)
        {
          y = startRenderPoint.Y - realBarHeight;
          notifierBarStatus = NotifierBarStatus.shown;
          timer.Stop();
          timer.Interval = showTime;
          if (OnShownStatus != null)
          {
            OnShownStatus(this, new EventArgs());
          }
          renderFinished = true;

          timer.Start();
        }

      }
      else if (startRenderPoint.Y <= y && notifierBarStatus != NotifierBarStatus.hidden)
      {
        y = startRenderPoint.Y + realBarHeight;
        if (OnHiddenStatus != null)
        {
          OnHiddenStatus(this, new EventArgs());
        }
        notifierBarStatus = NotifierBarStatus.hidden;
        renderFinished = true;
        timer.Stop();

        this.Dispose();
      }

      if (notifierBarStatus != NotifierBarStatus.hidden && notifierBarStatus != NotifierBarStatus.shown)
      {
        point.Y = y;
        int currentHeight = 0;

        if (notifierBarStatus == NotifierBarStatus.appearing)
        {
          currentHeight = this.Size.Height + moveDistance;
        }
        else if (notifierBarStatus == NotifierBarStatus.disappearing)
        {
          currentHeight = this.Size.Height - moveDistance;

          if (OnDisappearingStatus != null)
          {
            OnDisappearingStatus(this, new EventArgs());
          }
        }
        Size currentSize = new Size(this.Size.Width, currentHeight);
        this.Size = currentSize;

        this.Location = point;

        this.Invalidate(true);
      }
    }

    

    protected void MoveTimerEvent(object obj, EventArgs args)
    {
      int x = this.Location.X;
      int y = this.Location.Y;

      y -= moveBarDist;

      if (moveStartPoint.Y - y >= realBarHeight)
      {
        y = moveStartPoint.Y - realBarHeight;
        moveTimer.Stop();
      }

      Point point = new Point(x, y);
      this.Location = point;
      this.Invalidate(true);
    }

    public NotifierBarStatus getNotifierBarStatus()
    {
      return notifierBarStatus;
    }

    protected void InitializeForm()
    {
      int width = this.realBarWidth;
      int height = 0;

      Size barSize = new Size(width, height);

      this.Location = startRenderPoint;
      this.Size = barSize;
    }

    protected void Notifier_OnClick(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.vmoso.com/myplace");
    }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NotifierUI
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "NotifierUI";
            this.Load += new System.EventHandler(this.NotifierUI_Load);
            this.ResumeLayout(false);

        }

        private void NotifierUI_Load(object sender, EventArgs e)
        {

        }
    }

    public enum NotifierBarStatus
  {
    hidden = 0,
    appearing = 1,
    shown = 2,
    disappearing = 3,
  }

  public enum NotifierType
  {
    MostRecentMessage,
    PopUpMessage
  }
}

