using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet
{
    class Converter
    {
        IConverts convert;
        public Converter(IConverts _converts)
        {
            convert = _converts;
        }

        public string CovertText(string textToConvert)
        {
            StringReader stringReader = new StringReader(textToConvert);
            string convertedText = " ";
            string lineToAdd = "1";
            while (true)
            {
                lineToAdd = stringReader.ReadLine();
                if (lineToAdd != null)
                {
                    if (lineToAdd == string.Empty)
                        continue;
                    convertedText += convert.Convert(lineToAdd);
                    convertedText += "\n";
                }
                else
                {
                    break;
                }
            }
            return convertedText;
        }
    }
}
