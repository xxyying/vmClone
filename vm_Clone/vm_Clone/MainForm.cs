using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vm_Clone {
	public partial class MainForm : Form {

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
