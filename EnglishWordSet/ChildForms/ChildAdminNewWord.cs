using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            pageBackend.AddNewWords(txtInput.Text.ToString());
            txtInput.Clear();
            MyNotificationAlerts.GetSuccessMessage("The words are added to Database");
        }
    }
}
