using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class LearnedWordImpl : ILearnedWordService
    {
        private WordContext context = MyDBTransactions.GetContext();
        private Random rand;

        public void Add(string word, string sentence, string wordMeaning, string senteceMeaning, string username)
        {
            context.LearnedWords.Add(new LearnedWord { wordEnglish = word, wordSentence = sentence, wordTurkish = wordMeaning, meaningWordSentence = senteceMeaning,UserName=username });
            context.SaveChanges();
        }

        public void Delete(string word, string username)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish== word&& I.UserName== username);
            if(learnedword!=null)
            context.LearnedWords.Remove(learnedword);
            context.SaveChanges();
        }

        public LearnedWord GetRandomWord(string username)
        {
            rand ??= new Random();
            int toSkip = rand.Next(0, context.Words.Where(I => I.UserName == username).Count());
            return context.LearnedWords.Where(I => I.UserName == username).Skip(toSkip).Take(1).First();
        }

        public LearnedWord GetLearnedWord(string word, string username)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish == word && I.UserName == username);
            return learnedword;
        }

        public bool IsThere(string word, string username)
        {
            return 0 < context.LearnedWords.Count(I => I.wordEnglish == word && I.UserName == username);
        }

        public void Update(string word, string sentece, string wordMeaning, string senteceMeaning, string username)
        {
            LearnedWord learnedword = context.LearnedWords.FirstOrDefault(I => I.wordEnglish == word && I.UserName == username);
            learnedword.wordTurkish = wordMeaning;
            learnedword.wordSentence = sentece;
            learnedword.meaningWordSentence = senteceMeaning;
            context.SaveChanges();

        }
    }
}
