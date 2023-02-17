using DataAccess.Concrete;
using DataAccess.util;
using EnglishWordSet.MyTools;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.ToolsBackend;
using Entities.Concrete;
using LogAccess.services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EnglishWordSet.ChildForms.AdminPage
{
    public partial class ChildAdminNewAdmin : Form
    {
        AdminImpl adminImpl;
        TextBox focusText;
        public ChildAdminNewAdmin()
        {
            InitializeComponent();
            focusText = txtUserName;
            this.ActiveControl = focusText;
            focusText.Focus();
        }

        private void ChildAdminNewAdmin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitNewAdmin_Click(object sender, EventArgs e)
        {
            AdminController pageBackend = ControllersGetter.AdminPage();
            adminImpl ??= new ();

            TrimForm();
            string userName = txtUserName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string password = txtPassword.Text.ToString();
            string againPassword = txtAgainPassword.Text.ToString();


            if (adminImpl.IsThereUserName(userName))
            {
                UserNameProvider.SetError(txtUserName, "This username already using");
                return;
            }

            else if (userName== "")
            { UserNameProvider.SetError(txtUserName, "UserName can not be null");
                return;
            }

            else if (!MyRegex.CheckingValue.Isthere(userName, "[A-Za-z][A-Za-z0-9_]{3,29}"))
            { UserNameProvider.SetError(txtUserName, "UserName is not valid type");
                return;
            }
            else
            {
                UserNameProvider.Clear();
            }

            if (adminImpl.IsThereMail(email))
            {
                emailProvider.SetError(txtEmail, "This email already using");
                return;
            }
            else if (email == "")
            { emailProvider.SetError(txtEmail, "Email can not be null");
                return;
            }

            else if (!MyRegex.CheckingValue.IsMail(email))
            { emailProvider.SetError(txtEmail, "Email is not valid type");
                return;
            }
            else
            {
                emailProvider.Clear();
            }

            if (adminImpl.IsTherePhone(phone))
            {
                phoneProvider.SetError(txtPhone, "This phone number already using");
                return;
            }
            else if (phone == "")
            {
                phoneProvider.SetError(txtPhone, "Phone Number can not be null");
                return;
            }

            else if (!MyRegex.CheckingValue.IsPhoneNum(phone))
            { phoneProvider.SetError(txtPhone, "Phone Number is not valid type");
                return;
            }
            else
            {
                phoneProvider.Clear();
            }

            if (password== "")
            { passwordProvider.SetError(txtPassword, "Password can not be null");
                return;
            }

            else if (password!=againPassword)
            {
                passwordProvider.Clear();
                againPasswordProvider.SetError(txtAgainPassword, "Both of Passwords should be same");
                return;
            }
            else
            {
                againPasswordProvider.Clear();
            }

            if(!MyRegex.CheckingValue.Isthere(phone, "^0"))
            {
              phone = "0"+phone;   
            }

            adminImpl.Add(email,password,phone,userName);

            MyNotificationAlerts.GetSuccessMessage("Admin added");
            AddLog.systemLogs.Info(" " + userName + " is added to AdminsDB");
            CleanForm();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(MyKeyDownValueCheck.IsItDown(e))
            {
                focusText = txtEmail;
            }
            else { return; }
            focusText.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItUp(e))
            {
               focusText= txtUserName;
            }
            else if (MyKeyDownValueCheck.IsItDown(e))
            {
                focusText = txtPhone;
            }
            else{ return;}
            focusText.Focus();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItUp(e))
            {
                focusText= txtEmail;
            }
            else if (MyKeyDownValueCheck.IsItDown(e))
            {
                focusText = txtPassword;
            }
            else { return; }
            focusText.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((MyKeyDownValueCheck.IsItUp(e)))
            {
                focusText = txtPhone;
            }
            else if (MyKeyDownValueCheck.IsItDown(e))
            {
                focusText = txtAgainPassword;
            }
            else { return; }
            focusText.Focus();
        }

        private void txtAgainPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((MyKeyDownValueCheck.IsItUp(e)))
            {
                focusText = txtPassword;
                focusText.Focus();
            }
            if ((MyKeyDownValueCheck.IsItDown(e)))
            {
                focusText = txtPassword;
                btnSubmitNewAdmin.Focus();
            }
            else { return; }
        }
        private void CleanForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
        private void TrimForm()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = ((TextBox)c).Text.ToString().Trim();
                }
            }
        }

        private void ChildAdminNewAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (MyKeyDownValueCheck.IsItEnter(e))
            {
                this.btnSubmitNewAdmin_Click(sender, e);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter )
            {
                object sender = new object();
                EventArgs e = new EventArgs();
                this.btnSubmitNewAdmin_Click(sender, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
