using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.RefactoredStaticFuncs
{
    static class MyPageGetter
    {
        private static Form1 form1;
        private static AdminPage adminpage;

        public  static void SetForm1(Form1 frm1)
        {
            form1 = frm1;
        }
    public static Form1 GetForm1()
        {
            return form1;
        }

        public static void SetAdminPage(AdminPage newAdminpage)
        {
            adminpage = newAdminpage;
        }
        public static AdminPage GetAdminPage()
        {
            return adminpage;
        }

    }
}
