using DataAccess.Concrete;
using Entities.Concrete;
using System;
using EnglishWordSet.Sessions;

namespace EnglishWordSet.Controllers
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
