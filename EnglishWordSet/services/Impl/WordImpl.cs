using EnglishWordSet.Data.Contexts;
using EnglishWordSet.RefactoredStaticFuncs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl
{
    public class WordImpl : IWordService
    {
        private WordContext context = MyDBTransactions.GetContext();
        private Random rand = new Random();

        public void Add(string word, string wordMeaning)
        {
            context.Words.Add(new NWords { English = word, Turkish = wordMeaning });
            context.SaveChanges();
        }

        public void Delete(string word)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word);
            context.Words.Remove(nword);
            context.SaveChanges();
        }

        public string GetMeaning(string word)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word);
            return nword.Turkish;
        }

        public bool IsThere(string word)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word);
            return nword != null;
        }

        public void Update(string word, string wordMeaning)
        {
            NWords nword = context.Words.FirstOrDefault(I => I.English == word);
            nword.Turkish = wordMeaning;
            context.SaveChanges();
        }

       public NWords GetRandomWord()
        {
            int toSkip = rand.Next(0, context.Words.Count());
            return context.Words.Skip(toSkip).Take(1).First();
        }
    }
}
