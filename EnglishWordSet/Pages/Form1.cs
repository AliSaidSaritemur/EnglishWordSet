using EnglishWordSet.Check.Word;
using EnglishWordSet.CRUD;
using EnglishWordSet.Data.Contexts;
<<<<<<< HEAD
using EnglishWordSet.Data.Entities;
using EnglishWordSet.MyTools;
using EnglishWordSet.PageBackend;
=======
<<<<<<< HEAD
using EnglishWordSet.Data.Entities;
using EnglishWordSet.MyTools;
using EnglishWordSet.PageBackend;
=======
using EnglishWordSet.MyTools;
>>>>>>> e786232210edb1947b3038abcfc91f427dd1cdf5
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
using EnglishWordSet.Pages;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.Sessions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet
{
    public partial class Main : Form
    {
       private MBWordPageBackend mBWord ;
        public Main()
        {
            InitializeComponent();
            MyPageGetter.SetForm1(this);
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
                string textPath = "Saves.txt";
                string textToSave = "\n\n" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n" + tempText;
                TextManagment.WriteToText(textPath, textToSave);
            }

        }

        private void btnGetSaveText_Click(object sender, EventArgs e)
        {
            string savesFileName = "Saves.txt";
            string saveTexts = TextManagment.ReadText(savesFileName);
            txtOutput.Text = saveTexts;
        }
     
        private void btnGetNewWord_Click(object sender, EventArgs e)
        {
            mBWord = new MBWordPageBackend();
            string word = mBWord.GetWord();
           
            DialogResult dialogResult;
          
            dialogResult = MessageBox.Show(word, "Do you know this word ?", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes) {
                mBWord.RemoveWord();
                mBWord.SaveChange();
            }
            else if(dialogResult == DialogResult.No)
            {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
                ICheckWord IsWordInLearned = new IsLearned();

                if (IsWordInLearned.IsCheck(word))
                {
                    LearnedWordsPageBackend lwpb = MyGetBackend.LearnedPAge();
                    string sentenceWord= lwpb.GetSentence(word);
                    MessageBox.Show("You already learned this word. \nSentence : "+ sentenceWord, word);
                    return;
                }

                Random rnd = new Random();
                txtInput.Text = rnd.Next(10) < 5 ? mBWord.GetWordWithMeanig() + "\n" +  txtInput.Text.ToString() : txtInput.Text.ToString() + "\n " + mBWord.GetWordWithMeanig();
<<<<<<< HEAD
=======
=======
                Random rnd = new Random();
                txtInput.Text = rnd.Next(10) < 5 ? mBWord.GetWord() + " - \n" + txtInput.Text.ToString() : txtInput.Text.ToString() + " - \n"+ mBWord.GetWord();
>>>>>>> e786232210edb1947b3038abcfc91f427dd1cdf5
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
                mBWord.RemoveWord();
                mBWord.SaveChange();
                SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
            }
        }

        private void btnToAdminPage_Click(object sender, EventArgs e)
        {
            Form page;
            if (AdminSession.id_Admin != null && AdminSession.id_Admin != 0)
            {page= MyPageGetter.GetAdminPage(); }
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
        }
        private Task LoadMBAsync()
        {
            return Task.Run(() =>
            {
                mBWord = MyGetBackend.mBWordPage();
            });
        }
        private Task SetContext()
        {
            return Task.Run(() =>
            {
                MyDBTransactions.SetContext();
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
                pbCopy.Image = EnglishWordSet.Properties.Resources.sucsessBlue;
                timerCopySuccess.Start();
            
            }
        }
      
        private void timerCopySuccess_Tick(object sender, EventArgs e)
        {
            pbCopy.Image = EnglishWordSet.Properties.Resources.Copy;
        }

        private void pbPaste_Click(object sender, EventArgs e)
        {

            Image pasteImg= EnglishWordSet.Properties.Resources.paste;
            txtInput.Clear();
            txtInput.Paste();
      
            pbPaste.Image = MyImageFilter.GreenFilter(pasteImg);
            timerPasteSuccess.Start();
            SetWordInform(txtInput, lblWordCountInput, lblWordDayAvarageInput);
        }

        private void timerPasteSuccess_Tick(object sender, EventArgs e)
        {
            pbPaste.Image= EnglishWordSet.Properties.Resources.paste;
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

