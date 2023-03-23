using EnglishWordSet.Intefaces;
using System;
using System.IO;
using Util;

namespace EnglishWordSet.util
{
    class Converter
    {
        public bool randomStatue = false;
        IConverts convert;
        public Converter(IConverts _converts)
        {
            convert = _converts;
        }

        public string CovertText(string textToConvert)
        {
            string spaceAmount ="\n"; 
            string convertedText="";
            string lineToAdd;
            string tempText;
            Random rnd = new();
            int randomNumLimit = randomStatue ? 10 : 4;

            using StringReader stringReader = new(textToConvert);
            while ((lineToAdd = stringReader.ReadLine())!=null)
            {              
                    if (string.IsNullOrEmpty(lineToAdd))
                        continue;

                    tempText = convert.Convert(lineToAdd);

                    convertedText = rnd.Next(randomNumLimit) < 5 ? tempText + spaceAmount + convertedText : convertedText + spaceAmount + tempText;

                }

            string spaceDeltedConvertedText = RegexTransactions.EddittingStringValue.RemoveSpaces(convertedText);
            return spaceDeltedConvertedText;
        }
    }
}
