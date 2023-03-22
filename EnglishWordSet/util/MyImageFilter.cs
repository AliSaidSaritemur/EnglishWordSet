using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace EnglishWordSet.util
{
    internal class MyImageFilter
    {
        private System.Timers.Timer imageFilterTimer;
        private Image _image;
        private PictureBox _pictureBoxToBeEffect;
        private Image GreenFilter(Image image)
        {
            return FilterImage(image, Color.Green);
        }
        private Image RedFilter(Image image)
        {
            return FilterImage(image, Color.Red);
        }
        private void SetTimer()
        {
            imageFilterTimer = new System.Timers.Timer(500);
            imageFilterTimer.Elapsed += OnTimedEvent;
            imageFilterTimer.AutoReset = true;
            imageFilterTimer.Enabled = true;
        }
        public void GreenFilterToImageEffect(PictureBox pictureBoxToBeEffect)
        {
            if (imageFilterTimer != null)
            {
                _pictureBoxToBeEffect.Image = _image;
                imageFilterTimer.Close();
            }
            _pictureBoxToBeEffect = pictureBoxToBeEffect;
            _image = pictureBoxToBeEffect.Image;
            pictureBoxToBeEffect.Image = GreenFilter(_image);
            SetTimer();
        }
        public void RedFilterToImageEffect(PictureBox pictureBoxToBeEffect)
        {
            if (imageFilterTimer != null)
            {
                _pictureBoxToBeEffect.Image = _image;
                imageFilterTimer.Close();
            }
            _pictureBoxToBeEffect = pictureBoxToBeEffect;
            _image = pictureBoxToBeEffect.Image;
            pictureBoxToBeEffect.Image = RedFilter(pictureBoxToBeEffect.Image);
            SetTimer();
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            _pictureBoxToBeEffect.Image = _image;

        }
        private Image FilterImage(Image inputImage, Color color)
        {
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);
            Graphics imageGraphics = Graphics.FromImage(outputImage);
            imageGraphics.DrawImage(inputImage, 0, 0);
            imageGraphics.FillRectangle(new SolidBrush(Color.FromArgb(100, color)), 0, 0, outputImage.Width, outputImage.Height);
            return outputImage;
        }
    }
}
