using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSet.ConvertTransactions
{
    class SetTurkishWord
    {
        public string deleteTurkishWord(string lineToSet)
        {
            string deletedLine = lineToSet;
            string pattern = "-";
            Regex rgLine = new Regex(pattern);
            Match matchRgL = rgLine.Match(lineToSet);
            if (matchRgL.Success)
            {
                deletedLine = deletedLine.Substring(0, (deletedLine.IndexOf("-") + 1));
            }

            return deletedLine;
        }

    }
}
