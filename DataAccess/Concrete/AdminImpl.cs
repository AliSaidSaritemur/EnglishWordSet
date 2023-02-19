using DataAccess.Abstract;
using DataAccess.util;
using Entities.Concrete;
using Entities.DTOs;


namespace DataAccess.Concrete
{
    public class AdminImpl : IAdminService
    {
        DataEncryption dataEncryption;
        private WordContext context = MyDBTransactions.GetContext();
        public void Add(string email, string password, string phone, string useName)
        {
            dataEncryption ??= new();
            string encyptedPassword = dataEncryption.Encrypt(password);
            context.Add(new Admin { Email = email, Password = encyptedPassword, Phone = phone, UserName = useName });
            context.SaveChanges();
        }

        public void Delete(string username)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName== username);
            if (admin == null)
            context.Admins.Remove(admin);
            context.SaveChanges();
        }

        public Admin GetAdmin(string username)
        {
            return context.Admins.FirstOrDefault(I => I.UserName == username);
        }

        public string GetLastEntryDay(string username)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            return admin.lastEntryDay;

        }

        public bool IsThereLoginUser(LoginUser loginUser)
        {
            dataEncryption ??= new();
            return 0 < context.Admins.Count(I => I.UserName == loginUser.UserName&&
            I.Password ==dataEncryption.Encrypt(loginUser.Password));
        }

        public bool IsThereMail(string mail)
        {
            return 0 < context.Admins.Count(I => I.Email == mail);
        }

        public bool IsTherePhone(string phone)
        {
            return 0 < context.Admins.Count(I => I.Phone == phone);
        }

        public bool IsThereUserName(string username)
        {
            return 0 < context.Admins.Count(I => I.UserName == username);
        }

        public bool IsTokenEnough(string username, int tokenAmount)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            return admin.token >= tokenAmount;
        }

        public void ToIncreaseToken(string username, int tokenAmount)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            admin.token =admin.token + tokenAmount;
            context.SaveChanges();
        }

        public void ToReduceToken(string username, int tokenAmount)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            admin.token = admin.token - tokenAmount;
            context.SaveChanges();
        }

        public void Update(string email, string password, string phone, string username, int tokenAmount)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            admin.Email = email;
            admin.Password = password;
            admin.Phone = phone;
            admin.token = tokenAmount;
            context.SaveChanges();
        }

        public void UpdateLastEntryDay(string username, string lastEntryTime)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            admin.lastEntryDay = lastEntryTime;
            context.SaveChanges();
        }

        public void UpdateToken(string username, int tokenAmount)
        {
            Admin admin = context.Admins.FirstOrDefault(I => I.UserName == username);
            admin.token = tokenAmount;
            context.SaveChanges();
        }
    }
}
