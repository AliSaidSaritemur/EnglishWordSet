using System;
using System.Drawing;
using System.IO;


namespace EnglishWordSet.RefactoredStaticFuncs
{
    internal static class TypeComparator
    {
        public static bool ImageCompare(Image image1, Image image2)
        {
            byte[] image1Bytes;
            byte[] image2Bytes;

            using (var mstream = new MemoryStream())
            {
                image1.Save(mstream, image1.RawFormat);
                image1Bytes = mstream.ToArray();
            }

            using (var mstream = new MemoryStream())
            {
                image2.Save(mstream, image2.RawFormat);
                image2Bytes = mstream.ToArray();
            }

            var image164 = Convert.ToBase64String(image1Bytes);
            var image264 = Convert.ToBase64String(image2Bytes);

            return string.Equals(image164, image264);
        }
    }
}
