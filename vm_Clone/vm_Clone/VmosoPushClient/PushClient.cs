using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System;
using System.Reactive.Subjects;
using System.Security.Cryptography;
using System.Text;
using WampSharp;
using WampSharp.Rpc;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Collections;
using System.Web.Script.Serialization;
using VmosoApiClient.Client;
using VmosoApiClient.Api;
using VmosoApiClient.Model;
using log4net;
using vm_Clone;
using System.Net.WebSockets;

namespace VmosoPushClient
{
  public class PushClient
  {
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

        public PushClient(VmosoSession session)
    {
        this.session = session;
        this.urlBuilder = new DirectUrlBuilder(session.OriginalHost);
    }

    public void Start()
        {
            PushApi pushApi = new PushApi(session.GetApiClient());
            GetPushConfigResult getPushConfigResult = pushApi.GetPushConfig("ws");
            if(getPushConfigResult.Hdr.Rc==0)
            {
                pushServer = getPushConfigResult.Host;
                GetTokenResult getTokenResult = pushApi.GetToken(session.UserKey);
                if(getTokenResult.Hdr.Rc==0)
                {
                    signature = getTokenResult.Token;

                    BuildChannel();
                    Connect();
                    UserAuth();
                    Subscribe();
                    BuildChannelMonitor();
                }
            }

        }

    #region Rpc Interfaces
    public interface IRpcAuthentication
    {
      [WampRpcMethod("user:auth")]
      object Auth(string signature, string userKey, string topicKey);
    }
    #endregion

    public void BuildChannel()
    {
        logger.Info("Start building channel with " + "ws://" + pushServer);

        DefaultWampChannelFactory channelFactory = new DefaultWampChannelFactory();
        IWebProxy iProxy = session.GetApiClient().Configuration.ApiClient.RestClient.Proxy;
        if (iProxy != null) {
                WebProxy proxy = iProxy as WebProxy;
                NetworkCredential credentials = proxy.Credentials as NetworkCredential;
                
            channel = channelFactory.CreateChannel("ws://" + pushServer, proxy.Address.Host, proxy.Address.Port, credentials.UserName, credentials.Password);
        } else {
            channel = channelFactory.CreateChannel("ws://" + pushServer);
			Console.WriteLine(channel);
        }

        logger.Info("Successfully building channel with " + "ws://" + pushServer);
    }


    public void Connect()
    {
      logger.Info("Opening channel to " + "ws://" + pushServer);
            
      channel.Open();
      logger.Info("Successfully Opening channel to " + "ws://" + pushServer);
    }

    public void Disconnect()
    {
      logger.Info("Channel is closing " + "ws://" + pushServer);
      channel.Close();
      logger.Info("Channel is closed " + "ws://" + pushServer);
    }

    public void UserAuth()
    {
      logger.Info("Start Authentication " + "ws://" + pushServer);
      IRpcAuthentication auth = channel.GetRpcProxy<IRpcAuthentication>();
      object obj = auth.Auth(signature, session.UserKey, session.UserKey);
      logger.Info("Successfully Authentication " + "ws://" + pushServer);
    }

    public void Subscribe()
    {
      logger.Info("Start Subscribtion " + "ws://" + pushServer);
      ISubject<JToken> subject = channel.GetSubject<JToken>(session.UserKey);
      subscription = subject.Subscribe(x => MessageHandler(x));
      logger.Info("Successfully subscribe to " + "ws://" + pushServer);
    }

    public void Unsubscribe()
    {
      logger.Info("Start ending Subscribtion " + "ws://" + pushServer);

      subscription.Dispose();

      logger.Info("Successfully ending Subscribtion " + "ws://" + pushServer);
    }

    public void BuildChannelMonitor()
    {
      if (channel != null)
        this.Monitor = channel.GetMonitor();
    }

    private void MessageHandler(object obj)
    {
      logger.Info("Received push message");
      JavaScriptSerializer serializer = new JavaScriptSerializer();
      string jsonStr = obj.ToString();
      dynamic jsonDic = serializer.Deserialize<dynamic>(jsonStr);

      try
      {
        if ((jsonDic["namespace"] as string).Equals("user")) 
        {
          Dictionary<string, object> dataRecord = jsonDic["data"] as Dictionary<string, object>;
          VmosoTileDisplayRecord record = new VmosoTileDisplayRecord();
          record.character = "connect";
          record.isLoginNotif = true;
          record.actor = dataRecord.ContainsKey("displayName") ? dataRecord["displayName"] as string : string.Empty;
          record.iconSmall = dataRecord.ContainsKey("iconSmall") ? dataRecord["iconSmall"] as string : string.Empty;
          record.loginStatus = dataRecord.ContainsKey("loginStatus")
            ? dataRecord["loginStatus"] as string
            : string.Empty;

          if (OnReceiveMessage != null)
          {
            record.server = pushServer;
            OnReceiveMessage(this, new NotifierEventArgs(record, session));
          }
        }
        else if ((jsonDic["namespace"] as string).Equals("sparc"))
        {

          string targetRecordType = jsonDic["data"]["target"][0]["recordtype"];

          if (!targetRecordType.Equals("TaskRecord") && !targetRecordType.Equals("PostV2Record") &&
              !targetRecordType.Equals("FileRecord") && !targetRecordType.Equals("NoteV2Record")
              && !targetRecordType.Equals("FolderRecord") && !targetRecordType.Equals("LinkV2Record") 
              && !targetRecordType.Equals("UserObjectRecord"))
            return;

          Dictionary<string, object> pushData = jsonDic["data"];

          //if (targetRecordType.Equals("FileRecord") && pushData.ContainsKey("containers"))
          //  return;

          //if (targetRecordType.Equals("FolderRecord") && pushData.ContainsKey("containers"))
          //  return;
          VmosoTileDisplayRecord record = new VmosoTileDisplayRecord();
          record.character = "engage";

          Dictionary<string, object> targetRec = jsonDic["data"]["target"][0]["record"];

          record.type = !string.IsNullOrEmpty(targetRecordType) ? targetRecordType : "";

          if (record.type.Equals("TaskRecord"))
            record.taskType = targetRec.ContainsKey("taskType") ? targetRec["taskType"] as string : "";

          Dictionary<string, object> lastUpdater = targetRec.ContainsKey("lastUpdater")
            ? targetRec["lastUpdater"] as Dictionary<string, object>
            : new Dictionary<string, object>();
          object[] actors = pushData["actors"] as object[];
          Dictionary<string, object> actorDic = new Dictionary<string, object>();
          if (actors.Length > 0)
            actorDic = actors[0] as Dictionary<string, object>;

          Dictionary<string, object> actor = actorDic.ContainsKey("record")
            ? actorDic["record"] as Dictionary<string, object>
            : new Dictionary<string, object>();

          string actorKey = actor.ContainsKey("key") ? actor["key"] as string : "";

                    //if (actorKey.Equals(AuthData.authinfo.cred.who))
                    //{
                    //  return;
                    //}
                    //if (actorKey.Equals(AuthData.info.cred.who))


          //if (actorKey.Equals(session.UserKey) && (!targetRecordType.Equals("FolderRecord") ))
          //return;

          record.iconSmall = actor.ContainsKey("iconSmall") ? actor["iconSmall"] as string : "";
          record.isRegistered = actor.ContainsKey("isRegistered") ? (bool)actor["isRegistered"] : false;
          record.actorUserKey = actor.ContainsKey("key") ? actor["key"] as string : "";

          if (record.isRegistered)
          {
            record.actor = actor.ContainsKey("displayName") ? actor["displayName"] as string : "";
          }
          else
          {
            string firstName = actor["firstName"] as string;
            string lastName = actor["lastName"] as string;

            if (!string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(lastName))
            {
              if (!string.IsNullOrEmpty(firstName.Trim()))
              {
                record.actor += firstName[0];
              }

              if (!string.IsNullOrEmpty(lastName))
              {
                record.actor += string.IsNullOrEmpty(firstName) ? lastName[0] : ' ' + lastName[0];
              }
            }
            else
            {
              record.actor = actor.ContainsKey("displayName") ? actor["displayName"] as string : "";
            }
          }
          record.actor = actor.ContainsKey("displayName") ? actor["displayName"] as string : "";
          int timeupdated = pushData.ContainsKey("timestamp") ? Convert.ToInt32(pushData["timestamp"]) : 0;

          record.time = VmosoTimeHelper.ConvertTime(timeupdated);
          record.timestamp = timeupdated;

          if ((jsonDic["data"]["verb"] as string).Equals("create"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";

              if ((jsonDic["data"] as Dictionary<string, object>).ContainsKey("containers"))
              {

                Dictionary<string, object> containerRec = jsonDic["data"]["containers"][0]["record"];
                
                if (containerRec.ContainsKey("commentPID"))
                {
                  record.commentID = containerRec["commentPID"] as string;
                  record.contentKey = containerRec.ContainsKey("contentKey") ? containerRec["contentKey"] as string : "";
                  string text = containerRec.ContainsKey("text") ? containerRec["text"] as string : "";
                  record.text = StripeHtmlTag(text);
                  record.url = urlBuilder.CommentUrl(targetRecordType, containerRec);
                }
                else
                {
                  string containerRecordType = jsonDic["data"]["containers"][0]["recordtype"] as string;

                  if (containerRecordType.Equals("UserObjectRecord"))
                  {
                    string addUser = containerRec.ContainsKey("displayName")
                      ? containerRec["displayName"] as string
                      : "";
                    record.text = "Added User " + addUser;
                  }
                  else if (containerRecordType.Equals("FileRecord"))
                  {
                    string addFile = containerRec.ContainsKey("name") ? containerRec["name"] as string : "";
                    record.text = "Added Attachment " + addFile;
                  }
                  else if (containerRecordType.Equals("NoteV2Record"))
                  {
                    string addFile = containerRec.ContainsKey("title") ? containerRec["title"] as string : "";
                    record.text = "Added Attachment " + addFile;
                  }

                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
              }
              else
              {
                record.text = "Create";
                record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              }

              record.space = BuildTaskRecordSpace(record.actor);
            }
            else if (targetRecordType.Equals("PostV2Record"))
            {

              int elapsedTime = timeupdated - lastTs;
              lastTs = timeupdated;
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";

              record.space = FetchSpaceForRecord(targetRec);
              if (!(jsonDic["data"] as Dictionary<string, object>).ContainsKey("containers"))
              {
                record.text = "Create";
                record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              }
              else
              {
                Dictionary<string, object> containerRec = jsonDic["data"]["containers"][0]["record"];
                string containerRecordType = jsonDic["data"]["containers"][0]["recordtype"] as string;


                if (containerRecordType.Equals("FileRecord"))
                {
                  string recordText = " ";

                  if (containerRec.ContainsKey("name"))
                    recordText += containerRec["name"] as string;
                  else
                    recordText = "";

                  record.text = "Added Attachment" + recordText;
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
                else if (containerRecordType.Equals("NoteV2Record"))
                {
                  string recordText = " ";

                  if (containerRec.ContainsKey("title"))
                    recordText += containerRec["title"] as string;
                  else
                    recordText = "";

                  record.text = "Added Attachment" + recordText;
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
                else if (containerRecordType.Equals("FolderRecord"))
                {
                  record.text = "Create a Post";
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
                else if (containerRecordType.Equals("CommentV2Record"))
                {
                  record.commentID = containerRec.ContainsKey("commentPID") ? containerRec["commentPID"] as string : "";
                  string postCommentText = containerRec["text"] as string;

                  record.text = StripeHtmlTag(postCommentText);
                  record.url = urlBuilder.CommentUrl(targetRecordType, containerRec);
                }
                else
                {
                  string recordText = " ";

                  if (containerRec.ContainsKey("title"))
                    recordText += containerRec["title"] as string;
                  else
                    recordText = "";

                  record.text = "Added Attachment" + recordText;
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
              }
            }
            else if (targetRecordType.Equals("FileRecord"))
            {
              record.text = "Upload";
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
            }
            else if (targetRecordType.Equals("NoteV2Record"))
            {
              record.text = "Create";
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
            }
            else if (targetRecordType.Equals("FolderRecord"))
            {
              Dictionary<string, object> data = jsonDic["data"];
              

              if (data.ContainsKey("sparcsubtype") && (data["sparcsubtype"] as string).Equals("shareto") && data.ContainsKey("containers"))
              {
                string containerRecordType = jsonDic["data"]["containers"][0]["recordtype"] ;
                Dictionary<string, object> containerRec = jsonDic["data"]["containers"][0]["record"];
                

                record.text = "Share";
                record.space = FetchSpaceForRecord(containerRec);
                if (containerRec.ContainsKey("editor")) { 
                  Dictionary<string, object> editor = containerRec["editor"] as Dictionary<string, object>;
                  record.actor = editor["displayName"] as string;
                  if (containerRec.ContainsKey("title"))
                  {
                    record.title = containerRec["title"] as string;
                  }
                }
                else
                {
                  lastUpdater = containerRec["lastUpdater"] as Dictionary<string, object>;
                  record.actor = lastUpdater["displayName"] as string;
                  record.iconSmall = lastUpdater["iconSmall"] as string;
                  string destDisplayName = containerRec["displayName"] as string;
                  record.title = destDisplayName;
                  record.space = destDisplayName;
                }
                
                if (containerRecordType.Equals("LinkV2Record") )
                {
                  record.title = containerRec.ContainsKey("title") ? containerRec["title"] as string : "";
                }
                else if (containerRecordType.Equals("NoteV2Record"))
                {
                  record.title = containerRec.ContainsKey("title") ? containerRec["title"] as string : "";
                }
                else if (containerRecordType.Equals("FileRecord"))
                {
                  record.title = containerRec.ContainsKey("name") ? containerRec["name"] as string : "";
                }

                record.url = urlBuilder.NonCommentUrl(containerRecordType, containerRec);
                record.type = jsonDic["data"]["containers"][0]["recordtype"] as string;
              }
              else
              {
                return;
              }
              //else if (data.ContainsKey("sparcsubtype") && (data["sparcsubtype"] as string).Equals("posts"))
              //{
              //  record.text = "Create";
              //  if ((jsonDic["data"] as Dictionary<string, object>).ContainsKey("containers")){
              //    record.title = jsonDic["data"]["containers"][0]["record"]["title"] ;
              //    record.space = jsonDic["data"]["target"][0]["record"]["name"];
              //  }
              //}
            }
            
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("delete"))
          {
            if (targetRecordType.Equals("TaskRecord") || targetRecordType.Equals("PostV2Record") || targetRecordType.Equals("NoteV2Record") || targetRecordType.Equals("LinkV2Record") || targetRecordType.Equals("FolderRecord"))
            {
              Dictionary<string, object> dataDictionary = jsonDic["data"];
              record.title = (targetRecordType.Equals("TaskRecord") || targetRecordType.Equals("FolderRecord"))
                ? targetRec["name"] as string
                : targetRec["title"] as string;

              if (dataDictionary.ContainsKey("containers"))
              {
                Dictionary<string, object> containerRec = jsonDic["data"]["containers"][0]["record"];
                string containerRecordType = jsonDic["data"]["containers"][0]["recordtype"] as string;

                if (containerRecordType.Equals("UserObjectRecord"))
                {
                  string removeUser = containerRec.ContainsKey("displayName")
                    ? containerRec["displayName"] as string
                    : "";
                  record.text = "Remove User " + removeUser;
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
                else if (containerRecordType.Equals("FileRecord"))
                {
                  string removeFile = containerRec.ContainsKey("name") ? containerRec["name"] as string : "";
                  record.text = "Remove Attachment " + removeFile;
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
                else if (containerRecordType.Equals("NoteV2Record"))
                {
                  string removeFile = containerRec.ContainsKey("title") ? containerRec["title"] as string : "";
                  record.text = "Remove Attachment " + removeFile;
                  record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                }
                else if (containerRecordType.Equals("CommentV2Record"))
                {
                  string commentID = containerRec.ContainsKey("commentPID") ? containerRec["commentPID"] as string : "";

                  if (!string.IsNullOrEmpty(commentID))
                    record.text = "Delete Comment #" + commentID;
                  else
                    record.text = "Delete Comment";

                  record.url = urlBuilder.CommentUrl(targetRecordType, containerRec);
                }
                else if (containerRecordType.Equals("PostV2Record"))
                {
                  record.text = "Remove";
                }
              }
              else
              {
                record.text = "Delete";
                record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
                if (targetRecordType.Equals("LinkV2Record"))
                {
                  object[] tarDest = targetRec["destinations"] as object[];
                  if (tarDest.Count() > 0)
                  {
                    Dictionary<string, object> dest = tarDest[0] as Dictionary<string, object>;
                    record.space = dest["fullPath"] as string + "/" + dest["displayName"] as string;
                  }

                  record.title = targetRec["link"] as string;
                }
                else if (targetRecordType.Equals("FolderRecord"))
                {
                  object[] tarDest = targetRec["destinations"] as object[];
                  if (tarDest.Count() == 0)
                  {
                    return;
                  }
                  Dictionary<string, object> dest = tarDest[0] as Dictionary<string, object>;
                  record.space = dest["fullPath"] as string + "/" + dest["displayName"] as string;
                }
              }

              if (targetRecordType.Equals("TaskRecord"))
              {
                record.space = BuildTaskRecordSpace(record.actor);
              }
              else if (targetRecordType.Equals("PostV2Record") || targetRecordType.Equals("NoteV2Record"))
              {
                record.space = FetchSpaceForRecord(targetRec);
              }

            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("follow"))
          {
            if (targetRecordType.Equals("PostV2Record"))
            {
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";
              record.text = "Follow";
              record.space = FetchSpaceForRecord(targetRec);
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("unfollow"))
          {
            if (targetRecordType.Equals("PostV2Record"))
            {
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";
              record.text = "Unfollow";
              record.space = FetchSpaceForRecord(targetRec);
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("update"))
          {
            Dictionary<string, object> containerRec = null;

            if ((jsonDic["data"] as Dictionary<string, object>).ContainsKey("containers"))
            {
              containerRec = jsonDic["data"]["containers"][0]["record"];
            }

            if (targetRecordType.Equals("PostV2Record"))
            {
             
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";
              if (pushData.ContainsKey("containers"))
              {
                record.commentID = containerRec.ContainsKey("commentPID") ? containerRec["commentPID"] as string : "";
                record.text = containerRec.ContainsKey("text") ? StripeHtmlTag(containerRec["text"] as string) : "";
              }
              record.space = FetchSpaceForRecord(targetRec);
              record.url = urlBuilder.CommentUrl(targetRecordType, containerRec);
            }
            else if (targetRecordType.Equals("TaskRecord"))
            {
              if (pushData.ContainsKey("containers"))
              {
                record.commentID = containerRec.ContainsKey("commentPID") ? containerRec["commentPID"] as string : "";
                record.text = containerRec.ContainsKey("text") ? StripeHtmlTag(containerRec["text"] as string) : "";
              }

              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.url = urlBuilder.CommentUrl(targetRecordType, containerRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
            else if (targetRecordType.Equals("NoteV2Record") || targetRecordType.Equals("LinkV2Record"))
            {
              Dictionary<string, object> editor = jsonDic["data"]["target"][0]["record"]["editor"];
              record.actor = editor["displayName"] as string;
              record.text = "Edit";
              record.space = FetchSpaceForRecord(targetRec);
              if (string.IsNullOrEmpty(record.space))
              {
                record.space = "/Personal/";
              }
              
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
            }
            else if (targetRecordType.Equals("FolderRecord"))
            {
              record.title = targetRec["name"] as string;
              record.text = "Edit";
              record.contentKey = targetRec["key"] as string;
              record.space = targetRec["path"] + "/" + targetRec["displayName"];
            }

            if (containerRec == null)
            {
              if (targetRecordType.Equals("TaskRecord"))
              {
                string updateRecordType = jsonDic["data"]["target"][0]["record"]["taskType"] as string;
                if (updateRecordType.Equals("chat"))
                {
                  record.text = "Edit Chat";
                }
                else
                {
                  record.text = "Edit Task";
                }
              }
              else if (targetRecordType.Equals("PostV2Record"))
              {
                record.text = "Edit Post";
              }
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("close"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Close";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("complete"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Complete";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("undelete"))
          {
            Dictionary<string, object> containerRec = jsonDic["data"]["containers"][0]["record"];
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.space = BuildTaskRecordSpace(record.actor);
            }
            else if (targetRecordType.Equals("PostV2Record"))
            {
              record.title = targetRec.ContainsKey("title") ? targetRec["title"] as string : "";
            }
            record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";

            string commentID = containerRec.ContainsKey("commentPID") ? containerRec["commentPID"] as string : "";
            record.commentID = containerRec.ContainsKey("commentPID") ? containerRec["commentPID"] as string : "";
            string text = containerRec.ContainsKey("text") ? containerRec["text"] as string : "";

            record.text = StripeHtmlTag(text);
            record.url = urlBuilder.CommentUrl(targetRecordType, containerRec);
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("open"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Open";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("suspend"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Suspend";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("resume"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Resume";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("archive"))
          {
            if (targetRecordType.Equals("TaskRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Archive";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = BuildTaskRecordSpace(record.actor);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("rename"))
          {
            if (targetRecordType.Equals("FileRecord"))
            {
              record.title = targetRec.ContainsKey("name") ? targetRec["name"] as string : "";
              record.contentKey = targetRec.ContainsKey("key") ? targetRec["key"] as string : "";
              record.text = "Edit";
              record.url = urlBuilder.NonCommentUrl(targetRecordType, targetRec);
              record.space = FetchSpaceForRecord(targetRec);
            }
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("inviteconnectedcontact"))
          {
            record.text = "Invite as Connected";
            record.character = "connect";
            record.title = "Invitation";
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("join"))
          {
            
            if (((jsonDic["data"]["sparcsubtype"]) as string).Equals("admin")
              || (jsonDic["data"]["containers"][0]["recordtype"] as string).Equals("FolderRecord")
              )
            {
              return;
            }
            string displayName = jsonDic["data"]["containers"][0]["record"]["displayName"] as string;
            record.space = jsonDic["data"]["target"][0]["record"]["displayName"] as string;
            record.title = jsonDic["data"]["target"][0]["record"]["displayName"] as string;
            record.text = "Add " + displayName;
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("leave"))
          {
           
            string displayName = jsonDic["data"]["containers"][0]["record"]["displayName"] as string;
            record.space = jsonDic["data"]["target"][0]["record"]["displayName"] as string;
            record.title = jsonDic["data"]["target"][0]["record"]["displayName"] as string;
            record.text = "Remove user " + displayName;
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("accept"))
          {
            record.title = jsonDic["data"]["target"][0]["record"]["name"] as string;
            record.space = "/Personal/";
            record.text = "Accept";
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("decline"))
          {
            record.title = jsonDic["data"]["target"][0]["record"]["name"] as string;
            record.space = "/Personal/";
            record.text = "Decline";
          }
          else if ((jsonDic["data"]["verb"] as string).Equals("invitetrustedcontact"))
          {
            record.text = "Invite as Trusted";
            record.character = "connect";
            record.title = "Invitation";
          }

          if (targetRec.ContainsKey("key"))
          {
            record.contentKey = targetRec["key"] as string;
          }

          if (!string.IsNullOrEmpty(record.contentKey))
          {

            StreamApi streamApi = new StreamApi(session.GetApiClient());
            GetTileCountsResult tileCountsResult = streamApi.GetTileCounts(record.contentKey);
            //string countStr = VmosoHttpRequest.Get("svc/stream/" + record.contentKey + "/badgecounts/get", vmosoUri, string.Empty, VmosoCookies);
            if(tileCountsResult.Hdr.Rc==0)
            {
                    SparcCountRecord sparcCountRecord = tileCountsResult.Counts;
                    record.unreadCount = (int)sparcCountRecord.TotalNewCount;
            }
          }

            if (!string.IsNullOrEmpty(record.contentKey))
            {
                Record rule = getObjectRule(record.contentKey);
                if (rule != null)
                {
                    dynamic dynObj = JsonConvert.DeserializeObject(rule.Json);
                    if (dynObj.record.hideFlag.Equals("yes"))
                    {
                        return;
                    }
                }
            }

          if (OnReceiveMessage != null)
          {
            record.server = pushServer;
            OnReceiveMessage(this, new NotifierEventArgs(record,session));
          }
        }
        else if ((jsonDic["namespace"] as string).Equals("myPage"))
        {
          VmosoCountDisplayRecord countDisplayRecord = new VmosoCountDisplayRecord();

          int totalCount = 0;

          Dictionary<string, object> dataRecord = jsonDic["data"] as Dictionary<string, object>;
          if(dataRecord.ContainsKey("EANUT"))
            {
                object vEANut = dataRecord["EANUT"];
                if (vEANut is int) totalCount += (int)vEANut;
            }

            if (dataRecord.ContainsKey("CANUT"))
            {
                object vCANut = dataRecord["CANUT"];
                if (vCANut is int) totalCount += (int)vCANut;
            }
            if (dataRecord.ContainsKey("OANUT"))
            {
                object vOANut = dataRecord["OANUT"];
                if (vOANut is int) totalCount += (int)vOANut;
            }

          countDisplayRecord.TotalCount = totalCount.ToString();

          if (OnReceiveCount != null)
          {
            OnReceiveCount(this, new CountEventArgs(countDisplayRecord));
          }
        }

      }
      catch (Exception e)
      {
        return;
      }

    }

    protected string GetMd5Hash(MD5 md5Hash, string input)
    {
      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      StringBuilder sb = new StringBuilder();

      foreach (byte b in data)
      {
        sb.Append(b.ToString("x2"));
      }

      return sb.ToString();
    }

    protected string StripeHtmlTag(string html)
    {
      string str = html;

      string pattern = @"<[^>]*(>|$)";
      Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
      MatchCollection mc = regex.Matches(str);

      IEnumerator e = mc.GetEnumerator();
      StringBuilder sBuilder = new StringBuilder();

      while (e.MoveNext())
      {
        Match match = e.Current as Match;
        str = str.Replace(match.Value, "");
      }
      str = str.Trim();

      pattern = @"[\s\r\n]+";
      regex = new Regex(pattern, RegexOptions.IgnoreCase);
      mc = regex.Matches(str);
      e = mc.GetEnumerator();
      while (e.MoveNext())
      {
        Match match = e.Current as Match;
        str = str.Replace(match.Value, " ");
      }

      str = str.Trim();

      return str;
    }

    protected string FetchSpaceForRecord(object obj)
    {
      Dictionary<string, object> record = obj as Dictionary<string, object>;

      object[] tarDest = record.ContainsKey("destinations") ? record["destinations"] as object[] : new object[] { };

      if (tarDest.Count() > 0)
      {
        Dictionary<string, object> tarDic = tarDest[0] as Dictionary<string, object>;
        string fullPath = tarDic.ContainsKey("fullPath") ? tarDic["fullPath"] as string : "";
        string hp = tarDic.ContainsKey("displayName") ? tarDic["displayName"] as string : "";
        return fullPath + "/" + hp;
      }
      else
      {
        return "";
      }
    }

    protected string BuildTaskRecordSpace(string creator)
    {
      return (!string.IsNullOrEmpty(creator)) ? "/" + creator.Trim() + "/" + "Personal" + "/" : string.Empty;
    }

    protected Record getObjectRule(string key)
    {
      if (string.IsNullOrEmpty(key))
      {
        return null;
      }

            /*System.Net.ServicePointManager.ServerCertificateValidationCallback +=
               (se, cert, chain, sslerror) =>
               {
                 return true;
               };
            */

            StreamApi streamApi = new StreamApi(session.GetApiClient());
            StreamOptionsRecord optionsRecord = new StreamOptionsRecord();
            optionsRecord.ObjectKey = key;
            CheckRuleResult result = streamApi.CheckRule(optionsRecord.ToJson(), null, null);
            if(result.Hdr.Rc==0)
            {
                return result.Stream;
            } else
            {
                return null;
            }

    }
  }
}
