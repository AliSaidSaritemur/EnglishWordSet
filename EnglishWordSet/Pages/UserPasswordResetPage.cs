using DataAccess.Concrete;
using EnglishWordSet.util;
using LogAccess.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EnglishWordSet.Pages
{
    public partial class UserPasswordResetPage : Form
    {
        public UserPasswordResetPage()
        {
            InitializeComponent();
            userImpl=new ();
        }
      private  UserImpl userImpl;
        private void UserPasswordResetPage_Load(object sender, EventArgs e)
        {

        }

        private void btnResetUsetPassword_Click(object sender, EventArgs e)
        {

            string userName = txtUserName.Text.ToString().Trim();
            string mail = "";
            if (!userImpl.IsThereUserName(userName))
            {
                prUserName.SetError(txtUserName,"UserName cannot found");
                return;
            }
            else
            {        
                prUserName.Clear();
                mail = userImpl.GetMailWithUserName(userName);
            }
            string password = txtPassword.Text.ToString().Trim();
            string againPassword = txtPasswordAgain.Text.ToString().Trim();

            if (string.IsNullOrEmpty(password))
            {
                prPassword.SetError(txtPassword, "Password cannot be empty");
                return;
            }
          else  if (password!=againPassword)
            {
                prPassword.SetError(txtPassword, "Passwords should be same");
                return;
            }
            else
            {
                prPassword.Clear();
            }
            if (!cbMailVerificationCode.Checked)
            {
                DialogResult dialogResult;

                dialogResult = MessageBox.Show("Do you allow us to send code to your e-mail address ? \n (Required for this registration)", "Mail Verification", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                    EmailCheckPage emailCheck = new(mail, cbMailVerificationCode);
                    emailCheck.Show();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                return;
            }
            else
            {
                userImpl.UpdateUserPassword(userName,password);
                MyNotificationAlerts.GetSuccessMessage("Password changed");
                AddLog.systemLogs.Info($"{userName} changed password");
                Close();
            }

        }

        private void cbMailVerificationCode_Click(object sender, EventArgs e)
        {

            if (!cbMailVerificationCode.Checked)
            {
                DialogResult dialogResult;

                dialogResult = MessageBox.Show("Do you allow us to send code to your e-mail address ? \n (Required for this registration)", "Mail Verification", MessageBoxButtons.YesNoCancel);

                if (dialogResult == DialogResult.Yes)
                {
                 
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                return;
            }

        }
    }
}
