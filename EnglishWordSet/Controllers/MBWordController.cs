using DataAccess.Concrete;
using DataAccess.util;
using Entities.Concrete;

namespace EnglishWordSet.CRUD
{
    class MBWordController
    {
        public NWords selectedword { get; set; }
        private WordImpl wordImpl = new();

        public MBWordController()
        {
            selectedword = wordImpl.GetRandomWord();
        }
        
        public void RemoveWord()
        {
            wordImpl.Delete(selectedword.English);
        }

        public string GetWordWithMeanig()
        {
            string line = selectedword.English + " ~ " + selectedword.Turkish;
            return line;
        }
        public string GetWord()
        {
            selectedword = wordImpl.GetRandomWord();
            string line = selectedword.English;
            return line;
        }
        public string GetMeaning()
        {
            string line = selectedword.Turkish;
            return line;
        }
    }
}
