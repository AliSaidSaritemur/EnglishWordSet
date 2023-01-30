using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
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
            AdminPageBackend pageBackend = MyGetBackend.AdminPage();
            txtInput.Text = Regex.Replace(txtInput.Text, @"^\s*$(\n|\r|\r\n)", "", RegexOptions.Multiline);
            pageBackend.AddNewWords(txtInput.Text.ToString().Trim());    
            txtInput.Clear();
            MyNotificationAlerts.GetSuccessMessage("The words are added to Database");
        }
    }
}
