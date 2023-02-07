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
using System.Collections;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Google.Cloud.Translation.V2;
using EnglishWordSet.MyTools;
using EnglishWordSet.ToolsBackend;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Security.Cryptography;
using EnglishWordSet.util.StaticTools;

namespace EnglishWordSet
{
    public partial class AdminPage : Form
    {
        DialogResult dialogResult;
        AdminController pageBackend;
        public AdminPage()
        {
            InitializeComponent();
            pageBackend = ControllersGetter.AdminPage();
            MyPageGetter.SetAdminPage(this);
            this.ActiveControl = btnAddNewAdmin;
            btnAddNewAdmin.Focus();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        Form childAdmin;
        private void btnAddNewWord_Click(object sender, EventArgs e)
        {

            if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }

            childAdmin = pageBackend.GetChildNewWordPage();
            childAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e) 
        {        
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
            childAdmin = pageBackend.GetChildNewAdminPage();
            childAdmin.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddLearnedWord_Click(object sender, EventArgs e)
        {
                 if (!MyTestInternet.IsThereInternet())
            {
                BasicAlerts.ErrorAlert("Learned Words can't Add.\nFor adding words," +
               " connect to the internet.", "No internet access");
                return;
            }
            else { }

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }

            childAdmin = pageBackend.GetChildNewLearnedWord();
            childAdmin.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            MyPageGetter.GetForm1().Show();
            Hide();
        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyPageGetter.GetForm1().Show();
        }

        private void AdminPage_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnAddNewAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItLeft(e))
            {
                btnAddLearnedWord.Focus();
            }
        }

        private void btnAddNewWord_Enter(object sender, EventArgs e)
        {
            btnAddNewWord.BackColor = Color.AliceBlue;
        }

        private void btnAddNewWord_Leave(object sender, EventArgs e)
        {
            btnAddNewWord.BackColor = Color.White;
        }

        private void btnAddLearnedWord_Enter(object sender, EventArgs e)
        {
            btnAddLearnedWord.BackColor = Color.AliceBlue;
        }

        private void btnAddLearnedWord_Leave(object sender, EventArgs e)
        {
            btnAddLearnedWord.BackColor = Color.White;
        }

        private void btnAddNewAdmin_Enter(object sender, EventArgs e)
        {
            btnAddNewAdmin.BackColor = Color.AliceBlue;
        }

        private void btnAddNewAdmin_Leave(object sender, EventArgs e)
        {
            btnAddNewAdmin.BackColor = Color.White;
        }
    }

       
    }

