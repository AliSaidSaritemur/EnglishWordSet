﻿using EnglishWordSet.Intefaces;
using System.Text;
using Util;

namespace EnglishWordSet.ConvertTransactions
{
    class SetDays : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            lineToSet = lineToSet.Trim();
            string incLine;
            string pattern = "^[1-9]";
            bool startWithNum = RegexTransactions.CheckingValue.Isthere(lineToSet, pattern);

            if (lineToSet.StartsWith("9"))
            {
                incLine = "!!!";
                incLine += lineToSet.Substring(1);
            }
            else if (lineToSet.StartsWith("!!!"))
            {
                incLine = lineToSet.Substring(0);
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
