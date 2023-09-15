using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Chat.Services
{
    internal class SettingsAccountService
    {
        LoggedUserService loggedUserService = new LoggedUserService();
        ChatDbContext _dbContext = new ChatDbContext();
        private object d;
        public SettingsAccountService() { }

        public class UserData
        {
            public int id;
            public string nickname;
            public string username;
            public string email;
            public string password;
            public string name;
            public string lastname;
            public bool blocked;
        }

        public UserData LoadUserData()
        {
            var user = new UserData()
            {
                id = loggedUserService.GetId(),
                nickname = loggedUserService.GetNickname(),
                username = loggedUserService.GetUsername(),
                email = loggedUserService.GetEmail(),
                password = loggedUserService.GetPassword(),
                name = loggedUserService.GetName(),
                lastname = loggedUserService.GetLastName(),
                blocked = loggedUserService.IsBlocked(),
            };

            return user;
        }

        public void SavingUserData(string nickname, string username, string email, string password,
            string name, string lastname, bool blocking)
        {
            var user = _dbContext.Set<User>();
            var user_email = user.Where(e => e.EmailAdress == email);
            var user_username = user.Where(e => e.UserName == username);

            int user_id = GlobalVariables.Instance.globalId;

            if (username.Count() <= 4)
            {
                MessageBox.Show($"The entered username must be longer than 4 characters");
                return;
            }
            if (user_username.First().Id != user_id)
            {
                MessageBox.Show($"Username: '{username}' already exists!");
                return;
            }
            if (password.Count() <= 4)
            {
                MessageBox.Show($"The entered password must be longer than 4 characters");
                return;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show($"Incorrect email address!");
                return;
            }
            if (user_email.First().Id != user_id)
            {
                MessageBox.Show($"Email: '{email}' already exists!");
                return;
            }

            loggedUserService.SetNickname(nickname);
            loggedUserService.SetUsername(username);
            loggedUserService.SetEmail(email);
            loggedUserService.SetPassword(password);
            loggedUserService.SetName(name);
            loggedUserService.SetLastName(lastname);
            loggedUserService.SetBlocked(blocking);

            loggedUserService.SaveChanges();
        }
    }
}
