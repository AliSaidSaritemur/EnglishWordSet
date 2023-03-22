using System.Drawing;
using Tulpep.NotificationWindow;

namespace EnglishWordSet.util
{
    internal static class MyNotificationAlerts
    {
        static PopupNotifier popupSuccess;
        static PopupNotifier popupInfo;
        static PopupNotifier popupWarning;
        static PopupNotifier popupError;

        static MyNotificationAlerts()
        {
            popupSuccess = PoupSet();
            popupInfo = PoupSet();
            popupWarning = PoupSet();
            popupError = PoupSet();
        }

        public static void GetSuccessMessage(string MessageText)
        {
            popupSuccess.BodyColor = Color.FromArgb(40, 167, 69);
            popupSuccess.TitleText = "Success";
            popupSuccess.ContentText = MessageText;
            popupSuccess.Popup();
        }

        public static void GetInfoMessage(string MessageText)
        {
            popupInfo.BodyColor = Color.FromArgb(23, 162, 184);
            popupInfo.TitleText = "Info ";
            popupInfo.ContentText = MessageText;
            popupInfo.Popup();
        }

        public static void GetWarningMessage(string MessageText)
        {
            popupWarning.BodyColor = Color.FromArgb(255, 193, 7);
            popupWarning.TitleText = "Warning !!";
            popupWarning.ContentText = MessageText;
            popupWarning.Popup();
        }

        public static void GetErrorMessage(string MessageText)
        {
            popupError.BodyColor = Color.FromArgb(220, 53, 69);
            popupError.TitleText = "Error ";
            popupError.ContentText = MessageText;
            popupError.Popup();
        }

        private static PopupNotifier PoupSet()
        {
            PopupNotifier popup = new();
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Delay = 800;
            return popup;
        }
    }
}
