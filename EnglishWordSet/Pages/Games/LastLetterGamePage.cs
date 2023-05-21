using DataAccess.util;
using EnglishWordSet.util;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Util;

namespace EnglishWordSet.Pages.Games
{
    public partial class LastLetterGamePage : Form
    {
        public LastLetterGamePage()
        {
            InitializeComponent();
            ResetGame();
        }

        private void LastLetterGamePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            PageTransactions.GetUserPage().Show();
        }

        private void LastLetterGamePage_Load(object sender, EventArgs e)
        {

        }
        GettingRandomWordWithFrequencyLevel frequencyLevel=new ();
        LearnedWordsPanel _learnedWordsPanel = new();
        List<string> usedWords = new List<string>();
        private async void btnApplyWord_Click(object sender, EventArgs e)
        {
            string wordToBeApply = txtNewWord.Text.ToString().Trim().ToUpper();
            string requriedLetter = lblrequiredLetter.Text.ToString();
            string wordsFreqeuncylevel =await frequencyLevel.GetFrequency(wordToBeApply);
            if (!RegexTransactions.CheckingValue.IsName(wordToBeApply))
            {
                epTextNewWord.SetError(txtNewWord, "This word isn't in a decent type.");
            }
            else if (!Regex.IsMatch(wordToBeApply, $"^{requriedLetter}.+$", RegexOptions.IgnoreCase))
            {
                epTextNewWord.SetError(txtNewWord, "This word doesn't statrt required letter.");
            }
            else if (usedWords.Contains(wordToBeApply))
            {
                epTextNewWord.SetError(txtNewWord, "This word already used.");
            }
            else if (wordsFreqeuncylevel == "very rare")
            {
                epTextNewWord.SetError(txtNewWord, "This word is not a regular word.");
            }
            else
            {
                usedWords.Add(wordToBeApply);
                lblrequiredLetter.Text = wordToBeApply[wordToBeApply.Length - 1].ToString();
                epTextNewWord.Clear();
            }

        }

        private string GetRandomLetter()
        {
            Random random = new Random();
            string randomLetter = "";
            randomLetter += (char)random.Next('A', 'Z' + 1);
            return randomLetter;
        }

        private void pbResetGame_Click(object sender, EventArgs e)
        {
            MyImageFilter _myImageFilter = new();
            _myImageFilter.GreenFilterToImageEffect(pbResetGame);
            ResetGame();

        }
        private void ResetGame()
        {
            lblrequiredLetter.Text = GetRandomLetter();
            txtNewWord.Clear();
            epTextNewWord.Clear();
        }
    }
}
