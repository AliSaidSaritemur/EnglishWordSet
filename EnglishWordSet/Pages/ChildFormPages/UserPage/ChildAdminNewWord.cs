using DataAccess.Concrete;
using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.MyTools;
using EnglishWordSet.Pages;
using EnglishWordSet.Pages.ChildFormPages.AdminPage;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.services.Impl.ConvertImpls;
using EnglishWordSet.Sessions;
using EnglishWordSet.ToolsBackend;
using EnglishWordSet.util.MyTools;
using EnglishWordSet.util.StaticTools;
using Entities.Concrete;
using LogAccess.services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EnglishWordSet
{
    public partial class ChildAdminNewWord : Form
    {
        private DictionaryTransections _dictionaryTransections = new();
       private UserController pageBackend = ControllersGetter.AdminPage();
        private UserImpl adminImpl= new UserImpl();
        private MyImageFilter _myImageFilter= new();
        public ChildAdminNewWord()
        {
            InitializeComponent();
            SetSystem();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
     
            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }
            string WordstobeSave = GetWordstobeSave();

            if (string.IsNullOrEmpty(WordstobeSave)) {
            
            }
            else
            {
                
                txtInput.Text = Regex.Replace(WordstobeSave, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
                pageBackend.AddNewWords(txtInput.Text.ToString().Trim());
                MyNotificationAlerts.GetSuccessMessage("The words are added to Database");
            }
            txtInput.Clear();
          
        }


        private string GetWordstobeSave()
        {
          

            string input = txtInput.Text.ToString().Trim();

            Converter converter = new Converter(new ConvertingRemoveWordsAfterMark());
            input= converter.CovertText(input);

            if (input.Length == 0)
            {
                prWords.SetError(txtInput, "Words can't be empty !!!");
                return input;
            }
            else if (!MyRegex.CheckingValue.IsName(input))
            {
               string  inputWithoutEmpty =  Regex.Replace(input, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline).Trim();
                string logMessage="";
                string WordstobeSave = "";
                string line;
                StringReader stringReaderTranslated = new(inputWithoutEmpty);
                while (true)
                {
                    line = stringReaderTranslated.ReadLine();

                    if (line != null)
                    {
                        if (!MyRegex.CheckingValue.IsName(line.Trim()))
                            logMessage += line+"\n";
                        else
                            WordstobeSave=line + "\n";
                    }
                    else
                    {
                        break;
                    }
                }
               _myImageFilter.RedFilterToImageEffect(imgTrash);
                AddLog.WrongWordsLogs.Info(logMessage);
                FileTransactions.AddTextToFile(Settings.SettingsInfo.Default.WrongWordLogAdres, logMessage);
                prWords.Clear();
                return WordstobeSave;
            }
            else
            {
                prToken.Clear();
                prWords.Clear();
                return input;
            }
        }
        private void imgTrash_Click(object sender, EventArgs e)
        {
            Form TrashWrongWordPage = new TrashBox();
            TrashWrongWordPage.Show();
        }

        internal void SetTrashIcon()
        {
            string wrongWordsLogged = FileTransactions.ReadText(Settings.SettingsInfo.Default.WrongWordLogAdres);
            if (!string.IsNullOrEmpty(wrongWordsLogged))
                 imgTrash.Image = Properties.Resources.FullTrash;
            else
             imgTrash.Image = Properties.Resources.trash;
        }

        private void btnGetRandomWord_Click(object sender, EventArgs e)
        {
            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Random words can't get.\nFor getting words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }
            UserController pageBackend = ControllersGetter.AdminPage();
            string getRandomCountString = txtToBeGEttingRandomWordCount.Text.ToString();
            if (string.IsNullOrEmpty(getRandomCountString))
            {
                prToken.SetError(txtToBeGEttingRandomWordCount, "Please enter amount of words to be getting");
                return;
            }
         
            int getRandomCountInt = int.Parse(getRandomCountString);


            if (!adminImpl.IsTokenEnough(AdminSession.username_Admin, getRandomCountInt)) {
                prToken.SetError(txtToBeGEttingRandomWordCount,"Your Token amount is not enough");
                return;
            }
            else
            {
                prToken.Clear();
            }

            _dictionaryTransections.GetRandomWordtoTextBox(txtInput, getRandomCountInt);

            adminImpl.ToReduceToken(AdminSession.username_Admin, getRandomCountInt);
            SetSystem();
        }

        private void txtToBeGEttingRandomWordCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ChildAdminNewWord_Load(object sender, EventArgs e)
        {

        }
        private void SetSystem()
        {
            lblTokenAmount.Text = adminImpl.GetToken(AdminSession.username_Admin).ToString();
            SetTrashIcon();
        }

        private void getMeaningWithMark_Click(object sender, EventArgs e)
        {
            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Words meanning can't get.\nFor getting words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }
            if (!adminImpl.IsTokenEnough(AdminSession.username_Admin, 1))
            {
                prToken.SetError(lblTokenAmount, "Your Token amount is not enough");
                return;
            }
            else
            {
                prToken.Clear();
            }

            string englishWords =txtInput.Text.ToString().Trim();
            string markedAndTranslatedWords = pageBackend.getMeaningWithMark(englishWords);
            txtInput.Text = markedAndTranslatedWords;

            adminImpl.ToReduceToken(AdminSession.username_Admin, 1);
            SetSystem();
        }

        private void txtToBeGEttingRandomWordCount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
