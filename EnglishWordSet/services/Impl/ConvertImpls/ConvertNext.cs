using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.Intefaces;
using EnglishWordSet.services.Impl.ConvertTransactionsImpls;

namespace EnglishWordSet
{
    class ConvertNext : IConverts
    {
        public string Convert(string inputTxt)
        {
            string output = inputTxt;
            IConvertTransactions convertTransaction;

            convertTransaction = new LearnedWordAddingToDB();
            output = convertTransaction.EdditLine(output);
            if (string.IsNullOrEmpty(output))
                return output;

            convertTransaction = new SetDays();
            output = convertTransaction.EdditLine(output);

            convertTransaction = new DeleteAfterHyben();
            output = convertTransaction.EdditLine(output);

            convertTransaction = new AddHyphen();
            output = convertTransaction.EdditLine(output);
         
            return output;
        }
    }
}
