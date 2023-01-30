using EnglishWordSet.Data.Contexts;
<<<<<<< HEAD
using EnglishWordSet.MyTools;
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
<<<<<<< HEAD
            WordContext context = MyDBTransactions.GetContext();
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1

            TrimForm();
            string userName = txtUserName.Text.ToString();
            string email = txtEmail.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string password = txtPassword.Text.ToString();
            string againPassword = txtAgainPassword.Text.ToString();


<<<<<<< HEAD
            if (context.Admins.FirstOrDefault(a => a.UserName == userName)!=null)
            {
                UserNameProvider.SetError(txtUserName, "This username already using");
                return;
            }

            else if (userName== "")
=======
            if (userName== "")
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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

<<<<<<< HEAD
            if (context.Admins.FirstOrDefault(a => a.Email == email) != null)
            {
                emailProvider.SetError(txtEmail, "This email already using");
                return;
            }
            else if (email == "")
=======
            if (email == "")
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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

<<<<<<< HEAD
            if (context.Admins.FirstOrDefault(a => a.Phone == phone) != null)
            {
                phoneProvider.SetError(txtPhone, "This phone number already using");
                return;
            }
            else if (phone == "")
            {
                phoneProvider.SetError(txtPhone, "Phone Number can not be null");
=======

            if (phone == "")
            { emailProvider.SetError(txtPhone, "Phone Number can not be null");
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
                return;
            }

            else if (!MyRegex.Isthere(phone, "^0?[0-9]{10}$"))
<<<<<<< HEAD
            { phoneProvider.SetError(txtPhone, "Phone Number is not valid type");
=======
            { emailProvider.SetError(txtPhone, "Phone Number is not valid type");
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
                return;
            }
            else
            {
<<<<<<< HEAD
                phoneProvider.Clear();
=======
                emailProvider.Clear();
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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

<<<<<<< HEAD
            DataEncryption dataEncryption = new();
            string encyptedPassword = dataEncryption.Encrypt(password);


            context.Add(new Data.Entities.Admin { Email = email,Password=encyptedPassword,Phone=phone,UserName=userName });
=======

            WordContext context = MyDBTransactions.GetContext();
            context.Add(new Data.Entities.Admin { Email = email,Password=password,Phone=phone,UserName=userName });
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1

 
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
<<<<<<< HEAD
            else { return; }
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
<<<<<<< HEAD
            else{ return;}
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
<<<<<<< HEAD
            else { return; }
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
<<<<<<< HEAD
            else { return; }
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
<<<<<<< HEAD
            else { return; }
=======
>>>>>>> 4c133cded4616a0fea5579ee49cd08c987ea4ec1
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
