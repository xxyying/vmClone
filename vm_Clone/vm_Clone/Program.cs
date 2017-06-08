using System;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using log4net.Config;

namespace vm_Clone {
	static class Program {

		private static String LOG_SUBFOLDER = "log";
		private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {

			string localFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

			// Combine the base folder with your specific folder....
			String dataFolder = Path.Combine(localFolder, System.Reflection.Assembly.GetExecutingAssembly().GetName().Name) + "\\";

			if (!Directory.Exists(dataFolder)) {
				Directory.CreateDirectory(dataFolder);
			}

			String logFolder = dataFolder + "\\" + LOG_SUBFOLDER;
			GlobalContext.Properties["FilePath"] = logFolder + "\\vm.log";
			XmlConfigurator.Configure();

			if (!Directory.Exists(logFolder)) {
				Directory.CreateDirectory(logFolder);
			}


			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(dataFolder));
			//Application.Run(new LoginForm());


		}
	}
}
