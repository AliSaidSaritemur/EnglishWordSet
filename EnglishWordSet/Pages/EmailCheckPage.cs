using EnglishWordSet.Controllers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

namespace EnglishWordSet.Pages
{
    public partial class EmailCheckPage : Form
    {
        public EmailCheckPage(string userMail,CheckBox checkBox)
        {
            InitializeComponent();
            _userMail = userMail;
            _checkBox = checkBox;
            _verificationCode = _emailPageController.SendVerificationCodeWithEmailAndReturn(_userMail);
            tmrCode.Start();
        }
        private CheckBox _checkBox;
        private int lastSecondTimer = 60;
        private readonly string _userMail;
        private  string _verificationCode;
        private EmailCheckPageController _emailPageController = new();
        private void tmrCode_Tick(object sender, EventArgs e)
        {
            tmrCode.Interval = 1000;
            lastSecondTimer--;
            lblTimeToEnterCode.Text = lastSecondTimer.ToString();
            if(lastSecondTimer < 1)
            {
                MyNotificationAlerts.GetWarningMessage("Timeout, try again");
                lblTimeToEnterCode.Text = "00";
                pbSendNewCodeToMail.Visible = true;
                tmrCode.Stop();              
                btnCheckCode.Enabled = false;
            }


        }

        private void txtVerificationCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text.ToString().Trim() == _verificationCode)
            {
                _checkBox.Checked = true;
                Close();
            }
            else
            {
                MyNotificationAlerts.GetErrorMessage("Wrong Key ");
                txtVerificationCode.Clear();
            }

        }

        private void pbSendNewCodeToMail_Click(object sender, EventArgs e)
        {
            _verificationCode = _emailPageController.SendVerificationCodeWithEmailAndReturn(_userMail);
            lastSecondTimer = 60;
            pbSendNewCodeToMail.Visible = false;
            lblTimeToEnterCode.Text = "60";
            btnCheckCode.Enabled = true;
            tmrCode.Start();
            MyNotificationAlerts.GetInfoMessage("New code sended to mail adress");
        }
    }
}
