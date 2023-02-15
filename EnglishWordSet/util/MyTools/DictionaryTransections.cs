using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EnglishWordSet.util.MyTools
{
    internal static class DictionaryTransections
    {
        private static  HttpClient client = new();
        private static List<String> wordSentencelist = new List<String>();
        private static int wordSentencelistNum =0;
        private static string  lastQueryWord="";
        public static async void GetSEntenceByWordtoTextBox(RichTextBox textBoxtoWriteSentence,string queryWord)
        {

            if (queryWord== lastQueryWord)
            {
                ChangeSentenceInTextBox(textBoxtoWriteSentence);
                return;
            }
            string url ="https://api.dictionaryapi.dev/api/v2/entries/en/"+ queryWord;
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/"+queryWord+"/examples"),
                    Headers =
    {
        { "X-RapidAPI-Key", Settings.SettingsInfo.Default.RapidAPIKey},
        { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                DictionaryWords? wordList = JsonSerializer.Deserialize<DictionaryWords>(body);

                    wordSentencelist.Clear();
                    wordSentencelist=new List<String>(wordList.examples); 
                    ChangeSentenceInTextBox(textBoxtoWriteSentence);
                    lastQueryWord= queryWord;
                }           
            }
            catch(HttpRequestException e)
            {
                Console.WriteLine("Error: {0}",e);
            }

        }
       private static async void ChangeSentenceInTextBox(RichTextBox textBoxtoWriteSentence)
        {
            if ( wordSentencelist.Count < wordSentencelistNum+1){
                wordSentencelistNum = 0;
            }
            textBoxtoWriteSentence.Text = wordSentencelist[wordSentencelistNum];
            wordSentencelistNum++;
        }
    }
}
