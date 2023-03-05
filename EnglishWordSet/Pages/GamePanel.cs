using EnglishWordSet.RefactoredStaticFuncs;
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

        private void btnOpenLastLaterGame_Click(object sender, EventArgs e)
        {
            PageTransactions.GetLastLetterGamePage().Show();
            Hide();
        }

        private void GamePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            Hide();
        }
    }
}
