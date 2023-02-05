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

namespace EnglishWordSet.ChildForms.AdminPage
{
    public partial class ChildAdminNewLearnedWord : Form
    {
        TextBox focusText;
        public ChildAdminNewLearnedWord()
        {
            InitializeComponent();
            focusText = txtWord;
            this.ActiveControl = focusText;
            focusText.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminController pageBackend = ControllersGetter.AdminPage();
       
            string word=txtWord.Text.ToString().Trim();
            if (pageBackend.IsLEarnedWordAdded(word))
            {
                MyNotificationAlerts.GetErrorMessage("The word is already added to Database");
                return;
            }
            string sentence=txtSentence.Text.ToString().Trim();
            string meaning=txtMeaning.Text.ToString().Trim();   
            pageBackend.AddNewLearnedWord(word,sentence,meaning);
            txtWord.Clear();
            txtSentence.Clear();
            txtMeaning.Clear();
            MyNotificationAlerts.GetSuccessMessage("The word is added to Database");
        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtSentence.Focus();
            }
        }

        private void ChildAdminNewLearnedWord_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSentence_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItDown(e))
            {
                txtMeaning.Focus();
            }
            else if (MyKeyDownValueCheck.IsItUp(e))
            {
                txtWord.Focus();
            }
        }

        private void txtMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItDown(e))
            {
                btnAdd.Focus();
            }
            else if (MyKeyDownValueCheck.IsItUp(e))
            {
                txtSentence.Focus();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                object sender = new object();
                EventArgs e = new EventArgs();
                this.btnAdd_Click(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
