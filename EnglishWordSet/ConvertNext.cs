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

            
            SetDays setStars = new SetDays();
            SetTurkishWord stw = new SetTurkishWord();
            string output = inputTxt;
            output = setStars.incStar(output);
            output = stw.deleteTurkishWord(output);



            return output;
        }
    }
}
