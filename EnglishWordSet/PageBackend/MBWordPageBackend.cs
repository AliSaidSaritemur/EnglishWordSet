using EnglishWordSet.Data.Contexts;
using EnglishWordSet.Data.Entities;
using EnglishWordSet.RefactoredStaticFuncs;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.CRUD
{
    class MBWordPageBackend
    {

        public MBWordPageBackend()
        {
            Invoke();
        }
        public WordContext context = MyDBTransactions.GetContext();
        public NWords selectedword { get; set; }

        private void Invoke()
        {
            Random rand = new Random();
            int toSkip = rand.Next(0,context.Words.Count());
            selectedword = context.Words.Skip(toSkip).Take(1).First();

        }

        public void RemoveWord()
        {
            context.Words.Remove(selectedword);
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

        public void SaveChange()
        {
            context.SaveChanges();
        }
    }
}
