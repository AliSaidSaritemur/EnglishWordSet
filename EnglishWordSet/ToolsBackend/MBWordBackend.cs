using EnglishWordSet.Data.Contexts;
using EnglishWordSet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.CRUD
{
    class MBWordBackend
    {
        public MBWordBackend()
        {
            Invoke();
        }
        public WordContext context = new();
        public NWords selectedword { get; set; }

        private void Invoke()
        {
            selectedword = context.Words.FirstOrDefault();
        }

        public void RemoveWord()
        {
            context.Words.Remove(selectedword);
        
        }

        public string GetWordWithMeanig()
        {
            if (selectedword == null)
                Invoke();

            string line = selectedword.English + " - " + selectedword.Turkish;
            return line;
        }
        public string GetWord()
        {
            string line = selectedword.English;
            return line;
        }
        public void SaveChange()
        {
            context.SaveChanges();
        }
    }
}
