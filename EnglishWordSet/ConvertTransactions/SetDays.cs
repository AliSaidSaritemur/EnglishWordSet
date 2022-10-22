using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSet.ConvertTransactions
{
    class SetDays
    {
        public string incStar(string lineToSet)
        {
            string incLine;
            string pattern = "^[1-9]";
            Regex rgLine = new Regex(pattern);
            Match matchRgL = rgLine.Match(lineToSet);

            if (lineToSet.StartsWith("9"))
            {
                incLine = "!!!";
                incLine += lineToSet.Substring(1);
            }
           else  if (lineToSet.StartsWith("!!!"))
            {   
                incLine = lineToSet.Substring(1);
            }
            else if (matchRgL.Success)
            {
                incLine = lineToSet;
                StringBuilder incLineBuild = new StringBuilder(incLine);
                int nowCount= (int.Parse(lineToSet[0].ToString())+1);           
                incLineBuild[0]= char.Parse((nowCount).ToString());
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
