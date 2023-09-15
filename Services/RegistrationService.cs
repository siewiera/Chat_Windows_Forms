using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Threading;
using System.Net.Http.Headers;

namespace Chat.Services
{
    internal class RegistrationService
    {
        private readonly ChatDbContext _dbContext;
        public RegistrationService(ChatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private bool CheckEmailExists(string email)
        {
            if (email == "")
            {
                MessageBox.Show($"Email field is required!");
                return false;
            }

            var count_email = _dbContext.Set<User>()
                .Where(u => u.EmailAdress == email)
                .ToList()
                .Count();

            if (count_email > 0)
            {
                MessageBox.Show($"Email: '{email}' already exists!");
                return false;
            }
            else return true;
        }

        private bool CheckLoginExists(string login)
        {
            if (login == "")
            {
                MessageBox.Show($"Username field is required!");
                return false;
            }

            var count_login = _dbContext.Set<User>()
                .Where(u => u.UserName == login)
                .ToList()
                .Count();

            if (count_login > 0)
            {
                MessageBox.Show($"Username: '{login}' already exists!");
                return false;
            }
            else return true;
        }

        private bool CheckPasswordLength(string password)
        {
            if (password.Count() <= 4) return false;
            else return true;
        }

        private void AddUser(string login, string email, string password) 
        {
            var user = new User()
            {
                NickName = login.Remove(3) + DateTime.Now.ToString("yyyyMMddHHmmss"),
                UserName = login,
                EmailAdress = email,
                Password = password,
                Name = "",
                LastName = "",
                Blocked = false,
                RoleId = 1,
            };

            _dbContext.Users.AddRange(user);
            _dbContext.SaveChanges();
        }

        private bool GoToLoginPanel()
        {
            SignIn sigIn = new SignIn();
            Register register = new Register();

            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("You can log in now", "Registration successful", button);
            if (result == DialogResult.OK)
            {
                return true;
            }else return false;
        }


        public bool CheckRegister(string login, string email, string password)
        {
            if (!CheckLoginExists(login))
            {           
                return false;
            }
            else if (!CheckEmailExists(email))
            {               
                return false;
            }
            else if (!CheckPasswordLength(password))
            {
                MessageBox.Show($"The entered password must be longer than 4 characters");
                return false;
            }

            AddUser(login, email, password);
            if (GoToLoginPanel()) return true;
            else return false;

        }
    }
}
