using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    internal interface IRandomWordService
    {
       void Add(string word,string frequency);
        void DeleteWithID(int id);
        void Delete(RandomWord randomWordToBeDelete);
        void DeleteWithWord(string word);
        string getRandomWord();
        string getRandomWordWtihFrequencyListThenDelteWordAndAddWordSameFrequency(List<string> frequencies, int wordCountToBeGet);
    }
}
