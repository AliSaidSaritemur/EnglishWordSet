using EnglishWordSet.FileTransactions;
using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet
{
    class Converter
    {

        public bool spaceStatu=false;
        IConverts convert;
        public Converter(IConverts _converts)
        {
            convert = _converts;
        }

        public string CovertText(string textToConvert )
        {
         

            StringReader stringReader = new StringReader(textToConvert);
            string convertedText = "";
            string lineToAdd = "1";
            string tempText;

            while (true)
            {
                Random rnd = new Random();
         
                lineToAdd = stringReader.ReadLine();
                if (lineToAdd != null)
                {
                    if (lineToAdd == string.Empty)
                        continue;
                    tempText = convert.Convert(lineToAdd);  
                    convertedText = rnd.Next(10) < 5 ? (tempText + "\n" + convertedText) : (convertedText + "\n" + tempText);
                }
                else
                {
                    break;
                }
            }

            convertedText = spaceStatu ? convertedText + "\n" : convertedText;
            return convertedText;
        }
    }
}
