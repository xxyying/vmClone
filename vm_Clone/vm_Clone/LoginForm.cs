using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vm_Clone {
	public partial class LoginForm : Form {
		RegistryKey rkApp;
		public LoginForm() {
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e) {
			rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
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
			userName.Text = "";
			userName.ForeColor = Color.Black;
			//string txt = userName.Text;
			//Console.WriteLine("this is username: {0}", txt);
		}

		private void passWord_Enter(object sender, EventArgs e) {
			passWord.Text = "";
			passWord.ForeColor = Color.Black;
			passWord.PasswordChar = '*';
			//String pwd = passWord.Text;
			//Console.WriteLine("This is password: {0}", pwd);
		}

		private void LoginButton_Click(object sender, EventArgs e) {
			Form mainForm = new MainForm();

			String uname = userName.Text;
			String pword = passWord.Text;

			Console.WriteLine("Typed in username: {0}", uname);
			Console.WriteLine("Typed in password: {0}", pword);

			this.Visible = false;
			mainForm.ShowDialog();
			this.Close();
		}


	}
}
