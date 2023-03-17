using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class WordImpl : IWordService
    {
        private WordContext context = MyDBTransactions.GetContext();
        private Random rand = new Random();

        public void Add(string word, string wordMeaning, string username)
        {
            context.Words.Add(new NWords { English = word, Turkish = wordMeaning ,UserName=username});
            context.SaveChanges();
        }

        public void Delete(string word, string username)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word&&I.UserName== username);
            context.Words.Remove(nword);
            context.SaveChanges();
        }

        public string GetMeaning(string word, string username)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word && I.UserName == username);
            return nword.Turkish;
        }

        public bool IsThere(string word ,string username)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word && I.UserName == username);
            return nword != null;
        }

        public void Update(string word, string wordMeaning, string username)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word && I.UserName == username);
            nword.Turkish = wordMeaning;
            context.SaveChanges();
        }

       public NWords GetRandomWord(string username)
        {
            int toSkip = rand.Next(0, context.Words.Where(I => I.UserName == username).Count());
            if (context.Words.Where(I => I.UserName == username).Count() > 0)
                return context.Words.Where(I => I.UserName == username).Skip(toSkip).Take(1).First();
            else
                return null;

        }
    }
}
