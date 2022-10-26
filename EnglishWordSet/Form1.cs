using EnglishWordSet.CRUD;
using EnglishWordSet.Data.Contexts;
using EnglishWordSet.FileTransactions;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string tempText = txtInput.Text.ToString();

            bool spaceStatu =cbSpace.Checked;
            bool saveStatu = cBSave.Checked;

            Converter converter = new Converter(new ConvertNext());       
            converter.spaceStatu = cbSpace.Checked;
            tempText = converter.CovertText(tempText);

            txtOutput.Text = tempText;
            txtOutput.Lines = txtOutput.Lines.Where(line => line.Trim() != string.Empty).ToArray();
            if (cbSpace.Checked)
            {
                txtOutput.Text = txtOutput.Text.Replace("-","- \n");
            }
           
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

        private void btnCopyOutput_Click(object sender, EventArgs e)
        {           
             txtOutput.SelectionStart = 0;
            txtOutput.SelectionLength = txtOutput.Text.Length;

            if (txtOutput.SelectionLength > 0)
                txtOutput.Copy();
        }

        private void btnPasteInput_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtInput.Paste();
        }

        private void btnGetNewWord_Click(object sender, EventArgs e)
        {   
          
            MBWordBackend mBWord = new();
            string wordAndMeaning = mBWord.GetWordWithMeanig();
            DialogResult dialogResult;
          
            dialogResult = MessageBox.Show(wordAndMeaning,"Do you know this word ?", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes) {
                mBWord.RemoveWord();
            }
            else if(dialogResult == DialogResult.No)
            {
                txtInput.Text = mBWord.GetWord()+" - \n"+txtInput.Text.ToString();
                mBWord.RemoveWord();
            }
            mBWord.SaveChange();
        }
    }
}

