using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl.ConvertImpls
{
    internal class ConvertingWtihoutDays : IConverts
    {
        public string Convert(string inputTxt)
        {
            string output = inputTxt;
            IConvertTransactions convertTransaction;

            convertTransaction = new DeleteAfterHyben();
            output = convertTransaction.EdditLine(output);

            convertTransaction = new AddHyphen();
            output = convertTransaction.EdditLine(output);

            return output;
        }
    }
}
