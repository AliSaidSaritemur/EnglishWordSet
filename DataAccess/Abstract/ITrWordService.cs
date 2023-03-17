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
        string GetEnglishMeaning(string wordTr);
        bool IsThere(string wordTr);
        List<TrWord> GetTurksihWordsWithLevel(int level);
        string GetTurkishWordAndLevelsAsStringText();
        void CheckWordsEnglishIfIsTrueIncLevel(string trWord, string wordEng);
        bool CheckWordsEnglishMeaning(string trWord, string wordEng);
        void IncWordLevel(string trWord);
        int GetMaxLevel();
        void RemoveWordsWithLevel(int level);
    }
}
