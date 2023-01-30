using EnglishWordSet.Data.Entities;
using EnglishWordSet.PageBackend;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Collections.Specialized;
=======
<<<<<<< HEAD
using System.Collections.Specialized;
=======
>>>>>>> e786232210edb1947b3038abcfc91f427dd1cdf5
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
            lblSentence.AutoSize = true;
            string searchedWord = txtSearch.Text.ToString().Trim();
            LearnedWordsPageBackend lwpb = MyGetBackend.LearnedPAge();
             LearnedWord learnedWord = lwpb.SelectWord(searchedWord);
            string learnedwordString;
<<<<<<< HEAD
=======
=======
            string searchedWord = txtSearch.Text.ToString().Trim();
            LearnedWordsPageBackend lwpb = MyGetBackend.LearnedPAge();
             LearnedWord learnedWord = lwpb.SelectWord(searchedWord);
>>>>>>> e786232210edb1947b3038abcfc91f427dd1cdf5
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1

            if(learnedWord == null)
            {
                MyNotificationAlerts.GetErrorMessage("System has no "+ searchedWord+" word");
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
                lblSentences.Text="";
                return;
            }
            else
            {     
                lblSentences.Text = learnedWord.wordSentence;
            }
           
<<<<<<< HEAD
=======
=======
                lblSentence.Text="";
                return;
            }
            else
            {
                lblSentence.Text = learnedWord.wordSentence;
            }
           


>>>>>>> e786232210edb1947b3038abcfc91f427dd1cdf5
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
