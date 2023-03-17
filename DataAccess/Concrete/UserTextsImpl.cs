using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserTextsImpl:IUserTextsService
    {
        private WordContext context = MyDBTransactions.GetContext();

        public void AddToConvertedWords(string convertedWords, string UserName)
        {
            UserTexts userTexts = context._UserTexts.FirstOrDefault(I => I.UserName == UserName);
            userTexts.LastConvertedWords = convertedWords;
            userTexts.SavedConvertedWords = convertedWords +"\n"+ userTexts.SavedConvertedWords;
            context.SaveChanges();
        }

        public void AddToTrashbox(string wrongWord, string UserName)
        {
            UserTexts userTexts = context._UserTexts.FirstOrDefault(I => I.UserName == UserName);
            userTexts.TrashBox= wrongWord+"\n"+userTexts.TrashBox;
            context.SaveChanges();
        }

        public string GetConvertedWords(string UserName)
        {
            UserTexts userTexts = context._UserTexts.FirstOrDefault(I => I.UserName == UserName);
            return userTexts.SavedConvertedWords;
        }

        public string GetLastConvertedWords(string UserName)
        {
            UserTexts userTexts = context._UserTexts.FirstOrDefault(I => I.UserName == UserName);
            return userTexts.LastConvertedWords;
        }

        public string GetTrashBoxText(string UserName)
        {
            UserTexts userTexts = context._UserTexts.FirstOrDefault(I => I.UserName == UserName);
            return userTexts.TrashBox;
        }

        public void UpdateToTrashBox(string updatedVersion, string UserName)
        {
            UserTexts userTexts = context._UserTexts.FirstOrDefault(I => I.UserName == UserName);
            userTexts.TrashBox = updatedVersion;
            context.SaveChanges();
        }
    }
}
