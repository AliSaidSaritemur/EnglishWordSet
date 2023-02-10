using System;
using System.Collections.Generic;
using System.Drawing;
using Unsplasharp;
using System.Windows.Forms;
using EnglishWordSet.RefactoredStaticFuncs;
using LogAccess;
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
            if (lastSearchedWord == searchedWord&&client!=null)
            {
                photos = lastPhotos;
                photonum = (photonum < photos.Count-1) ?++photonum:0;
            }
            else
            {
                client = new UnsplasharpClient(Settings.SettingsInfo.Default.UnsplashAPIKey) ?? client;
                photos = await client.SearchPhotos(searchedWord.ToUpper());
                photos.AddRange(await client.SearchPhotos(searchedWord.ToLower()));        
                RefreshSystem(searchedWord, photos);                           
            }

            if (photos.Count < 2)
            {
                pbLearned.Image = Properties.Resources.noImageAvaIlable;
                Photo photosErrorCheck = await client.GetRandomPhoto();
                 if (string.IsNullOrEmpty(photosErrorCheck.Urls.Regular))
                {
                    Logs.Error("Unsplash API Key is failed to start ");
                    client=null;
                }
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
