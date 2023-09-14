using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class SettingsAccountService
    {
        LoggedUserService loggedUserService = new LoggedUserService();
        ChatDbContext _dbContext = new ChatDbContext();
        public SettingsAccountService(){}

        public void SavingUserData(string nickname, string username, string email, string password, 
            string name, string lastname, bool blocking) 
        {
            loggedUserService.SetNickname(nickname);
            loggedUserService.SetUsername(username);
            loggedUserService.SetEmail(email);
            loggedUserService.SetPassword(password);
            loggedUserService.SetName(name);
            loggedUserService.SetLastName(lastname);
            loggedUserService.SetBlocked(blocking);

            _dbContext.SaveChanges();
        }
    }
}
