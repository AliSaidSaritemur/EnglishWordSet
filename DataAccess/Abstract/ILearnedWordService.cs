﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
     interface ILearnedWordService
    {
        void Add(string word, string sentece, string wordMeaning, string senteceMeaning);
        void Delete(string word);
        void Update(string word, string sentece, string wordMeaning, string senteceMeaning);
        LearnedWord GetLearnedWord(string word);
        bool IsThere(string word);
        LearnedWord GetRandomWord();
    }
}