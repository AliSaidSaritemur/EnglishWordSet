using DataAccess.Concrete;
using EnglishWordSet.util;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace EnglishWordSet.Pages.ChildFormPages.TurkishWordPage
{
    public partial class RemovingTurkishWordPage : Form
    {
        public RemovingTurkishWordPage()
        {
            InitializeComponent();
        }
        string wortToBeRemove;
        TrWordImpl _trWordImpl;
        private void btnRemoveWord_Click(object sender, EventArgs e)
        {
            if (WordProviderTest())
                return;

            _trWordImpl ??= new();

            if (!_trWordImpl.IsThereTurkishWord(wortToBeRemove,Sessions.UserSession.username_Admin)) {
                MyNotificationAlerts.GetErrorMessage($"({wortToBeRemove}) cannot be found");
                return;
            }

            _trWordImpl.RemoveWord(wortToBeRemove, Sessions.UserSession.username_Admin);
            MyNotificationAlerts.GetSuccessMessage($"({wortToBeRemove}) removed");
            txtWordToBeRemove.Text = "";
        }

        private bool WordProviderTest()
        {
            wortToBeRemove = txtWordToBeRemove.Text.ToString().Trim();
            if (wortToBeRemove.Length == 0)
            {
                prWord.SetError(txtWordToBeRemove, "Word can't be empty !!!");
                return true;
            }
            else if (!RegexTransactions.CheckingValue.IsName(wortToBeRemove))
            {
                prWord.SetError(txtWordToBeRemove, "Word should be invalid type !!!");
                return true;
            }
            else
            {
                prWord.Clear();
                return false;
            }
        }
    }
}
