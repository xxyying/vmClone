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

		private void stream_button_Click(object sender, EventArgs e) {
			//streamPanel.Visible = true;
		}

		private void searchTextPanel_Paint(object sender, PaintEventArgs e) {
			Panel p = sender as Panel;
			ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.Silver, ButtonBorderStyle.Solid);
		}

		private void searchTextBox_Enter(object sender, EventArgs e) {
			searchTextBox.Text = "";
			searchTextBox.ForeColor = Color.Black;

		}

		private void MainForm_Move(object sender, EventArgs e) {
			if(this.WindowState == FormWindowState.Minimized) {
				this.Hide();
				NotifyIcon.ShowBalloonTip(1000, "Important Notice", "Vmoso Big Knowledgement Widget hidden. Click to show.", ToolTipIcon.Info);
			}
		}

		private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
			this.Show();
		}


	}

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
