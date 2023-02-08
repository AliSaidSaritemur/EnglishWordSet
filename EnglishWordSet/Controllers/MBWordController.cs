using DataAccess.Concrete;
using DataAccess.util;
using Entities.Concrete;

namespace EnglishWordSet.CRUD
{
    class MBWordController
    {

        public MBWordController()
        {
            Invoke();
        }
        public NWords selectedword { get; set; }
         private WordImpl wordImpl =new();

        private void Invoke()
        {       
            selectedword = wordImpl.GetRandomWord();
        }

        public void RemoveWord()
        {
            wordImpl.Delete(selectedword.English);
        }

        public string GetWordWithMeanig()
        {
            string line = selectedword.English + " - " + selectedword.Turkish;
            return line;
        }
        public string GetWord()
        { 
            string line = selectedword.English;
            return line;
        }     
    }
}
