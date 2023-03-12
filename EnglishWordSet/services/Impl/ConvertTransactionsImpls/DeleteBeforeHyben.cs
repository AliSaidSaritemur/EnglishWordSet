using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl.ConvertTransactionsImpls
{
    internal class DeleteBeforeHyben : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string deletedLine = lineToSet;
            bool isThereHyben = MyRegex.CheckingValue.Isthere(lineToSet, Settings.SettingsInfo.Default.SeparatorMark);

            if (isThereHyben)
            {
                deletedLine = deletedLine.Substring(deletedLine.IndexOf(Settings.SettingsInfo.Default.SeparatorMark) + 1);
            }

            return deletedLine;
        }
    }
}
