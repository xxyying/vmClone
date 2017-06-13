using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

using VmosoApiClient.Api;
using VmosoApiClient.Client;
using VmosoApiClient.Model;

using VmosoAHAClient;
using VmosoShareClient;
using VmosoContactClient;
using VmosoStreamClient;
using VmosoPushClient;
using System.IO;
using System.Net;
using log4net;
using MSDN.Html.Editor;

namespace vm_Clone {
	public partial class MainForm : Form {

		// Initialization
		private const int STATUS_INFO = 3;
		private const int STATUS_WARNING = 2;
		private const int STATUS_ERROR = 1;

		public const String APP_NAME = "Vmoso BKW";
		public const String CACHE_SUBFOLDER = "cache";
		public const String AHA_CACHE_SUBFOLDER = "aha";
		public const String SHARE_CACHE_SUBFOLDER = "share";
		public const String SPACES_CACHE_SUBFOLDER = "spaces";
		public const String CONTACTS_CACHE_SUBFOLDER = "contacts";

		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		public VmosoSession Session { get; set; }

		ContactClient contactClient { get; set; }
		StreamClient streamClient { get; set; }
		PushClient pushClient { get; set; }

		SearchAHAWorkerInput searchAhaWorkerInput { get; set; }
		SearchAHAWorkerInput searchStreamAhaWorkerInput { get; set; }

		SearchStreamWorkerInput searchStreamWorkerInput { get; set; }
		StreamCommentsWorkerInput streamCommentsWorkerInput { get; set; }

		String dataFolder { get; set; }
		String ahaCacheFolder { get; set; }
		String shareCacheFolder { get; set; }
		String spacesCacheFolder { get; set; }
		String contactsCacheFolder { get; set; }

		public Color VMOSO_BLUE = Color.FromArgb(39, 169, 255);
		public Color VMOSO_GREEN = Color.FromArgb(101, 153, 65);
		public Color VMOSO_ORANGE = Color.FromArgb(247, 151, 29);
		public Color VMOSO_YELLOW = Color.FromArgb(255, 206, 13);

		ClipboardWatcher clipboardWatcher;
		String loggedUserDisplayName;

		HtmlEditorControl htmlEditor = new HtmlEditorControl();

		private NotifierUIManager notifMgr;
		private bool isNormalDisconnect = false;
		private bool isExit;

		private bool endOfStream = false;

		// -----------------------------------------------------------------------------------------------


		bool showList = false;
		private Point tmp;

		public MainForm(String dataFolder) {
			this.dataFolder = dataFolder;
			InitializeComponent();
			Initialize();

		}

		// Initialization
		private void Initialize() {
			tmp = new Point(0, 0);
			subLinkPanel.Visible = false;
			linkSortUp.Visible = false;
			link_button.Visible = true;
			link_Panel.Visible = true;
		}

		#region Common
		private void MainForm_Load(object sender, EventArgs e) {
			log.Debug("Loading MainForm");
			log.Info("Application data folder: " + dataFolder);

			String cacheFolder = dataFolder + CACHE_SUBFOLDER + "\\";

			if (!Directory.Exists(cacheFolder)) {
				log.Info("Creating directory " + cacheFolder);
				Directory.CreateDirectory(cacheFolder);
			}

			ahaCacheFolder = cacheFolder + AHA_CACHE_SUBFOLDER + "\\";

			if (!Directory.Exists(ahaCacheFolder)) {
				log.Info("Creating directory " + ahaCacheFolder);
				Directory.CreateDirectory(ahaCacheFolder);
			}

			shareCacheFolder = cacheFolder + SHARE_CACHE_SUBFOLDER + "\\";

			if (!Directory.Exists(shareCacheFolder)) {
				log.Info("Creating directory " + shareCacheFolder);
				Directory.CreateDirectory(shareCacheFolder);
			}

			spacesCacheFolder = cacheFolder + SPACES_CACHE_SUBFOLDER + "\\";

			if (!Directory.Exists(spacesCacheFolder)) {
				log.Info("Creating directory " + spacesCacheFolder);
				Directory.CreateDirectory(spacesCacheFolder); 
			}

			contactsCacheFolder = cacheFolder + CONTACTS_CACHE_SUBFOLDER + "\\";

			if (!Directory.Exists(contactsCacheFolder)) {
				log.Info("Creating directory " + contactsCacheFolder);
				Directory.CreateDirectory(contactsCacheFolder);
			}

		}
		#endregion

		#region Common
		private void MainForm_Shown(object sender, EventArgs e) {
			if (Session == null) {
				if (Properties.Settings.Default.RememberMe) {
					if (Properties.Settings.Default.VmosoUsername != "" 
						|| Properties.Settings.Default.VmosoPassword != ""
						|| Properties.Settings.Default.VmosoUsername != "Username"
						|| Properties.Settings.Default.VmosoPassword != "Password") {
						login();
					} else {
						LoginForm loginForm = new LoginForm();
						loginForm.Show();
					}
				} else {
					LoginForm loginForm = new LoginForm();
					loginForm.Show();

				}
			}
		}


		#endregion

		#region Left link-subpanel
		private void link_button_Click(object sender, EventArgs e) {
			showList = true;
			link_Panel.Visible = true;
			if (showList == true) {
				link_button.Visible = false;
				subLinkPanel.Visible = true;
				linkSortUp.Visible = true;
			}
			tmp = floatMenu.Location;
			floatMenu.Location = new Point(0, 262);
		}

		private void linkSortUp_Click(object sender, EventArgs e) {
			showList = false;
			link_button.Visible = true;
			subLinkPanel.Visible = false;
			linkSortUp.Visible = false ;
			floatMenu.Location = tmp;
		}
		#endregion

		#region Search bar
		private void searchTextPanel_Paint(object sender, PaintEventArgs e) {
			Panel p = sender as Panel;
			ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.Silver, ButtonBorderStyle.Solid);
		}

		private void searchTextBox_Enter(object sender, EventArgs e) {
			textSearchAHA.Text = "";
			textSearchAHA.ForeColor = Color.Black;

		}
		#endregion


		#region Minimize and Hide
		private void MainForm_Move(object sender, EventArgs e) {
			if (this.WindowState == FormWindowState.Minimized) {
				this.Hide();
				NotifyIcon.ShowBalloonTip(1000, "Important Notice", "Vmoso Big Knowledgement Widget hidden. Click to show.", ToolTipIcon.Info);
			}
		}

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
			this.Show();
		}
		#endregion




		private void stream_button_Click(object sender, EventArgs e) {
			//streamPanel.Visible = true;
		}

		


		private void showToolTip(String message, Control control, int status) {
			ToolTip toolTip = new ToolTip();

			switch (status) {
				case STATUS_INFO:
					toolTip.ForeColor = Color.Black;
					toolTip.BackColor = Color.White;
					break;
				case STATUS_WARNING:
					toolTip.ForeColor = Color.Orange;
					toolTip.BackColor = Color.Orange;
					break;
				case STATUS_ERROR:
					toolTip.ForeColor = Color.Red;
					toolTip.BackColor = Color.Red;
					break;
			}

			toolTip.Show(message, control, 100, 100, 3000);
		}

		private void showStatus(String message, int status) {
			switch (status) {
				case STATUS_ERROR:
					toolStripStatusLabelMessage.ForeColor = Color.Red;
					break;
				case STATUS_WARNING:
					toolStripStatusLabelMessage.ForeColor = Color.Orange;
					break;
				case STATUS_INFO:
					toolStripStatusLabelMessage.ForeColor = Color.Black;
					break;

			}
			toolStripStatusLabelMessage.Text = message;
		}

		public void login() {
			if (Properties.Settings.Default.VmosoUsername != ""
				|| Properties.Settings.Default.VmosoPassword != ""
				|| Properties.Settings.Default.VmosoUsername != "Username"
				|| Properties.Settings.Default.VmosoPassword != "Password") {
				showStatus(Properties.Resources.message_connecting, STATUS_INFO);
				backgroundLoginWorker.RunWorkerAsync();
			}
		}

		#region Login

		private void backgroundLoginWorker_DoWork(object sender, DoWorkEventArgs e) {

			if (Session == null) {
				String vmosoHost = Properties.Settings.Default.VmosoHost;
				FileInfo hostFile = new FileInfo(dataFolder + "/host");
				if (hostFile.Exists) {
					vmosoHost = File.ReadAllText(hostFile.FullName);
					ServicePointManager.ServerCertificateValidationCallback += (sdr, certificate, chain, sslPolicyErrors) => true;
				}

				String vmosoCid = Properties.Settings.Default.VmosoCid;
				FileInfo cidFile = new FileInfo(dataFolder + "/cid");
				if (cidFile.Exists) {
					vmosoCid = File.ReadAllText(cidFile.FullName);
				}

				log.Info("Creating session for host " + vmosoHost);
				Session = new VmosoSession(vmosoHost, vmosoCid);
				//if (Properties.Settings.Default.UseProxy) {
				//	Session.setProxy(Properties.Settings.Default.ProxyHost, Properties.Settings.Default.ProxyPort, Properties.Settings.Default.ProxyUser, Properties.Settings.Default.ProxyPassword);
				//}

				try {
					log.Info("Login with username " + Properties.Settings.Default.VmosoUsername);
					Session.Login(Properties.Settings.Default.VmosoUsername, Properties.Settings.Default.VmosoPassword);

				} catch (ApiException ex) {
					log.Error("Login error", ex);
					Exception ex2 = new Exception(Properties.Resources.error_login, ex);
					e.Result = ex2;
				}
			}

			try {
				log.Info("Getting user info for username " + Properties.Settings.Default.VmosoUsername);
				UserApi userApi = new UserApi(Session.GetApiClient());

				GetMeResult result = userApi.GetMe();
				if (result.Hdr.Rc == 0) {
					log.Info("User " + result.DisplayRecord.DisplayName + " logged");
					e.Result = result.DisplayRecord.DisplayName;
				} else {
					Exception ex2 = new Exception(Properties.Resources.error_login);
					log.Error("Vmoso error getting user info. Rc=" + result.Hdr.Rc);
					e.Result = ex2;
				}
			} catch (Exception ex) {
				Exception ex2 = new Exception(Properties.Resources.error_login);
				log.Error("Error getting user info", ex);
				e.Result = ex2;
			}
		}

		private void backgroundLoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			if (e.Result is Exception) {
				Exception ex = e.Result as Exception;
				showStatus(ex.Message, STATUS_ERROR);
				Session = null;
				LoginForm loginForm = new LoginForm();
				loginForm.Show();
			} else {
				loggedUserDisplayName = e.Result as String;
				showStatus(String.Format(Properties.Resources.message_hi, loggedUserDisplayName), STATUS_INFO);
				textSearchAHA.Enabled = true;
				buttonSearch.Enabled = true;
				AhaClient = new AHAClient(Session);
				shareClient = new ShareClient(Session);
				contactClient = new ContactClient(Session);
				streamClient = new StreamClient(Session);
				notifMgr = new NotifierUIManager(Session);
				pushClient = new PushClient(Session);
				pushClient.OnReceiveMessage += OnPushReceiveMessage;
				pushClient.OnReceiveCount += OnPushReceiveCount;

				//toolStripStatusLabelPush.Text = "Connecting push...";
				backgroundStartPushWorker.RunWorkerAsync();

				//labelCross.Visible = true;

				//buttonMoreResults.Enabled = false;

				List<String> types = new List<String>();
				if (checkBoxUsers.Checked) types.Add(AHAClient.USER_TYPE);
				if (checkBoxGroups.Checked) types.Add(AHAClient.USERGROUP_TYPE);
				if (checkBoxSpaces.Checked) types.Add(AHAClient.HOTSPOT_TYPE);
				if (checkBoxActivities.Checked) {
					types.Add(AHAClient.TASK_TYPE);
					types.Add(AHAClient.POST_TYPE);
				}
				//if (checkBoxContent.Checked) {
				//	types.Add(AHAClient.FILE_TYPE);
				//	types.Add(AHAClient.DOCUMENT_TYPE);
				//}

				//labelProgressAHA.Visible = true;
				//searchAhaWorkerInput = new SearchAHAWorkerInput(SearchAHAWorkerInput.CACHE, "", types);
				//backgroundAhaSearchWorker.RunWorkerAsync(searchAhaWorkerInput);

				//labelProgressStream.Visible = true;
				//searchStreamWorkerInput = new SearchStreamWorkerInput(SearchStreamWorkerInput.FIRST_PAGE, "", null);
				//backgroundStreamSearchWorker.RunWorkerAsync(searchStreamWorkerInput);

				//if (listViewShare.Items.Count == 0) {
				//	List<ShareItem> shareItems = readFromShareCache();
				//	foreach (ShareItem item in shareItems) {
				//		addShareItem(item);
				//	}
				//}

				//if (listViewContacts.Items.Count == 0) {
				//	List<ContactItem> contactItems = readFromContactsCache();
				//	foreach (ContactItem item in contactItems) {
				//		addContactItem(item);
				//	}
				//}

			}
		}

		#endregion

		#region Link
		AHAClient AhaClient { get; set; }

		#endregion

		#region share
		ShareClient shareClient { get; set; }

		#endregion

		#region Push

		private void OnPushReceiveMessage(object obj, NotifierEventArgs e) {
			if (this.InvokeRequired) {
				this.Invoke(new MethodInvoker(delegate {
					notifMgr.Add(e.DisplayRecord, Session);
				}));

			} else {

				notifMgr.Add(e.DisplayRecord, Session);
			}

			if (!backgroundStreamSearchWorker.IsBusy && !htmlEditorActive()) {
				searchStreamWorkerInput.Query = "";
				searchStreamWorkerInput.Page = SearchStreamWorkerInput.FIRST_PAGE;
				backgroundStreamSearchWorker.RunWorkerAsync(searchStreamWorkerInput);
			}
		}

		private void OnPushReceiveCount(object obj, CountEventArgs e) {
			if (this.InvokeRequired) {
				this.Invoke(new MethodInvoker(delegate {
					string totalCountStr = e.CountDisplayRecord.TotalCount;
					int totalCount = Convert.ToInt32(totalCountStr);

					if (totalCount >= 0) {
						this.notifyIcon.Icon = CountIcon.CreateTaskTrayIcon(totalCount, Properties.GlobalResources.vmoso_tasktray_icon);
					}

				}));

				return;
			}
		}

		protected void PushServer_ConnectionError(object sender, EventArgs e) {
			if (isNormalDisconnect)
				return;

			while (MessageBox.Show(Properties.Resources.error_connection_lost, Properties.Resources.window_title_error_connection_lost, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				if (CheckForInternetConnection()) {
					pushClient.Start();
					pushClient.Monitor.ConnectionError += PushServer_ConnectionError;
					pushClient.Monitor.ConnectionLost += PushServer_ConnectionLost;
					return;
				}
			}

			if (this.InvokeRequired) {
				this.Invoke(new MethodInvoker(delegate {
					isExit = true;
					this.Close();
				}));
			}
		}

		protected void PushServer_ConnectionLost(object sender, EventArgs e) {
			if (isNormalDisconnect)
				return;

			while (MessageBox.Show(Properties.Resources.error_connection_lost, Properties.Resources.window_title_error_connection_lost, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				if (CheckForInternetConnection()) {
					pushClient.Start();
					pushClient.Monitor.ConnectionError += PushServer_ConnectionError;
					pushClient.Monitor.ConnectionLost += PushServer_ConnectionLost;
					return;
				}
			}

			if (this.InvokeRequired) {
				this.Invoke(new MethodInvoker(delegate {
					isExit = true;
					this.Close();
				}));
			}
		}

		protected bool CheckForInternetConnection() {
			string testingURL = "http://www.vmoso.com";
			try {
				using (var client = new WebClient())
				using (var stream = client.OpenRead(testingURL)) {
					return true;
				}
			} catch {
				return false;
			}
		}

		//#region Stream update

		//private void backgroundStreamUpdateWorker_DoWork(object sender, DoWorkEventArgs e) {
		//	if (e.Argument is UpdateStreamWorkerInput) {
		//		UpdateStreamWorkerInput input = e.Argument as UpdateStreamWorkerInput;
		//		try {
		//			StreamItem item = streamClient.GetStreamItem(input.ContentKey);
		//			e.Result = new UpdateStreamWorkerResult(item);
		//		} catch (Exception ex) {
		//			e.Result = ex;
		//		}
		//	}
		//}

		//private void backgroundStreamUpdateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
		//	if (e.Result is Exception) {
		//		Exception ex = e.Result as Exception;
		//		log.Error("Error updating stream", ex);
		//		showToolTip(Properties.Resources.error_updating_stream, listViewStream, STATUS_ERROR);
		//	} else {
		//		bool updated = false;
		//		UpdateStreamWorkerResult result = e.Result as UpdateStreamWorkerResult;
		//		StreamItem updatedItem = result.Item;
		//		foreach (ListViewItem item in listViewStream.Items) {
		//			StreamItem streamItem = item.Tag as StreamItem;
		//			if (streamItem.Key.Equals(result.Item.Key)) {
		//				if (!string.IsNullOrEmpty(updatedItem.LastUpdaterIconKey) && !streamImageList.Images.ContainsKey(updatedItem.LastUpdaterIconKey)) {
		//					Stream iconStream = VmosoFileUtils.downloadIcon(Session, updatedItem.LastUpdaterIconKey, updatedItem.Key);
		//					if (iconStream != null) {
		//						Bitmap bmp = new Bitmap(iconStream);
		//						streamImageList.Images.Add(updatedItem.LastUpdaterIconKey, bmp);
		//					}
		//				}
		//				item.Tag = updatedItem;
		//				updated = true;
		//			}
		//		}

		//		if (updated) {
		//			listViewStream.Refresh();
		//		} else {
		//			if (!backgroundStreamSearchWorker.IsBusy) {
		//				searchStreamWorkerInput.Page = SearchStreamWorkerInput.FIRST_PAGE;
		//				backgroundStreamSearchWorker.RunWorkerAsync(searchStreamWorkerInput);
		//			}
		//		}
		//	}
		//}


		//#endregion

		#endregion

		#region Status bar

		private void timerMessageChange_Tick(object sender, EventArgs e) {
			timerMessageChange.Stop();
			showStatus("", STATUS_INFO);
		}

		private void startMessageRemover() {
			if (!toolStripStatusLabelMessage.Text.Equals("")) {
				timerMessageChange.Start();
			}
		}

		private void toolStripStatusLabelMessage_TextChanged(object sender, EventArgs e) {
			startMessageRemover();
		}
		#endregion


		// backgroundStartPushWorker 
		private void backgroundStartPushWorker_DoWork(object sender, DoWorkEventArgs e) {
			pushClient.Start();
		}

		private void backgroundStartPushWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
			pushClient.Monitor.ConnectionError += PushServer_ConnectionError;
			pushClient.Monitor.ConnectionLost += PushServer_ConnectionLost;
		}



		protected void PushServer_ConnectionError(object sender, EventArgs e) {
			if (isNormalDisconnect)
				return;

			while (MessageBox.Show(Properties.Resources.error_connection_lost, Properties.Resources.window_title_error_connection_lost, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				if (CheckForInternetConnection()) {
					pushClient.Start();
					pushClient.Monitor.ConnectionError += PushServer_ConnectionError;
					pushClient.Monitor.ConnectionLost += PushServer_ConnectionLost;
					return;
				}
			}

			if (this.InvokeRequired) {
				this.Invoke(new MethodInvoker(delegate {
					isExit = true;
					this.Close();
				}));
			}
		}

		protected void PushServer_ConnectionLost(object sender, EventArgs e) {
			if (isNormalDisconnect)
				return;

			while (MessageBox.Show(Properties.Resources.error_connection_lost, Properties.Resources.window_title_error_connection_lost, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				if (CheckForInternetConnection()) {
					pushClient.Start();
					pushClient.Monitor.ConnectionError += PushServer_ConnectionError;
					pushClient.Monitor.ConnectionLost += PushServer_ConnectionLost;
					return;
				}
			}

			if (this.InvokeRequired) {
				this.Invoke(new MethodInvoker(delegate {
					isExit = true;
					this.Close();
				}));
			}
		}

		protected bool CheckForInternetConnection() {
			string testingURL = "http://www.vmoso.com";
			try {
				using (var client = new WebClient())
				using (var stream = client.OpenRead(testingURL)) {
					return true;
				}
			} catch {
				return false;
			}
		}

		private void contacts_button_Click(object sender, EventArgs e) {

		}
	} // end of MainForm : Form

	// ------------------------------------------------------------------------------------------------------
	class SearchAHAWorkerInput {
		public const String CACHE = "cache";
		public const String FIRST_PAGE = "firstPage";
		public const String NEXT_PAGE = "nextPage";

		public String Page { get; set; }
		public String Query { get; set; }
		public List<String> Types { get; set; }

		public SearchAHAWorkerInput(String Page, String Query) {
			this.Page = Page;
			this.Query = Query;
			this.Types = new List<String>();
		}
		public SearchAHAWorkerInput(String Page, String Query, List<String> Types) {
			this.Page = Page;
			this.Query = Query;
			this.Types = Types;
		}
	}

	class SearchStreamWorkerInput {
		public const String CACHE = "cache";
		public const String FIRST_PAGE = "firstPage";
		public const String NEXT_PAGE = "nextPage";

		public String Page { get; set; }
		public String Query { get; set; }
		public List<StreamRule> Rules { get; set; }

		public SearchStreamWorkerInput(String Page, String Query) {
			this.Page = Page;
			this.Query = Query;
		}
		public SearchStreamWorkerInput(String Page, String Query, List<StreamRule> Rules) {
			this.Page = Page;
			this.Query = Query;
			this.Rules = Rules;
		}
	}

	class StreamCommentsWorkerInput {
		public const String CACHE = "cache";
		public const String FIRST_PAGE = "firstPage";
		public const String NEXT_PAGE = "nextPage";

		public StreamItem StreamItem { get; set; }
		public String Page { get; set; }
		public String Query { get; set; }

		public StreamCommentsWorkerInput(StreamItem StreamItem, String Page, String Query) {
			this.StreamItem = StreamItem;
			this.Page = Page;
			this.Query = Query;
		}
	}
}
