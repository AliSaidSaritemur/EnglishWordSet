﻿using Google.Cloud.Translation.V2;

namespace EnglishWordSet.MyTools
{
    public class Translater
    {

        private string fromLanguage = LanguageCodes.Turkish;
        private string toLanguage = LanguageCodes.English;

        public string Translate(string inputTxt)
        {
            var client = TranslationClient.CreateFromApiKey("Your API Key");

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
