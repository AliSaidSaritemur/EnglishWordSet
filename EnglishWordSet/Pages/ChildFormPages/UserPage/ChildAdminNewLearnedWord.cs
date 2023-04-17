using DataAccess.Concrete;
using EnglishWordSet.Controllers;
using EnglishWordSet.Sessions;
using EnglishWordSet.util;
using LogAccess.services;
using System;
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
          

            LearnedWordImpl _learnedWordImpl = new();

            if (WordProviderTest() || SentenceProviderTest() || MeanningProviderTest())
                return;


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
                Close();
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
            word = txtWord.Text.ToString().Trim();
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
            sentence = txtSentence.Text.ToString().Trim();
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
            meaning = txtMeaning.Text.ToString().Trim();
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

        LearnedWordImpl _learnedWordImpl;
        private void btnRemoveLearnedWord_Click(object sender, EventArgs e)
        { _learnedWordImpl ??= new LearnedWordImpl();
            if (WordProviderTest())
                return;

            else if (!_learnedWordImpl.IsThere(word.Trim(), UserSession.username_Admin))
            {
                MyNotificationAlerts.GetErrorMessage(word + " is not a Learned Word");
            }
            else { 
            _learnedWordImpl ??= new LearnedWordImpl();
            _learnedWordImpl.Delete(word, UserSession.username_Admin);
            AddLog.systemLogs.Info(" " + UserSession.username_Admin + " Deleted " + word);
            MyNotificationAlerts.GetSuccessMessage(" " + word + " was Deleted");
                }
        }
    }
}
