using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyImageFilter
    {

        public static Image GreenFilter (Image image)
        {
            return FilterImage(image,Color.Green);
        }
        public static Image RedFilter(Image image)
        {
            return FilterImage(image, Color.Red);
        }


        private static  Image FilterImage(Image inputImage,Color color){
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);
            Graphics imageGraphics = Graphics.FromImage(outputImage);
            imageGraphics.DrawImage(inputImage, 0, 0);
            imageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(100, color)), 0, 0, outputImage.Width, outputImage.Height);
            return outputImage; 
        }
    }
}
