﻿using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using EnglishWordSet.util.StaticTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.ChildForms.AdminPage
{
    public partial class ChildAdminNewLearnedWord : Form
    {
        TextBox focusText;
        string word;
        string sentence;
        string meaning;
        public ChildAdminNewLearnedWord()
        {
            InitializeComponent();
            focusText = txtWord;
            this.ActiveControl = focusText;
            focusText.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Learned Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }

             word = txtWord.Text.ToString().Trim();
             sentence = txtSentence.Text.ToString().Trim();
             meaning = txtMeaning.Text.ToString().Trim();

            if (WordProviderTest()||SentenceProviderTest()||MeanningProviderTest())
                return;
       
            AdminController pageBackend = ControllersGetter.AdminPage();
            if (pageBackend.IsLEarnedWordAdded(word))
            {
                MyNotificationAlerts.GetErrorMessage("The word is already added to Database");
                return;
            }
           
            pageBackend.AddNewLearnedWord(word,sentence,meaning);
            txtWord.Clear();
            txtSentence.Clear();
            txtMeaning.Clear();
            MyNotificationAlerts.GetSuccessMessage("The word is added to Database");
        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtSentence.Focus();
            }
        }

        private void ChildAdminNewLearnedWord_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSentence_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItDown(e))
            {
                txtMeaning.Focus();
            }
            else if (MyKeyDownValueCheck.IsItUp(e))
            {
                txtWord.Focus();
            }
        }

        private void txtMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItDown(e))
            {
                btnAdd.Focus();
            }
            else if (MyKeyDownValueCheck.IsItUp(e))
            {
                txtSentence.Focus();
            }
        }
        
        private bool WordProviderTest()
        {
            if (word.Length == 0)
            {
                prWord.SetError(txtWord, "Word can't be empty !!!");
                return true;
            }
            else if (!MyRegex.IsName(word))
            {
                prWord.SetError(txtWord, "Word should be invalid type !!!");
                return true;
            }
            else
            {
                prWord.Clear();
                return false;
            }
        }

        private bool SentenceProviderTest()
        {
            if (sentence.Length == 0)
            {
                prWord.SetError(txtSentence, "Sentence can't be empty !!!");
                return true;
            }
            else if (!MyRegex.IsName(sentence))
            {
                prSentence.SetError(txtSentence, "Sentence should be invalid type !!!");
                return true;
            }
            else
            {
                prSentence.Clear();
                return false;
            }
        }
        private bool MeanningProviderTest()
        {
            if (!string.IsNullOrEmpty(meaning) && !MyRegex.IsName(meaning))
            {
                prMeanning.SetError(txtMeaning, "Meaning should be invalid type !!!");
                return true;
            }
            else
            {
                prMeanning.Clear();
                return false;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                object sender = new object();
                EventArgs e = new EventArgs();
                this.btnAdd_Click(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}