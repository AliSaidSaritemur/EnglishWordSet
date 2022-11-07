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
            userName=userName.Trim();
            string email = txtEmail.Text.ToString();
            email=email.Trim(); 
            string phone = txtPhone.Text.ToString();
            phone =phone=phone.Trim();  
            string password = txtPassword.Text.ToString();
            password=  password.Trim(); 
            string againPassword = txtAgainPassword.Text.ToString();
            againPassword= againPassword.Trim();


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

            context.SaveChanges();
            MyNotificationAlerts.GetSuccessMessage("Admin added");
            txtUserName.Clear();
            txtAgainPassword.Clear();   
            txtEmail.Clear();
            txtPhone.Clear();
            txtUserName.Clear();
        }
    }
}
