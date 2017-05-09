using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Web.Script.Serialization;
using System.IO;

namespace VmosoBKW.Cache
{
  public class VmosoImageCache
  {
    private readonly string defalutCacheFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/" + "BroadVision" + "/Cache";
    private readonly string defaultCacheFile = "File";

    private string cacheFolder;
    private string cacheFileName;

    public VmosoImageCache()
    {
      this.cacheFolder = defalutCacheFolder;
      this.cacheFileName = defaultCacheFile;
    }

    public void SetCacheFileLocation(string path)
    {
      this.cacheFolder = path;
    }

    public string GetCacheFileLocation()
    {
      return this.cacheFolder;
    }

    public void SaveObject(object obj, string fileName)
    {
      if (string.IsNullOrEmpty(cacheFolder))
        cacheFolder = defalutCacheFolder;

      if (string.IsNullOrEmpty(fileName))
        fileName = defaultCacheFile;

      string cachePath = cacheFolder + "/" + fileName;

      if (!Directory.Exists(cacheFolder))
        Directory.CreateDirectory(cacheFolder);

      if (obj.GetType() == typeof(Image) || obj.GetType() == typeof(Bitmap))
      {
        Image image = (Image)obj;
        image.Save(cachePath);
      }
    }

    public object GetObject(string fileName)
    {
      if (string.IsNullOrEmpty(cacheFolder))
        cacheFolder = defalutCacheFolder;

      if (string.IsNullOrEmpty(fileName))
        fileName = defaultCacheFile;

      string cachePath = cacheFolder + "/" + fileName;

      if (!Directory.Exists(cacheFolder) || !File.Exists(cachePath))
        return null;

      if (fileName.EndsWith(".png"))
      {
        return Image.FromFile(cachePath);
      }
      else
      {
        return null;
      }
    }
  }
}
