using EnglishWordSet.RefactoredStaticFuncs;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
            if (queryWord == lastQueryWord)
            {
                ChangeSentenceInTextBox(textBoxtoWriteSentence);
                return;
            }
            try
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/" + queryWord + "/examples"),
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
                    DictionaryWords wordList = JsonSerializer.Deserialize<DictionaryWords>(body);

                    wordSentencelist.Clear();
                    wordSentencelist = new List<String>(wordList.examples);
                    ExamplesArrange(wordSentencelist);
                    ChangeSentenceInTextBox(textBoxtoWriteSentence);
                    lastQueryWord = queryWord;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Error: {0}", e);
            }

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
        public static async void GetRandomWordtoTextBox(RichTextBox textBoxtoWriteSentence)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/?random=true"),
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
                DictionaryWords word = JsonSerializer.Deserialize<DictionaryWords>(body);
                textBoxtoWriteSentence.Text += word.word+"\n";
            }

        }
        }
}
