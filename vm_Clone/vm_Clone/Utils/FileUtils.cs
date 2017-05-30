using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vm_Clone
{
    class FileUtils
    {

        static string[] SIZES = { "B", "KB", "MB", "GB" };

        static public String GetStringSize(double len)
        {
            
            int order = 0;
            while (len >= 1024 && ++order < SIZES.Length)
            {
                len = len / 1024;
            }

            return String.Format("{0:0.##} {1}", len, SIZES[order]);
        }
    }
}
