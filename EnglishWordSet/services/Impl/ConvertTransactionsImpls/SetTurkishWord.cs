using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.util.StaticTools;

namespace EnglishWordSet.ConvertTransactions
{
    class SetTurkishWord : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string deletedLine = lineToSet;
            bool isThereHyben = MyRegex.CheckingValue.Isthere(lineToSet, Marks.SeparatorMark);

            if (isThereHyben)
            {
                deletedLine = deletedLine.Substring(0, (deletedLine.IndexOf(Marks.SeparatorMark) + 1));
            }

            return deletedLine;
        }
    }
}
