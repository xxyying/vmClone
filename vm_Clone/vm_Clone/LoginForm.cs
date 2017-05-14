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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VmosoApiClient.Client;

namespace vm_Clone {
	public partial class LoginForm : Form {
		RegistryKey rkApp;
		MainForm mainForm;
		public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

		private const int STATUS_INFO = 3;
		private const int STATUS_WARNING = 2;
		private const int STATUS_ERROR = 1;

		//Mouse actions
		private const int MOUSEEVENTF_LEFTDOWN = 0x02;
		private const int MOUSEEVENTF_LEFTUP = 0x04;
		private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
		private const int MOUSEEVENTF_RIGHTUP = 0x10;

		public const String APP_NAME = "Vmoso BKW";
		public const String CACHE_SUBFOLDER = "cache";
		public const String AHA_CACHE_SUBFOLDER = "aha";
		public const String SHARE_CACHE_SUBFOLDER = "share";
		public const String SPACES_CACHE_SUBFOLDER = "spaces";
		public const String CONTACTS_CACHE_SUBFOLDER = "contacts";

		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		public VmosoSession Session { get; set; }


		HtmlEditorControl htmlEditor = new HtmlEditorControl();



		public LoginForm() {
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e) {
			rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

			//refreshControls();

			Assembly assembly = Assembly.GetExecutingAssembly();
			FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
			labelVersion.Text = "VmosoBKW " + fileVersionInfo.ProductVersion;

			mainForm.Session = null;

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
			//string txt = userName.Text;
			//Console.WriteLine("this is username: {0}", txt);
		}

		private void passWord_Enter(object sender, EventArgs e) {
			passWord.Text = Properties.Settings.Default.VmosoPassword;
			passWord.ForeColor = Color.Black;
			passWord.PasswordChar = '*';
			//String pwd = passWord.Text;
			//Console.WriteLine("This is password: {0}", pwd);
		}


		private void LoginForm_Shown(object sender, EventArgs e) {
			if (Session == null) {
				if (Properties.Settings.Default.RememberMe) {
					if (Properties.Settings.Default.VmosoUsername != "" || Properties.Settings.Default.VmosoPassword != "") {
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

		public void login() {
			if (Properties.Settings.Default.VmosoUsername != "" || Properties.Settings.Default.VmosoPassword != "") {
				showStatus(Properties.Resources.message_connecting, STATUS_INFO);
				//backgroundLoginWorker.RunWorkerAsync();
			}
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
