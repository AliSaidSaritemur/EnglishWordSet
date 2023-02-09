using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IAdminService
    {
        public void Add(string email, string password, string phone, string username);
        public void Delete(string username);
        public void Update(string email, string password, string phone, string username);
        public bool IsThereUserName(string username);
        public bool IsThereMail(string mail);
        public bool IsTherePhone(string phone);
        public bool IsThereLoginUser(LoginUser loginUser);
        public Admin GetAdmin(string username);
    }
}
