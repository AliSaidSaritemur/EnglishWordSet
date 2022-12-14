using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EnglishWordSet.MyTools
{
    public class TextInformationGeter
    {
        private string inputText;

        public TextInformationGeter(string inputText)
        {
            inputText = Regex.Replace(inputText, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            this.inputText = inputText;

        }

        public int GetWordCount()
        {
            int wordsCount =wordsCount = inputText.ToCharArray().Count(c => c == '-');
            return wordsCount;   
        }

        public int GetDaysAvarage()
        {
            int wordsCount= GetWordCount(); 
            if (wordsCount == 0)
                return 0;
            GetWordCount();
            int DayCount = 0;
            int avarageDayWord;
            string templine;
            StringReader stringReader = new(inputText);
            string patternForNum = "^[1-9]";

            while (true)
            {
                templine = stringReader.ReadLine();

                if (templine == null)
                    break;

                if (templine.StartsWith("!!!"))
                    DayCount += 10;

                if (MyRegex.Isthere(templine, patternForNum))
                {
                    DayCount += (templine[0] - '0');
                }
            }
            avarageDayWord = DayCount / wordsCount;
          return avarageDayWord;    
        }

    }
}
