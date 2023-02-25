using DataAccess.util;
using EnglishWordSet.RefactoredStaticFuncs;
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
        public AdminTransactionsPage()
        {
            InitializeComponent();
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
            int wordsToBeAddCount = int.Parse(txtRandomWordToBeAddCount.Text.ToString());
            gettingRandom.AddRandomWordstoDB(wordsToBeAddCount);
      
        }


    }
}
