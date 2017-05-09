using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VmosoBKW
{
  public class VmosoTimeHelper
  {
    public static string ConvertTime(double timestamp)
    {
      if (timestamp == 0)
        return "";

      DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
      dtDateTime = dtDateTime.AddSeconds(timestamp);
      TimeSpan elapsed = DateTime.UtcNow.Subtract(dtDateTime);

      if (elapsed.TotalDays >= 1)
      {
        double day = Math.Truncate(elapsed.TotalDays);
        string dayStr = day == 1 ? "day " : "days ";

        return day + " " + dayStr + "ago";
      }
      else if (elapsed.TotalHours >= 1)
      {
        double hour = Math.Truncate(elapsed.TotalHours);
        string hourStr = hour == 1 ? "hour " : "hours ";

        return hour + " " + hourStr + "ago";
      }
      else if (elapsed.TotalMinutes >= 1)
      {
        double minute = Math.Truncate(elapsed.TotalMinutes);
        string minStr = minute == 1 ? "minute " : "minutes ";

        return minute + " " + minStr + "ago";
      }
      else
      {
        return "Just Now";
      }
    }
  }
}
