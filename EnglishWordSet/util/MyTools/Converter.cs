using EnglishWordSet.Intefaces;
using System;
using System.IO;

namespace EnglishWordSet.MyTools
{
    class Converter
    {

        public bool spaceStatu = false;
        public bool randomStatue = false;
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
                        if(randomStatue)
                        convertedText = rnd.Next(10) < 5 ? tempText + spaceAmount + convertedText : convertedText + spaceAmount + tempText;

                        else
                        {
                            convertedText = convertedText + spaceAmount + tempText;
                        }
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
