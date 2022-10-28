using EnglishWordSet.Data.Contexts;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.ToolsBackend
{
    class AdminPageBackend
    {
        public WordContext context = MyDBTransactions.GetContext();

        public void AddNewWords(string inputTExt)
        {
            StringReader stringReader = new StringReader(inputTExt);
            string lineToAdd;
            while (true)
            {
                lineToAdd = stringReader.ReadLine();
                if (lineToAdd != null)
                {


                }
                else {
                    break;
                }

            }
        }

    }
}
