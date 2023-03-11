using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.util.StaticTools;

namespace EnglishWordSet.ConvertTransactions
{
    class AddHyphen : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string resultLine = lineToSet;
            bool isThereHyben = MyRegex.CheckingValue.Isthere(lineToSet, Settings.SettingsInfo.Default.SeparatorMark);

            if (!isThereHyben && resultLine != null)
            {
                resultLine += " "+ Settings.SettingsInfo.Default.SeparatorMark;
            }
            return resultLine;
        }
    }
}
