﻿using Entities.Concrete;


namespace DataAccess.Abstract
{
     interface ILearnedWordService
    {
        void Add(string word, string sentece, string wordMeaning, string senteceMeaning,string username);
        void Delete(string word, string username);
        void Update(string word, string sentece, string wordMeaning, string senteceMeaning, string username);
        LearnedWord GetLearnedWord(string word, string username);
        bool IsThere(string word, string username);
        LearnedWord GetRandomWord( string username);
        List<string> GetDifferentRandomWordWithCount( string username,int count);
        int LearnedWordCount(string username);
        List<LearnedWord> GetLearnedWords(string username);
        List<LearnedWord> GetLearnedWordsWithStartStr(string username,string startStr);
        List<string> GetLearnedEnglishWordsWithStartStr(string username, string startStr);
    }
}
