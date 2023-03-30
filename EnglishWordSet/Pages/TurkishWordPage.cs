using DataAccess.Concrete;
using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.services.Impl.ConvertTransactionsImpls;
using EnglishWordSet.Sessions;
using EnglishWordSet.util;
using LogAccess.services;
using Microsoft.Extensions.Logging;
using System;
using System.Drawing;
using System.Windows.Forms;
using Util;

namespace EnglishWordSet.Pages
{
    public partial class TurkishWordPage : Form
    {
        public TurkishWordPage()
        {
            InitializeComponent();
        }
        TrWordImpl _trWordImpl = new();
        private void TurkishWordPage_Load(object sender, EventArgs e)
        {

        }

        private void TurkishWordPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            PageTransactions.GetForm1().Show();
            Hide();
        }

        private void btnGetTurkishWord_Click(object sender, EventArgs e)
        {
            txtInputTurkishWords.Text = _trWordImpl.GetTurkishWordAndLevelsAsStringText(UserSession.username_Admin);
        }

        private void btnConvertTrWords_Click(object sender, EventArgs e)
        {
        string convertedText= StringTransactionsWithFunc.ReadStringWithAction(txtInputTurkishWords.Text.ToString(), getAndSetTurkishLine);
            txtInputTurkishWords.Text = convertedText;
            _trWordImpl.RemoveWordsWithLevel(3, UserSession.username_Admin);
            string outputTurkishWord = _trWordImpl.GetTurkishWordAndLevelsAsStringText(UserSession.username_Admin);
            txtOutputTurkishWords.Text = outputTurkishWord;
            AddLog.ConvertedwordsTurkih.Info($"{Sessions.UserSession.username_Admin} Last Convertion Transaction : \n {outputTurkishWord}");
            ChangeTxtInputWordsColor("true", Color.Green);
            ChangeTxtInputWordsColor("false",Color.Red);
        }

        DeleteAfterHyben deleteAfterHyben = new();
        DeleteBeforeHyben deleteBeforeHyben = new();
        RemovingMark removingMark = new();
        public  string getAndSetTurkishLine(string line)
        {
            string resultLine = line;
            string turkish = removingMark.EdditLine(deleteAfterHyben.EdditLine(line)).Trim();
            string english = deleteBeforeHyben.EdditLine(line).Trim();
            if (RegexTransactions.CheckingValue.IsName(turkish))
            {
                if(_trWordImpl.CheckWordsEnglishMeaning(turkish, english, UserSession.username_Admin))
                {
                    _trWordImpl.IncWordLevel(turkish, UserSession.username_Admin);
                    resultLine += " true" ;
                }
                else
                {
                    if(_trWordImpl.GetWordLevel(turkish, UserSession.username_Admin)>1)
                    _trWordImpl.DescWordLevel(turkish, UserSession.username_Admin);

                    resultLine += $"  false // true :{_trWordImpl.GetEnglishMeaning(turkish, UserSession.username_Admin)}";
                }
            }
            return resultLine;
        }
            
        public void ChangeTxtInputWordsColor(string word,Color color)
        {
            string tempInputWords = txtInputTurkishWords.Text.ToString();

            while (tempInputWords.IndexOf(word) >=0)
            {
                int indexOfWord = tempInputWords.IndexOf(word);
                int lengthofWord = word.Length;
                txtInputTurkishWords.Select(indexOfWord, lengthofWord);
                txtInputTurkishWords.SelectionColor = color;

                tempInputWords= tempInputWords.Remove(indexOfWord, 1).Insert(indexOfWord, $"{(char)(word[0]+1)}");
            }        
        }

        private void btnInputClean_Click(object sender, EventArgs e)
        {
            txtInputTurkishWords.Text = "";
        }

        private void btnOutputClean_Click(object sender, EventArgs e)
        {
            txtOutputTurkishWords.Text = "";
        }
    }
}
