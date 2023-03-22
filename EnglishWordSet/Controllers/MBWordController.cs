using DataAccess.Concrete;
using EnglishWordSet.Sessions;
using EnglishWordSet.util;
using Entities.Concrete;

namespace EnglishWordSet.CRUD
{
    class MBWordController
    {
        public NWords selectedword { get; set; }
        private WordImpl wordImpl = new();

        public MBWordController()
        {
            selectedword = wordImpl.GetRandomWord(UserSession.username_Admin);
        }
        
        public void RemoveWord()
        {
            wordImpl.Delete(selectedword.English, UserSession.username_Admin);
        }

        public string GetWordWithMeanig()
        {
            string line = selectedword.English + " "+ Settings.SettingsInfo.Default.SeparatorMark + " " + selectedword.Turkish;
            return line;
        }
        public string GetWord()
        {
            selectedword = wordImpl.GetRandomWord(UserSession.username_Admin);
            if(selectedword == null)
            {
                MyNotificationAlerts.GetWarningMessage("There is no New Word");
                return "";
            }            
            string line = selectedword.English;
            return line;
        }
        public string GetMeaning()
        {
            string line = selectedword.Turkish;
            return line;
        }
    }
}
