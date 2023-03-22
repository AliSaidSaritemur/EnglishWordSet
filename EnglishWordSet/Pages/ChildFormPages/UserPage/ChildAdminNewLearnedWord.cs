using DataAccess.Concrete;
using EnglishWordSet.PageBackend;
using EnglishWordSet.Sessions;
using EnglishWordSet.ToolsBackend;
using EnglishWordSet.util;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace EnglishWordSet.ChildForms.AdminPage
{
    public partial class ChildAdminNewLearnedWord : Form
    {
        TextBox focusText;
        string word;
        string sentence;
        string meaning;
        private MyImageFilter _myImageFilter = new();
        private DictionaryTransections _dictionaryTransections= new();
        public string formLocation = "InAdminPage";
        public ChildAdminNewLearnedWord()
        {
            InitializeComponent();
            focusText = txtWord;
            focusText.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            word = txtWord.Text.ToString().Trim();
            sentence = txtSentence.Text.ToString().Trim();
            meaning = txtMeaning.Text.ToString().Trim();

            LearnedWordImpl _learnedWordImpl = new();

            if (_learnedWordImpl.IsThere(word, UserSession.username_Admin))
            {
                LearnedWordsController lwpb = ControllersGetter.LearnedPAge();
                string sentenceWord = lwpb.GetSentence(word);
                MessageBox.Show("You already learned this word. \nSentence : " + sentenceWord, word);
                return;
            }

           else if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Learned Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }


            if (WordProviderTest()||SentenceProviderTest()||MeanningProviderTest())
                return;
       
            UserController pageBackend = ControllersGetter.AdminPage();
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
            AddLog.systemLogs.Info(" "+word+" is added to LearnedWords");
            if (formLocation == "Form1")
            {
                Hide();
            }
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
          string  word = txtWord.Text.ToString().Trim();
            if (word.Length == 0)
            {
                prWord.SetError(txtWord, "Word can't be empty !!!");
                return true;
            }
            else if (!RegexTransactions.CheckingValue.IsName(word))
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
                prSentence.SetError(txtSentence, "Sentence can't be empty !!!");
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool MeanningProviderTest()
        {
            if (!string.IsNullOrEmpty(meaning) && !RegexTransactions.CheckingValue.IsName(meaning))
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

        private void ChildAdminNewLearnedWord_Load(object sender, EventArgs e)
        {

        }

        private void ChildAdminNewLearnedWord_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        internal void btnNewSentence_Click(object sender, EventArgs e)
        {

            prSentence.Clear();

            if (WordProviderTest())
            {
                return;
            }
          else  if (MyTestInternet.IsThereInternet())
            {
                _myImageFilter.GreenFilterToImageEffect(btnNewSentence);
                _dictionaryTransections.GetSEntenceByWordtoTextBox(txtSentence, txtWord.Text.ToString().Trim());
            }
            else
            {
                    BasicAlerts.ErrorAlert("Senteces can't getting.\nFor adding sentencess," +
                   " connect to the internet.", "No internet access");
            }
        }
    }
}
