using EnglishWordSet.Data.Contexts;
using EnglishWordSet.MyTools;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.services.Impl;
using Entities.Concrete;
using Phaber.Unsplash.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnglishWordSet.PageBackend
{
     class LearnedWordsController
    {

        private LearnedWordImpl _learnedWordImpl = new ();
        public WordContext context = MyDBTransactions.GetContext();
        public LearnedWord selectedWord;

        public LearnedWord SelectWord(string word)
        {      
            word =word.ToLower();
            if (selectedWord==null || selectedWord.wordEnglish != word)
                selectedWord = _learnedWordImpl.GetLearnedWord(word);

            return selectedWord;    
        }

        public String GetSentence(string word)
        {
            SelectWord(word);
            return selectedWord.wordSentence;
        }
    }
}
