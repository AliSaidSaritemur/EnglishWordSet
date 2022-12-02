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
        AdminPage adminPage;
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

                if(MyPageGetter.GetAdminPage()!=null)
                    adminPage = MyPageGetter.GetAdminPage();
                else
                {
                    adminPage = new AdminPage();
                    MyPageGetter.SetAdminPage(adminPage);
                }

                adminPage.Show();
                this.Close();
            }


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

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
            if(e.CloseReason == CloseReason.UserClosing&&adminPage==null)
            {
                MyPageGetter.GetForm1().Show();
            }
            
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
    }
}
