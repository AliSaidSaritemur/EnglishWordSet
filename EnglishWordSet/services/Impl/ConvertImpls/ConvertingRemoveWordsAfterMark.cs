using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.Intefaces;
using EnglishWordSet.services.Impl.ConvertTransactionsImpls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl.ConvertImpls
{
    internal class ConvertingRemoveWordsAfterMark :IConverts
    {
        public string Convert(string inputTxt)
        {
            string output = inputTxt;
            IConvertTransactions convertTransaction;

            convertTransaction = new SetTurkishWord();
            output = convertTransaction.EdditLine(output);

            convertTransaction = new RemovingMark();
            output = convertTransaction.EdditLine(output);

            return output;
        }
    }
}
