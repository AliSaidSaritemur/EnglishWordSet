using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Util;

namespace EnglishWordSet.util
{
    public class TextInformationGeter
    {
        private string inputText;

        public TextInformationGeter(string inputText)
        {
            this.inputText = Regex.Replace(inputText, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);       
        }

        public int GetWordCount()
        {
            int wordsCount = Regex.Matches(inputText, Settings.SettingsInfo.Default.SeparatorMark).Count;
            return wordsCount;
        }

        public int GetDaysAvarage()
        {
            int wordsCount = GetWordCount();
            if (wordsCount <= 0)
                return 0;
            int DayCount = 0;
            int avarageDayWord;
            string templine;
            using (StringReader stringReader = new(inputText)) { 
                string patternForNum = "^[1-9]";

            while ((templine = stringReader.ReadLine()) != null)
            {
                if (templine.StartsWith("!!!"))
                    DayCount += 10;

               else if (RegexTransactions.CheckingValue.Isthere(templine, patternForNum))
                {
                    DayCount += templine[0] - '0';
                }
            }
            }
            avarageDayWord = DayCount / wordsCount;
            return avarageDayWord;
        }

    }
}
