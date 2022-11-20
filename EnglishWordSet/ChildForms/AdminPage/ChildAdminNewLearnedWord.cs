﻿using EnglishWordSet.RefactoredStaticFuncs;
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
            AdminPageBackend pageBackend = MyGetBackend.AdminPage();
            string word=txtWord.Text.ToString().Trim();
            string sentence=txtSentence.Text.ToString().Trim();
            string meaning=txtMeaning.Text.ToString().Trim();   
            pageBackend.AddNewLearnedWord(word,sentence,meaning);
            txtWord.Clear();
            txtSentence.Clear();
            txtMeaning.Clear();
            MyNotificationAlerts.GetSuccessMessage("The words are added to Database");
        }

        private void txtWord_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ChildAdminNewLearnedWord_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
