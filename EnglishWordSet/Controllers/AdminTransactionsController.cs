using APIAccess.Concrete;
using DataAccess.Concrete;
using DataAccess.util;
using EnglishWordSet.Pages.ChildFormPages.UserPage;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Controllers
{
    internal class AdminTransactionsController
    {
        int rareWordCount = 0;
        int basicWordCount = 0;
        int regualrWordCount = 0;
        RandomWordImpl _randomWordImpl;
        HerokuappRandomWordAPISImpl _randomAPI = new();
        DataMuseAPISImpl _frequencyAPI = new();
        GettingRandomWordWithFrequencyLevel gettingRandomWordWithFrequencyLevel = new();
        private AdminTransactionsPage transationpage;

        public AdminTransactionsController(AdminTransactionsPage _transactionsPage)
        {
            transationpage = _transactionsPage;
        }

        public async void AddRandomWordstoDB(int wordsToBeAddCount)
        {
            _randomWordImpl ??= new();
            transationpage.btnAddRandomWordtoDB.Enabled = false;
            transationpage.pBarAddingRandomWords.Visible = true;
            int wordstobeAddCountTemp = wordsToBeAddCount;
            for (int i = 0; i < wordstobeAddCountTemp; i++)
            {
                string randomWord = await _randomAPI.GetRandomWordAsync();
                string wordFrequency = await gettingRandomWordWithFrequencyLevel.GetFrequency(randomWord);
                if (wordFrequency == "very rare")
                {
                    wordstobeAddCountTemp++;
                }
                else
                {
                    _randomWordImpl.Add(randomWord, wordFrequency);
                    transationpage.pBarAddingRandomWords.Value++;
                }

            }
            AddLog.systemLogs.Info("Random " + wordsToBeAddCount + " Words Added \n Basic : " + basicWordCount + ",Regular : " + regualrWordCount + " ,Rare : " + rareWordCount);
            rareWordCount = 0;
            basicWordCount = 0;
            regualrWordCount = 0;
            transationpage.pBarAddingRandomWords.Value = 0;
            transationpage.pBarAddingRandomWords.Visible = false;
            transationpage.btnAddRandomWordtoDB.Enabled = true;
        }
    }
}
