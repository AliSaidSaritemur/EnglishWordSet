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

            lblWord1.Text = _learnedWordImpl.GetRandomWord(Sessions.UserSession.username_Admin).wordEnglish;
            lblWord2.Text = _learnedWordImpl.GetRandomWord(Sessions.UserSession.username_Admin).wordEnglish;
            lblWord3.Text = _learnedWordImpl.GetRandomWord(Sessions.UserSession.username_Admin).wordEnglish;
            lblWord4.Text = _learnedWordImpl.GetRandomWord(Sessions.UserSession.username_Admin).wordEnglish;

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
