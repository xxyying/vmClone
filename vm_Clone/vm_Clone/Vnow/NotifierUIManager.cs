using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Diagnostics;
using VmosoBKW.VmosoPanes;
using VmosoBKW.VmosoForms;
using VmosoPushClient;
using VmosoApiClient.Client;


namespace VmosoBKW
{
  public class NotifierUIManager : System.Windows.Forms.Form
  {
    const int recentMsgShownTime = 10000;

    protected System.Collections.Concurrent.ConcurrentQueue<VmosoTileDisplayRecord> notifierQueue = new System.Collections.Concurrent.ConcurrentQueue<VmosoTileDisplayRecord>();
    protected System.Collections.Concurrent.ConcurrentQueue<VmosoTileDisplayRecord> mostRecentQueue = new System.Collections.Concurrent.ConcurrentQueue<VmosoTileDisplayRecord>();
    protected Point top;
    protected int realBarHeight = 0;
    protected int defaultBarWidth = 460;
    protected int defaultBarHeight = 70;
    protected int notifierCounter = 0;
    protected int mostRecentCountLimit = 10;
    protected Timer showMessageTimer = new Timer();
    protected int showMessageEllapsedTime = 0;
    protected NotifierUI currentNotifier;
    protected MostRecentMessageForm recentMessageForm;
    protected Rectangle workingArea;
    protected Size expectedSize;
    private bool canShowRecentMessage = true;

    protected event NotifierEventHandler add;
        private VmosoSession Session;

    public string Server { get; set; }

    public NotifierUIManager(VmosoSession session)
    {
      this.Session = session;
      this.add += new NotifierEventHandler(OnAdd);
      top = new Point();
      workingArea = Screen.GetWorkingArea(this);
      showMessageTimer.Interval = 1000;
      showMessageTimer.Tick += ShowMessageTimerOnTick;
      this.expectedSize = new Size((int)(workingArea.Width * 0.14), (int)(workingArea.Height * 0.1));
      top.X = workingArea.X + workingArea.Width - expectedSize.Width;
      top.Y = workingArea.Y + workingArea.Height;
      realBarHeight = expectedSize.Height;
    }

    public NotifierUIManager(Size expectedSize)
    {
      this.add += new NotifierEventHandler(OnAdd);
      top = new Point();
      this.expectedSize = expectedSize;
      workingArea = Screen.GetWorkingArea(this);
      top.X = workingArea.X + workingArea.Width - (expectedSize.Width);
      top.Y = workingArea.Y + workingArea.Height;
      realBarHeight = expectedSize.Height;

      showMessageTimer.Interval = 1000;
      showMessageTimer.Tick += ShowMessageTimerOnTick;
    }

    public void Add(VmosoTileDisplayRecord displayRecord, VmosoSession session)
    {
      notifierQueue.Enqueue(displayRecord);

      if (add != null)
      {
        add(this, new NotifierEventArgs(displayRecord,session));
      }
    }

    public void ShowMostRecentMessage()
    {
      if (mostRecentQueue.Count == 0 || canShowRecentMessage == false)
        return;

      canShowRecentMessage = false;

      Point recentMessageTopPoint = new Point();
      recentMessageTopPoint.X = workingArea.X + workingArea.Width - expectedSize.Width;
      recentMessageTopPoint.Y = workingArea.Y + workingArea.Height;

      Size formSize = new Size(this.expectedSize.Width, 0);
      int xOffset = 3;

      Size controlPaneSize = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.25));

      MostRecentControlPane controlPane = new MostRecentControlPane(controlPaneSize);
      controlPane.Render();

      recentMessageForm = new MostRecentMessageForm(formSize, recentMessageTopPoint);
      recentMessageForm.TopMost = true;
      recentMessageForm.Disposed += MostRecentMessage_FormDisposed;
      recentMessageForm.AddMessageControl(controlPane);

      IEnumerator<VmosoTileDisplayRecord> enumerator = mostRecentQueue.GetEnumerator();

      int elementIndex = 0;

      while (enumerator.MoveNext())
      {
        elementIndex++;
        VmosoTileDisplayRecord displayRecord = enumerator.Current;

        Size typeIconPaneSize = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.25));
        Size summaryPaneSize = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.375));
        Size personalPaneSize = new Size(this.expectedSize.Width - xOffset * 2, (int)(this.expectedSize.Height * 0.375) - 3);

        TypeIconPane typeIconPane = elementIndex == mostRecentQueue.Count ? new TypeIconPane(typeIconPaneSize, displayRecord, true) : new TypeIconPane(typeIconPaneSize, displayRecord, false);
        SummaryPane summaryPane = new SummaryPane(summaryPaneSize, displayRecord);
        PersonalPane personalPane = new PersonalPane(personalPaneSize, displayRecord, Session);

        typeIconPane.Render();
        summaryPane.Render();
        personalPane.Render();

        recentMessageForm.AddTile(personalPane);
        recentMessageForm.AddTile(summaryPane);

        if (elementIndex == mostRecentQueue.Count)
          recentMessageForm.AddTile(typeIconPane);
      }

      recentMessageForm.Render();
      recentMessageForm.Show();

      showMessageTimer.Start();
    }

    public void ClearMostRecentMessageQueue()
    {
      mostRecentQueue = new System.Collections.Concurrent.ConcurrentQueue<VmosoTileDisplayRecord>();
    }

    protected void MostRecentMessage_FormDisposed(object sender, EventArgs e)
    {
      this.canShowRecentMessage = true;
      showMessageTimer.Stop();
      showMessageEllapsedTime = 0;
    }

    protected void OnAdd(object obj, NotifierEventArgs e)
    {
      if (!string.IsNullOrEmpty(e.DisplayRecord.character) && e.DisplayRecord.character.Equals("engage") && CanShow(e.DisplayRecord))
      {
        if (mostRecentQueue.Count >= 10)
        {
          VmosoTileDisplayRecord recentDisplayRecord;
          mostRecentQueue.TryDequeue(out recentDisplayRecord);
        }

        mostRecentQueue.Enqueue(e.DisplayRecord);
      }

      if (currentNotifier == null)
      {
        VmosoNotifierTile ui = new VmosoNotifierTile(top, e.DisplayRecord, expectedSize, Session);
        currentNotifier = ui;
        ui.OnShownStatus += new EventHandler(OnShownHandler);
        ui.OnHiddenStatus += new EventHandler(OnHiddenStatus);
        VmosoTileDisplayRecord immediateDisplayRecord;
        notifierQueue.TryDequeue(out immediateDisplayRecord);
        notifierCounter++;
        ui.ShowMessage();
      }
    }

    protected void OnShownHandler(object obj, EventArgs e)
    {
      top.Y -= realBarHeight;
      if (notifierQueue.Count > 0)
      {
        VmosoTileDisplayRecord displayRecord;
        notifierQueue.TryDequeue(out displayRecord);
        VmosoNotifierTile ui = new VmosoNotifierTile(top, displayRecord, expectedSize, Session);

        currentNotifier = ui;
        ui.OnShownStatus += new EventHandler(OnShownHandler);
        ui.OnHiddenStatus += new EventHandler(OnHiddenStatus);
        notifierCounter++;
        ui.ShowMessage();
      }
      else
      {
        currentNotifier = null;
      }
    }

    protected void OnDisappearingHandler(object obj, EventArgs e)
    {
      if (notifierQueue.Count > 0)
      {
        top.Y -= realBarHeight;
        VmosoTileDisplayRecord displayRecord;
        notifierQueue.TryDequeue(out displayRecord);
        VmosoNotifierTile ui = new VmosoNotifierTile(top, displayRecord, expectedSize, Session);
        currentNotifier = ui;
        ui.OnShownStatus += new EventHandler(OnShownHandler);
        ui.OnHiddenStatus += new EventHandler(OnHiddenStatus);
        ui.OnDisappearingStatus += new EventHandler(OnDisappearingHandler);
        notifierCounter++;
        ui.ShowMessage();
      }
    }

    protected void OnHiddenStatus(object obj, EventArgs e)
    {
      if (notifierQueue.Count > 0)
      {
        top.Y -= realBarHeight;
        VmosoTileDisplayRecord displayRecord;
        notifierQueue.TryDequeue(out displayRecord);
        VmosoNotifierTile ui = new VmosoNotifierTile(top, displayRecord, expectedSize, Session);
        currentNotifier = ui;
        ui.OnShownStatus += new EventHandler(OnShownHandler);
        ui.OnHiddenStatus += new EventHandler(OnHiddenStatus);
        notifierCounter++;
        ui.ShowMessage();
      }
      notifierCounter--;
      if (notifierQueue.Count == 0 && IsLastNotifier())
      {
        top.Y = workingArea.Y + workingArea.Height;
        currentNotifier = null;
      }
    }

    protected bool IsLastNotifier()
    {
      return notifierCounter == 0;
    }

    // Check if current message belongs to "today"
    protected bool CanShow(VmosoTileDisplayRecord record)
    {
      double secondOfDay = 86400;
      double timestamp = ConvertToLocalUnixTime(record.timestamp);

      double unixTimesCap = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local)).TotalSeconds;
      double daysCap = (int)(unixTimesCap / secondOfDay);
      double startTime = daysCap * secondOfDay;
      double endTime = secondOfDay * (daysCap + 1);

      if (timestamp >= startTime && timestamp < endTime)
        return true;
      else
        return false;
    }

    protected double ConvertToLocalUnixTime(double utcTime)
    {
      System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
      dtDateTime = dtDateTime.AddSeconds(utcTime).ToLocalTime();
      double localUnixTime = dtDateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local)).TotalSeconds;

      return localUnixTime;
    }

    protected void ShowMessageTimerOnTick(object sender, EventArgs e)
    {
      showMessageEllapsedTime += showMessageTimer.Interval;
      
      if (showMessageEllapsedTime >= recentMsgShownTime)
      {
        recentMessageForm.Dispose();
      }
    }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NotifierUIManager
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "NotifierUIManager";
            this.Load += new System.EventHandler(this.NotifierUIManager_Load);
            this.ResumeLayout(false);

        }

        private void NotifierUIManager_Load(object sender, EventArgs e)
        {

        }
    }
}
