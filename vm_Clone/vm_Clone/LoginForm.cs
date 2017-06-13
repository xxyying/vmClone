using log4net;
using Microsoft.Win32;
using MSDN.Html.Editor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VmosoApiClient.Client;
using VmosoContactClient;
using VmosoPushClient;
using VmosoStreamClient;
using System.Globalization;
using System.IO;
using System.Net;
using VmosoApiClient.Api;
using VmosoApiClient.Model;

namespace vm_Clone {
	public partial class LoginForm : Form {

		MainForm mainForm;
		RegistryKey rkApp;

		public LoginForm() {
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e) {
			Console.WriteLine("Loading LoginForm...");

			rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			mainForm = Application.OpenForms["MainForm"] as MainForm;

			refreshLoginForm();

			Assembly assembly = Assembly.GetExecutingAssembly();
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
			labelVersion.Text = "VmosoBKW " + fileVersionInfo.ProductVersion;

		}



		// Jump to reset password page 
		private void forgetLabel_LinkClicked(object sender, EventArgs e) {
			ProcessStartInfo sInfo = new ProcessStartInfo("https://www.vmoso.com/mkt/en/forget.html");
			Process.Start(sInfo);
		}

		// Jump to sign up page
		private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			ProcessStartInfo sInfo = new ProcessStartInfo("https://www.vmoso.com/mkt/en/signup.html");
			Process.Start(sInfo);
		}

		private void userName_Enter(object sender, EventArgs e) {
			userName.Text = Properties.Settings.Default.VmosoUsername;
			userName.ForeColor = Color.Black;
			if (userName.Text != "" || userName.Text != "Username") {
				clearBtn.Visible = true;
			}
			//Console.WriteLine("this is username: {0}", txt);
		}

		private void passWord_Enter(object sender, EventArgs e) {
			passWord.Text = Properties.Settings.Default.VmosoPassword;
			passWord.ForeColor = Color.Black;
			passWord.PasswordChar = '*';
			//Console.WriteLine("This is password: {0}", pwd);
		}




		private void LoginButton_Click(object sender, EventArgs e) {

			Properties.Settings.Default.VmosoUsername = userName.Text;
			Properties.Settings.Default.VmosoPassword = passWord.Text;
			Properties.Settings.Default.RememberMe = rememberMe_checkBox.Checked;

			Console.WriteLine("Typed in username: {0}", Properties.Settings.Default.VmosoUsername);
			Console.WriteLine("Typed in password: {0}", Properties.Settings.Default.VmosoPassword);

			Properties.Settings.Default.Save();

			// show mainform
			this.Visible = false;
			mainForm.login();
			mainForm.Activate();
			Close();
		}
		

		private void refreshLoginForm() {
			if (mainForm.Session != null) {
				LoginButton.Enabled = false;
				userName.Enabled = false;
				passWord.Enabled = false;
			} else {
				LoginButton.Enabled = true;
				userName.Enabled = true;
				passWord.Enabled = true;
				if (Properties.Settings.Default.RememberMe) {
					rememberMe_checkBox.Checked = true;
					if (Properties.Settings.Default.VmosoUsername != null) {
						userName.Text = Properties.Settings.Default.VmosoUsername;
					}
					if (Properties.Settings.Default.VmosoPassword != null) {
						passWord.Text = Properties.Settings.Default.VmosoPassword;
					}
				}
			}
		}
	}


}
