using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using Entities.DTOs;
using System.Numerics;


namespace DataAccess.Concrete
{
    public class UserImpl : IUserService
    {
        DataEncryption dataEncryption;
        private WordContext context = MyDBTransactions.GetContext();
        public void Add(string email, string password, string phone, string useName)
        {
            dataEncryption ??= new();
            string encyptedPassword = dataEncryption.Encrypt(password);
            context.Add(new User { Email = email, Password = encyptedPassword, Phone = phone, UserName = useName });
            context.SaveChanges();
        }

        public void Delete(string username)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName== username);
            if (user == null)
            context.Users.Remove(user);
            context.SaveChanges();
        }

        public User GetUser(string username)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            if (user == null)
                return user;
            else
            {
                return null;
            }
        }

        public string GetLastEntryDay(string username)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            return user.lastEntryDay;

        }

        public int GetToken(string username)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            return user.token;
        }

        public bool IsThereLoginUser(LoginUser loginUser)
        {
            dataEncryption ??= new();
            return 0 < context.Users.Count(I => I.UserName == loginUser.UserName&&
            I.Password ==dataEncryption.Encrypt(loginUser.Password));
        }

        public bool IsThereMail(string mail)
        {
            return 0 < context.Users.Count(I => I.Email == mail);
        }

        public bool IsTherePhone(string phone)
        {
            return 0 < context.Users.Count(I => I.Phone == phone);
        }

        public bool IsThereUserName(string username)
        {
            return 0 < context.Users.Count(I => I.UserName == username);
        }

        public bool IsTokenEnough(string username, int tokenAmount)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            return user.token >= tokenAmount;
        }

        public void ToIncreaseToken(string username, int tokenAmount)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            user.token = user.token + tokenAmount;
            context.SaveChanges();
        }

        public void ToReduceToken(string username, int tokenAmount)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            user.token = user.token - tokenAmount;
            context.SaveChanges();
        }

        public void Update(string email, string password, string phone, string username, int tokenAmount)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            user.Email = email;
            user.Password = password;
            user.Phone = phone;
            user.token = tokenAmount;
            context.SaveChanges();
        }

        public void UpdateLastEntryDay(string username, string lastEntryTime)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            user.lastEntryDay = lastEntryTime;
            context.SaveChanges();
        }

        public void UpdateToken(string username, int tokenAmount)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            user.token = tokenAmount;
            context.SaveChanges();
        }

        public string GetRole(string username)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            return user.Role;
        }

        public void UpdateUserPassword(string username, string password)
        {
            dataEncryption ??= new();
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            user.Password = dataEncryption.Encrypt(password); ;
            context.SaveChanges();
        }

        public string GetMailWithUserName(string username)
        {
            User user = context.Users.FirstOrDefault(I => I.UserName == username);
            return user.Email;
        }
    }
}
