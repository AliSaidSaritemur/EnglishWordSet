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
    internal class ConvertingWithoutSave : IConverts
    {
        public string Convert(string input)
        {
            string output = input;
            IConvertTransactions convertTransaction;

            convertTransaction = new ReducingFullDays();
            output = convertTransaction.EdditLine(output);

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
