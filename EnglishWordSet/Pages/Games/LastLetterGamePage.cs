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
    public partial class LastLetterGamePage : Form
    {
        public LastLetterGamePage()
        {
            InitializeComponent();
        }

        private void LastLetterGamePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
