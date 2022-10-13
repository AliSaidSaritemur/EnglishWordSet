using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSet.ConvertTransactions
{
    class SetStars
    {
        public string incStar(string lineToSet)
        {
            string incLine = "";
           
            if (lineToSet.StartsWith("***"))
            {
                incLine = "!";
                incLine += lineToSet.Substring(3);
            }
            else
            {
                incLine = "*";
                incLine += lineToSet;
            }
            return incLine;
        }

    }
}
