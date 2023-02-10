using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class LearnedWordImpl : ILearnedWordService
    {
        private WordContext context = MyDBTransactions.GetContext();
        private Random rand;

        public void Add(string word, string sentence, string wordMeaning, string senteceMeaning)
        {
            context.LearnedWords.Add(new LearnedWord { wordEnglish = word, wordSentence = sentence, wordTurkish = wordMeaning, meaningWordSentence = senteceMeaning });
            context.SaveChanges();
        }

        public void Delete(string word)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish== word);
            if(learnedword!=null)
            context.LearnedWords.Remove(learnedword);
            context.SaveChanges();
        }

        public LearnedWord GetRandomWord()
        {
            rand ??= new Random();
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
