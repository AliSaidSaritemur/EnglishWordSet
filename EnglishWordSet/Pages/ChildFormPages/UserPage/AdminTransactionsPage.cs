using DataAccess.util;
using EnglishWordSet.Controllers;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.util.StaticTools;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Pages.ChildFormPages.UserPage
{
    public partial class AdminTransactionsPage : Form
    {
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
    }
}
