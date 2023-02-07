using EnglishWordSet.Data.Contexts;
using EnglishWordSet.RefactoredStaticFuncs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl
{
    public class LearnedWordImpl : ILearnedWordService
    {
        private WordContext context = MyDBTransactions.GetContext();
        private Random rand = new Random();

        public void Add(string word, string sentence, string wordMeaning, string senteceMeaning)
        {
            context.LearnedWords.Add(new LearnedWord { wordEnglish = word, wordSentence = sentence, wordTurkish = wordMeaning, meaningWordSentence = senteceMeaning });
            context.SaveChanges();
        }

        public void Delete(string word)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish== word);
            context.LearnedWords.Remove(learnedword);
            context.SaveChanges();
        }

        public LearnedWord GetRandomWord()
        {
            int toSkip = rand.Next(0, context.Words.Count());
            return context.LearnedWords.Skip(toSkip).Take(1).First();
        }

        public LearnedWord GetLearnedWord(string word)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish == word);
            return learnedword;
        }

        public bool IsThere(string word)
        {
            return 0 < context.LearnedWords.Count(I => I.wordEnglish == word);
        }

        public void Update(string word, string sentece, string wordMeaning, string senteceMeaning)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish == word);
            learnedword.wordTurkish = wordMeaning;
            learnedword.wordSentence = sentece;
            learnedword.meaningWordSentence = senteceMeaning;
            context.SaveChanges();

        }
    }
}
