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
        private readonly int _id;
        public User _user;
        private readonly ChatDbContext _dbContext;

        public LoggedUserService()
        {
            /*ChatDbContext _dbContext = new ChatDbContext();*/
            _dbContext = new ChatDbContext();
            _id = GlobalVariables.Instance.globalId;
            _user = _dbContext.Set<User>()
                            .Where(u => u.Id == _id)
                            .First();
        }

        public int GetId()
        {
            return _user.Id;
        }


        public string GetUsername()
        {
            return _user.UserName;
        }
        public void SetUsername(string username)
        {
            _user.UserName = username;
        }


        public string GetName()
        {
            return _user.Name;
        }
        public void SetName(string name)
        {
            _user.Name = name;
        }


        public string GetLastName()
        {
            return _user.LastName;
        }
        public void SetLastName(string lastname)
        {
            _user.LastName = lastname;
        }


        public string GetEmail()
        {
            return _user.EmailAdress;
        }
        public void SetEmail(string email)
        {
            _user.EmailAdress = email;
        }


        public bool IsBlocked()
        {
            return _user.Blocked;
        }
        public void SetBlocked(bool blocking)
        {
            _user.Blocked = blocking;
        }


        public int GetRole()
        {
            return _user.RoleId;
        }
        public void SetRole(int role)
        {
            _user.RoleId = role;
        }


        public string GetPassword()
        {
            return _user.Password;
        }
        public void SetPassword(string password)
        {
            _user.Password = password;
        }
        

        public string GetNickname()
        {
            return _user.NickName;
        }
        public void SetNickname(string nickname)
        {
            _user.NickName = nickname;
        }

        public void SaveChanges() 
        {
            _dbContext.SaveChanges();
        }
    }
}
