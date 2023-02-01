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

namespace EnglishWordSet.MyTools
{
    public class UnsplashImagesTransaction
    {

        public async void getImageWithWord(PictureBox pbLearned,String searchedWord)
        {
            if (searchedWord == null)return;

         var client = new UnsplasharpClient("YOUR API KEY");
            var randomPhotosFromQuery = await client.SearchPhotos(searchedWord);

            if (randomPhotosFromQuery.Count < 2) {
                pbLearned.Image = Properties.Resources.noImageAvaIlable;
                return;
            }
       

            Random rnd = new Random();
            var photos =  randomPhotosFromQuery[rnd.Next(randomPhotosFromQuery.Count-1)];


            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photos.Urls.Regular);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);

            pbLearned.Image = img;
        }

    }
   
}
