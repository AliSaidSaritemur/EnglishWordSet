using EnglishWordSet.Pages;
using DataAccess.Concrete;
using EnglishWordSet.Sessions;
using System;
using System.Windows.Forms;
using LogAccess.services;
using System.Text.RegularExpressions;
using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.services.Impl.ConvertImpls;
using Util;
using EnglishWordSet.util;
using EnglishWordSet.Controllers;
using System.Drawing;

namespace EnglishWordSet
{
    public partial class Main : Form
    {
        private MBWordController mBWord;
        private MyImageFilter _myImageFilter = new();
        private  UserTextsImpl _UserTextsImpl = new();
        public Main()
        {
            InitializeComponent();
        }

        RichTextBoxBuilder richTextBoxBuilderForInputTxt;
        RichTextBoxBuilder richTextBoxBuilderForOutputTxt;
        private void btnConvert_Click(object sender, EventArgs e)
        {
            string tempText = txtInput.Text.ToString();

            bool saveStatu = cBSave.Checked;
            Converter converter;
            if (!cbSetDay.Checked)
            {
                converter = new Converter(new ConvertingWtihoutDays());
            }
            else if (cBSave.Checked)
            {
                converter = new Converter(new ConvertNext());
            }
            else
            {
                converter = new Converter(new ConvertingWithoutSave());
            }

            converter.randomStatue = true;
            tempText = converter.CovertText(tempText);

            txtOutput.Text = tempText;
            SetWordInform(txtOutput, lblWordCountOutput, lblWordDayAvarageOutput);
            string noSpaceOutput = RegexTransactions.EddittingStringValue.RemoveSpaces(tempText);
           
            if (saveStatu)
            {
                DateTime timeOnly = new DateTime(DateTime.Now.TimeOfDay.Ticks);
                _UserTextsImpl.AddToConvertedWords( tempText,Sessions.UserSession.username_Admin);
                AddLog.ConvertedWordsLogs.Info($"{UserSession.username_Admin} Converted words : \n {tempText}");

            }
            else
            {
               AddLog.ConvertedWordsLogs.Trace($"{UserSession.username_Admin} Converted words : \n {tempText}");
            }
            richTextBoxBuilderForOutputTxt ??= new RichTextBoxBuilder(txtOutput);
            richTextBoxBuilderForOutputTxt.ChangeTxtInputWordsColor("!!!", Color.Red);

        }

        private  void btnGetSaveText_Click(object sender, EventArgs e)
        {
            txtOutput.Text = _UserTextsImpl.GetConvertedWords(Sessions.UserSession.username_Admin);
        }

        private void btnGetNewWord_Click(object sender, EventArgs e)
        { 
            mBWord ??= new();
            string word = mBWord.GetWord();
            if (string.IsNullOrEmpty(word))
                return;

            DialogResult dialogResult;

            dialogResult = MessageBox.Show(word, "Do you know this word ?", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes)
            {
                mBWord.RemoveWord();
                btnGetNewWord_Click(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                LearnedWordImpl _learnedWordImpl = new();

                if (_learnedWordImpl.IsThere(word, UserSession.username_Admin))
                {
                    LearnedWordsController lwpb = ControllersGetter.LearnedPAge();
                    string sentenceWord = lwpb.GetSentence(word);
                    MessageBox.Show("You already learned this word. \nSentence : " + sentenceWord, word);
                    return;
                }

                ChildAdminNewLearnedWordPAgeGetter(word, mBWord.GetMeaning());
                Random rnd = new ();
                txtInput.Text = rnd.Next(10) < 5 ? mBWord.GetWordWithMeanig() + "\n" + txtInput.Text.ToString() : txtInput.Text.ToString() + "\n " + mBWord.GetWordWithMeanig();
                mBWord.RemoveWord();
                SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
            }
        }

        ChildAdminNewLearnedWord _childAdminNewLearned;
        private void ChildAdminNewLearnedWordPAgeGetter(string word, string meaning)
        {
            if (_childAdminNewLearned == null) { 
             _childAdminNewLearned = PageTransactions.GetChildAdminNewLearnedWordPageForMain(); 
            _childAdminNewLearned.formLocation = "Form1";
            _childAdminNewLearned.StartPosition = FormStartPosition.CenterScreen;
            }
            _childAdminNewLearned.txtWord.Text = word.Trim();
            _childAdminNewLearned.txtMeaning.Text = meaning;
            if (MyTestInternet.IsThereInternet())
            {
                _childAdminNewLearned.btnNewSentence_Click(new object(), new EventArgs());
            }

            _childAdminNewLearned.Show();
            GC.Collect();
        }

        private void btnToAdminPage_Click(object sender, EventArgs e)
        {
            Form page;
            page = PageTransactions.GetUserPage(); 
            page.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void getLaarnedWordPage_Click(object sender, EventArgs e)
        {
            Form page =PageTransactions.GetLearnedWordsPanelPage();
            GC.Collect();
            page.Show();
        }

        private  void pbCopy_Click(object sender, EventArgs e)
        {
            txtOutput.SelectionStart = 0;
            txtOutput.SelectionLength = txtOutput.Text.Length;

            if (txtOutput.SelectionLength > 0)
            {
                txtOutput.Copy();
                pbCopy.Image = Properties.Resources.sucsessBlue;
                timerCopySuccess.Start();

            }
        }

        private void timerCopySuccess_Tick(object sender, EventArgs e)
        {
            pbCopy.Image = Properties.Resources.Copy;
        }

        private void pbPaste_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Paste();
            _myImageFilter.GreenFilterToImageEffect(pbPaste);
            SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetWordInform(RichTextBox textBox, Label lblWordCount, Label lblWordDayAvarage)
        {
            string inputText = textBox.Text.ToString().Trim();
            TextInformationGeter informationGeter = new TextInformationGeter(inputText);

            int wordsCount = informationGeter.GetWordCount();
            int avarageDayWord = informationGeter.GetDaysAvarage();
            if (wordsCount != 0)
            {
                lblWordCount.Text = "Word Count : " + wordsCount;
                lblWordDayAvarage.Text = "Day Avarage : " + avarageDayWord;
            }
        }

        private void btnGetLast_Click(object sender, EventArgs e)
        {

            string words = _UserTextsImpl.GetLastConvertedWords(Sessions.UserSession.username_Admin);
            words = Regex.Replace(words, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            txtInput.Text = words;
            SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
            richTextBoxBuilderForInputTxt ??= new RichTextBoxBuilder(txtInput);
            richTextBoxBuilderForInputTxt.ChangeTxtInputWordsColor("!!!", Color.Red);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddLog.systemLogs.Info(UserSession.username_Admin + "  Logged out");

            if (!PageTransactions.MainIsNull())
                Environment.Exit(0);            
        }

        private void cbWordLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpenTurkishWordPage_Click(object sender, EventArgs e)
        {
        PageTransactions.GetTurkishWordPage().Show();
            Hide();

        }

        private void btnInputClean_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
        }

        private void btnOutputClean_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void pbLogOutMainPage_Click(object sender, EventArgs e)
        {        
            PageTransactions.CloseAllPage();
            Sessions.UserSession.role_Admin = null;
            GC.Collect();
            PageTransactions.GetLoginPage().Show();
        }
    }
}

