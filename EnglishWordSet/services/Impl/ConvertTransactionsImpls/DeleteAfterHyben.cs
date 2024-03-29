﻿using EnglishWordSet.Intefaces;
using Util;

namespace EnglishWordSet.ConvertTransactions
{
    class DeleteAfterHyben : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string deletedLine = lineToSet;
            bool isThereHyben = RegexTransactions.CheckingValue.Isthere(lineToSet, Settings.SettingsInfo.Default.SeparatorMark);

            if (isThereHyben)
            {
                deletedLine = deletedLine.Substring(0, (deletedLine.IndexOf(Settings.SettingsInfo.Default.SeparatorMark) + 1));
            }

            return deletedLine;
        }
    }
}
