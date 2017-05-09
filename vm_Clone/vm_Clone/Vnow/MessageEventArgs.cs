using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VmosoBKW;
using VmosoApiClient.Client;

///
///Self-Defined Event Args and Delegates
///
namespace VmosoPushClient
{
  #region NotifierEventHandler and NotifierEventArgs
  public delegate void NotifierEventHandler(object obj, NotifierEventArgs e);

  public class NotifierEventArgs : EventArgs
  {
    public VmosoTileDisplayRecord DisplayRecord { get; set; }
    public VmosoSession Session { get; set; }

    public NotifierEventArgs(VmosoTileDisplayRecord displayRecord, VmosoSession session)
    {
      this.DisplayRecord = displayRecord;
      this.Session = session;
    }
  }
  #endregion

  #region CountEventHandler and CountEventArgs

  public delegate void CountEventHandler(object obj, CountEventArgs e);

  public class CountEventArgs : EventArgs
  {
    public VmosoCountDisplayRecord CountDisplayRecord { get; set; }

    public CountEventArgs(VmosoCountDisplayRecord countDisplayrecord)
    {
      this.CountDisplayRecord = countDisplayrecord;
    }
  }

  #endregion


}
