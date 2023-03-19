using DataAccess.Concrete;
using EnglishWordSet.RefactoredStaticFuncs;
using Entities.Concrete;
using LogAccess.services;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Pages.ChildFormPages.AdminPage
{
    public partial class TrashBox : Form
    {
        public TrashBox()
        {
            InitializeComponent();
        }
        private string WrongWordsFileName = Settings.SettingsInfo.Default.WrongWordLogAdres;
        private UserTextsImpl _UserTextsImpl = new();
        private void TrashBox_Load(object sender, EventArgs e)
        {
            string wrongWordsLogged= _UserTextsImpl.GetTrashBoxText(Sessions.UserSession.username_Admin);
            string reversedTExt= MyRegex.EddittingStringValue.ReverseString(wrongWordsLogged);
            rtbTrashWords.Text = MyRegex.EddittingStringValue.RemoveSpaces(reversedTExt);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            _UserTextsImpl.UpdateToTrashBox(rtbTrashWords.Text.ToString(),Sessions.UserSession.username_Admin);
            AddLog.WrongWordsLogs.Info("Wrong words list updated new version: \n" + rtbTrashWords.Text.ToString());
            MyNotificationAlerts.GetSuccessMessage("The save operation was successful");      
        }

        private void btnCleanWrongWords_Click(object sender, EventArgs e)
        {
            _UserTextsImpl.UpdateToTrashBox("", Sessions.UserSession.username_Admin);
            rtbTrashWords.Text = "";
          MyNotificationAlerts.GetSuccessMessage("The clean operation was successful");
            AddLog.WrongWordsLogs.Info("Wrong words list cleaned" );
        }

        private void TrashBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            string wrongWordsLogged = _UserTextsImpl.GetTrashBoxText(Sessions.UserSession.username_Admin);
            ChildAdminNewWord childNewWordPage = ControllersGetter.AdminPage().GetChildNewWordPage();
            childNewWordPage.SetTrashIcon();
        }

        private void rtbTrashWords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
