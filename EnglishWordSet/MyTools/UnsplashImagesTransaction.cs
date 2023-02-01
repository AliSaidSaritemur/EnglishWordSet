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
         var client = new UnsplasharpClient("YOUR API KEY");
         
         var randomPhotosFromQuery = await client.GetRandomPhoto(count: 1, query: searchedWord);

           var photos =  randomPhotosFromQuery[0];


            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(photos.Urls.Regular);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

            pbLearned.Image = img;
         //   var listPhotos =  client.ListPhotos();
         //   var downloadLink =  client.GetPhotoDownloadLink(listPhotos[0].Id);


            string fetchUrl = "https://api.unsplash.com/search/photos/?client_id=zbUIVrp4QpDLHjJjhV4gSE1lAniC20DXwQsDkMa68Ws&per_page=1&page=1&query=leon";
          
        }

    }
   
}
