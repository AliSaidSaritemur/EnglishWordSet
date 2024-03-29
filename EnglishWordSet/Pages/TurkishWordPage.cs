﻿using DataAccess.Concrete;
using EnglishWordSet.Controllers;
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
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.LightCoral;
                    break;
                }
            }
        }
        TrWordImpl _trWordImpl = new();
        private void TurkishWordPage_Load(object sender, EventArgs e)
        {
           
        }

        private void TurkishWordPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnGetTurkishWord_Click(object sender, EventArgs e)
        {
            txtInputTurkishWords.Text = _trWordImpl.GetTurkishWordAndLevelsAsStringText(UserSession.username_Admin);
        }

        RichTextBoxBuilder richTextBoxBuilderForInputTxt;
        private void btnConvertTrWords_Click(object sender, EventArgs e)
        {
        string convertedText= StringTransactionsWithFunc.ReadStringWithAction(txtInputTurkishWords.Text.ToString(), getAndSetTurkishLine);
            txtInputTurkishWords.Text = convertedText;
            _trWordImpl.RemoveWordsWithLevel(3, UserSession.username_Admin);
            string outputTurkishWord = _trWordImpl.GetTurkishWordAndLevelsAsStringText(UserSession.username_Admin);
            txtOutputTurkishWords.Text = outputTurkishWord;
            AddLog.ConvertedwordsTurkih.Info($"{Sessions.UserSession.username_Admin} Last Convertion Transaction : \n {outputTurkishWord}");
             richTextBoxBuilderForInputTxt ??= new RichTextBoxBuilder(txtInputTurkishWords);
            richTextBoxBuilderForInputTxt.ChangeTxtInputWordsColor("true", Color.Green);
            richTextBoxBuilderForInputTxt.ChangeTxtInputWordsColor("false",Color.Red);
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
            
        

        private void btnInputClean_Click(object sender, EventArgs e)
        {
            txtInputTurkishWords.Text = "";
        }

        private void btnOutputClean_Click(object sender, EventArgs e)
        {
            txtOutputTurkishWords.Text = "";
        }

        private void pbBackMainPage_Click(object sender, EventArgs e)
        {
            PageTransactions.GetForm1().Show();
            Hide();
        }
        TurkishWordController turkishWordController;
        private void btnDeleteWord_Click(object sender, EventArgs e)
        {
            if(btnDeleteWord.Text.ToString()== "Delete Word") { 
             turkishWordController ??= new();
            turkishWordController.GetChildRemovingTurkishWordPage().Show();
                btnDeleteWord.Text = "Close Page";
            }
            else
            {
                btnDeleteWord.Text = "Delete Word";
                turkishWordController.GetChildRemovingTurkishWordPage().Hide();
            }

        }
    }
}
