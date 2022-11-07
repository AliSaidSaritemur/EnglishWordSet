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
        public ChildAdminNewAdmin()
        {
            InitializeComponent();
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

            string userName = txtUserName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string password = txtPassword.Text.ToString();
            string againPassword = txtAgainPassword.Text.ToString();


            if (userName.Trim() == "")
            { UserNameProvider.SetError(txtUserName, "UserName can not be null"); }

            else if (!MyRegex.Isthere(userName, "[A-Za-z][A-Za-z0-9_]{3,29}"))
            { UserNameProvider.SetError(txtUserName, "UserName is not valid type"); }
            else
            {
                UserNameProvider.Clear();
            }

            if (email.Trim() == "")
            { emailProvider.SetError(txtEmail, "Email can not be null"); }

            else if (!MyRegex.Isthere(email, "[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
            { emailProvider.SetError(txtEmail, "Email is not valid type"); }
            else
            {
                emailProvider.Clear();
            }


            if (phone.Trim() == "")
            { emailProvider.SetError(txtPhone, "Phone Number can not be null"); }

            else if (!MyRegex.Isthere(phone, "0?[0-9]"))
            { emailProvider.SetError(txtPhone, "Phone Number is not valid type"); }
            else
            {
                emailProvider.Clear();
            }

            if (password.Trim() == "")
            { passwordProvider.SetError(txtPassword, "Password can not be null"); }

            else if (password!=againPassword)
            {
                passwordProvider.Clear();
                againPasswordProvider.SetError(txtAgainPassword, "Both of Passwords should be same"); }
            else
            {
                againPasswordProvider.Clear();
            }




        }
    }
}
