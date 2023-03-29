using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Extensions;
namespace DataAccess.Concrete
{
    public class TrWordImpl : ITrWordService
    {
        private WordContext context = MyDBTransactions.GetContext();

        public void AddWtithoutLevel(string wordTr, string wordEng, string userName)
        {
            if (IsThere(wordTr, userName))
                return;

            context.TrWords.Add(new TrWord { English = wordEng, Turkish = wordTr,UserName= userName });
            context.SaveChanges();
        }

        public void CheckWordsEnglishIfIsTrueIncLevelOrDescLevel(string trWord, string wordEng, string UserName)
        {
            if (string.IsNullOrEmpty(trWord) || string.IsNullOrEmpty(wordEng))
                return;

            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == trWord && I.UserName == UserName);
            trWordToBeCheck.level = trWordToBeCheck.English == wordEng ? trWordToBeCheck.level + 1 : 
                trWordToBeCheck.level>1 ? trWordToBeCheck.level-1:trWordToBeCheck.level;
            context.SaveChanges();
        }

        public bool CheckWordsEnglishMeaning(string trWord, string wordEng, string UserName)
        {
            if (string.IsNullOrEmpty(trWord) || string.IsNullOrEmpty(wordEng)||!IsThere(trWord, UserName))
                return false;

            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == trWord && I.UserName == UserName);
           return trWordToBeCheck.English == wordEng;
        }

        public void DescWordLevel(string trWord, string UserName)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == trWord && I.UserName == UserName);
            trWordToBeCheck.level--;
            context.SaveChanges();
        }

        public string GetEnglishMeaning(string wordTr, string UserName)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == wordTr && I.UserName == UserName);
            return trWordToBeCheck.English;
        }

        public int GetMaxLevel( string UserName)
        {
            if (context.TrWords.Where(I => I.UserName == UserName).Count() < 1)
                return 0;

            int maxLevel = context.TrWords.Where(I=> I.UserName == UserName).Max(p => p.level);
            return maxLevel;
        }

        public string GetTurkishWordAndLevelsAsStringText( string UserName)
        {
            string result="";
            for(int i =1;i<= GetMaxLevel(UserName);i++)
            {
                if (GetTurksihWordsWithLevel(i, UserName).Count < 1)
                    continue;

                 result += $"{i}.";
                foreach (var turkishWordToBeAddString in GetTurksihWordsWithLevel(i, UserName))
                {
                    result += "\n" + turkishWordToBeAddString.Turkish+" "+Settings.SettingsInfo.Default.SeparatorMark;
                }
                result += "\n";
            }
            return result;

        }

        public List<TrWord> GetTurksihWordsWithLevel(int level, string UserName)
        {
            List<TrWord> trWords = context.TrWords.Where(I=>I.level==level && I.UserName == UserName).ToList();
            return trWords;
        }

        public int GetWordLevel(string trWord, string UserName)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == trWord && I.UserName == UserName);
            return trWordToBeCheck.level;
        }

        public void IncWordLevel(string trWord, string UserName)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == trWord && I.UserName == UserName);
            trWordToBeCheck.level = trWordToBeCheck.level+1;
            context.SaveChanges();
        }

        public bool IsThere(string wordTr, string UserName)
        {
            TrWord nword = context.TrWords.FirstOrDefault(I => I.Turkish == wordTr&&I.UserName==UserName);
            return nword != null;
        }

        public void RemoveWordsWithLevel(int level, string UserName)
        {
            var trWordLİst = context.TrWords.Where(I => I.level > 3 && I.UserName == UserName).ToList();
            foreach (var word in trWordLİst)
            {
                context.TrWords.Remove(word);
            }
            context.SaveChanges();
        }

        public void Update(string wordTr, string wordEng, string userName,int level)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == wordTr && I.UserName == userName);
            trWordToBeCheck.English = wordEng;
            trWordToBeCheck.UserName = userName;
            trWordToBeCheck.level = level;
            context.SaveChanges();
        }
    }
}
