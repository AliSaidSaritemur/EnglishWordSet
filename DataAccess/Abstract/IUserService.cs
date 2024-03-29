﻿using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IUserService
    {
        public void Add(string email, string password, string phone, string username);
        public void Delete(string username);
        public void Update(string email, string password, string phone, string username, int tokenAmount);
        public bool IsThereUserName(string username);
        public bool IsThereMail(string mail);
        public bool IsTherePhone(string phone);
        public bool IsThereLoginUser(LoginUser loginUser);
        public User GetUser(string username);
        public void UpdateToken(string username,int tokenAmount);
        public void UpdateLastEntryDay(string username, string lastEntryTime);
        public string GetLastEntryDay(string username);
        public int GetToken(string username);
        public bool IsTokenEnough(string username, int tokenAmount);
        public void ToReduceToken(string username, int tokenAmount);
        public void ToIncreaseToken(string username, int tokenAmount);
        public void UpdateUserPassword(string username, string password);
        public string GetRole(string username);
        public string GetMailWithUserName(string username);

    }
}
