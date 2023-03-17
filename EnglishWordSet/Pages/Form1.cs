﻿using EnglishWordSet.CRUD;
using EnglishWordSet.MyTools;
using EnglishWordSet.PageBackend;
using EnglishWordSet.Pages;
using EnglishWordSet.RefactoredStaticFuncs;
using DataAccess.Concrete;
using EnglishWordSet.Sessions;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.util;
using LogAccess.services;
using System.Text.RegularExpressions;
using System.Linq;
using Image = System.Drawing.Image;
using LogAccess;
using System.Windows.Markup;
using EnglishWordSet.util.StaticTools;
using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.util.MyTools;
using EnglishWordSet.services.Impl.ConvertImpls;

namespace EnglishWordSet
{
    public partial class Main : Form
    {
        private string savesFileName = "/logs/ConvertedWord/ConvertedWords.log";
        private string saveTexts;
        private MBWordController mBWord;
        private MyImageFilter _myImageFilter = new();
        private  UserTextsImpl _UserTextsImpl = new();
        public Main()
        {
            InitializeComponent();
            PageTransactions.SetForm1(this);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string tempText = txtInput.Text.ToString();

            bool saveStatu = cBSave.Checked;
            Converter converter;
            if (cbSetDay.Checked)
            {
                 converter = new Converter(new ConvertNext());
            }
            else
            {
                 converter = new Converter(new ConvertingWtihoutDays());
            }

            converter.spaceStatu = cbSpace.Checked;
            converter.randomStatue = true;
            tempText = converter.CovertText(tempText);

            txtOutput.Text = tempText;
            SetWordInform(txtOutput, lblWordCountOutput, lblWordDayAvarageOutput);
            string noSpaceOutput = MyRegex.EddittingStringValue.RemoveSpaces(tempText);
           
            if (saveStatu)
            {
                _UserTextsImpl.AddToConvertedWords(tempText,Sessions.UserSession.username_Admin);
             //   AddLog.ConvertedWordsLogs.Info(tempText);

            }
            else
            {
               // AddLog.ConvertedWordsLogs.Trace(noSpaceOutput);
            }
        }

        private async void btnGetSaveText_Click(object sender, EventArgs e)
        {
            txtOutput.Text = _UserTextsImpl.GetConvertedWords(Sessions.UserSession.username_Admin);
        }

        private void btnGetNewWord_Click(object sender, EventArgs e)
        {
            mBWord ??= new();
            string word = mBWord.GetWord();

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

                if (_learnedWordImpl.IsThere(word))
                {
                    LearnedWordsController lwpb = ControllersGetter.LearnedPAge();
                    string sentenceWord = lwpb.GetSentence(word);
                    MessageBox.Show("You already learned this word. \nSentence : " + sentenceWord, word);
                    return;
                }

                ChildAdminNewLearnedWordPAgeGetter(word, mBWord.GetMeaning());
                Random rnd = new Random();
                txtInput.Text = rnd.Next(10) < 5 ? mBWord.GetWordWithMeanig() + "\n" + txtInput.Text.ToString() : txtInput.Text.ToString() + "\n " + mBWord.GetWordWithMeanig();
                mBWord.RemoveWord();
                SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
            }
        }

        private void ChildAdminNewLearnedWordPAgeGetter(string word, string meaning)
        {
            ChildAdminNewLearnedWord _childAdminNewLearned = PageTransactions.GetChildAdminNewLearnedWordPage();
            _childAdminNewLearned.txtWord.Text = word.Trim();
            _childAdminNewLearned.formLocation = "Form1";
            _childAdminNewLearned.txtMeaning.Text = meaning;
            _childAdminNewLearned.StartPosition = FormStartPosition.CenterScreen;

            if (MyTestInternet.IsThereInternet())
            {
                _childAdminNewLearned.btnNewSentence_Click(new object(), new EventArgs());
            }

            _childAdminNewLearned.Show();


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
            LoadAsync();
        }

        private async void LoadAsync()
        {
            await SetContext();
            await LoadMBAsync();
            btnGetNewWord.Enabled = true;
            btnToAdminPage.Enabled = true;
            getLaarnedWordPage.Enabled = true;
        }
        private Task LoadMBAsync()
        {
            return Task.Run(() =>
            {
                mBWord = ControllersGetter.mBWordPage();
            });
        }
        private Task SetContext()
        {
            return Task.Run(() =>
            {
                mBWord ??= new();
            });
        }

        private void getLaarnedWordPage_Click(object sender, EventArgs e)
        {
            Form page = new LearnedWordsPanel();
            page.Show();
        }

        private async void pbCopy_Click(object sender, EventArgs e)
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
            Image pasteImg = Properties.Resources.paste;
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
            if (!ReadSaveText())
                return;
            string words = _UserTextsImpl.GetLastConvertedWords(Sessions.UserSession.username_Admin);
            words = Regex.Replace(words, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            txtInput.Text = words;
            SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
        }


        private string GetLastWordsFromSaves()
        {
            Regex regex = new Regex("\\d{4}-\\d{2}-\\d{2} \\d{2}:\\d{2}:\\d{2}\\.\\d{4}");
            string vals = regex.Split(saveTexts)[0];
            vals ??= vals.Remove(vals.TrimEnd().LastIndexOf(Environment.NewLine));
            return vals;
        }

        private bool ReadSaveText()
        {

            saveTexts = " ";
            saveTexts = FileTransactions.ReadText(Settings.SettingsInfo.Default.ConvertedWordLog);
            saveTexts = string.Join("\r\n", saveTexts.Split('\r', '\n').Reverse());
            if (!string.IsNullOrEmpty(saveTexts))
                return true;
            else
            {
                AddLog.systemLogs.Error("There was a problem opening the Converter Word file.");
                return false;
                btnGetSaveText.Visible = false;
                btnGetLast.Visible = false;
                BasicAlerts.ErrorAlert("There are some technical problems with the display of transactions currently made. You can fix the problem by restarting the program.",
                    "Unable to access files");
                return false;
            }

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
                AddLog.systemLogs.Info(UserSession.username_Admin + "  Logged out");
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
    }
}

