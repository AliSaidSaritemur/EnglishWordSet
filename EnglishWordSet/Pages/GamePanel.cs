using EnglishWordSet.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet.Pages
{
    public partial class GamePanel : Form
    {
        public GamePanel()
        {
            InitializeComponent();
        }



        private void GamePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!PageTransactions.MainIsNull())
            {
                e.Cancel = true;
                this.Hide();
                PageTransactions.GetUserPage().Show();
            }
        }

        private void btnOpenCreatingSentencePage_Click(object sender, EventArgs e)
        {
            PageTransactions.GetCreatingSentencePage().Show();
            Hide();
        }

        private void btnOpenLastLetterGame_Click(object sender, EventArgs e)
        {
            PageTransactions.GetLastLetterGamePage().Show();
            Hide();
        }
    }
}
