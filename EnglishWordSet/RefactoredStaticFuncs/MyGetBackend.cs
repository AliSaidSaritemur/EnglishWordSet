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
    static class MyGetBackend
    {

      private static  AdminPageBackend adminPageBackend;
        private static LoginPageBackend loginPageBackend;
        private static MBWordPageBackend mBWordPageBackend;
        private static LearnedWordsPageBackend learnedWordsPageBackend;

        public static AdminPageBackend AdminPage()
        {
            if(adminPageBackend==null)
                adminPageBackend = new AdminPageBackend();  
            return adminPageBackend;    
        }

        public static LoginPageBackend LoginPage()
        {
            if (loginPageBackend == null)
                loginPageBackend = new LoginPageBackend();
            return loginPageBackend;
        }
        public static MBWordPageBackend mBWordPage()
        {
            if (mBWordPageBackend == null)
                mBWordPageBackend = new MBWordPageBackend();
            return mBWordPageBackend;
        }

        public static LearnedWordsPageBackend LearnedPAge()
        {
            if (learnedWordsPageBackend == null)
                learnedWordsPageBackend = new LearnedWordsPageBackend();
            return learnedWordsPageBackend;
        }

    }
}
