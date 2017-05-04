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
	public partial class LoginForm : Form {
		public LoginForm() {
			InitializeComponent();
		}

		private void LoginButton_Click(object sender, EventArgs e) {
			Form mainForm = new MainForm();
			this.Visible = false;
			mainForm.ShowDialog();
			this.Close();
		}
	}
}
