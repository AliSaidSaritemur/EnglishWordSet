using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    internal class TrWordImpl : ITrWordService
    {
        private WordContext context = MyDBTransactions.GetContext();

        public void AddWtithoutLevel(string wordTr, string wordEng, string userName)
        {
            context.TrWords.Add(new TrWord { English = wordEng, Turkish = wordTr,UserName= userName });
            context.SaveChanges();
        }

        public void CheckWordsEnglishIfIsTrueIncLevel(string trWord, string wordEng)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == trWord);
            trWordToBeCheck.level = trWordToBeCheck.English == wordEng ? trWordToBeCheck.level + 1 : trWordToBeCheck.level;
            context.SaveChanges();
        }

        public string GetEnglishMeaning(string wordTr)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == wordTr);
            return trWordToBeCheck.English;
        }

        public int GetMaxLevel()
        {
            int maxLevel = context.TrWords.Max(p => p.level);
            return maxLevel;
        }

        public string GetTurkishWordAndLevelsAsStringText()
        {
            string result="";
            for(int i =1;i<= GetMaxLevel();i++)
            {
                 result = $"\n{i}.";
                foreach (var turkishWordToBeAddString in GetTurksihWordsWithLevel(i))
                {
                    result += "\n" + turkishWordToBeAddString.Turkish;
                }
            }
            return result;

        }

        public List<TrWord> GetTurksihWordsWithLevel(int level)
        {
            List<TrWord> trWords = context.TrWords.Where(a=>a.level==level).ToList();
            return trWords;
        }

        public bool IsThere(string wordTr)
        {
            TrWord nword = context.TrWords.FirstOrDefault(I => I.Turkish == wordTr);
            return nword != null;
        }

        public void Update(string wordTr, string wordEng, string userName,int level)
        {
            TrWord trWordToBeCheck = context.TrWords.FirstOrDefault(I => I.Turkish == wordTr);
            trWordToBeCheck.English = wordEng;
            trWordToBeCheck.UserName = userName;
            trWordToBeCheck.level = level;
            context.SaveChanges();
        }
    }
}
