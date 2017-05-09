using System.Collections.Generic;

namespace VmosoBKW
{
  public class DirectUrlBuilder
  {
    private readonly string defaultDirectUrl = "/myplace";
    //private readonly string commentsUrl = "/comments";
    private readonly string commentsUrl = "/c";
    //private readonly string taskUrl = "/tasks";
    private readonly string taskUrl = "/t";
    //private readonly string postUrl = "/posts";
    private readonly string postUrl = "/p";
    //private readonly string fileUrl = "/files";
    private readonly string fileUrl = "/f";
    //private readonly string noteUrl = "/documents";
    private readonly string noteUrl = "/d";
    private readonly string documentUrl = "/l";
    private readonly string linkurl = "/l";
    private string host;

    public DirectUrlBuilder(string host)
    {
      this.host = host;
    }

    public string NonCommentUrl(string targetRecordType, Dictionary<string, object> recordOfTarget)
    {
      if (string.IsNullOrEmpty(targetRecordType) || recordOfTarget == null)
        return host + defaultDirectUrl;

      string url = host + defaultDirectUrl;

      if (recordOfTarget.ContainsKey("key") && !string.IsNullOrEmpty(recordOfTarget["key"] as string))
      {
        switch (targetRecordType)
        {
          case "TaskRecord":
            url = host + taskUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "PostV2Record":
            url = host + postUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "FileRecord":
            url = host + fileUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "LinkV2Record":
            url = host + linkurl + "/" + recordOfTarget["key"] as string;
            break;
          case "NoteV2Record":
            url = host + noteUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "FolderRecord":
            if (recordOfTarget.ContainsKey("type") )
            {
              string recordType = recordOfTarget["type"] as string;
              if (recordType.Equals("file"))
              {
                url = host + fileUrl + "/" + recordOfTarget["key"] as string;
              }
              else if (recordType.Equals("document"))
              {
                url = host + documentUrl + "/" + recordOfTarget["key"] as string;
              }
            }
           
            break;
          default:
            url = host + defaultDirectUrl;
            break;
        }
      }
      else
      {
        url = host + defaultDirectUrl;
      }
      
      return url;
    }

    public string NonCommentUrlOld(string targetRecordType, Dictionary<string, object> recordOfTarget)
    {
      if (string.IsNullOrEmpty(targetRecordType))
        return host + defaultDirectUrl;

      string url = string.Empty;

      if (recordOfTarget.ContainsKey("key") && !string.IsNullOrEmpty(recordOfTarget["key"] as string))
      {
        switch (targetRecordType)
        {
          case "TaskRecord":
            url = host + taskUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "PostV2Record":
            url = host + postUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "FileRecord":
            url = host + fileUrl + "/" + recordOfTarget["key"] as string;
            break;
          case "NoteV2Record":
            url = host + noteUrl + "/" + recordOfTarget["key"] as string;
            break;
          default:
            url = host + defaultDirectUrl;
            break;
        }
      }
      else
      {
        url = host + defaultDirectUrl;
      }

      return url;
    }

    public string CommentUrlOld(string targetRecordType, Dictionary<string, object> recordOfContainers)
    {
      if (string.IsNullOrEmpty(targetRecordType) || recordOfContainers == null)
        return host + defaultDirectUrl;

      string url = string.Empty;

      string commentID = recordOfContainers.ContainsKey("commentPID") ? recordOfContainers["commentPID"] as string : "";
      string contentKey = recordOfContainers.ContainsKey("contentKey") ? recordOfContainers["contentKey"] as string : "";
      

      if (!string.IsNullOrEmpty(commentID) && !string.IsNullOrEmpty(contentKey))
      {
        switch (targetRecordType)
        {
          case "PostV2Record":
            url = host + commentsUrl + postUrl + "/" + contentKey + "/" + commentID;
            break;
          case "TaskRecord":
            url = host + commentsUrl + taskUrl + "/" + contentKey + "/" + commentID;
            break;
          default:
            url = host + defaultDirectUrl;
            break;
        }
      }
      else
      {
        url = host + defaultDirectUrl;
      }

      return url;
    }

    public string CommentUrl(string targetRecordType, Dictionary<string, object> recordOfContainers)
    {
      if (string.IsNullOrEmpty(targetRecordType) || recordOfContainers == null)
        return host + defaultDirectUrl;

      string url = string.Empty;

      string commentID = recordOfContainers.ContainsKey("commentPID") ? recordOfContainers["commentPID"] as string : "";
      string contentKey = recordOfContainers.ContainsKey("contentKey") ? recordOfContainers["contentKey"] as string : "";


      if (!string.IsNullOrEmpty(commentID) && !string.IsNullOrEmpty(contentKey))
      {
        switch (targetRecordType)
        {
          case "PostV2Record":
            //url = host + commentsUrl + postUrl + "/" + contentKey + "/" + commentID;
            url = host + postUrl + "/" + contentKey + commentsUrl + "/" + commentID;
            break;
          case "TaskRecord":
            //url = host + commentsUrl + taskUrl + "/" + contentKey + "/" + commentID;
            url = host + taskUrl + "/" + contentKey + commentsUrl + "/" + commentID;
            break;
          default:
            url = host + defaultDirectUrl;
            break;
        }
      }
      else
      {
        url = host + defaultDirectUrl;
      }

      return url;
    }
  }
}
