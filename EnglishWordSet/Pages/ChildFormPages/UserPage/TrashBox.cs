﻿using DataAccess.Concrete;
using EnglishWordSet.Sessions;
using EnglishWordSet.util;
using LogAccess.services;
using System;
using System.Windows.Forms;
using Util;

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
            string reversedTExt= RegexTransactions.EddittingStringValue.ReverseString(wrongWordsLogged);
            rtbTrashWords.Text = RegexTransactions.EddittingStringValue.RemoveSpaces(reversedTExt);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            _UserTextsImpl.UpdateToTrashBox(rtbTrashWords.Text.ToString(),Sessions.UserSession.username_Admin);
            AddLog.WrongWordsLogs.Info($"Wrong words list updated by { UserSession.username_Admin} new version: \n" + rtbTrashWords.Text.ToString());
            MyNotificationAlerts.GetSuccessMessage("The save operation was successful");      
        }

        private void btnCleanWrongWords_Click(object sender, EventArgs e)
        {
            _UserTextsImpl.UpdateToTrashBox("", Sessions.UserSession.username_Admin);
            rtbTrashWords.Text = "";
          MyNotificationAlerts.GetSuccessMessage("The clean operation was successful");
            AddLog.WrongWordsLogs.Info($"Wrong words list cleaned by {UserSession.username_Admin}");
        }

        private void TrashBox_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void rtbTrashWords_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrashBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChildAdminNewWord childNewWordPage = ControllersGetter.AdminPage().GetChildNewWordPage();
            childNewWordPage.SetTrashIcon();     
        }
    }
}
