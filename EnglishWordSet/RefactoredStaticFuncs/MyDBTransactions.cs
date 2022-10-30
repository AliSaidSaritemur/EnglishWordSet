using EnglishWordSet.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
   static class MyDBTransactions
    {
       static WordContext wordContext;

        public static WordContext GetContext()
        {
            return wordContext;
        }
        public static  void  SetContext()
        {
            if (wordContext == null)
                wordContext = new();
        }
    }
}
