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

namespace vm_Clone {
	public partial class MainForm : Form {

		//[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
		public const String APP_NAME = "Vmoso BKW";
		public const String CACHE_SUBFOLDER = "cache";
		public const String AHA_CACHE_SUBFOLDER = "aha";
		public const String SHARE_CACHE_SUBFOLDER = "share";
		public const String SPACES_CACHE_SUBFOLDER = "spaces";
		public const String CONTACTS_CACHE_SUBFOLDER = "contacts";

		public VmosoSession Session { get; set; }
		ContactClient contactClient { get; set; }
		StreamClient streamClient { get; set; }
		PushClient pushClient { get; set; }

		bool showList = false;
		Point tmp = new Point(0, 0);

		public MainForm() {
			InitializeComponent();
			subLinkPanel.Visible = false;
			linkSortUp.Visible = false;
			link_button.Visible = true;
			streamPanel.Visible = false;

		}


		private void link_button_Click(object sender, EventArgs e) {
			showList = true;
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
			streamPanel.Visible = true;
		}
	}
}
