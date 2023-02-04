using EnglishWordSet.CRUD;
using EnglishWordSet.PageBackend;
using EnglishWordSet.ToolsBackend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(adminPageBackend==null)
                adminPageBackend = new AdminController();  
            return adminPageBackend;    
        }

        public static LoginController LoginPage()
        {
            if (loginPageBackend == null)
                loginPageBackend = new LoginController();
            return loginPageBackend;
        }
        public static MBWordController mBWordPage()
        {
            if (mBWordPageBackend == null)
                mBWordPageBackend = new MBWordController();
            return mBWordPageBackend;
        }

        public static LearnedWordsController LearnedPAge()
        {
            if (learnedWordsPageBackend == null)
                learnedWordsPageBackend = new LearnedWordsController();
            return learnedWordsPageBackend;
        }

    }
}
