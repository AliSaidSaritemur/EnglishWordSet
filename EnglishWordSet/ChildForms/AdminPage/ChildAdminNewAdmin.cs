using EnglishWordSet.Data.Contexts;
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
    public partial class ChildAdminNewAdmin : Form
    {
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
            AdminPageBackend pageBackend = MyGetBackend.AdminPage();

            TrimForm();
            string userName = txtUserName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string password = txtPassword.Text.ToString();
            string againPassword = txtAgainPassword.Text.ToString();


            if (userName== "")
            { UserNameProvider.SetError(txtUserName, "UserName can not be null");
                return;
            }

            else if (!MyRegex.Isthere(userName, "[A-Za-z][A-Za-z0-9_]{3,29}"))
            { UserNameProvider.SetError(txtUserName, "UserName is not valid type");
                return;
            }
            else
            {
                UserNameProvider.Clear();
            }

            if (email == "")
            { emailProvider.SetError(txtEmail, "Email can not be null");
                return;
            }

            else if (!MyRegex.Isthere(email, "[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
            { emailProvider.SetError(txtEmail, "Email is not valid type");
                return;
            }
            else
            {
                emailProvider.Clear();
            }


            if (phone == "")
            { emailProvider.SetError(txtPhone, "Phone Number can not be null");
                return;
            }

            else if (!MyRegex.Isthere(phone, "^0?[0-9]{10}$"))
            { emailProvider.SetError(txtPhone, "Phone Number is not valid type");
                return;
            }
            else
            {
                emailProvider.Clear();
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

            if(!MyRegex.Isthere(phone, "^0"))
            {
                string temp = "0"+phone;
                phone= temp;    
            }


            WordContext context = MyDBTransactions.GetContext();
            context.Add(new Data.Entities.Admin { Email = email,Password=password,Phone=phone,UserName=userName });

 
            MyNotificationAlerts.GetSuccessMessage("Admin added");
            CleanForm();
            context.SaveChanges();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(MyKeyDownValueCheck.IsItDown(e))
            {
                focusText = txtEmail;
            }
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
            focusText.Focus();
        }

        private void txtAgainPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if ((MyKeyDownValueCheck.IsItUp(e)))
            {
                focusText = txtPassword;
            }


            if (MyKeyDownValueCheck.IsItEnter(e))
            {
                this.btnSubmitNewAdmin_Click(sender,e);
            }
            focusText.Focus();
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
    }
}
