using System.Drawing;
using System.IO;
using System.Net;

namespace Util
{
    public static class TypeConverter
    {
        static WebClient wc = new();
        public static Image ConverterURLtoImage(string url)
        {         
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}
