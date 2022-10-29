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

namespace EnglishWordSet
{
    public partial class AdminPage : Form
    {
        DialogResult dialogResult;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        private void btnAddNewWord_Click(object sender, EventArgs e)
        {

            if (!MyTestInternet.IsThereInternet())
            {
                dialogResult = MessageBox.Show("No Words Addded.\nFor adding words," +
                  " connect to the internet.", "No internet access",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string tempText = txtInput.Text.ToString();
            txtInput.Text = MyTranslater.TranslateEnglishToTurkish(tempText);
          
        }
    }
}
