using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using EnglishWordSet.util.StaticTools;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordSet
{
    public partial class ChildAdminNewWord : Form
    {
        public ChildAdminNewWord()
        {
            InitializeComponent();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }

            if (InputProviderTest())
                return;

            AdminController pageBackend = ControllersGetter.AdminPage();
            txtInput.Text = Regex.Replace(txtInput.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            pageBackend.AddNewWords(txtInput.Text.ToString().Trim());    
            txtInput.Clear();
            MyNotificationAlerts.GetSuccessMessage("The words are added to Database");
        }


        private bool InputProviderTest()
        {
            if (txtInput.Text.ToString().Trim().Length == 0)
            {
                prWords.SetError(txtInput, "Words can't be empty !!!");
                return true;
            }
            else if (!MyRegex.IsName(txtInput.Text.ToString().Trim()))
            {
                prWords.SetError(txtInput, "Words should be invalid type !!!");
                return true;
            }
            else
            {
                prWords.Clear();
                return false;
            }
        }
    }
}
