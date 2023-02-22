using EnglishWordSet.RefactoredStaticFuncs;
using Entities.DTOs;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

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
            if (wordlist != null) { 
                    wordSentencelist = new List<String>(wordlist.examples);
            }
            else
            {
                wordSentencelist = new List<String>();
            }
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
        private static async Task<bool> IsWordHasSentence(string queryWord)
        {
            string RequestUri = "https://wordsapiv1.p.rapidapi.com/words/" + queryWord + "/examples";
            DictionaryWords wordlist = await GetWordsapiWordwithRequestUri(RequestUri);
            if (wordlist == null|| wordlist.examples.Count<1)
            {
                return false;
            }
            else
            {
              return true;
            }
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
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    resultWord = JsonSerializer.Deserialize<DictionaryWords>(body);
                    return resultWord;
                }
            }
            catch (HttpRequestException e)
            {
                AddLog.systemLogs.Warn("Link could not be accessed : " + RequestUri);
                return null;
            }          
        }

        public static async void GetRandomWordtoTextBox(RichTextBox textBoxtoWriteSentence)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://random-word-api.herokuapp.com/word");

            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var resultWords = JsonSerializer.Deserialize<List<string>>(body);
            if (!await IsWordHasSentence(resultWords[0]))
            { GetRandomWordtoTextBox(textBoxtoWriteSentence); }
            else { 
            textBoxtoWriteSentence.Text += resultWords[0] + "\n";
            }
        }
        public static async void GetRandomWordtoTextBox(RichTextBox textBoxtoWriteSentence,int getttingCount)
        {
            for (int i = 0; i < getttingCount; i++) 
                GetRandomWordtoTextBox(textBoxtoWriteSentence);
        }

    }
}
