using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Pages;
using EnglishWordSet.Pages.ChildFormPages.UserPage;
using EnglishWordSet.Pages.Games;

namespace EnglishWordSet.util
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
        private static TurkishWordPage _turkishWordPage;

        public static void SetForm1(Main frm1)
        {
            form1 = frm1;
        }
        public static Main GetForm1()
        {
            form1 ??= new Main();
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

        public static UserPage GetUserPage() => userpage ??= new();

        public static AdminTransactionsPage GetAdminTransactionsPage() => adminTransactionsPage ??= new();

        public static ChildAdminNewLearnedWord GetChildAdminNewLearnedWordPage() => childAdminNewLearnedWord ??= new ();

        public static GamePanel GetGamePanel() => _gamePanel ??= new();

        public static LastLetterGamePage GetLastLetterGamePage() => _lastLetterGamePage ??= new();

        public static TurkishWordPage GetTurkishWordPage() => _turkishWordPage ??= new();

    }
}
