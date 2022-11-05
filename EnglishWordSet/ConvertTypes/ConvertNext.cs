using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            convertTransaction = new SetTurkishWord();
            output = convertTransaction.EdditLine(output);

            convertTransaction = new AddHyphen();
            output = convertTransaction.EdditLine(output);

            return output;
        }
    }
}
