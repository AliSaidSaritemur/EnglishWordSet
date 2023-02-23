using EnglishWordSet.RefactoredStaticFuncs;
using Entities.DTOs;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.util.MyTools
{
    internal class RapidAPIManage
    {
        private static List<String> wordSentencelist = new List<String>();
        private static int wordSentencelistNum = 0;
        public  async Task<List<string>> RapidGetSentenceByWordWithTextBox(RichTextBox textBoxtoWriteSentence, string queryWord)
        {
            string RequestUri = "https://wordsapiv1.p.rapidapi.com/words/" + queryWord + "/examples";
            DictionaryWords wordlist = await GetWordsapiWordwithRequestUri(RequestUri);
            wordSentencelist.Clear();
            if (wordlist != null)
            {
               return new List<String>(wordlist.examples);
            }
            else
            {
                return new List<String>();
            }

        }
        public static async Task<DictionaryWords> GetWordsapiWordwithRequestUri(string RequestUri)
        {
            DictionaryWords resultWord;
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
    }
}
