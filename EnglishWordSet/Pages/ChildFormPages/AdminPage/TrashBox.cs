using EnglishWordSet.RefactoredStaticFuncs;
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
        private string WrongWordsFileName = "/logs/WrongWords/WronWordsUser.log";
        private void TrashBox_Load(object sender, EventArgs e)
        {
            string wrongWordsLogged= FileTransactions.ReadText(WrongWordsFileName);
        string reversedTExt= MyRegex.EddittingStringValue.ReverseString(wrongWordsLogged);
            rtbTrashWords.Text = MyRegex.EddittingStringValue.RemoveSpaces(reversedTExt);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            FileTransactions.WriteText(WrongWordsFileName, rtbTrashWords.Text.ToString());
            MyNotificationAlerts.GetSuccessMessage("The save operation was successful");
            AddLog.WrongWordsLogs.Trace("Wrong words list updated new version: \n" + rtbTrashWords.Text.ToString());
        }

        private void btnCleanWrongWords_Click(object sender, EventArgs e)
        {
            rtbTrashWords.Text = "";
            FileTransactions.WriteText(WrongWordsFileName, rtbTrashWords.Text.ToString());
            MyNotificationAlerts.GetSuccessMessage("The clean operation was successful");
            AddLog.WrongWordsLogs.Trace("Wrong words list cleaned" );
        }

        private void TrashBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            string wrongWordsLogged = FileTransactions.ReadText(WrongWordsFileName);
            ChildAdminNewWord childNewWordPage = ControllersGetter.AdminPage().GetChildNewWordPage();
            childNewWordPage.SetTrashIcon();
        }

        private void rtbTrashWords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
