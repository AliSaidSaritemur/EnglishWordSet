using APIAccess.Concrete;
using Entities.Concrete;
using Util;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeConverter = Util.TypeConverter;
using EnglishWordSet.util;
using EnglishWordSet.Controllers;
using DataAccess.Concrete;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            this.ActiveControl = cBSearchedWords;
            cBSearchedWords.Focus();
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            lblSentence.AutoSize = true;
             searchedWord = cBSearchedWords.Text.ToString().Trim();
            LearnedWordsController lwpb = ControllersGetter.LearnedPAge();
             LearnedWord learnedWord = lwpb.SelectWord(searchedWord);

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


        private void pBLearned_Click(object sender, EventArgs e)
        {                   
            pBLearned.Enabled= false;
            btnChangeImage.Visible = true;
            btnChangeImage_ClickAsync(sender, e);
        }
        private async void btnChangeImage_ClickAsync(object sender, EventArgs e)
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
                
          string wordImgUrl = await tran.getImageWithWord(searchedWord);
            if (wordImgUrl != null)
                pBLearned.Image = TypeConverter.ConverterURLtoImage(wordImgUrl);
            else
                pBLearned.Image = Properties.Resources.noImageAvaIlable;
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
            pBLearned.Image = disConnectImage;
            _myImageFilter.RedFilterToImageEffect(pBLearned);
            epWifiConnectionImage.SetError(pBLearned, "No Internet connection !!!");
            pBLearned.Enabled = true;
            btnChangeImage.Visible = false;
            isConnectWifi = false;  
        }

        private void LearnedWordsPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            Hide();
        }


        private void LearnedWordsPanel_Activated(object sender, EventArgs e)
        {

            cBSearchedWords.Text = "";
            lblSentences.Text = "";
            pBLearned.Image = EnglishWordSet.Properties.Resources.tipMark;
        }

        LearnedWordImpl _learnedWordImpl = new();
        private void cBSearchedWords_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pbSearch_Click(sender, e);
                cBSearchedWords.DroppedDown = false;
                return;
            }
            else if (MyKeyDownValueCheck.IsItUp(e) || MyKeyDownValueCheck.IsItDown(e))
            {
                if (MyKeyDownValueCheck.IsItDown(e))
                {
                    cBSearchedWords.DroppedDown = true;
                }
           
                return;
            }
           

            string searchKeyWord=cBSearchedWords.Text.ToString();
            cBSearchedWords.Items.Clear();
            cBSearchedWords.SelectionStart = cBSearchedWords.Text.Length;
            List<string> learnedWords = _learnedWordImpl.GetLearnedEnglishWordsWithStartStr
                  (Sessions.UserSession.username_Admin, searchKeyWord);
            learnedWords.Sort((a, b) => a.CompareTo(b));
            learnedWords.Add(searchKeyWord);
            learnedWords.ForEach(I => cBSearchedWords.Items.Add(I));

        }
    }
}
