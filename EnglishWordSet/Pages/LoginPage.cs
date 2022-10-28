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

namespace EnglishWordSet
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            LoginPageBackend loginB = new();
            string userName = txtUserName.Text.ToString();
            string password = txtPassword.Text.ToString();

            if (!loginB.IsThereUserName(userName)) {
                epUserName.SetError(txtUserName, "User Name not found");
                return;
            }
            else
            {
                epUserName.Clear();
            }

            if (!loginB.IsThereUser(password))
            {
                epUserName.SetError(txtPassword, "Wrong password !!!");
            }
            else
            {
                epUserName.Clear();
                AdminPage adminPage = new();
                adminPage.Show();
                this.Close();
            }


        }
    }
}
