using EnglishWordSet.CRUD;
using EnglishWordSet.Data.Contexts;
using EnglishWordSet.FileTransactions;
using EnglishWordSet.MyTools;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet
{
    public partial class Form1 : Form
    {
       private MBWordPageBackend mBWord ;
        public Form1()
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
           
            string wordAndMeaning = mBWord.GetWordWithMeanig();
           
            DialogResult dialogResult;
          
            dialogResult = MessageBox.Show(wordAndMeaning,"Do you know this word ?", MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes) {
                mBWord.RemoveWord();
                mBWord.SaveChange();
            }
            else if(dialogResult == DialogResult.No)
            {
                txtInput.Text = mBWord.GetWord()+" - \n"+txtInput.Text.ToString();
                mBWord.RemoveWord();
                mBWord.SaveChange();
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
        }

        private void timerPasteSuccess_Tick(object sender, EventArgs e)
        {
            pbPaste.Image= EnglishWordSet.Properties.Resources.paste;
        }
    }
}

