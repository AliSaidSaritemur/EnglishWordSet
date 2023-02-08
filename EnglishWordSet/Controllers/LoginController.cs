using DataAccess.Concrete;
using DataAccess.util;
using EnglishWordSet.MyTools;
using EnglishWordSet.Sessions;
using Entities.Concrete;
using System.Linq;



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
