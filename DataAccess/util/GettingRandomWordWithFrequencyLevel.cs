using APIAccess.Abstract;
using APIAccess.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.util
{
    public class GettingRandomWordWithFrequencyLevel
    {
        int rareWordCount = 0;
        int basicWordCount = 0;
        int regualrWordCount = 0;
        RandomWordImpl _randomWordImpl;
        HerokuappRandomWordAPISImpl _randomAPI = new();
        DataMuseAPISImpl _frequencyAPI=new();


        public async void AddRandomWordstoDB(int wordsToBeAddCount)
        {
            _randomWordImpl ??=new();

            int wordstobeAddCountTemp = wordsToBeAddCount;
            for (int i = 0; i < wordstobeAddCountTemp; i++)
            {
                string randomWord = await _randomAPI.GetRandomWordAsync();
                string wordFrequency = await GetFrequency(randomWord);
                if(wordFrequency== "very rare")
                {
                    wordstobeAddCountTemp++;     
                }
                else 
                { 
                _randomWordImpl.Add(randomWord, wordFrequency);
                }
             
            }
            AddLog.systemLogs.Info("Random "+wordsToBeAddCount+" Words Added \n Basic : "+basicWordCount+",Regular : "+regualrWordCount+" ,Rare : "+rareWordCount);
            rareWordCount = 0;
            basicWordCount = 0;
            regualrWordCount = 0;
        }


        public async Task<string> GetFrequency(string wordToBeGetFrequecy) {

           float wordsFrequencyFloat = await _frequencyAPI.GetFrequency(wordToBeGetFrequecy);

            if (wordsFrequencyFloat > 20)
            {
                basicWordCount++;
                return "basic";
            }
            else if (wordsFrequencyFloat > 3)
            {
                regualrWordCount++;
                return "regular";
            }
            else if (wordsFrequencyFloat > 0.5)
            {
                rareWordCount++;
                return "rare";
            }
            else
                return "very rare";
        }

        public async void AddWordToDbWithFrequency(int wordsToBeAddCount,string frequency)
        {
            _randomWordImpl ??= new();
            int wordstobeAddCountTemp = wordsToBeAddCount+5;
            for (int i = 0; i < wordstobeAddCountTemp; i++)
            {
                string randomWord = await _randomAPI.GetRandomWordAsync();
                string wordFrequency = await GetFrequency(randomWord);
                if (wordFrequency != frequency)
                {
                    wordstobeAddCountTemp++;
                }
                else
                {
                    _randomWordImpl.Add(randomWord, wordFrequency);
                }

            }
        }
      
    }
}
