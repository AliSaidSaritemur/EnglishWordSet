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

            
            SetStars setStars = new SetStars();
            string output = inputTxt;
            output = setStars.incStar(output);

            

            return output;
        }
    }
}
