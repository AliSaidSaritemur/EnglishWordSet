using DataAccess.util;
using EnglishWordSet.util;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        }

        private void LastLetterGamePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        ButtonTransactions buttonTransactions;
        private void LastLetterGamePage_Load(object sender, EventArgs e)
        {
            buttonTransactions = new(btnApplyWord);
        }
        GettingRandomWordWithFrequencyLevel frequencyLevel=new ();
        List<string> usedWords = new List<string>();
       
        private async void btnApplyWord_Click(object sender, EventArgs e)
        {
            string wordToBeApply = txtNewWord.Text.ToString().Trim().ToUpper();
            string requriedLetter = lblrequiredLetter.Text.ToString();
            string wordsFreqeuncylevel =await frequencyLevel.GetFrequency(wordToBeApply);
            Color btnAlertColor = Color.Red;
            if (!RegexTransactions.CheckingValue.IsName(wordToBeApply))
            {
                epTextNewWord.SetError(txtNewWord, "This word isn't in a decent type.");
            }
            else if (wordToBeApply.Length<3)
            {
                epTextNewWord.SetError(txtNewWord, "This word is not long enough.");
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
                requriedLetter = wordToBeApply[wordToBeApply.Length - 1]!='X'? wordToBeApply[wordToBeApply.Length - 1].ToString(): requriedLetter;
                lblrequiredLetter.Text = requriedLetter;
                txtNewWord.Text = requriedLetter;
                txtNewWord.SelectionStart = txtNewWord.Text.Length;
                epTextNewWord.Clear();
                btnAlertColor = Color.LightGreen;                  
                lblScoreBoard.Text = (int.Parse(lblScoreBoard.Text.ToString())+1).ToString();
                lblGameTimer.Text = (int.Parse(lblGameTimer.Text.ToString()) +4).ToString();
            }
            buttonTransactions.ChangeButtonColor(btnAlertColor, 1);
        }


        private string GetRandomLetter()
        {
            Random random = new Random();
            string randomLetter = "";
            randomLetter += (char)random.Next('A', 'Z' + 1);
            return randomLetter=="X"?GetRandomLetter(): randomLetter;
        }

        private void pbResetGame_Click(object sender, EventArgs e)
        {
            MyImageFilter _myImageFilter = new();
            _myImageFilter.GreenFilterToImageEffect(pbResetGame);
            ResetGame();
            btnStartGame.Visible = true;

        }
        private void ResetGame()
        {
            txtNewWord.Clear();
            epTextNewWord.Clear();
            usedWords.Clear();
            txtNewWord.Text = lblrequiredLetter.Text;
            txtNewWord.SelectionStart = txtNewWord.Text.Length;
            lblGameTimer.Text = "60";
            lblScoreBoard.Text = "0";
        }

        private void txtNewWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnApplyWord_Click(sender, e);
                e.SuppressKeyPress = true;
            }
    
        }

        private void tmrGameTimer_Tick(object sender, EventArgs e)
        {
            string currentLblGameTimer = (int.Parse(lblGameTimer.Text.ToString()) - 1).ToString();
                lblGameTimer.Text = currentLblGameTimer;
            if (currentLblGameTimer == "0")
            {
                tmrGameTimer.Stop();
                FinishGame();      
            }
                
        }
        private void FinishGame()
        {
            txtNewWord.Enabled=false;
            btnApplyWord.Enabled=false;
            DialogResult dialogResult;
            dialogResult = MessageBox.Show($"Your Game is Over\n Your Score :{lblScoreBoard.Text}", "Do you want to start a new Game ?", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)
            {
                StartANewGame();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
            StartANewGame();
        }
        private void StartANewGame()
        {
            lblrequiredLetter.Text = GetRandomLetter();
            ResetGame();
            txtNewWord.Enabled = true;
            btnApplyWord.Enabled = true;
            tmrGameTimer.Start();
        }

        private void pbBackUserPage_Click(object sender, EventArgs e)
        {
                this.Hide();
                PageTransactions.GetUserPage().Show();
        }
    }
}
