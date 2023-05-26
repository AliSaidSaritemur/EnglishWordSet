using System;
using System.Drawing;
using System.Windows.Forms;
using EnglishWordSet.Controllers;
using EnglishWordSet.Sessions;
using EnglishWordSet.util;

namespace EnglishWordSet
{
    public partial class UserPage : Form
    {
        UserController pageBackend;
        public UserPage()
        {
            InitializeComponent();
            pageBackend = ControllersGetter.AdminPage();
            this.ActiveControl = btnAddNewAdmin;
            btnAddNewAdmin.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
  
            if (UserSession.role_Admin == "admin")
                pbAdminPageOpen.Visible = true;
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
            PageTransactions.GetForm1().Show();
            Hide();
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

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pbAdminPageOpen_Click(object sender, EventArgs e)
        {
          PageTransactions.GetAdminTransactionsPage().Show();
        }

        private void pbOpenGamePanel_Click(object sender, EventArgs e)
        {
            PageTransactions.GetGamePanel().Show();
            Hide();
        }
    }

       
    }

