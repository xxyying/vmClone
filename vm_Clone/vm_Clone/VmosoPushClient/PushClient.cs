using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmosoPushClient {
	public class PushClient {
		private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		private IWampChannel<JToken> channel;

		private IDisposable subscription;
		private DirectUrlBuilder urlBuilder;
		private int lastTs = 0;
		public static string Signature { get; set; }
		public event NotifierEventHandler OnReceiveMessage;
		public event CountEventHandler OnReceiveCount;

		public CookieCollection VmosoCookies { get; set; }
		public WampSharp.Auxiliary.Client.IWampClientConnectionMonitor Monitor { get; set; }

		private VmosoSession session;
		private string pushServer;
		private string signature;
	}
}
