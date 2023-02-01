using EnglishWordSet.Data.Entities;
using EnglishWordSet.MyTools;
using EnglishWordSet.PageBackend;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        string searchedWord;
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
            lblSentence.AutoSize = true;
             searchedWord = txtSearch.Text.ToString().Trim();
            LearnedWordsPageBackend lwpb = MyGetBackend.LearnedPAge();
             LearnedWord learnedWord = lwpb.SelectWord(searchedWord);
            string learnedwordString;

            if(learnedWord == null)
            {
                MyNotificationAlerts.GetErrorMessage("System has no "+ searchedWord+" word");
                lblSentences.Text="";
                return;
            }
            else
            {     
                lblSentences.Text = learnedWord.wordSentence;
                pBLearned.Enabled = true;
            }
           
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

        private void pBLearned_Click(object sender, EventArgs e)
        {
            if (!MyTestInternet.IsThereInternet())
            {
                Image disConnectImage = EnglishWordSet.Properties.Resources.wifiDisconnect;
                pBLearned.Image = MyImageFilter.RedFilter(disConnectImage);
                epWifiConnectionImage.SetError(pBLearned, "No Internet connection !!!");
                WifiEPtimer.Start();
                return;
            }
            UnsplashImagesTransaction tran = new();
            tran.getImageWithWord(pBLearned, searchedWord);
            pBLearned.Enabled=false;
            timerImageEnable.Start();
        }

        private void WifiEPtimer_Tick(object sender, EventArgs e)
        {
            pBLearned.Image = EnglishWordSet.Properties.Resources.wifiDisconnect;
        }

        private void timerImageEnable_Tick(object sender, EventArgs e)
        {
            pBLearned.Enabled = true;
        }
    }
}
