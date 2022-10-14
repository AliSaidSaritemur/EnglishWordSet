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
            string incLine;
            string pattern = "\\*";
            Regex rgLine = new Regex(pattern);
            Match matchRgL = rgLine.Match(lineToSet);

            if (lineToSet.StartsWith("***"))
            {
                incLine = "!";
                incLine += lineToSet.Substring(3);
            }
            else if (matchRgL.Success)
            {
                incLine = "*";
                incLine += lineToSet;
            }
            else
            {
                incLine = "* ";
                incLine += lineToSet;
            }
            return incLine;
        }

    }
}
