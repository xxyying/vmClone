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

		private void LoginForm_Shown(object sender, EventArgs e) {
			if (Session == null) {
				if (Properties.Settings.Default.RememberMe) {
					if (Properties.Settings.Default.VmosoUsername != "Username" || Properties.Settings.Default.VmosoPassword != "Passward"
							|| Properties.Settings.Default.VmosoUsername != "" || Properties.Settings.Default.VmosoPassword != "") {
						login();
					} else {
						LoginForm loginForm = new LoginForm();
						login();
					}
				} else {
					LoginForm loginForm = new LoginForm();
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
			if (userName.Text != "" || userName.Text != USERNAME_HINT) {
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

		public void login() {

			Console.WriteLine("Connecting to server...");
			// check authentication

		}


		private void LoginButton_Click(object sender, EventArgs e) {

			Properties.Settings.Default.VmosoUsername = userName.Text;
			Properties.Settings.Default.VmosoPassword = passWord.Text;
			Console.WriteLine("Typed in username: {0}", Properties.Settings.Default.VmosoUsername);
			Console.WriteLine("Typed in password: {0}", Properties.Settings.Default.VmosoPassword);

			if (Properties.Settings.Default.VmosoUsername != USERNAME_HINT
				|| Properties.Settings.Default.VmosoPassword != PASSWORD_HINT
				|| Properties.Settings.Default.VmosoUsername != ""
				|| Properties.Settings.Default.VmosoPassword != "") {
				//showStatus(Properties.Resources.message_connecting, STATUS_INFO);
				backgroundLoginWorker.RunWorkerAsync();
			}

			Properties.Settings.Default.RememberMe = rememberMe_checkBox.Checked;
			//if (Properties.Settings.Default.RememberMe) {
			//	Properties.Settings.Default.VmosoUsername = userName.Text;
			//	Properties.Settings.Default.VmosoPassword = passWord.Text;
			//} else {
			//	Properties.Settings.Default.VmosoUsername = "";
			//	Properties.Settings.Default.VmosoPassword = "";
			//}
			Properties.Settings.Default.Save();


			// show mainform
			Form mainForm = new MainForm(dataFolder);
			this.Visible = false;
			mainForm.ShowDialog();
			mainForm.Activate();
			Close();
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

		//private void backgroundLoginWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
		//	if (e.Result is Exception) {
		//		Exception ex = e.Result as Exception;
		//		showStatus(ex.Message, STATUS_ERROR);
		//		Session = null;
		//		//LoginForm loginForm = new LoginForm();
		//		//loginForm.Show();
		//	} else {
		//		loggedUserDisplayName = e.Result as String;
		//		showStatus(String.Format(Properties.Resources.message_hi, loggedUserDisplayName), STATUS_INFO);
		//		textSearchAHA.Enabled = true;
		//		buttonSearch.Enabled = true;
		//		AhaClient = new AHAClient(Session);
		//		shareClient = new ShareClient(Session);
		//		contactClient = new ContactClient(Session);
		//		streamClient = new StreamClient(Session);
		//		notifMgr = new NotifierUIManager(Session);
		//		pushClient = new PushClient(Session);
		//		pushClient.OnReceiveMessage += OnPushReceiveMessage;
		//		pushClient.OnReceiveCount += OnPushReceiveCount;

		//		//toolStripStatusLabelPush.Text = "Connecting push...";
		//		backgroundStartPushWorker.RunWorkerAsync();

		//		labelCross.Visible = true;

		//		buttonMoreResults.Enabled = false;

		//		List<String> types = new List<String>();
		//		if (checkBoxUsers.Checked) types.Add(AHAClient.USER_TYPE);
		//		if (checkBoxGroups.Checked) types.Add(AHAClient.USERGROUP_TYPE);
		//		if (checkBoxSpaces.Checked) types.Add(AHAClient.HOTSPOT_TYPE);
		//		if (checkBoxActivities.Checked) {
		//			types.Add(AHAClient.TASK_TYPE);
		//			types.Add(AHAClient.POST_TYPE);
		//		}
		//		if (checkBoxContent.Checked) {
		//			types.Add(AHAClient.FILE_TYPE);
		//			types.Add(AHAClient.DOCUMENT_TYPE);
		//		}

		//		labelProgressAHA.Visible = true;
		//		searchAhaWorkerInput = new SearchAHAWorkerInput(SearchAHAWorkerInput.CACHE, "", types);
		//		backgroundAhaSearchWorker.RunWorkerAsync(searchAhaWorkerInput);

		//		labelProgressStream.Visible = true;
		//		searchStreamWorkerInput = new SearchStreamWorkerInput(SearchStreamWorkerInput.FIRST_PAGE, "", null);
		//		backgroundStreamSearchWorker.RunWorkerAsync(searchStreamWorkerInput);

		//		if (listViewShare.Items.Count == 0) {
		//			List<ShareItem> shareItems = readFromShareCache();
		//			foreach (ShareItem item in shareItems) {
		//				addShareItem(item);
		//			}
		//		}

		//		if (listViewContacts.Items.Count == 0) {
		//			List<ContactItem> contactItems = readFromContactsCache();
		//			foreach (ContactItem item in contactItems) {
		//				addContactItem(item);
		//			}
		//		}

		//	}
		//}
		#endregion

		private void refreshLoginForm() {
			if (Session != null) {
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
