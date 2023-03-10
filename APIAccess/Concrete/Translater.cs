using APIAccess.Abstract;
using Google.Cloud.Translation.V2;
using LogAccess;
using LogAccess.services;

namespace APIAccess.Concrete
{
    public class Translater:GoogleCLoudTranslateService
    {

        private string fromLanguage = LanguageCodes.Turkish;
        private string toLanguage = LanguageCodes.English;
        TranslationClient client;
        public string Translate(string inputTxt)
        {     
            try {
                client ??= TranslationClient.CreateFromApiKey(Settings.SettingsInfo.Default.GoogleTranslateAPIKey);
                var response = client.TranslateText(inputTxt, fromLanguage, toLanguage);

            return response.TranslatedText.ToString();
            }
            catch (Google.GoogleApiException e)
            {
                 AddLog.systemLogs.Error("Google Translate API is failed to start ");
                  client = null;
                return inputTxt;
            }
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
