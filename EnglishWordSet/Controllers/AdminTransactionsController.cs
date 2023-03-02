using APIAccess.Concrete;
using DataAccess.Concrete;
using DataAccess.util;
using EnglishWordSet.Pages.ChildFormPages.UserPage;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.util.StaticTools;
using LogAccess.services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Controllers
{
    internal class AdminTransactionsController
    {
        Random random = new();
        List<string> randomWordsList;
        RandomWordImpl _randomWordImpl;
        HerokuappRandomWordAPISImpl _randomAPI = new();
        GettingRandomWordWithFrequencyLevel gettingRandomWordWithFrequencyLevel = new();
        private AdminTransactionsPage transationpage;

        Dictionary<string, int> randomWordsFrequencyList = new Dictionary<string, int>();
        public AdminTransactionsController(AdminTransactionsPage _transactionsPage)
        {
            transationpage = _transactionsPage;
            randomWordsFrequencyList.Add("basic",0);
            randomWordsFrequencyList.Add("regular", 0);
            randomWordsFrequencyList.Add("rare", 0);
        }

        public async void AddRandomWordstoDB(int wordsToBeAddCount)
        {
            _randomWordImpl ??= new();
            transationpage.btnAddRandomWordtoDB.Enabled = false;
            transationpage.pBarAddingRandomWords.Visible = true;
            int wordstobeAddCountTemp = wordsToBeAddCount;
            for (int i = 0; i < wordstobeAddCountTemp; i++)
            {
                string randomWord = await GetRandomWordFromList();
                string wordFrequency = await gettingRandomWordWithFrequencyLevel.GetFrequency(randomWord);
                if (wordFrequency == "very rare")
                {
                   
                     wordstobeAddCountTemp++;
                }
                else
                {
                    _randomWordImpl.Add(randomWord, wordFrequency);
                    randomWordsFrequencyList[wordFrequency]++;
                    transationpage.pBarAddingRandomWords.Value++;
                }

            }
            AddLog.systemLogs.Info("Random " + wordsToBeAddCount + " Words Added \n Basic : " + randomWordsFrequencyList["basic"] + ",Regular : " + randomWordsFrequencyList["regular"] + " ,Rare : " + randomWordsFrequencyList["rare"]);
            
            foreach (KeyValuePair<string, int> entry in randomWordsFrequencyList)
            {
                randomWordsFrequencyList[entry.Key] = 0;
            }


            transationpage.pBarAddingRandomWords.Value = 0;
            transationpage.pBarAddingRandomWords.Visible = false;
            transationpage.btnAddRandomWordtoDB.Enabled = true;
            MyNotificationAlerts.GetSuccessMessage("Random Words added to DB");
        }


      private async Task<string> GetRandomWordFromList()
        {
            randomWordsList ??= await _randomAPI.GetRandomWordsAsync();
             string randomWord= randomWordsList[random.Next(randomWordsList.Count-1)];
            return randomWord;
        }
    }
}
