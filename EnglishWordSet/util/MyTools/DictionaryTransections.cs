using EnglishWordSet.RefactoredStaticFuncs;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.util.MyTools
{
    internal static class DictionaryTransections
    {
        private static HttpClient client = new();
        private static List<String> wordSentencelist = new List<String>();
        private static int wordSentencelistNum = 0;
        private static string lastQueryWord = "";
        public static async void GetSEntenceByWordtoTextBox(RichTextBox textBoxtoWriteSentence, string queryWord)
        {  
                    string RequestUri = "https://wordsapiv1.p.rapidapi.com/words/" + queryWord + "/examples";
                    DictionaryWords wordlist = await GetWordsapiWordwithRequestUri(RequestUri);           
                    wordSentencelist.Clear();
                    wordSentencelist = new List<String>(wordlist.examples);
                    ExamplesArrange(wordSentencelist);
                    ChangeSentenceInTextBox(textBoxtoWriteSentence);
                    lastQueryWord = queryWord;
        }
        private static async void ChangeSentenceInTextBox(RichTextBox textBoxtoWriteSentence)
        {
            if (wordSentencelist.Count == 0)
            {
                textBoxtoWriteSentence.Text = "There is no sentences";
                return;
            }

            else if (wordSentencelist.Count < wordSentencelistNum + 1)
            {
                wordSentencelistNum = 0;
            }
            textBoxtoWriteSentence.Text = wordSentencelist[wordSentencelistNum];
            wordSentencelistNum++;
        }

        private static async void ExamplesArrange(List<String> examplestobeArranged)
        {
            StringBuilder strB;
            for (int i = 0; i < examplestobeArranged.Count; i++)
            {
                strB = new StringBuilder(examplestobeArranged[i]);
                strB[0] = char.ToUpper(strB[0]);
                examplestobeArranged[i] = strB.ToString();
                if (!MyRegex.CheckingValue.IsLastCharPunctuation(examplestobeArranged[i]))
                    examplestobeArranged[i] = examplestobeArranged[i] + ".";
            }
        }

        public static async Task<DictionaryWords> GetWordsapiWordwithRequestUri(string RequestUri){
            DictionaryWords  resultWord;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(RequestUri),
                Headers =
    {
        { "X-RapidAPI-Key",  Settings.SettingsInfo.Default.RapidAPIKey },
        { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                resultWord = JsonSerializer.Deserialize<DictionaryWords>(body);

            }
            return resultWord;
        }

        public static async void GetRandomWordtoTextBox(RichTextBox textBoxtoWriteSentence)
        {
            string RequestUri = "https://wordsapiv1.p.rapidapi.com/words/?random=true";
            DictionaryWords word = await GetWordsapiWordwithRequestUri(RequestUri);
            textBoxtoWriteSentence.Text += word.word + "\n";
        }
        public static async void GetRandomWordtoTextBox(RichTextBox textBoxtoWriteSentence,int getttingCount)
        {
            for (int i = 0; i < getttingCount; i++)
                GetRandomWordtoTextBox(textBoxtoWriteSentence);
        }

    }
}
