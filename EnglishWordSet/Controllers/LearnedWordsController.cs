using EnglishWordSet.MyTools;
using EnglishWordSet.RefactoredStaticFuncs;
using DataAccess.Concrete;
using Entities.Concrete;
using Phaber.Unsplash.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.util;
using EnglishWordSet.Sessions;

namespace EnglishWordSet.PageBackend
{
     class LearnedWordsController
    {
        private LearnedWordImpl _learnedWordImpl = new ();       
        public LearnedWord selectedWord;

        public LearnedWord SelectWord(string word)
        {      
            word =word.ToLower();
            if (selectedWord==null || selectedWord.wordEnglish != word)
                selectedWord = _learnedWordImpl.GetLearnedWord(word,UserSession.username_Admin);

            return selectedWord;    
        }

        public String GetSentence(string word)
        {
            SelectWord(word);
            return selectedWord.wordSentence;
        }
    }
}
