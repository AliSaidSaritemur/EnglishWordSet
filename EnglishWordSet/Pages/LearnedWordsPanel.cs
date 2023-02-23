using EnglishWordSet.MyTools;
using EnglishWordSet.PageBackend;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using Entities.Concrete;
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


namespace EnglishWordSet.Pages
{
    public partial class LearnedWordsPanel : Form
    {
        UnsplashImagesTransaction tran;
        string searchedWord;
        bool isConnectWifi=false;
        private MyImageFilter _myImageFilter = new();
        public LearnedWordsPanel()
        {
            InitializeComponent();
            tran = new();
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
            LearnedWordsController lwpb = ControllersGetter.LearnedPAge();
             LearnedWord learnedWord = lwpb.SelectWord(searchedWord);
            string learnedwordString;

            if(learnedWord == null)
            {
                MyNotificationAlerts.GetErrorMessage("System has no "+ searchedWord+" word");
                lblSentences.Text="";
                pBLearned.Visible=false;
            }
            else
            {     
                lblSentences.Text = learnedWord.wordSentence;
                pBLearned.Enabled = true;
                pBLearned.Visible = true;
                pBLearned.Image = EnglishWordSet.Properties.Resources.tipMark;        
            }
            btnChangeImage.Visible = false;
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
            pBLearned.Enabled= false;
            btnChangeImage.Visible = true;
            btnChangeImage_Click(sender, e);
        }
        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            if (!MyTestInternet.IsThereInternet())
            {
                WifiConnectionAlert();
                return;
            }
            else if(!isConnectWifi) 
            {   WifiEPtimer.Stop();
                epWifiConnectionImage.Clear();
                isConnectWifi = true;
            }
                
            tran.getImageWithWord(pBLearned, searchedWord);
            btnChangeImage.Enabled = false;
            timerImageEnable.Start();
        }
        private void WifiEPtimer_Tick(object sender, EventArgs e)
        {
            pBLearned.Image = EnglishWordSet.Properties.Resources.wifiDisconnect;
        }

        private void timerImageEnable_Tick(object sender, EventArgs e)
        {
            btnChangeImage.Enabled = true;
        }
        private void WifiConnectionAlert()
        {
            Image disConnectImage = EnglishWordSet.Properties.Resources.wifiDisconnect;
            _myImageFilter.RedFilterToImageEffect(pBLearned);
            epWifiConnectionImage.SetError(pBLearned, "No Internet connection !!!");
            pBLearned.Enabled = true;
            btnChangeImage.Visible = false;
            isConnectWifi = false;  
        }
       
    }
}
