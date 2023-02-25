using APIAccess.Concrete;
using DataAccess.util;
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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EnglishWordSet.util.MyTools
{
    internal  class DictionaryTransections
    {
        GettingRandomWordWithFrequencyLevel _RandomWordWithFrequency = new();
        private  HttpClient client = new();
        private  List<String> wordSentencelist = new List<String>();
        private  int wordSentencelistNum = 0;
        private RapidAPISImpl _rapidAPISImpl=new();
        private  string lastQueryWord = "";
        public  async void GetSEntenceByWordtoTextBox(RichTextBox textBoxtoWriteSentence, string queryWord)
        {
            wordSentencelist = await _rapidAPISImpl.GetExammples(queryWord);
            ExamplesArrange(wordSentencelist);
            ChangeSentenceInTextBox(textBoxtoWriteSentence);
            lastQueryWord = queryWord;
        }
        private  async void ChangeSentenceInTextBox(RichTextBox textBoxtoWriteSentence)
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
   
        private  async void ExamplesArrange(List<String> examplestobeArranged)
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
     
        public  async void GetRandomWordtoTextBox(RichTextBox textBoxtoWriteSentence, int getttingCount)
        {

          
        }

    }
}