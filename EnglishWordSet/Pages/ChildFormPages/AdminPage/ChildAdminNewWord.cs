using EnglishWordSet.MyTools;
using EnglishWordSet.Pages;
using EnglishWordSet.Pages.ChildFormPages.AdminPage;
using EnglishWordSet.RefactoredStaticFuncs;
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
        private string WrongWordsFileName = "/logs/WrongWords/WronWordsUser.log";
        public ChildAdminNewWord()
        {
            InitializeComponent();
            SetTrashIcon();
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

            if (string.IsNullOrEmpty(WordstobeSave))
                return;

            AdminController pageBackend = ControllersGetter.AdminPage();
            txtInput.Text = Regex.Replace(WordstobeSave, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            pageBackend.AddNewWords(txtInput.Text.ToString().Trim());    
            txtInput.Clear();
            MyNotificationAlerts.GetSuccessMessage("The words are added to Database");
        }


        private string GetWordstobeSave()
        {
           string input = txtInput.Text.ToString().Trim();
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
                imgTrash.Image = MyImageFilter.RedFilter(Properties.Resources.trash);
                timerTresh.Start();
                AddLog.WrongWordsLogs.Info(logMessage);
                prWords.Clear();
                return WordstobeSave;
            }
            else
            {
                prWords.Clear();
                return input;
            }
        }

        private void timerTresh_Tick(object sender, EventArgs e)
        {
            imgTrash.Image =Properties.Resources.FullTrash;
        }

        private void imgTrash_Click(object sender, EventArgs e)
        {
            Form TrashWrongWordPage = new TrashBox();
            TrashWrongWordPage.Show();
        }

        internal void SetTrashIcon()
        {
            string wrongWordsLogged = FileTransactions.ReadText(WrongWordsFileName);
            if (!string.IsNullOrEmpty(wrongWordsLogged))
                 imgTrash.Image = Properties.Resources.FullTrash;
            else
             imgTrash.Image = Properties.Resources.trash;
        }

        private void btnGetRandomWord_Click(object sender, EventArgs e)
        {
            DictionaryTransections.GetRandomWordtoTextBox(txtInput);
        }
    }
}
