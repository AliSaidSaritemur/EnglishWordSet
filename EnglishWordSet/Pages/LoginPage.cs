using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.Sessions;
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
using System.Xml.Linq;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPageBackend loginB = MyGetBackend.LoginPage();
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
                epUserName.Clear();
                AdminPage adminPage = new();
                adminPage.Show();
                this.Close();
            }


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender, e);
            }

            else if (e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }   
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin_Click(sender,e);
            }
          else  if (e.KeyCode == Keys.Up)
            {
                txtUserName.Focus();
            }
        }
    }
}
