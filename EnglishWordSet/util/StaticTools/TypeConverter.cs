using System.Drawing;
using System.IO;
using System.Net;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    internal static class TypeConverter
    {
        static WebClient wc;
        public static Image ConverterURLtoImage(string url)
        {
            wc ??= new();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}
