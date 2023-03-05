
using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Pages;
using EnglishWordSet.Pages.ChildFormPages.UserPage;
using EnglishWordSet.Pages.Games;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class PageTransactions
    {
        private static Main form1;
        private static LoginPage _loginPage;
        private static UserPage userpage;
        private static ChildAdminNewLearnedWord childAdminNewLearnedWord;
        private static AdminTransactionsPage adminTransactionsPage;
        private static GamePanel _gamePanel;
        private static LastLetterGamePage _lastLetterGamePage;

        public  static void SetForm1(Main frm1)
        {
            form1 = frm1;
        }
        public static Main GetForm1()
        {
            form1??=new Main(); 
            return form1;
        }
        public static void SetLoginPage(LoginPage loginPage)
        {
            _loginPage = loginPage;
        }
        public static LoginPage GetLoginPage()
        {
            return _loginPage;
        }

        public static UserPage GetUserPage()
        {
            userpage ??= new();
            return userpage;
        }

        public static AdminTransactionsPage GetAdminTransactionsPage()
        {
            adminTransactionsPage ??= new();
            return adminTransactionsPage;
        }
        public static ChildAdminNewLearnedWord GetChildAdminNewLearnedWordPage()
        {
            childAdminNewLearnedWord ??= new();
            return childAdminNewLearnedWord;
        }
        public static GamePanel GetGamePanel()
        {
            _gamePanel ??= new();
            return _gamePanel;
        }
        public static LastLetterGamePage GetLastLetterGamePage()
        {
            _lastLetterGamePage ??= new();
            return _lastLetterGamePage;
        }
    }
}
