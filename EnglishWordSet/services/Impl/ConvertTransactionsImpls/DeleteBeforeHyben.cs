using EnglishWordSet.Intefaces;
using Util;

namespace EnglishWordSet.services.Impl.ConvertTransactionsImpls
{
    internal class DeleteBeforeHyben : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string deletedLine = lineToSet;
            bool isThereHyben = RegexTransactions.CheckingValue.Isthere(lineToSet, Settings.SettingsInfo.Default.SeparatorMark);

            if (isThereHyben)
            {
                deletedLine = deletedLine.Substring(deletedLine.IndexOf(Settings.SettingsInfo.Default.SeparatorMark) + 1);
            }

            return deletedLine;
        }
    }
}
