using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Pages;
using EnglishWordSet.Pages.ChildFormPages.TurkishWordPage;
using EnglishWordSet.Pages.ChildFormPages.UserPage;
using EnglishWordSet.Pages.Games;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EnglishWordSet.util
{
    static class PageTransactions
    {
        private static Main form1;
        private static LoginPage _loginPage;
        private static UserPage userpage;
        private static ChildAdminNewLearnedWord childAdminNewLearnedWord;
        private static ChildAdminNewLearnedWord childAdminNewLearnedWordForMain;
        private static ChildAdminNewUser _childAdminNewUser;
        private static ChildAdminNewWord _childAdminNewWord;
        private static AdminTransactionsPage adminTransactionsPage;
        private static GamePanel _gamePanel;
        private static LastLetterGamePage _lastLetterGamePage;
        private static TurkishWordPage _turkishWordPage;
        private static CreatingSentence _creatingSentence;
        private static RemovingTurkishWordPage _removingTurkishWord;
        private static LearnedWordsPanel _learnedWordsPanel;


        public static LoginPage GetLoginPage() => _loginPage ??= new();

        public static Main GetForm1() => form1 ??= new();

        public static Boolean MainIsNull() => form1==null ?true:false;

        public static UserPage GetUserPage() => userpage ??= new();

        public static AdminTransactionsPage GetAdminTransactionsPage() => adminTransactionsPage ??= new();

        public static ChildAdminNewLearnedWord GetChildAdminNewLearnedWordPage() => childAdminNewLearnedWord ??= new ();

        public static ChildAdminNewLearnedWord GetChildAdminNewLearnedWordPageForMain() => childAdminNewLearnedWordForMain ??= new ();

        public static ChildAdminNewUser GetChildAdminNewUserPage() => _childAdminNewUser ??= new ();

        public static ChildAdminNewWord GetChildAdminNewWordPage() => _childAdminNewWord ??= new ();

        public static GamePanel GetGamePanel() => _gamePanel ??= new();

        public static LastLetterGamePage GetLastLetterGamePage() => _lastLetterGamePage ??= new();

        public static TurkishWordPage GetTurkishWordPage() => _turkishWordPage ??= new();

        public static CreatingSentence GetCreatingSentencePage() => _creatingSentence ??= new();

        public static RemovingTurkishWordPage GetRemovingTurkishWordPage() => _removingTurkishWord ??= new();

        public static LearnedWordsPanel GetLearnedWordsPanelPage() => _learnedWordsPanel ??= new();

        public static void CloseAllPage()
        {
            _creatingSentence = null;
            form1 = null;
            _loginPage = null;
            userpage = null;
            childAdminNewLearnedWord = null;
            adminTransactionsPage = null;
            _gamePanel = null;
            _lastLetterGamePage = null;
            _turkishWordPage = null;
            _childAdminNewUser = null;
            _childAdminNewWord = null;
            _removingTurkishWord = null;
            childAdminNewLearnedWordForMain = null;

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);


                openForms.Reverse();

            foreach (Form f in openForms)
            {
                if (f.Name != "LoginPage")           
                    f.Dispose();             
            }
        }

    }
}
