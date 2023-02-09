using EnglishWordSet.Intefaces;
using EnglishWordSet.RefactoredStaticFuncs;

namespace EnglishWordSet.ConvertTransactions
{
    class AddHyphen : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            string resultLine = lineToSet;
            bool isThereHyben = MyRegex.Isthere(lineToSet, "-");

            if (!isThereHyben && resultLine != null)
            {
                resultLine += " -";
            }
            return resultLine;
        }
    }
}
