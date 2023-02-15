
using EnglishWordSet.ChildForms.AdminPage;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class PageTransactions
    {
        private static Main form1;
        private static AdminPage adminpage;
        private static ChildAdminNewLearnedWord childAdminNewLearnedWord;

        public  static void SetForm1(Main frm1)
        {
            form1 = frm1;
        }
        public static Main GetForm1()
        {
            return form1;
        }

        public static AdminPage GetAdminPage()
        {
            adminpage ??= new();
            return adminpage;
        }

        public static ChildAdminNewLearnedWord GetChildAdminNewLearnedWordPage()
        {
            childAdminNewLearnedWord ??= new();
            return childAdminNewLearnedWord;
        }
    }
}
