using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
     interface ITrWordService
    {
        void AddWtithoutLevel(string wordTr, string wordEng,string UserName);
        void Update(string wordTr, string wordEng, string UserName, int level);
        string GetEnglishMeaning(string wordTr, string UserName);
        bool IsThere(string wordTr, string UserName);
        List<TrWord> GetTurksihWordsWithLevel(int level, string UserName);
        string GetTurkishWordAndLevelsAsStringText(string userName);
        void CheckWordsEnglishIfIsTrueIncLevelOrDescLevel(string trWord, string wordEng, string UserName);
        bool CheckWordsEnglishMeaning(string trWord, string wordEng, string UserName);
        void IncWordLevel(string trWord, string UserName);
        void DescWordLevel(string trWord, string UserName);
        int GetMaxLevel(string UserName);
        void RemoveWordsWithLevel(int level, string UserName);
        int GetWordLevel(string trWord, string UserName);
    }
}
