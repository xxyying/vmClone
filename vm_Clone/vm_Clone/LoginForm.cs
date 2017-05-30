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

namespace vm_Clone {
	public partial class LoginForm : Form {
		RegistryKey rkApp;
		MainForm mainForm;
		//public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
		//[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]

		private const int STATUS_INFO = 3;
		private const int STATUS_WARNING = 2;
		private const int STATUS_ERROR = 1;

		////Mouse actions
		//private const int MOUSEEVENTF_LEFTDOWN = 0x02;
		//private const int MOUSEEVENTF_LEFTUP = 0x04;
		//private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
		//private const int MOUSEEVENTF_RIGHTUP = 0x10;

		public const String APP_NAME = "Vmoso BKW";
		public const String CACHE_SUBFOLDER = "cache";
		public const String AHA_CACHE_SUBFOLDER = "aha";
		public const String SHARE_CACHE_SUBFOLDER = "share";
		public const String SPACES_CACHE_SUBFOLDER = "spaces";
		public const String CONTACTS_CACHE_SUBFOLDER = "contacts";

		const string USERNAME_HINT = "Username";
		const string PASSWORD_HINT = "Password";


		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		public VmosoSession Session { get; set; }

		ContactClient contactClient { get; set; }
		StreamClient streamClient { get; set; }
		PushClient pushClient { get; set; }

		String dataFolder { get; set; }

		HtmlEditorControl htmlEditor = new HtmlEditorControl();

		public LoginForm(String dataFolder) {
			this.dataFolder = dataFolder;
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e) {
			Console.WriteLine("Loading LoginForm...");
			Console.WriteLine("Application data folder: {0}", dataFolder);

			rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			mainForm = Application.OpenForms["MainForm"] as MainForm;

			refreshLoginForm();

			Assembly assembly = Assembly.GetExecutingAssembly();
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
			labelVersion.Text = "VmosoBKW " + fileVersionInfo.ProductVersion;

		}

		private void LoginForm_Shown(object sender, EventArgs e) {
			if (Session == null) {
				if (Properties.Settings.Default.RememberMe) {
					if (Properties.Settings.Default.VmosoUsername != "UserName" || Properties.Settings.Default.VmosoPassword != "Passward" 
							|| Properties.Settings.Default.VmosoUsername != "" || Properties.Settings.Default.VmosoPassword != "") {
						login();
					} else {
						LoginForm loginForm = new LoginForm(dataFolder);
						login();
					}
				} else {
					LoginForm loginForm = new LoginForm(dataFolder);
					login();
					Console.WriteLine("Login form shows...");
					
				}
			}
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
			//Console.WriteLine("this is username: {0}", txt);
		}

		private void passWord_Enter(object sender, EventArgs e) {
			passWord.Text = Properties.Settings.Default.VmosoPassword;
			passWord.ForeColor = Color.Black;
			passWord.PasswordChar = '*';
			//Console.WriteLine("This is password: {0}", pwd);
		}	

		public void login() {
			if (Properties.Settings.Default.VmosoUsername != USERNAME_HINT 
				|| Properties.Settings.Default.VmosoPassword != PASSWORD_HINT
				|| Properties.Settings.Default.VmosoUsername != "" 
				|| Properties.Settings.Default.VmosoPassword != "") {
				showStatus(Properties.Resources.message_connecting, STATUS_INFO);
			}
			
			// check authentication

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



		private void LoginButton_Click(object sender, EventArgs e) {
			Form mainForm = new MainForm();

			Properties.Settings.Default.RememberMe = rememberMe_checkBox.Checked;
			if (Properties.Settings.Default.RememberMe) {
				Properties.Settings.Default.VmosoUsername = userName.Text;
				Properties.Settings.Default.VmosoPassword = passWord.Text;
			} else {
				Properties.Settings.Default.VmosoUsername = "";
				Properties.Settings.Default.VmosoPassword = "";
			}

			Properties.Settings.Default.Save();

			Console.WriteLine("Typed in username: {0}", userName.Text);
			Console.WriteLine("Typed in password: {0}", passWord.Text);

			this.Visible = false;
			mainForm.ShowDialog();
			//this.Close();
		}


		private void refreshLoginForm() {
			if (Session != null) {
				LoginButton.Enabled = false;
				userName.Enabled = false;
				passWord.Enabled = false;
			} else {
				LoginButton.Enabled = true;
				userName.Enabled = true;
				passWord.Enabled = true;
			}
		}
	}
}
