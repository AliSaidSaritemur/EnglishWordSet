using EnglishWordSet.Data.Contexts;
using EnglishWordSet.Data.Entities;
using EnglishWordSet.RefactoredStaticFuncs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.ToolsBackend
{
    class LoginPageBackend
    {
        public WordContext context = MyDBTransactions.GetContext();

      private Admin admin;
        public bool IsThereUserName(string userName)
        {
            admin =  context.Admins.FirstOrDefault(a=> a.UserName==userName);

            bool result = admin != null ? true : false;

            return result;
        }
        public bool IsThereUser(string password)
        {
            bool result = admin.Password == password ? true : false;

            return result;

        }

    }
}
