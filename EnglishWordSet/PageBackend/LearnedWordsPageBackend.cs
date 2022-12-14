using EnglishWordSet.Data.Contexts;
using EnglishWordSet.Data.Entities;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.PageBackend
{
     class LearnedWordsPageBackend
    {
        public WordContext context = MyDBTransactions.GetContext();
        public LearnedWord selectedWord;

        public LearnedWord SelectWord(string word)
        {
            word=word.ToLower();
            selectedWord = context.LearnedWords.FirstOrDefault(I=> I.wordEnglish== word);
            return selectedWord;    
        }
        
    }
}
