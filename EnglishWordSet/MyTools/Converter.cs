
using EnglishWordSet.Intefaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.MyTools
{
    class Converter
    {

        public bool spaceStatu = false;
        IConverts convert;
        public Converter(IConverts _converts)
        {
            convert = _converts;
        }

        public string CovertText(string textToConvert)
        {
            string spaceAmount = spaceStatu ? "\n\n" : "\n";
            StringReader stringReader = new(textToConvert);
            string convertedText = "";
            string lineToAdd;
            string tempText;
            Random rnd = new();

            while (true)
            {
                lineToAdd = stringReader.ReadLine();
                if (lineToAdd != null)
                {
                    if (lineToAdd == string.Empty)
                        continue;

                    tempText = convert.Convert(lineToAdd);


                    if (convertedText != "")
                    {
                        convertedText = rnd.Next(10) < 5 ? tempText + spaceAmount + convertedText : convertedText + spaceAmount + tempText;

                    }
                    else
                    {
                        convertedText = tempText;
                    }

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
