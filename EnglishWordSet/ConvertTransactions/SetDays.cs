using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSet.ConvertTransactions
{
    class SetDays :IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            lineToSet = lineToSet.Trim();
            string incLine;
            string pattern = "^[1-9]";
            bool startWithNum = MyRegex.Isthere(lineToSet, pattern);

            if (lineToSet.StartsWith("9"))
            {
                incLine = "!!!";
                incLine += lineToSet.Substring(1);
            }
            else if (lineToSet.StartsWith("!!!"))
            {
                incLine = lineToSet.Substring(1);
            }
            else if (startWithNum)
            {
                incLine = lineToSet;
                StringBuilder incLineBuild = new StringBuilder(incLine);
                int nowCount = (int.Parse(lineToSet[0].ToString()) + 1);
                incLineBuild[0] = char.Parse((nowCount).ToString());
                incLine = incLineBuild.ToString();
            }
            else
            {
                incLine = "1 ";
                incLine += lineToSet;
            }
            return incLine;
        }

        

    }
}
