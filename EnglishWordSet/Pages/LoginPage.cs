using DataAccess.Concrete;
using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.MyTools;
using EnglishWordSet.Pages;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.Sessions;
using EnglishWordSet.ToolsBackend;
using LogAccess;
using LogAccess.services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EnglishWordSet
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            this.ActiveControl = txtUserName;
            txtUserName.Focus();

        }
        Main mainPage;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginController loginB = ControllersGetter.LoginPage();
            string userName = txtUserName.Text.ToString();
            string password = txtPassword.Text.ToString();

            if (!loginB.IsThereUserName(userName)) {
                epUserName.SetError(txtUserName, "User Name not found");
                MyNotificationAlerts.GetErrorMessage("Login not verified");
                return;
            }
            else
            {
                epUserName.Clear();
            }

            if (!loginB.IsThereUser(password))
            {
                epUserName.SetError(txtPassword, "Wrong password !!!");
                MyNotificationAlerts.GetErrorMessage("Login not verified");
            }
            else
            {
                MyNotificationAlerts.GetSuccessMessage("Login verified");
                AddLog.systemLogs.Info(userName + "  Loged");
                epUserName.Clear();
                mainPage = PageTransactions.GetForm1();
                 UserSession.SetUserSession(userName);
                loginB.RefreshTokens();
                mainPage.Show();
                this.Hide();
            }


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            PageTransactions.SetLoginPage(this);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }   
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (MyKeyDownValueCheck.IsItDown(e))
            {
                btnLogin.Focus();
            }
          else  if (MyKeyDownValueCheck.IsItUp(e))
            {
                txtUserName.Focus();
            }
        }

        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
      
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                object sender = new object();
                EventArgs e = new EventArgs();
                this.btnLogin_Click(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChildAdminNewUser newAdmin = new();
            newAdmin.StartPosition = FormStartPosition.CenterScreen;    
            newAdmin.Show();
        }

        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void llblForgetPasswordPageOpen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserPasswordResetPage _userPasswordResetPage = new ();
            _userPasswordResetPage.Show();
        }
    }
}
