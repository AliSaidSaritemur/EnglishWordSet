using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;

namespace EnglishWordSet.ConvertTransactions
{
    class SetTurkishWord : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string deletedLine = lineToSet;
            bool isThereHyben = MyRegex.CheckingValue.Isthere(lineToSet, "~");

            if (isThereHyben)
            {
                deletedLine = deletedLine.Substring(0, (deletedLine.IndexOf("~") + 1));
            }

            return deletedLine;
        }
    }
}
