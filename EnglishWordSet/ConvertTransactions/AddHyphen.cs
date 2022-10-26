using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.ConvertTransactions
{
    class AddHyphen : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string resultLine = lineToSet;
            bool isThereHyben = MyRegex.Isthere(lineToSet, "-");

            if (!isThereHyben&&resultLine!=null)
            {
                resultLine += " -";
            }

            return resultLine;
        }
    }
}
