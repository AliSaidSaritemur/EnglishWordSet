using EnglishWordSet.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
   static class DBTransactions
    {
       static WordContext wordContext;
        public static WordContext GetContext()
        {
            if(wordContext==null)
             wordContext = new();
            return wordContext;
        } 

    }
}
