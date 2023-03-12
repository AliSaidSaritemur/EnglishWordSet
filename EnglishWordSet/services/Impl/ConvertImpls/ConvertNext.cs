using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.Intefaces;


namespace EnglishWordSet
{
    class ConvertNext : IConverts
    {
        public string Convert(string inputTxt)
        {
            string output = inputTxt;
            IConvertTransactions convertTransaction;

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
