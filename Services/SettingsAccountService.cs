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
        private readonly int id;
        
        ChatDbContext _dbContext = new ChatDbContext();
        private LoggedUserService _loggedUserService;
        public SettingsAccountService(int id) 
        {
            _loggedUserService = new LoggedUserService(id);
        }

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
                id = _loggedUserService.GetId(),
                nickname = _loggedUserService.GetNickname(),
                username = _loggedUserService.GetUsername(),
                email = _loggedUserService.GetEmail(),
                password = _loggedUserService.GetPassword(),
                name = _loggedUserService.GetName(),
                lastname = _loggedUserService.GetLastName(),
                blocked = _loggedUserService.IsBlocked(),
            };

            return user;
        }

        public bool SavingUserData(string nickname, string username, string email, string password,
            string name, string lastname, bool blocking)
        {
            int user_id = GlobalVariables.Instance.globalId;
            var user = _dbContext.Set<User>()
                .Where(e => e.Id != user_id);
            var user_email = user.Where(e => e.EmailAdress == email);
            var user_username = user.Where(e => e.UserName == username);
          

            if (username.Count() <= 4)
            {
                MessageBox.Show($"The entered username must be longer than 4 characters");
                return false;
            }
            if (user_username.Count() >= 1)
            {
                MessageBox.Show($"Username: '{username}' already exists!");
                return false;
            }
            if (password.Count() <= 4)
            {
                MessageBox.Show($"The entered password must be longer than 4 characters");
                return false;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show($"Incorrect email address!");
                return false;
            }
            if (user_email.Count() >= 1)
            {
                MessageBox.Show($"Email: '{email}' already exists!");
                return false;
            }

            _loggedUserService.SetNickname(nickname);
            _loggedUserService.SetUsername(username);
            _loggedUserService.SetEmail(email);
            _loggedUserService.SetPassword(password);
            _loggedUserService.SetName(name);
            _loggedUserService.SetLastName(lastname);
            _loggedUserService.SetBlocked(blocking);

            _loggedUserService.SaveChanges();

            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("You'r data has been saves", "Save..", button);
            if (result == DialogResult.OK)
            {
                return true;
            }
            else return false;
        }
    }
}
