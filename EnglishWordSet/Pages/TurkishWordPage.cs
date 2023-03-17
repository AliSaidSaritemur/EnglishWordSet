using DataAccess.Concrete;
using EnglishWordSet.ConvertTransactions;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.services.Impl.ConvertTransactionsImpls;
using EnglishWordSet.util.StaticTools;
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
        TrWordImpl _trWordImpl = new();
        private void TurkishWordPage_Load(object sender, EventArgs e)
        {

        }

        private void TurkishWordPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            PageTransactions.GetForm1().Show();
            Hide();
        }

        private void btnGetTurkishWord_Click(object sender, EventArgs e)
        {
            txtInputTurkishWords.Text = _trWordImpl.GetTurkishWordAndLevelsAsStringText();
        }

        private void btnConvertTrWords_Click(object sender, EventArgs e)
        {
        string convertedText= StringTransactions.ReadStringWithAction(txtInputTurkishWords.Text.ToString(), getAndSetTurkishLine);
            txtInputTurkishWords.Text = convertedText;
            txtOutputTurkishWords.Text= _trWordImpl.GetTurkishWordAndLevelsAsStringText();
            _trWordImpl.RemoveWordsWithLevel(3);
        }

        DeleteAfterHyben deleteAfterHyben = new();
        DeleteBeforeHyben deleteBeforeHyben = new();
        RemovingMark removingMark = new();
        public  string getAndSetTurkishLine(string line)
        {
            string resultLine = line;
            string turkish = removingMark.EdditLine(deleteAfterHyben.EdditLine(line)).Trim();
            string english = deleteBeforeHyben.EdditLine(line).Trim();
            if (MyRegex.CheckingValue.IsName(turkish))
            {
                if(_trWordImpl.CheckWordsEnglishMeaning(turkish, english))
                {
                    _trWordImpl.IncWordLevel(turkish);
                    resultLine += " true" ;
                }
                else
                {
                    resultLine += $"  false // true :{_trWordImpl.GetEnglishMeaning(turkish)}";
                }
            }
            return resultLine;
        }
      
    }
}
