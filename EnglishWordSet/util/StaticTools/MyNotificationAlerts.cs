using System.Drawing;
using Tulpep.NotificationWindow;

namespace EnglishWordSet.RefactoredStaticFuncs
{
   internal static class MyNotificationAlerts
    {
        static PopupNotifier popup;

         static MyNotificationAlerts()
        {
           popup ??= new ();          
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Delay = 800;
        }

        public static void GetSuccessMessage(string MessageText)
        {
            popup.BodyColor = Color.FromArgb(40, 167, 69);
            popup.TitleText = "Success";
            popup.ContentText = MessageText;
            popup.Popup();
        }

        public static void GetInfoMessage(string MessageText)
        {
            popup.BodyColor = Color.FromArgb(23, 162, 184);
            popup.TitleText = "Info ";
            popup.ContentText = MessageText;
            popup.Popup();
        }

        public static void GetWarningMessage(string MessageText)
        {
            popup.BodyColor = Color.FromArgb(255, 193, 7);
            popup.TitleText = "Warning !!";
            popup.ContentText = MessageText;
            popup.Popup();
        }

        public static void GetErrorMessage(string MessageText)
        {
            popup.BodyColor = Color.FromArgb(220, 53, 69);
            popup.TitleText = "Error ";        
            popup.ContentText = MessageText;
            popup.Popup();
        }
    }
}
