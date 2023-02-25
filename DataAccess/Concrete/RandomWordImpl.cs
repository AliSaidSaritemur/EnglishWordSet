using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RandomWordImpl : IRandomWordService
    {
        GettingRandomWordWithFrequencyLevel _GettingRandomWordWithFrequency = new();
        private WordContext context = MyDBTransactions.GetContext();
        private Random rand = new Random();
        public void Add(string word, string frequency)
        {
            context.RandomWords.Add(new RandomWord { Word = word, frequency = frequency });
            context.SaveChanges();
        }

        public void Delete(RandomWord randomWordToBeDelete)
        {
            if (randomWordToBeDelete != null)
                context.RandomWords.Remove(randomWordToBeDelete);
            context.SaveChanges();
        }

        public void DeleteWithID(int id)
        {
            RandomWord randomWord = context.RandomWords.FirstOrDefault(I => I.Id == id);
            if (randomWord != null)
                context.RandomWords.Remove(randomWord);
            context.SaveChanges();
        }

        public void DeleteWithWord(string word)
        {
            RandomWord randomWord = context.RandomWords.FirstOrDefault(I => I.Word == word);
            if (randomWord != null)
                context.RandomWords.Remove(randomWord);
            context.SaveChanges();
        }

        public string getRandomWord()
        {
            int toSkip = rand.Next(0, context.RandomWords.Count());
            return context.RandomWords.Skip(toSkip).Take(1).First().Word;
        }

        public string getRandomWordWtihFrequencyList(List<string> frequencies)
        {
            RandomWord rnword = context.RandomWords.FirstOrDefault(I => frequencies.Contains(I.frequency));
            return rnword.Word;
        }


        public string getRandomWordWtihFrequencyListThenDelteWord(List<string> frequencies)
        {
            RandomWord rnword = context.RandomWords.FirstOrDefault(I => frequencies.Contains(I.frequency));
            string resultWord= rnword.Word;
            Delete(rnword);
            return resultWord;
        }

        public string getRandomWordWtihFrequencyListThenDelteWordAndAddWordSameFrequency(List<string> frequencies,int wordCountToBeGet)
        {
            string tempWord = "";
            for (int i = 0; i < wordCountToBeGet; i++)
            {
                RandomWord rnword = context.RandomWords.FirstOrDefault(I => frequencies.Contains(I.frequency));
                 tempWord += rnword.Word+"\n";
                _GettingRandomWordWithFrequency.AddWordToDbWithFrequency(1, rnword.frequency);
                Delete(rnword);
            }
           
            return tempWord;
        }
    }
}
