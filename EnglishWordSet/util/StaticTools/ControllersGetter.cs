using EnglishWordSet.CRUD;
using EnglishWordSet.PageBackend;
using EnglishWordSet.ToolsBackend;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class ControllersGetter
    {
        private static  AdminController adminPageBackend;
        private static LoginController loginPageBackend;
        private static MBWordController mBWordPageBackend;
        private static LearnedWordsController learnedWordsPageBackend;

        public static AdminController AdminPage()
        {
            adminPageBackend ??= new AdminController();  
            return adminPageBackend;    
        }

        public static LoginController LoginPage()
        {
            loginPageBackend ??= new LoginController();
            return loginPageBackend;
        }
        public static MBWordController mBWordPage()
        {      
            mBWordPageBackend ??= new MBWordController();
            return mBWordPageBackend;
        }

        public static LearnedWordsController LearnedPAge()
        {
            learnedWordsPageBackend ??= new LearnedWordsController();
            return learnedWordsPageBackend;
        }
    }
}
