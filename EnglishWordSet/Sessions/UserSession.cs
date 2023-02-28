
using DataAccess.Concrete;

namespace EnglishWordSet.Sessions
{
    static class UserSession
    {
        private static UserImpl userImpl=new();
        public static string username_Admin { get; set; }
        public static string role_Admin { get; set; }

        public static void SetUserSession(string username)
        {
            username_Admin=username;
            role_Admin = userImpl.GetRole(username);
        }
    }
}
