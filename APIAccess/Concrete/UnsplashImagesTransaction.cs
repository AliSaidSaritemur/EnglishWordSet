﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Unsplasharp;
using LogAccess;
using Unsplasharp.Models;
using LogAccess.services;
using APIAccess.Abstract;

namespace APIAccess.Concrete
{
    public class UnsplashImagesTransaction : UnsplashAPIService
    {
        private string lastSearchedWord;
        private  List<Unsplasharp.Models.Photo> lastPhotos;
        private UnsplasharpClient client;
        private int photonum=0;
        public async Task<string> getImageWithWord(String searchedWord)
        {
            List<Unsplasharp.Models.Photo> photos;
            if (searchedWord == null)return null;
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
                Photo photosErrorCheck = await client.GetRandomPhoto();
                 if (string.IsNullOrEmpty(photosErrorCheck.Urls.Regular))
                {
                    AddLog.systemLogs.Error("Unsplash API Key is failed to start ");
                    client=null;
                }
                return null;
            }

            var nowPhoto = photos[photonum];
            return nowPhoto.Urls.Regular;
        }

        private void RefreshSystem(string searchedWord, List<Unsplasharp.Models.Photo> photos)
        {
            lastSearchedWord = searchedWord;
            lastPhotos = photos;
            photonum = 0;
        }
    } 
}
