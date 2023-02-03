using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using Unsplasharp;
using Phaber.Unsplash.Entities;
using System.Security.Policy;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Media;
using Phaber.Unsplash;
using System.Windows.Forms;
using EnglishWordSet.RefactoredStaticFuncs;
using System.IO;
using Unsplasharp.Models;

namespace EnglishWordSet.MyTools
{
    public class UnsplashImagesTransaction
    {

        private string lastSearchedWord;
        private  List<Unsplasharp.Models.Photo> lastPhotos;
        private UnsplasharpClient client;
        private Image lastImage;
        Random rnd=new Random();
        public async void getImageWithWord(PictureBox pbLearned,String searchedWord)
        {
            List<Unsplasharp.Models.Photo> photos;
            if (searchedWord == null)return;
            else { }
            if (lastSearchedWord == searchedWord)
            {
                photos = lastPhotos;
            }
            else
            {
                client = new UnsplasharpClient("Your API Key") ?? client;
                photos = await client.SearchPhotos(searchedWord);
                lastSearchedWord = searchedWord;
                lastPhotos = photos;
            }

            if (photos.Count < 2)
            {
                pbLearned.Image = Properties.Resources.noImageAvaIlable;
                return;
            }

            Image img;

            do
            {
                img = GetRandomImageFromArray(photos);
            } while (lastImage!= null &&TypeComparator.ImageCompare(img,lastImage));

            pbLearned.Image,lastImage = img;
        }

        private Image GetRandomImageFromArray(List<Unsplasharp.Models.Photo> photos)
        {
            var photo = photos[rnd.Next(photos.Count - 1)];
            var img = TypeConverter.ConverterURLtoImage(photo.Urls.Regular);
            return img;
        }   
    }
   
}
