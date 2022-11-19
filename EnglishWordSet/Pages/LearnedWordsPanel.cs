using EnglishWordSet.Data.Entities;
using EnglishWordSet.PageBackend;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Tulpep.PayULibrary.Models.Request.Request_Cross;

namespace EnglishWordSet.Pages
{
    public partial class LearnedWordsPanel : Form
    {
        
        public LearnedWordsPanel()
        {
            InitializeComponent();

        }

        private void LearnedWordsPanel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtSearch;
            txtSearch.Focus();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            string searchedWord = txtSearch.Text.ToString().Trim();
            LearnedWordsPageBackend lwpb = MyGetBackend.LearnedPAge();
             LearnedWord learnedWord = lwpb.SelectWord(searchedWord);

            if(learnedWord == null)
            {
                MyNotificationAlerts.GetErrorMessage("System has no "+ searchedWord+" word");
                return;
            }
            lblSentence.Text = learnedWord.wordSentence;


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pbSearch_Click(sender, e);
            }
        }
    }
}
