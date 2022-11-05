using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;
using System.Windows.Forms;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyNotificationAlerts
    {

        public static void GetSuccessMessage(string MessageText)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.FromArgb(40, 167, 69);
            popup.TitleText = "Success";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
            popup.ContentText = MessageText;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Delay = 800;
            popup.Popup();
        }

        public static void GetInfoMessage(string MessageText)
        {

            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.FromArgb(23, 162, 184);
            popup.TitleText = "Info ";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
            popup.ContentText = MessageText;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Delay = 800;
            popup.Popup();
        }

        public static void GetWarningMessage(string MessageText)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.FromArgb(255, 193, 7);
            popup.TitleText = "Warning !!";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
            popup.ContentText = MessageText;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Delay = 800;
            popup.Popup();
        }

        public static void GetErrorMessage(string MessageText)
        {

            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.FromArgb(220, 53, 69);
            popup.TitleText = "Error ";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
            popup.ContentText = MessageText;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Delay = 800;
            popup.Popup();
        }

    }
}
