using Azure.Identity;
using Chat.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class LoggedUserService
    {
        /*private readonly int _id;*/
        public User _user;
        private readonly ChatDbContext _dbContext;

        public LoggedUserService()
        {
            /*ChatDbContext _dbContext = new ChatDbContext();*/
            _dbContext = new ChatDbContext();
            int _id = GlobalVariables.Instance.globalId;
            _user = _dbContext.Set<User>()
                            .Where(u => u.Id == _id)
                            .First();
        }

        public string GetUsername()
        {
            return _user.UserName;
        }
        public string SetUsername(string username)
        {
            return _user.UserName = username;
        }

        public string GetName()
        {
            return _user.Name;
        }
        public string SetName(string name)
        {
            return _user.Name = name;
        }

        public string GetLastName()
        {
            return _user.LastName;
        }
        public string SetLastName(string lastname)
        {
            return _user.LastName = lastname;
        }

        public string GetEmail()
        {
            return _user.EmailAdress;
        }
        public string SetEmail(string email)
        {
            return _user.EmailAdress = email;
        }

        public bool IsBlocked()
        {
            return _user.Blocked;
        }
        public bool SetBlocked(bool blocking)
        {
            return _user.Blocked = blocking;
        }

        public int GetRole()
        {
            return _user.RoleId;
        }
        public int SetRole(int role)
        {
            return _user.RoleId = role;
        }

        public string GetPassword()
        {
            return _user.Password;
        }
        public string SetPassword(string password)
        {
            return _user.Password = password;
        }

        public string GetNickname()
        {
            return _user.NickName;
        }
        public string SetNickname(string nickname)
        {
            return _user.NickName = nickname;
        }
    }
}
