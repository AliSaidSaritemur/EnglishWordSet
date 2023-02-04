using EnglishWordSet.Data.Contexts;
using EnglishWordSet.Data.Entities;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.services.Impl;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.CRUD
{
    class MBWordController
    {

        public MBWordController()
        {
            Invoke();
        }
        public WordContext context = MyDBTransactions.GetContext();
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
