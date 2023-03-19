using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.services.Impl.ConvertTransactionsImpls
{
    internal class ReducingFullDays : IConvertTransactions
    {
        public string EdditLine(string lineToSet)
        {
            if (!lineToSet.StartsWith("!!!"))
                return lineToSet;

            return "6"+lineToSet.Substring(3);
        }
    }
}
