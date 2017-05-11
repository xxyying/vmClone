using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vm_Clone
{
  public class VmosoTileDisplayRecord
  {
    public string title { get; set; }
    public string contentKey { get; set; }
    public string iconSmall { get; set; }
    public string commentID { get; set; }
    public string text { get; set; }
    public string type { get; set; }
    public string time { get; set; }
    public string space { get; set; }
    public string actor { get; set; }
    public string actorUserKey { get; set; }
    public string taskType { get; set; }
    public string server { get; set; }
    public string url { get; set; }
    public string loginStatus { get; set; }
    public bool isLoginNotif { get; set; }
    public string character { get; set; }
    public int unreadCount { get; set; }
    public double timestamp { get; set; }
    public bool isRegistered { get; set; }
  }
}
