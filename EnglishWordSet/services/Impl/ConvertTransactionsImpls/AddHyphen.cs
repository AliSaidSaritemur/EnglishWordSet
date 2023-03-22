using EnglishWordSet.Intefaces;
using Util;

namespace EnglishWordSet.ConvertTransactions
{
    class AddHyphen : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string resultLine = lineToSet;
            bool isThereHyben = RegexTransactions.CheckingValue.Isthere(lineToSet, Settings.SettingsInfo.Default.SeparatorMark);

            if (!isThereHyben && resultLine != null)
            {
                resultLine += " "+ Settings.SettingsInfo.Default.SeparatorMark;
            }
            return resultLine;
        }
    }
}
