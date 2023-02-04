using EnglishWordSet.Data.Contexts;
using EnglishWordSet.Data.Entities;
using EnglishWordSet.MyTools;
using EnglishWordSet.RefactoredStaticFuncs;
using EnglishWordSet.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSet.ToolsBackend
{
    class LoginController
    {
        public WordContext context = MyDBTransactions.GetContext();

        private Admin admin;
        public bool IsThereUserName(string userName)
        {
            admin = context.Admins.FirstOrDefault(a => a.UserName == userName);

            bool result = admin != null ? true : false;

            return result;
        }
        public bool IsThereUser(string password)
        {
            DataEncryption dataEncryption = new();
            string encryptedPassword = dataEncryption.Encrypt(password);

            bool result = admin.Password == encryptedPassword ? true : false;
            AdminSession.id_Admin =result  ?  admin.id : AdminSession.id_Admin;
            return result;
        }
    }
}
