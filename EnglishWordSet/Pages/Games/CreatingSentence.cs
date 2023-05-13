using APIAccess.Concrete;
using DataAccess.Concrete;
using EnglishWordSet.util;
using Google.Apis.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Pages.Games
{
    public partial class CreatingSentence : Form
    {
        public CreatingSentence()
        {
            InitializeComponent();
        }

        private void CreatingSentence_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            PageTransactions.GetUserPage().Show();
        }

        LearnedWordImpl _learnedWordImpl = new();
        private void btnStartSentenceGame_Click(object sender, EventArgs e)
        {
            if(_learnedWordImpl.LearnedWordCount(Sessions.UserSession.username_Admin) < 5)
            {
                MyNotificationAlerts.GetWarningMessage("You dont have enough word to play !!!");
                return;
            }
            List<string> randomWords =_learnedWordImpl.GetDifferentRandomWordWithCount(Sessions.UserSession.username_Admin, 4);

            lblWord1.Text = randomWords[0];
            lblWord2.Text = randomWords[1];
            lblWord3.Text = randomWords[2];
            lblWord4.Text = randomWords[3];

        }
        Translater _translater = new();
        private void btnTestSentence_Click(object sender, EventArgs e)
        {
            string sentenceToBeTranslate=rTBInputSentence.Text.ToString();
            rTBTranslatedSentence.Text = _translater.Translate(sentenceToBeTranslate);
        }

        private void CreatingSentence_Load(object sender, EventArgs e)
        {

        }

        private void getLaarnedWordPage_Click(object sender, EventArgs e)
        {
            Form page = PageTransactions.GetLearnedWordsPanelPage();
            page.Show();
        }
    }
}
