using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.MyTools
{
    public class Translater
    {

        private string fromLanguage = LanguageCodes.Turkish;
        private string toLanguage = LanguageCodes.English;

        public string Translate(string inputTxt)
        {
            var client = TranslationClient.CreateFromApiKey("AIzaSyBTL7y3H--lfRrgzfFVsIPYjXs7f7TdkyU");

            var response = client.TranslateText(inputTxt, fromLanguage, toLanguage);

            return response.TranslatedText.ToString();
        }

        public void SetFromLanguageCode(string code)
        {
            fromLanguage = code;
        }
        public void SetToLanguageCode(string code)
        {
            toLanguage = code;
        }
    }
}
