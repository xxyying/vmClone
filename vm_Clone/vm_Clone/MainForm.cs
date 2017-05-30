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
		private Point tmp;



		public MainForm() {
			InitializeComponent();
			Initialize();

		}

		private void Initialize() {
			tmp = new Point(0, 0);
			subLinkPanel.Visible = false;
			linkSortUp.Visible = false;
			link_button.Visible = true;
			link_Panel.Visible = true;
		}

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
}
