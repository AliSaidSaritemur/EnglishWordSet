using EnglishWordSet.CRUD;
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

namespace EnglishWordSet
{
    public partial class Main : Form
    {
       private MBWordController mBWord ;
        public Main()
        {
            InitializeComponent();
            PageTransactions.SetForm1(this);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {   
            string tempText = txtInput.Text.ToString();

            bool saveStatu = cBSave.Checked;

            Converter converter = new Converter(new ConvertNext());       
            converter.spaceStatu = cbSpace.Checked;
            tempText = converter.CovertText(tempText);

            txtOutput.Text = tempText;
            SetWordInform(txtOutput, lblWordCountOutput, lblWordDayAvarageOutput);
            if (saveStatu)
            {
                AddLog.ConvertedWordsLogs.Info(tempText);
                string textPath = "Saves.txt";
                string textToSave = "\n\n" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n" + tempText;
                FileTransactions.WriteToText(textPath, textToSave);
            }
            else
            {
                AddLog.ConvertedWordsLogs.Trace(tempText);
            }
        }

        private void btnGetSaveText_Click(object sender, EventArgs e)
        {
            string savesFileName = "/logs/ConvertedWord/ConvertedWords.log";
            string saveTexts = FileTransactions.ReadText(savesFileName);
            txtOutput.Text = saveTexts;
        }
     
        private void btnGetNewWord_Click(object sender, EventArgs e)
        {
            mBWord ??= new ();
            string word = mBWord.GetWord();
           
            DialogResult dialogResult;
          
            dialogResult = MessageBox.Show(word, "Do you know this word ?", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes) {
                mBWord.RemoveWord();
                btnGetNewWord_Click(sender, e);
            }
            else if(dialogResult == DialogResult.No)
            {
                LearnedWordImpl _learnedWordImpl = new ();

                if (_learnedWordImpl.IsThere(word))
                {
                    LearnedWordsController lwpb = ControllersGetter.LearnedPAge();
                    string sentenceWord= lwpb.GetSentence(word);
                    MessageBox.Show("You already learned this word. \nSentence : "+ sentenceWord, word);
                    return;
                }

                Random rnd = new Random();
                txtInput.Text = rnd.Next(10) < 5 ? mBWord.GetWordWithMeanig() + "\n" +  txtInput.Text.ToString() : txtInput.Text.ToString() + "\n " + mBWord.GetWordWithMeanig();
                mBWord.RemoveWord();
                SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
            }
        }

        private void btnToAdminPage_Click(object sender, EventArgs e)
        {
            Form page;
            if (!string.IsNullOrEmpty(AdminSession.username_Admin))
            {page= PageTransactions.GetAdminPage(); }
            else
            { page = new LoginPage(); }
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
            Form page=new LearnedWordsPanel();
            page.Show();
        }

        private async void pbCopy_Click(object sender, EventArgs e)
        {
            txtOutput.SelectionStart = 0;
            txtOutput.SelectionLength = txtOutput.Text.Length;

            if (txtOutput.SelectionLength > 0)
            { txtOutput.Copy();
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

            Image pasteImg= Properties.Resources.paste;
            txtInput.Clear();
            txtInput.Paste();
      
            pbPaste.Image = MyImageFilter.GreenFilter(pasteImg);
            timerPasteSuccess.Start();
            SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
        }

        private void timerPasteSuccess_Tick(object sender, EventArgs e)
        {
            pbPaste.Image= Properties.Resources.paste;
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SetWordInform(RichTextBox textBox,Label lblWordCount, Label lblWordDayAvarage)
        {
            string inputText = textBox.Text.ToString().Trim();
            TextInformationGeter informationGeter = new TextInformationGeter(inputText);

            int wordsCount = informationGeter.GetWordCount();
            int avarageDayWord = informationGeter.GetDaysAvarage();
            if(wordsCount != 0) { 
            lblWordCount.Text = "Word Count : " + wordsCount;
            lblWordDayAvarage.Text = "Day Avarage : " + avarageDayWord;
            }
        }


    }
}

