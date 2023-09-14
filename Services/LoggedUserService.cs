using Azure.Identity;
using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class LoggedUserService
    {
        public int _use;
        private readonly int _id;
        public User _user;

        public LoggedUserService()
        {
            ChatDbContext _dbContext = new ChatDbContext();

            _id = GlobalVariables.Instance.globalId;
            _user = _dbContext.Set<User>()
                            .Where(u => u.Id == _id)
                            .First();
        }

        public string GetUsername()
        {
            return _user.UserName;
        }
        public string GetName()
        {
            return _user.Name;
        }
        public string GetLastName()
        {
            return _user.LastName;
        }
        public string GetEmail()
        {
            return _user.EmailAdress;
        }
        public bool IsBlocked()
        {
            return _user.Blocked;
        }
        public int GetRole()
        {
            return _user.RoleId;
        }
        public string GetPassword()
        {
            return _user.Password;
        }
        public string GetNickname()
        {
            return _user.NickName;
        }
    }
}
