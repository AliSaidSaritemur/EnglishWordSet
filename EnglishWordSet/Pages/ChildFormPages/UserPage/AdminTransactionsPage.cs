using DataAccess.Concrete;
using DataAccess.util;
using EnglishWordSet.Controllers;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.util.StaticTools;
using LogAccess.services;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnglishWordSet.Pages.ChildFormPages.UserPage
{
    public partial class AdminTransactionsPage : Form
    {
        LearnedWordImpl _learnedWordImpl;
        GettingRandomWordWithFrequencyLevel gettingRandom=new();
        AdminTransactionsController adminTransactionsController;
        public AdminTransactionsPage()
        {
            InitializeComponent();
            adminTransactionsController = new(this);
        }

        private void txtRandomWordToBeAddCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddRandomWordtoDB_Click(object sender, EventArgs e)
        {

            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else if (!MyRegex.CheckingValue.IsNumber(txtRandomWordToBeAddCount.Text.ToString()))
            {
                prAddRandomWords.SetError(txtRandomWordToBeAddCount, "Please enter just number of words to be getting");
                return;
            }
            else if (txtRandomWordToBeAddCount.Text.ToString().Length > 9)
            {
                prAddRandomWords.SetError(txtRandomWordToBeAddCount, "Please enter a smaller number");
                return;
            }
            else
            {
                prAddRandomWords.Clear();
            }
            int wordsToBeAddCount = int.Parse(txtRandomWordToBeAddCount.Text.ToString());
            pBarAddingRandomWords.Maximum = wordsToBeAddCount;
            adminTransactionsController.AddRandomWordstoDB(wordsToBeAddCount);
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void AdminTransactionsPage_Load(object sender, EventArgs e)
        {

        }
        private void pBarAddingRandomWords_Click(object sender, EventArgs e)
        {

        }

        private void AdminTransactionsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnDeleteWordFromLearned_Click(object sender, EventArgs e)
        {
            _learnedWordImpl ??= new LearnedWordImpl();

            string word = txtWordtoBeDeleteFromLearned.Text.ToString().Trim();
            if (string.IsNullOrEmpty(word))
            {
                prDeleteLeanerdWords.SetError(txtWordtoBeDeleteFromLearned,"Enter the word you want to delete");
                return;
            }
           else if (!_learnedWordImpl.IsThere(word))
            {
                MyNotificationAlerts.GetErrorMessage(word +" is not a Learned Word");

            }
            else
            {
                _learnedWordImpl.Delete(word);
                AddLog.systemLogs.Info(" " + word + " was Deleted ");
                MyNotificationAlerts.GetSuccessMessage(" " + word + " was Deleted ");
            }
            prDeleteLeanerdWords.Clear();
        }

        private void txtRandomWordToBeAddCount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (txtRandomWordToBeAddCount.Text.ToString().Length > 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
