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
        private int photonum=0;
        public async void getImageWithWord(PictureBox pbLearned,String searchedWord)
        {
            List<Unsplasharp.Models.Photo> photos;
            if (searchedWord == null)return;
            else { }
            if (lastSearchedWord == searchedWord)
            {
                photos = lastPhotos;
                photonum = (photonum < photos.Count-1) ?++photonum:0;
            }
            else
            {
                client = new UnsplasharpClient("zbUIVrp4QpDLHjJjhV4gSE1lAniC20DXwQsDkMa68Ws") ?? client;
                photos = await client.SearchPhotos(searchedWord);
                RefreshSystem(searchedWord, photos);
            }

            if (photos.Count < 2)
            {
                pbLearned.Image = Properties.Resources.noImageAvaIlable;
                return;
            }

            var nowPhoto = photos[photonum];
            Image img = TypeConverter.ConverterURLtoImage(nowPhoto.Urls.Regular);
            pbLearned.Image = img;
        }

        private void RefreshSystem(string searchedWord, List<Unsplasharp.Models.Photo> photos)
        {
            lastSearchedWord = searchedWord;
            lastPhotos = photos;
            photonum = 0;
        }
    } 
}
