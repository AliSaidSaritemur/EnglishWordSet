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
    public partial class TurkishWordPage : Form
    {
        public TurkishWordPage()
        {
            InitializeComponent();
        }

        private void TurkishWordPage_Load(object sender, EventArgs e)
        {

        }

        private void TurkishWordPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            PageTransactions.GetForm1().Show();
            Hide();
        }
    }
}
