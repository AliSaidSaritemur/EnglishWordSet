using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyImageFilter
    {
        private static System.Timers.Timer imageFilterTimer;
        private static Image _image;
        private static PictureBox _pictureBoxToBeEffect;
        private static Image GreenFilter (Image image)
        {
            return FilterImage(image,Color.Green);
        }
        private static Image RedFilter(Image image)
        {
            return FilterImage(image, Color.Red);
        }
        private static void SetTimer()
        {
            imageFilterTimer = new System.Timers.Timer(500);
            imageFilterTimer.Elapsed += OnTimedEvent;
            imageFilterTimer.AutoReset = true;
            imageFilterTimer.Enabled = true;
        }
        public static void GreenFilterToImageEffect(PictureBox pictureBoxToBeEffect)
        {
            _pictureBoxToBeEffect=pictureBoxToBeEffect;
            _image = pictureBoxToBeEffect.Image;
            pictureBoxToBeEffect.Image = GreenFilter(_image);
            SetTimer();
        }
        public static void RedFilterToImageEffect(PictureBox pictureBoxToBeEffect)
        {
            _pictureBoxToBeEffect = pictureBoxToBeEffect;
            _image = pictureBoxToBeEffect.Image;
            pictureBoxToBeEffect.Image = RedFilter(_image);
            SetTimer();
        }
        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _pictureBoxToBeEffect.Image = _image;
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
