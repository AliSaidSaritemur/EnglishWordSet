using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;
using Google.Cloud.Translation.V2;
using EnglishWordSet.MyTools;
using EnglishWordSet.ToolsBackend;
using EnglishWordSet.Data.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Security.Cryptography;

namespace EnglishWordSet
{
    public partial class AdminPage : Form
    {
        DialogResult dialogResult;
        AdminPageBackend pageBackend;
        public AdminPage()
        {
            InitializeComponent();
            pageBackend = MyGetBackend.AdminPage();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        Form childAdmin;
        private void btnAddNewWord_Click(object sender, EventArgs e)
        {

            if (!MyTestInternet.IsThereInternet())
            {
                dialogResult = MessageBox.Show("No Words Addded.\nFor adding words," +
                  " connect to the internet.", "No internet access",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { }

            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            childAdmin = pageBackend.GetChildNewWordPage();
            childAdmin.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Add Admin btn
        {
            if (!MyTestInternet.IsThereInternet())
            {
                dialogResult = MessageBox.Show("No Words Addded.\nFor adding words," +
                  " connect to the internet.", "No internet access",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else { }
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            childAdmin = pageBackend.GetChildNewAdminPage();
            childAdmin.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

       
    }

