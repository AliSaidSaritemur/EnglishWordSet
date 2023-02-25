
using EnglishWordSet.ChildForms.AdminPage;
using EnglishWordSet.Pages.ChildFormPages.UserPage;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class PageTransactions
    {
        private static Main form1;
        private static UserPage userpage;
        private static ChildAdminNewLearnedWord childAdminNewLearnedWord;
        private static AdminTransactionsPage adminTransactionsPage;

        public  static void SetForm1(Main frm1)
        {
            form1 = frm1;
        }
        public static Main GetForm1()
        {
            return form1;
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
    }
}
