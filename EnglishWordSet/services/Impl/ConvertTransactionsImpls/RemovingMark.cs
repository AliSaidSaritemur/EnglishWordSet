using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl.ConvertTransactionsImpls
{
    internal class RemovingMark : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            return lineToSet.Replace("~", "");
        }
    }
}
