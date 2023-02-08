using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyPageGetter
    {
        private static Main form1;
        private static AdminPage adminpage;

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

    }
}
