using DataAccess.Concrete;
using DataAccess.util;
using EnglishWordSet.MyTools;
using EnglishWordSet.Sessions;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;



namespace EnglishWordSet.ToolsBackend
{
    class LoginController
    {
        private AdminImpl adminImpl=new();
        private LoginUser loginUser=new();
        public bool IsThereUserName(string userName)
        {
            loginUser.UserName = userName;
            return adminImpl.IsThereUserName(userName);
        }
        public bool IsThereUser(string password)
        {
            loginUser.Password=password;
            return adminImpl.IsThereLoginUser(loginUser);
        }
    }
}
